namespace TableToText
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbxSQLDatabases = new System.Windows.Forms.ComboBox();
            this.cbxSQLServers = new System.Windows.Forms.ComboBox();
            this.dgvTablesFound = new System.Windows.Forms.DataGridView();
            this.lblSQLServers = new System.Windows.Forms.Label();
            this.lblSQLDatabases = new System.Windows.Forms.Label();
            this.lblSQLTables = new System.Windows.Forms.Label();
            this.btnSetTargetDirectory = new System.Windows.Forms.Button();
            this.lblTargetDirectory = new System.Windows.Forms.Label();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.cbxDelimiter = new System.Windows.Forms.ComboBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.chkAddDateTimeToFileName = new System.Windows.Forms.CheckBox();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablesFound)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSQLDatabases
            // 
            this.cbxSQLDatabases.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSQLDatabases.FormattingEnabled = true;
            this.cbxSQLDatabases.Location = new System.Drawing.Point(1006, 150);
            this.cbxSQLDatabases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSQLDatabases.Name = "cbxSQLDatabases";
            this.cbxSQLDatabases.Size = new System.Drawing.Size(864, 32);
            this.cbxSQLDatabases.TabIndex = 14;
            this.cbxSQLDatabases.SelectedIndexChanged += new System.EventHandler(this.cbxSQLDatabases_SelectedIndexChanged);
            // 
            // cbxSQLServers
            // 
            this.cbxSQLServers.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSQLServers.FormattingEnabled = true;
            this.cbxSQLServers.Items.AddRange(new object[] {
            "EBISDSQL01",
            "EBISDSQL02",
            "EBISPSQL01",
            "EBISPSQL16",
            "EBISTSQL12",
            "EDMSPSQL01",
            "EDMSTSQL01"});
            this.cbxSQLServers.Location = new System.Drawing.Point(747, 150);
            this.cbxSQLServers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSQLServers.Name = "cbxSQLServers";
            this.cbxSQLServers.Size = new System.Drawing.Size(248, 32);
            this.cbxSQLServers.TabIndex = 13;
            this.cbxSQLServers.SelectedIndexChanged += new System.EventHandler(this.cbxSQLServers_SelectedIndexChanged);
            // 
            // dgvTablesFound
            // 
            this.dgvTablesFound.AllowUserToAddRows = false;
            this.dgvTablesFound.AllowUserToDeleteRows = false;
            this.dgvTablesFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablesFound.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablesFound.Location = new System.Drawing.Point(747, 224);
            this.dgvTablesFound.Name = "dgvTablesFound";
            this.dgvTablesFound.ReadOnly = true;
            this.dgvTablesFound.RowHeadersWidth = 62;
            this.dgvTablesFound.RowTemplate.Height = 28;
            this.dgvTablesFound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablesFound.Size = new System.Drawing.Size(1123, 538);
            this.dgvTablesFound.TabIndex = 11;
            // 
            // lblSQLServers
            // 
            this.lblSQLServers.AutoSize = true;
            this.lblSQLServers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQLServers.Location = new System.Drawing.Point(754, 116);
            this.lblSQLServers.Name = "lblSQLServers";
            this.lblSQLServers.Size = new System.Drawing.Size(129, 29);
            this.lblSQLServers.TabIndex = 15;
            this.lblSQLServers.Text = "SQL Servers";
            // 
            // lblSQLDatabases
            // 
            this.lblSQLDatabases.AutoSize = true;
            this.lblSQLDatabases.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQLDatabases.Location = new System.Drawing.Point(1012, 116);
            this.lblSQLDatabases.Name = "lblSQLDatabases";
            this.lblSQLDatabases.Size = new System.Drawing.Size(159, 29);
            this.lblSQLDatabases.TabIndex = 16;
            this.lblSQLDatabases.Text = "SQL Databases";
            // 
            // lblSQLTables
            // 
            this.lblSQLTables.AutoSize = true;
            this.lblSQLTables.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQLTables.Location = new System.Drawing.Point(754, 192);
            this.lblSQLTables.Name = "lblSQLTables";
            this.lblSQLTables.Size = new System.Drawing.Size(118, 29);
            this.lblSQLTables.TabIndex = 17;
            this.lblSQLTables.Text = "SQL Tables";
            // 
            // btnSetTargetDirectory
            // 
            this.btnSetTargetDirectory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetTargetDirectory.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTargetDirectory.Location = new System.Drawing.Point(55, 815);
            this.btnSetTargetDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetTargetDirectory.Name = "btnSetTargetDirectory";
            this.btnSetTargetDirectory.Size = new System.Drawing.Size(232, 40);
            this.btnSetTargetDirectory.TabIndex = 20;
            this.btnSetTargetDirectory.Text = "Set Target Directory";
            this.btnSetTargetDirectory.UseVisualStyleBackColor = true;
            this.btnSetTargetDirectory.Click += new System.EventHandler(this.btnSetTargetDirectory_Click);
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTargetDirectory.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetDirectory.Location = new System.Drawing.Point(294, 793);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.Size = new System.Drawing.Size(165, 27);
            this.lblTargetDirectory.TabIndex = 19;
            this.lblTargetDirectory.Text = "Target Directory:";
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(294, 820);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.ReadOnly = true;
            this.txtTargetDirectory.Size = new System.Drawing.Size(1123, 37);
            this.txtTargetDirectory.TabIndex = 18;
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(294, 870);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(414, 37);
            this.txtFileName.TabIndex = 21;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFileName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(170, 873);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(108, 27);
            this.lblFileName.TabIndex = 22;
            this.lblFileName.Text = "File Name:";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateFile.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(55, 1019);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(232, 40);
            this.btnCreateFile.TabIndex = 23;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // cbxDelimiter
            // 
            this.cbxDelimiter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDelimiter.FormattingEnabled = true;
            this.cbxDelimiter.Items.AddRange(new object[] {
            "|",
            ",",
            "\",\""});
            this.cbxDelimiter.Location = new System.Drawing.Point(294, 923);
            this.cbxDelimiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxDelimiter.Name = "cbxDelimiter";
            this.cbxDelimiter.Size = new System.Drawing.Size(71, 37);
            this.cbxDelimiter.TabIndex = 24;
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDelimiter.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelimiter.Location = new System.Drawing.Point(170, 926);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(97, 27);
            this.lblDelimiter.TabIndex = 25;
            this.lblDelimiter.Text = "Delimiter";
            // 
            // chkAddDateTimeToFileName
            // 
            this.chkAddDateTimeToFileName.AutoSize = true;
            this.chkAddDateTimeToFileName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chkAddDateTimeToFileName.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAddDateTimeToFileName.Checked = true;
            this.chkAddDateTimeToFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddDateTimeToFileName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddDateTimeToFileName.Location = new System.Drawing.Point(392, 927);
            this.chkAddDateTimeToFileName.Name = "chkAddDateTimeToFileName";
            this.chkAddDateTimeToFileName.Size = new System.Drawing.Size(293, 31);
            this.chkAddDateTimeToFileName.TabIndex = 26;
            this.chkAddDateTimeToFileName.Text = "Add Date/Time to FileName";
            this.chkAddDateTimeToFileName.UseVisualStyleBackColor = false;
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstructions.Location = new System.Drawing.Point(57, 150);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.ReadOnly = true;
            this.rtbInstructions.Size = new System.Drawing.Size(669, 612);
            this.rtbInstructions.TabIndex = 27;
            this.rtbInstructions.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(61, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(726, 44);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Download SQL Table Data to Delimited Text File";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TableToText.Properties.Resources.cool_background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1918, 1087);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.chkAddDateTimeToFileName);
            this.Controls.Add(this.lblDelimiter);
            this.Controls.Add(this.cbxDelimiter);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSetTargetDirectory);
            this.Controls.Add(this.lblTargetDirectory);
            this.Controls.Add(this.txtTargetDirectory);
            this.Controls.Add(this.lblSQLTables);
            this.Controls.Add(this.lblSQLDatabases);
            this.Controls.Add(this.lblSQLServers);
            this.Controls.Add(this.cbxSQLDatabases);
            this.Controls.Add(this.cbxSQLServers);
            this.Controls.Add(this.dgvTablesFound);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablesFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSQLDatabases;
        private System.Windows.Forms.ComboBox cbxSQLServers;
        private System.Windows.Forms.DataGridView dgvTablesFound;
        private System.Windows.Forms.Label lblSQLServers;
        private System.Windows.Forms.Label lblSQLDatabases;
        private System.Windows.Forms.Label lblSQLTables;
        private System.Windows.Forms.Button btnSetTargetDirectory;
        private System.Windows.Forms.Label lblTargetDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.ComboBox cbxDelimiter;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.CheckBox chkAddDateTimeToFileName;
        private System.Windows.Forms.RichTextBox rtbInstructions;
        private System.Windows.Forms.Label lblTitle;
    }
}

