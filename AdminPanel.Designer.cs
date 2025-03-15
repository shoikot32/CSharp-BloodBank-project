namespace BloodBank
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addmanagerBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.addregisterBtn = new System.Windows.Forms.Button();
            this.managerBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.addmanagerBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.addregisterBtn);
            this.panel1.Controls.Add(this.managerBtn);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1073, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 757);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addmanagerBtn
            // 
            this.addmanagerBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addmanagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addmanagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addmanagerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmanagerBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.addmanagerBtn.Image = ((System.Drawing.Image)(resources.GetObject("addmanagerBtn.Image")));
            this.addmanagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addmanagerBtn.Location = new System.Drawing.Point(59, 432);
            this.addmanagerBtn.Name = "addmanagerBtn";
            this.addmanagerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addmanagerBtn.Size = new System.Drawing.Size(219, 58);
            this.addmanagerBtn.TabIndex = 33;
            this.addmanagerBtn.Text = "Add Manager";
            this.addmanagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addmanagerBtn.UseVisualStyleBackColor = false;
            this.addmanagerBtn.Click += new System.EventHandler(this.addmanagerBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(96, 670);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(155, 58);
            this.logoutBtn.TabIndex = 28;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // addregisterBtn
            // 
            this.addregisterBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addregisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addregisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addregisterBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addregisterBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.addregisterBtn.Image = ((System.Drawing.Image)(resources.GetObject("addregisterBtn.Image")));
            this.addregisterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addregisterBtn.Location = new System.Drawing.Point(55, 335);
            this.addregisterBtn.Name = "addregisterBtn";
            this.addregisterBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addregisterBtn.Size = new System.Drawing.Size(223, 58);
            this.addregisterBtn.TabIndex = 30;
            this.addregisterBtn.Text = "Add Register";
            this.addregisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addregisterBtn.UseVisualStyleBackColor = false;
            this.addregisterBtn.Click += new System.EventHandler(this.button1_Click);
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
            this.managerBtn.Location = new System.Drawing.Point(55, 239);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.managerBtn.Size = new System.Drawing.Size(223, 58);
            this.managerBtn.TabIndex = 27;
            this.managerBtn.Text = "Manager Access";
            this.managerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managerBtn.UseVisualStyleBackColor = false;
            this.managerBtn.Click += new System.EventHandler(this.managerBtn_Click);
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
            this.registerBtn.Location = new System.Drawing.Point(55, 145);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerBtn.Size = new System.Drawing.Size(221, 58);
            this.registerBtn.TabIndex = 28;
            this.registerBtn.Text = "Register Access";
            this.registerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
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
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Admin Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 757);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button managerBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addregisterBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button addmanagerBtn;
    }
}