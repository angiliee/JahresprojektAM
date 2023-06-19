namespace Jahresprojekt
{
    partial class Score
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
            this.bttn_back = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_rank = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.txtB_rank = new System.Windows.Forms.TextBox();
            this.txtB_username = new System.Windows.Forms.TextBox();
            this.txtB_score = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttn_back
            // 
            this.bttn_back.BackColor = System.Drawing.Color.Black;
            this.bttn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_back.Location = new System.Drawing.Point(205, 943);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(319, 74);
            this.bttn_back.TabIndex = 1;
            this.bttn_back.Text = "RETURN";
            this.bttn_back.UseVisualStyleBackColor = false;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Black;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_header.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_header.Location = new System.Drawing.Point(825, 102);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(176, 65);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "Scores:";
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_rank.Location = new System.Drawing.Point(525, 260);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(117, 50);
            this.lbl_rank.TabIndex = 7;
            this.lbl_rank.Text = "RANK";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_username.Location = new System.Drawing.Point(815, 260);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(212, 50);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "USERNAME";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_score.Location = new System.Drawing.Point(1184, 250);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(133, 50);
            this.lbl_score.TabIndex = 9;
            this.lbl_score.Text = "SCORE";
            // 
            // txtB_rank
            // 
            this.txtB_rank.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB_rank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_rank.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB_rank.ForeColor = System.Drawing.Color.White;
            this.txtB_rank.Location = new System.Drawing.Point(507, 357);
            this.txtB_rank.Multiline = true;
            this.txtB_rank.Name = "txtB_rank";
            this.txtB_rank.ReadOnly = true;
            this.txtB_rank.Size = new System.Drawing.Size(135, 306);
            this.txtB_rank.TabIndex = 10;
            this.txtB_rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB_username
            // 
            this.txtB_username.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_username.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB_username.ForeColor = System.Drawing.Color.White;
            this.txtB_username.Location = new System.Drawing.Point(744, 357);
            this.txtB_username.Multiline = true;
            this.txtB_username.Name = "txtB_username";
            this.txtB_username.ReadOnly = true;
            this.txtB_username.Size = new System.Drawing.Size(354, 306);
            this.txtB_username.TabIndex = 11;
            this.txtB_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB_score
            // 
            this.txtB_score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB_score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_score.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB_score.ForeColor = System.Drawing.Color.White;
            this.txtB_score.Location = new System.Drawing.Point(1203, 357);
            this.txtB_score.Multiline = true;
            this.txtB_score.Name = "txtB_score";
            this.txtB_score.ReadOnly = true;
            this.txtB_score.Size = new System.Drawing.Size(135, 306);
            this.txtB_score.TabIndex = 12;
            this.txtB_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtB_score);
            this.Controls.Add(this.txtB_username);
            this.Controls.Add(this.txtB_rank);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_rank);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.bttn_back);
            this.Name = "Score";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttn_back;
        private Label lbl_header;
        private Label lbl_rank;
        private Label lbl_username;
        private Label lbl_score;
        private TextBox txtB_rank;
        private TextBox txtB_username;
        private TextBox txtB_score;
    }
}