namespace Jahresprojekt
{
    partial class Guide
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
            this.txtB_guide = new System.Windows.Forms.TextBox();
            this.lbl_guide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_back
            // 
            this.bttn_back.BackColor = System.Drawing.Color.Black;
            this.bttn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_back.Location = new System.Drawing.Point(205, 948);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(482, 58);
            this.bttn_back.TabIndex = 1;
            this.bttn_back.Text = "RETURN";
            this.bttn_back.UseVisualStyleBackColor = false;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // txtB_guide
            // 
            this.txtB_guide.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB_guide.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB_guide.ForeColor = System.Drawing.Color.White;
            this.txtB_guide.Location = new System.Drawing.Point(205, 183);
            this.txtB_guide.Multiline = true;
            this.txtB_guide.Name = "txtB_guide";
            this.txtB_guide.ReadOnly = true;
            this.txtB_guide.Size = new System.Drawing.Size(1495, 745);
            this.txtB_guide.TabIndex = 3;
            // 
            // lbl_guide
            // 
            this.lbl_guide.AutoSize = true;
            this.lbl_guide.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_guide.ForeColor = System.Drawing.Color.White;
            this.lbl_guide.Location = new System.Drawing.Point(929, 64);
            this.lbl_guide.Name = "lbl_guide";
            this.lbl_guide.Size = new System.Drawing.Size(120, 47);
            this.lbl_guide.TabIndex = 4;
            this.lbl_guide.Text = "GUIDE";
            // 
            // Guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lbl_guide);
            this.Controls.Add(this.txtB_guide);
            this.Controls.Add(this.bttn_back);
            this.Name = "Guide";
            this.Text = "Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttn_back;
        private TextBox txtB_guide;
        private Label lbl_guide;
    }
}