namespace Jahresprojekt
{
    partial class Login
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
            this.bttn_continue = new System.Windows.Forms.Button();
            this.txtB_username = new System.Windows.Forms.TextBox();
            this.txtB_password = new System.Windows.Forms.TextBox();
            this.bttn_register = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_continue
            // 
            this.bttn_continue.BackColor = System.Drawing.Color.Black;
            this.bttn_continue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn_continue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_continue.Location = new System.Drawing.Point(940, 530);
            this.bttn_continue.Name = "bttn_continue";
            this.bttn_continue.Size = new System.Drawing.Size(247, 76);
            this.bttn_continue.TabIndex = 0;
            this.bttn_continue.Text = "sign in ";
            this.bttn_continue.UseVisualStyleBackColor = false;
            this.bttn_continue.Click += new System.EventHandler(this.bttn_continue_Click);
            // 
            // txtB_username
            // 
            this.txtB_username.Location = new System.Drawing.Point(672, 397);
            this.txtB_username.Multiline = true;
            this.txtB_username.Name = "txtB_username";
            this.txtB_username.Size = new System.Drawing.Size(515, 50);
            this.txtB_username.TabIndex = 4;
            this.txtB_username.Text = "USERNAME";
            this.txtB_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtB_username_MouseClick);
            // 
            // txtB_password
            // 
            this.txtB_password.Location = new System.Drawing.Point(672, 453);
            this.txtB_password.Multiline = true;
            this.txtB_password.Name = "txtB_password";
            this.txtB_password.Size = new System.Drawing.Size(515, 50);
            this.txtB_password.TabIndex = 5;
            this.txtB_password.Text = "PASSWORD";
            this.txtB_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtB_password_MouseClick);
            // 
            // bttn_register
            // 
            this.bttn_register.BackColor = System.Drawing.Color.Black;
            this.bttn_register.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_register.Location = new System.Drawing.Point(672, 530);
            this.bttn_register.Name = "bttn_register";
            this.bttn_register.Size = new System.Drawing.Size(262, 76);
            this.bttn_register.TabIndex = 6;
            this.bttn_register.Text = "register";
            this.bttn_register.UseVisualStyleBackColor = false;
            this.bttn_register.Click += new System.EventHandler(this.bttn_register_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe Fluent Icons", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_login.Location = new System.Drawing.Point(859, 257);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(181, 64);
            this.lbl_login.TabIndex = 7;
            this.lbl_login.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.bttn_register);
            this.Controls.Add(this.txtB_password);
            this.Controls.Add(this.txtB_username);
            this.Controls.Add(this.bttn_continue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttn_continue;
        private TextBox txtB_username;
        private TextBox txtB_password;
        private Button bttn_register;
        private Label lbl_login;
    }
}