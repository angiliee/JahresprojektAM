namespace Jahresprojekt
{
    partial class Mainmenu
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
            this.bttn_start = new System.Windows.Forms.Button();
            this.bttn_score = new System.Windows.Forms.Button();
            this.bttn_guide = new System.Windows.Forms.Button();
            this.bttn_signOut = new System.Windows.Forms.Button();
            this.bttn_exit = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.bttn_skins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_start
            // 
            this.bttn_start.BackColor = System.Drawing.Color.Black;
            this.bttn_start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttn_start.Location = new System.Drawing.Point(729, 284);
            this.bttn_start.Name = "bttn_start";
            this.bttn_start.Size = new System.Drawing.Size(494, 76);
            this.bttn_start.TabIndex = 0;
            this.bttn_start.Text = "PLAY";
            this.bttn_start.UseVisualStyleBackColor = false;
            this.bttn_start.Click += new System.EventHandler(this.bttn_start_Click_1);
            // 
            // bttn_score
            // 
            this.bttn_score.BackColor = System.Drawing.Color.Black;
            this.bttn_score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttn_score.Location = new System.Drawing.Point(729, 366);
            this.bttn_score.Name = "bttn_score";
            this.bttn_score.Size = new System.Drawing.Size(494, 76);
            this.bttn_score.TabIndex = 1;
            this.bttn_score.Text = "SCORE";
            this.bttn_score.UseVisualStyleBackColor = false;
            this.bttn_score.Click += new System.EventHandler(this.bttn_score_Click_1);
            // 
            // bttn_guide
            // 
            this.bttn_guide.BackColor = System.Drawing.Color.Black;
            this.bttn_guide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttn_guide.Location = new System.Drawing.Point(729, 448);
            this.bttn_guide.Name = "bttn_guide";
            this.bttn_guide.Size = new System.Drawing.Size(494, 76);
            this.bttn_guide.TabIndex = 2;
            this.bttn_guide.Text = "GUIDE";
            this.bttn_guide.UseVisualStyleBackColor = false;
            this.bttn_guide.Click += new System.EventHandler(this.bttn_guide_Click_1);
            // 
            // bttn_signOut
            // 
            this.bttn_signOut.BackColor = System.Drawing.Color.Black;
            this.bttn_signOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttn_signOut.Location = new System.Drawing.Point(729, 612);
            this.bttn_signOut.Name = "bttn_signOut";
            this.bttn_signOut.Size = new System.Drawing.Size(240, 76);
            this.bttn_signOut.TabIndex = 3;
            this.bttn_signOut.Text = "SIGN OUT";
            this.bttn_signOut.UseVisualStyleBackColor = false;
            this.bttn_signOut.Click += new System.EventHandler(this.bttn_exit_Click_1);
            // 
            // bttn_exit
            // 
            this.bttn_exit.BackColor = System.Drawing.Color.Black;
            this.bttn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_exit.Location = new System.Drawing.Point(975, 612);
            this.bttn_exit.Name = "bttn_exit";
            this.bttn_exit.Size = new System.Drawing.Size(248, 76);
            this.bttn_exit.TabIndex = 7;
            this.bttn_exit.Text = "QUIT GAME";
            this.bttn_exit.UseVisualStyleBackColor = false;
            this.bttn_exit.Click += new System.EventHandler(this.bttn_exit_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_welcome.Location = new System.Drawing.Point(829, 102);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(318, 86);
            this.lbl_welcome.TabIndex = 8;
            this.lbl_welcome.Text = "Welcome ";
            // 
            // bttn_skins
            // 
            this.bttn_skins.BackColor = System.Drawing.Color.Black;
            this.bttn_skins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttn_skins.Location = new System.Drawing.Point(729, 530);
            this.bttn_skins.Name = "bttn_skins";
            this.bttn_skins.Size = new System.Drawing.Size(494, 76);
            this.bttn_skins.TabIndex = 9;
            this.bttn_skins.Text = "SHOP";
            this.bttn_skins.UseVisualStyleBackColor = false;
            this.bttn_skins.Click += new System.EventHandler(this.bttn_skins_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.bttn_skins);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.bttn_exit);
            this.Controls.Add(this.bttn_signOut);
            this.Controls.Add(this.bttn_guide);
            this.Controls.Add(this.bttn_score);
            this.Controls.Add(this.bttn_start);
            this.Name = "Mainmenu";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttn_start;
        private Button bttn_score;
        private Button bttn_guide;
        private Button bttn_signOut;
        private Button bttn_exit;
        private Label lbl_welcome;
        private Button bttn_skins;
    }
}