using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableToText
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get
            {
                return this.lblMessage.Text;
            }
            set
            {
                this.lblMessage.Text = value;
            }
        }
        public string fileName;

        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", fileName);
        }
    }
}
