namespace Jahresprojekt
{
    partial class Start
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
            this.bttn_login = new System.Windows.Forms.Button();
            this.bttn_register = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pB_allThree = new System.Windows.Forms.PictureBox();
            this.bttn_quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB_allThree)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_login
            // 
            this.bttn_login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_login.Location = new System.Drawing.Point(597, 443);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(333, 94);
            this.bttn_login.TabIndex = 0;
            this.bttn_login.Text = "LOGIN";
            this.bttn_login.UseVisualStyleBackColor = false;
            this.bttn_login.Click += new System.EventHandler(this.bttn_login_Click);
            // 
            // bttn_register
            // 
            this.bttn_register.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_register.Location = new System.Drawing.Point(597, 559);
            this.bttn_register.Name = "bttn_register";
            this.bttn_register.Size = new System.Drawing.Size(333, 97);
            this.bttn_register.TabIndex = 1;
            this.bttn_register.Text = "REGISTER";
            this.bttn_register.UseVisualStyleBackColor = false;
            this.bttn_register.Click += new System.EventHandler(this.bttn_register_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_welcome.Location = new System.Drawing.Point(613, 281);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(284, 32);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "SURVIVE THE MONSTERS";
            // 
            // pB_allThree
            // 
            this.pB_allThree.Image = global::Jahresprojekt.Properties.Resources.allThree;
            this.pB_allThree.Location = new System.Drawing.Point(996, 258);
            this.pB_allThree.Name = "pB_allThree";
            this.pB_allThree.Size = new System.Drawing.Size(596, 558);
            this.pB_allThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_allThree.TabIndex = 3;
            this.pB_allThree.TabStop = false;
            // 
            // bttn_quit
            // 
            this.bttn_quit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_quit.Location = new System.Drawing.Point(22, 941);
            this.bttn_quit.Name = "bttn_quit";
            this.bttn_quit.Size = new System.Drawing.Size(215, 88);
            this.bttn_quit.TabIndex = 4;
            this.bttn_quit.Text = "QUIT GAME";
            this.bttn_quit.UseVisualStyleBackColor = false;
            this.bttn_quit.Click += new System.EventHandler(this.bttn_quit_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.bttn_quit);
            this.Controls.Add(this.pB_allThree);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.bttn_register);
            this.Controls.Add(this.bttn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.pB_allThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttn_login;
        private Button bttn_register;
        private Label lbl_welcome;
        private PictureBox pB_allThree;
        private Button bttn_quit;
    }
}