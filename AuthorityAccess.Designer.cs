namespace BloodBank
{
    partial class authorityAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorityAccess));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.managerBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Authority Access";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.managerBtn);
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 757);
            this.panel1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(98, 612);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 30;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // managerBtn
            // 
            this.managerBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.managerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.managerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.managerBtn.Image = ((System.Drawing.Image)(resources.GetObject("managerBtn.Image")));
            this.managerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerBtn.Location = new System.Drawing.Point(46, 462);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.managerBtn.Size = new System.Drawing.Size(230, 58);
            this.managerBtn.TabIndex = 27;
            this.managerBtn.Text = "Manager Access";
            this.managerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managerBtn.UseVisualStyleBackColor = false;
            this.managerBtn.Click += new System.EventHandler(this.managerBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.Crimson;
            this.adminBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminBtn.Image")));
            this.adminBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn.Location = new System.Drawing.Point(52, 211);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminBtn.Size = new System.Drawing.Size(221, 58);
            this.adminBtn.TabIndex = 29;
            this.adminBtn.Text = "Admin Access";
            this.adminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.registerBtn.Image = ((System.Drawing.Image)(resources.GetObject("registerBtn.Image")));
            this.registerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerBtn.Location = new System.Drawing.Point(51, 339);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerBtn.Size = new System.Drawing.Size(221, 58);
            this.registerBtn.TabIndex = 28;
            this.registerBtn.Text = "Register Access";
            this.registerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // authorityAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 757);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "authorityAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authority";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button managerBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button button1;
    }
}