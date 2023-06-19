namespace Jahresprojekt
{
    partial class lbl_register
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
            this.txtB_username = new System.Windows.Forms.TextBox();
            this.txtB_password = new System.Windows.Forms.TextBox();
            this.bttn_create = new System.Windows.Forms.Button();
            this.bttn_back = new System.Windows.Forms.Button();
            this.txtB_password2 = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB_username
            // 
            this.txtB_username.Location = new System.Drawing.Point(672, 397);
            this.txtB_username.Multiline = true;
            this.txtB_username.Name = "txtB_username";
            this.txtB_username.Size = new System.Drawing.Size(540, 50);
            this.txtB_username.TabIndex = 3;
            this.txtB_username.Text = "USERNAME";
            this.txtB_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtB_username_MouseClick);
            // 
            // txtB_password
            // 
            this.txtB_password.Location = new System.Drawing.Point(672, 454);
            this.txtB_password.Multiline = true;
            this.txtB_password.Name = "txtB_password";
            this.txtB_password.Size = new System.Drawing.Size(540, 50);
            this.txtB_password.TabIndex = 4;
            this.txtB_password.Text = "PASSWORD";
            this.txtB_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtB_password_MouseClick);
            // 
            // bttn_create
            // 
            this.bttn_create.BackColor = System.Drawing.Color.Black;
            this.bttn_create.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn_create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_create.Location = new System.Drawing.Point(940, 593);
            this.bttn_create.Name = "bttn_create";
            this.bttn_create.Size = new System.Drawing.Size(272, 76);
            this.bttn_create.TabIndex = 5;
            this.bttn_create.Text = "create";
            this.bttn_create.UseVisualStyleBackColor = false;
            this.bttn_create.Click += new System.EventHandler(this.bttn_create_Click);
            // 
            // bttn_back
            // 
            this.bttn_back.BackColor = System.Drawing.Color.Black;
            this.bttn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_back.Location = new System.Drawing.Point(672, 593);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(262, 76);
            this.bttn_back.TabIndex = 6;
            this.bttn_back.Text = "login";
            this.bttn_back.UseVisualStyleBackColor = false;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // txtB_password2
            // 
            this.txtB_password2.Location = new System.Drawing.Point(672, 512);
            this.txtB_password2.Multiline = true;
            this.txtB_password2.Name = "txtB_password2";
            this.txtB_password2.Size = new System.Drawing.Size(540, 50);
            this.txtB_password2.TabIndex = 8;
            this.txtB_password2.Text = "PASSWORD";
            this.txtB_password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB_password2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtB_password2_MouseClick);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe Fluent Icons", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_login.Location = new System.Drawing.Point(819, 280);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(280, 64);
            this.lbl_login.TabIndex = 9;
            this.lbl_login.Text = "REGISTER";
            // 
            // lbl_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txtB_password2);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.bttn_create);
            this.Controls.Add(this.txtB_password);
            this.Controls.Add(this.txtB_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "lbl_register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtB_username;
        private TextBox txtB_password;
        private Button bttn_create;
        private Button bttn_back;
        private TextBox txtB_password2;
        private Label lbl_login;
    }
}