namespace loginPage
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.pctBoxUser = new System.Windows.Forms.PictureBox();
            this.pctBoxPswd = new System.Windows.Forms.PictureBox();
            this.pctBoxUsername = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Label();
            this.checkBoxPswd = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBoxUser
            // 
            this.pctBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBoxUser.BackgroundImage")));
            this.pctBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxUser.Location = new System.Drawing.Point(153, 35);
            this.pctBoxUser.Name = "pctBoxUser";
            this.pctBoxUser.Size = new System.Drawing.Size(227, 221);
            this.pctBoxUser.TabIndex = 0;
            this.pctBoxUser.TabStop = false;
            // 
            // pctBoxPswd
            // 
            this.pctBoxPswd.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxPswd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBoxPswd.BackgroundImage")));
            this.pctBoxPswd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxPswd.Location = new System.Drawing.Point(61, 407);
            this.pctBoxPswd.Name = "pctBoxPswd";
            this.pctBoxPswd.Size = new System.Drawing.Size(40, 38);
            this.pctBoxPswd.TabIndex = 1;
            this.pctBoxPswd.TabStop = false;
            // 
            // pctBoxUsername
            // 
            this.pctBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBoxUsername.BackgroundImage")));
            this.pctBoxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxUsername.Location = new System.Drawing.Point(61, 293);
            this.pctBoxUsername.Name = "pctBoxUsername";
            this.pctBoxUsername.Size = new System.Drawing.Size(40, 38);
            this.pctBoxUsername.TabIndex = 2;
            this.pctBoxUsername.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(61, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 2);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(61, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 2);
            this.panel2.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.txtUsername.Location = new System.Drawing.Point(119, 293);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(334, 38);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.txtPassword.Location = new System.Drawing.Point(119, 407);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(334, 38);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Enter += new System.EventHandler(this.pswdEnter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(204)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(34, 522);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(224, 59);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(204)))));
            this.btnClear.Location = new System.Drawing.Point(325, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 25);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkBoxPswd
            // 
            this.checkBoxPswd.AutoSize = true;
            this.checkBoxPswd.ForeColor = System.Drawing.Color.Black;
            this.checkBoxPswd.Location = new System.Drawing.Point(61, 468);
            this.checkBoxPswd.Name = "checkBoxPswd";
            this.checkBoxPswd.Size = new System.Drawing.Size(132, 24);
            this.checkBoxPswd.TabIndex = 10;
            this.checkBoxPswd.Text = "Show Password";
            this.checkBoxPswd.UseVisualStyleBackColor = true;
            this.checkBoxPswd.CheckedChanged += new System.EventHandler(this.checkboxChecked);
            this.checkBoxPswd.Click += new System.EventHandler(this.checkboxClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(204)))));
            this.btnExit.Location = new System.Drawing.Point(264, 522);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 59);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 624);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.checkBoxPswd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctBoxUsername);
            this.Controls.Add(this.pctBoxPswd);
            this.Controls.Add(this.pctBoxUser);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctBoxUser;
        private PictureBox pctBoxPswd;
        private PictureBox pctBoxUsername;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label btnClear;
        private CheckBox checkBoxPswd;
        private Button btnExit;
    }
}