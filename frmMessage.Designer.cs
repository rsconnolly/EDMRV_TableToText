namespace TableToText
{
    partial class frmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOpenTextFile = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(77, 101);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1187, 231);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Label Message...";
            // 
            // btnOpenTextFile
            // 
            this.btnOpenTextFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTextFile.Location = new System.Drawing.Point(82, 381);
            this.btnOpenTextFile.Name = "btnOpenTextFile";
            this.btnOpenTextFile.Size = new System.Drawing.Size(215, 43);
            this.btnOpenTextFile.TabIndex = 1;
            this.btnOpenTextFile.Text = "Open Text File";
            this.btnOpenTextFile.UseVisualStyleBackColor = true;
            this.btnOpenTextFile.Click += new System.EventHandler(this.btnOpenTextFile_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(74, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(988, 48);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Download SQL Table Data to Delimited Text File";
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOpenTextFile);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMessage";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOpenTextFile;
        private System.Windows.Forms.Label lblTitle;
    }
}