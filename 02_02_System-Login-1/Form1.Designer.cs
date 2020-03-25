namespace _02_02_System_Login_1
{
    partial class Form1
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
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.LblWebSite = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.GroupInformation = new System.Windows.Forms.GroupBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PanelFooter.SuspendLayout();
            this.GroupInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompanyName.ForeColor = System.Drawing.Color.Black;
            this.LblCompanyName.Location = new System.Drawing.Point(84, 60);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(129, 16);
            this.LblCompanyName.TabIndex = 9;
            this.LblCompanyName.Text = "Industryolog Academy";
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::_02_02_System_Login_1.Properties.Resources._01___Logo_2017;
            this.PicLogo.Location = new System.Drawing.Point(128, 14);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(41, 43);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 11;
            this.PicLogo.TabStop = false;
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PanelFooter.Controls.Add(this.LblWebSite);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 293);
            this.PanelFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(297, 46);
            this.PanelFooter.TabIndex = 10;
            // 
            // LblWebSite
            // 
            this.LblWebSite.AutoSize = true;
            this.LblWebSite.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWebSite.ForeColor = System.Drawing.Color.White;
            this.LblWebSite.Location = new System.Drawing.Point(82, 15);
            this.LblWebSite.Name = "LblWebSite";
            this.LblWebSite.Size = new System.Drawing.Size(132, 16);
            this.LblWebSite.TabIndex = 0;
            this.LblWebSite.Text = "www.industryolog.com";
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(16, 224);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(267, 33);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // GroupInformation
            // 
            this.GroupInformation.Controls.Add(this.TextPassword);
            this.GroupInformation.Controls.Add(this.label2);
            this.GroupInformation.Controls.Add(this.TextUserName);
            this.GroupInformation.Controls.Add(this.label1);
            this.GroupInformation.Location = new System.Drawing.Point(16, 87);
            this.GroupInformation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupInformation.Name = "GroupInformation";
            this.GroupInformation.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupInformation.Size = new System.Drawing.Size(267, 127);
            this.GroupInformation.TabIndex = 6;
            this.GroupInformation.TabStop = false;
            this.GroupInformation.Text = "Admin Information";
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(112, 87);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(135, 21);
            this.TextPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TextUserName
            // 
            this.TextUserName.Location = new System.Drawing.Point(112, 40);
            this.TextUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(135, 21);
            this.TextUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 339);
            this.Controls.Add(this.LblCompanyName);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.GroupInformation);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            this.PanelFooter.PerformLayout();
            this.GroupInformation.ResumeLayout(false);
            this.GroupInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.Label LblWebSite;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.GroupBox GroupInformation;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.Label label1;
    }
}

