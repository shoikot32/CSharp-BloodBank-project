namespace BloodBank
{
    partial class registerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.mloginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(368, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "PASSWORD  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(368, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "USER-NAME :";
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordText.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordText.Location = new System.Drawing.Point(368, 393);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(314, 36);
            this.passwordText.TabIndex = 11;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // userNameText
            // 
            this.userNameText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.userNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameText.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userNameText.Location = new System.Drawing.Point(368, 269);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(314, 36);
            this.userNameText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(325, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 48);
            this.label1.TabIndex = 15;
            this.label1.Text = "Register Access";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(368, 459);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(126, 39);
            this.backBtn.TabIndex = 21;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // mloginBtn
            // 
            this.mloginBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.mloginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mloginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mloginBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mloginBtn.Location = new System.Drawing.Point(556, 459);
            this.mloginBtn.Name = "mloginBtn";
            this.mloginBtn.Size = new System.Drawing.Size(126, 39);
            this.mloginBtn.TabIndex = 27;
            this.mloginBtn.Text = "Log In";
            this.mloginBtn.UseVisualStyleBackColor = false;
            this.mloginBtn.Click += new System.EventHandler(this.mloginBtn_Click);
            // 
            // registerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 707);
            this.Controls.Add(this.mloginBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button mloginBtn;
    }
}