namespace Jahresprojekt
{
    partial class PlayerScore
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
            this.lbl_playerScore = new System.Windows.Forms.Label();
            this.lbl_score2 = new System.Windows.Forms.Label();
            this.bttn_otherScores = new System.Windows.Forms.Button();
            this.bttn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_playerScore
            // 
            this.lbl_playerScore.AutoSize = true;
            this.lbl_playerScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_playerScore.Location = new System.Drawing.Point(314, 102);
            this.lbl_playerScore.Name = "lbl_playerScore";
            this.lbl_playerScore.Size = new System.Drawing.Size(155, 32);
            this.lbl_playerScore.TabIndex = 0;
            this.lbl_playerScore.Text = "Your Score is:";
            // 
            // lbl_score2
            // 
            this.lbl_score2.AutoSize = true;
            this.lbl_score2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_score2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_score2.Location = new System.Drawing.Point(342, 152);
            this.lbl_score2.Name = "lbl_score2";
            this.lbl_score2.Size = new System.Drawing.Size(106, 128);
            this.lbl_score2.TabIndex = 1;
            this.lbl_score2.Text = "0";
            // 
            // bttn_otherScores
            // 
            this.bttn_otherScores.BackColor = System.Drawing.Color.Black;
            this.bttn_otherScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_otherScores.Location = new System.Drawing.Point(402, 335);
            this.bttn_otherScores.Name = "bttn_otherScores";
            this.bttn_otherScores.Size = new System.Drawing.Size(157, 51);
            this.bttn_otherScores.TabIndex = 2;
            this.bttn_otherScores.Text = "VIEW OTHER SCORES";
            this.bttn_otherScores.UseVisualStyleBackColor = false;
            this.bttn_otherScores.Click += new System.EventHandler(this.bttn_otherScores_Click);
            // 
            // bttn_back
            // 
            this.bttn_back.BackColor = System.Drawing.Color.Black;
            this.bttn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_back.Location = new System.Drawing.Point(220, 335);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(157, 51);
            this.bttn_back.TabIndex = 3;
            this.bttn_back.Text = "GO BACK";
            this.bttn_back.UseVisualStyleBackColor = false;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // PlayerScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.bttn_otherScores);
            this.Controls.Add(this.lbl_score2);
            this.Controls.Add(this.lbl_playerScore);
            this.Name = "PlayerScore";
            this.Text = "PlayerScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_playerScore;
        private Label lbl_score2;
        private Button bttn_otherScores;
        private Button bttn_back;
    }
}