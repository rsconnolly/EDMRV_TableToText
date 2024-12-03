using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace TableToText
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            cbxDelimiter.SelectedIndex = cbxDelimiter.FindStringExact("|");
            checkReadyToTransfer();
            rtbInstructions.BackColor = Color.White;
            rtbInstructions.Clear();
            rtbInstructions.BulletIndent = 10;
            rtbInstructions.SelectionFont = new Font("Calibri", 14, FontStyle.Bold);
            rtbInstructions.SelectedText = "Instructions: \n";
            rtbInstructions.SelectionBullet = true;
            rtbInstructions.SelectedText = "Select a SQL Server using the dropdown box to the right" + "\n";
            rtbInstructions.SelectedText = "Select a database on that server using the dropdown box to the right" + "\n";
            rtbInstructions.SelectedText = "Select a table within that Database on the data grid to the right" + "\n";
            rtbInstructions.SelectedText = "Click the \"Set Target Directory\" button below and navigate to the directory where you would like the file to be created" + "\n";
            rtbInstructions.SelectedText = "Type the file name that you want to use in the text box below" + "\n";
            rtbInstructions.SelectedText = "Select a delimiter using the dropdown box below" + "\n";
            rtbInstructions.SelectedText = "If you want a timestamp appended to your filename check the checkbox to do so" + "\n";
            rtbInstructions.SelectedText = "Click the \"Create File\" button to create the file";
        }

        private void cbxSQLServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = DataManager.GetDatabases(cbxSQLServers.Text);
            cbxSQLDatabases.ValueMember = dt.Columns[0].ToString();
            cbxSQLDatabases.DisplayMember = dt.Columns[0].ToString();
            cbxSQLDatabases.DataSource = dt;
            checkReadyToTransfer();
        }

        private void cbxSQLDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = DataManager.GetTables(cbxSQLServers.Text, cbxSQLDatabases.Text);
            DataView dv = new DataView(dt);
            dv.Sort = "Schema, [Table Name]";
            dgvTablesFound.DataSource = dv;
            dgvTablesFound.AutoResizeColumns();
            checkReadyToTransfer();
        }

        private void btnSetTargetDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = txtTargetDirectory.Text;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtTargetDirectory.Text = fbd.SelectedPath;
                }
            }
            checkReadyToTransfer();
        }
        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            checkReadyToTransfer();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string LogFolder = @"C:\Log\";
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Declare Variables and provide values
                string FileNamePart = txtFileName.Text;//Datetime will be added to it
                string DestinationFolder = txtTargetDirectory.Text;
                string TableName = Convert.ToString(dgvTablesFound.Rows[dgvTablesFound.SelectedCells[0].RowIndex].Cells["Schema"].Value) + "." + Convert.ToString(dgvTablesFound.Rows[dgvTablesFound.SelectedCells[0].RowIndex].Cells["Table Name"].Value);
                string FileDelimiter = "|"; //You can provide comma or pipe or whatever you like
                string RowPreFix = "";
                string RowSuffix = "";
                if (cbxDelimiter.Text.Length == 1)
                {
                    FileDelimiter = cbxDelimiter.Text;
                    RowPreFix = "";
                    RowSuffix = "";
                }
                if (cbxDelimiter.Text.Length == 3)
                {
                    FileDelimiter = cbxDelimiter.Text;
                    RowPreFix = cbxDelimiter.Text.Substring(0, 1);
                    RowSuffix = cbxDelimiter.Text.Substring(2, 1);
                }
                string FileExtension = ".txt"; //Provide the extension you like such as .txt or .csv

                //Create Connection to SQL Server in which you like to load files
                SqlConnection SQLConnection = new SqlConnection();
                SQLConnection.ConnectionString = "Data Source = " + cbxSQLServers.Text + "; Initial Catalog =" + cbxSQLDatabases.Text + "; "
                   + "Integrated Security=true;";

                //Read data from table or view to data table
                string query = "Select * From " + TableName;
                SqlCommand cmd = new SqlCommand(query, SQLConnection);
                SQLConnection.Open();
                DataTable d_table = new DataTable();
                d_table.Load(cmd.ExecuteReader());
                SQLConnection.Close();

                string FileFullPath = "";
                if (chkAddDateTimeToFileName.Checked)
                {
                    FileFullPath = DestinationFolder + "\\" + FileNamePart + "_" + datetime + FileExtension;
                }
                else
                {
                    FileFullPath = DestinationFolder + "\\" + FileNamePart + FileExtension;
                }
                if (File.Exists(FileFullPath))
                {
                    if (MessageBox.Show("Delete " + FileFullPath + "?", "File Exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                //Prepare the file path 

                StreamWriter sw = null;
                sw = new StreamWriter(FileFullPath, false);

                // Write the Header Row to File
                int ColumnCount = d_table.Columns.Count;
                sw.Write(RowPreFix); //initialize row with prefix
                for (int ic = 0; ic < ColumnCount; ic++)
                {
                    sw.Write(d_table.Columns[ic]);
                    if (ic < ColumnCount - 1)
                    {
                        sw.Write(FileDelimiter);
                    }
                }
                sw.Write(RowSuffix); //end row with suffix
                sw.Write(sw.NewLine);

                // Write All Rows to the File
                foreach (DataRow dr in d_table.Rows)
                {
                    sw.Write(RowPreFix);
                    for (int ir = 0; ir < ColumnCount; ir++)
                    {
                        if (!Convert.IsDBNull(dr[ir]))
                        {
                            sw.Write(dr[ir].ToString());
                        }
                        if (ir < ColumnCount - 1)
                        {
                            sw.Write(FileDelimiter);
                        }
                    }
                    sw.Write(RowSuffix + sw.NewLine);
                }
                sw.Close();
                frmMessage f2 = new frmMessage();
                f2.LabelText = "You have successfully downloaded data from: " + TableName + "\n to \n" + FileFullPath;
                f2.fileName = FileFullPath;
                f2.ShowDialog();


            }
            catch (Exception exception)
            {
                // Create Log File for Errors
                using (StreamWriter sw = File.CreateText(LogFolder
                    + "\\" + "ErrorLog_" + datetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void checkReadyToTransfer()
        {
            if (cbxSQLServers.SelectedIndex == -1)
            {
                btnCreateFile.Enabled = false;
                return;
            }
            if (cbxSQLDatabases.SelectedIndex == -1)
            {
                btnCreateFile.Enabled = false;
                return;
            }
            if (dgvTablesFound.SelectedCells.Count == 0)
            {
                btnCreateFile.Enabled = false;
                return;
            }
            if (Directory.Exists(txtTargetDirectory.Text) == false)
            {
                btnCreateFile.Enabled = false;
                return;
            }
            if (txtFileName.Text.Length == 0)
            {
                btnCreateFile.Enabled = false;
                return;
            }
            btnCreateFile.Enabled = true;

        }

    }
}

