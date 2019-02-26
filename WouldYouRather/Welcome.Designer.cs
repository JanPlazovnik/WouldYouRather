namespace WouldYouRather
{
    partial class Welcome
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
            this.btnLoginPanel = new System.Windows.Forms.Button();
            this.btnRegisterPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.tbRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbRegisterUsername = new System.Windows.Forms.TextBox();
            this.btnRegisterBack = new System.Windows.Forms.Button();
            this.btnLoginBack = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoginPanel
            // 
            this.btnLoginPanel.Location = new System.Drawing.Point(87, 141);
            this.btnLoginPanel.Name = "btnLoginPanel";
            this.btnLoginPanel.Size = new System.Drawing.Size(103, 43);
            this.btnLoginPanel.TabIndex = 0;
            this.btnLoginPanel.Text = "Login";
            this.btnLoginPanel.UseVisualStyleBackColor = true;
            this.btnLoginPanel.Click += new System.EventHandler(this.btnLoginPanel_Click);
            // 
            // btnRegisterPanel
            // 
            this.btnRegisterPanel.Location = new System.Drawing.Point(211, 141);
            this.btnRegisterPanel.Name = "btnRegisterPanel";
            this.btnRegisterPanel.Size = new System.Drawing.Size(103, 43);
            this.btnRegisterPanel.TabIndex = 1;
            this.btnRegisterPanel.Text = "Register";
            this.btnRegisterPanel.UseVisualStyleBackColor = true;
            this.btnRegisterPanel.Click += new System.EventHandler(this.btnRegisterPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Would You Rather";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLoginBack);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblLoginPassword);
            this.pnlLogin.Controls.Add(this.lblLoginUsername);
            this.pnlLogin.Controls.Add(this.tbLoginPassword);
            this.pnlLogin.Controls.Add(this.tbLoginUsername);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(400, 228);
            this.pnlLogin.TabIndex = 3;
            this.pnlLogin.Visible = false;
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Location = new System.Drawing.Point(116, 45);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(168, 20);
            this.tbLoginUsername.TabIndex = 0;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(116, 94);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(168, 20);
            this.tbLoginPassword.TabIndex = 1;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Location = new System.Drawing.Point(113, 29);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(55, 13);
            this.lblLoginUsername.TabIndex = 2;
            this.lblLoginUsername.Text = "Username";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(113, 78);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(53, 13);
            this.lblLoginPassword.TabIndex = 3;
            this.lblLoginPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(211, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(74, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btnRegisterBack);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.lblRegisterPassword);
            this.pnlRegister.Controls.Add(this.lblRegisterUsername);
            this.pnlRegister.Controls.Add(this.tbRegisterPassword);
            this.pnlRegister.Controls.Add(this.tbRegisterUsername);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(400, 228);
            this.pnlRegister.TabIndex = 5;
            this.pnlRegister.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(211, 141);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(74, 43);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(113, 78);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(53, 13);
            this.lblRegisterPassword.TabIndex = 3;
            this.lblRegisterPassword.Text = "Password";
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Location = new System.Drawing.Point(113, 29);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(55, 13);
            this.lblRegisterUsername.TabIndex = 2;
            this.lblRegisterUsername.Text = "Username";
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.Location = new System.Drawing.Point(116, 94);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.PasswordChar = '*';
            this.tbRegisterPassword.Size = new System.Drawing.Size(168, 20);
            this.tbRegisterPassword.TabIndex = 1;
            // 
            // tbRegisterUsername
            // 
            this.tbRegisterUsername.Location = new System.Drawing.Point(116, 45);
            this.tbRegisterUsername.Name = "tbRegisterUsername";
            this.tbRegisterUsername.Size = new System.Drawing.Size(168, 20);
            this.tbRegisterUsername.TabIndex = 0;
            // 
            // btnRegisterBack
            // 
            this.btnRegisterBack.Location = new System.Drawing.Point(117, 141);
            this.btnRegisterBack.Name = "btnRegisterBack";
            this.btnRegisterBack.Size = new System.Drawing.Size(73, 43);
            this.btnRegisterBack.TabIndex = 5;
            this.btnRegisterBack.Text = "Back";
            this.btnRegisterBack.UseVisualStyleBackColor = true;
            this.btnRegisterBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.Location = new System.Drawing.Point(117, 141);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(73, 43);
            this.btnLoginBack.TabIndex = 6;
            this.btnLoginBack.Text = "Back";
            this.btnLoginBack.UseVisualStyleBackColor = true;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 228);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterPanel);
            this.Controls.Add(this.btnLoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginPanel;
        private System.Windows.Forms.Button btnRegisterPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.TextBox tbRegisterPassword;
        private System.Windows.Forms.TextBox tbRegisterUsername;
        private System.Windows.Forms.Button btnLoginBack;
        private System.Windows.Forms.Button btnRegisterBack;
    }
}