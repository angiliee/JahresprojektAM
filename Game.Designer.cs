namespace Jahresprojekt
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.pB_player = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.pB_life = new System.Windows.Forms.PictureBox();
            this.pB_life2 = new System.Windows.Forms.PictureBox();
            this.pB_life3 = new System.Windows.Forms.PictureBox();
            this.PistolTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_money = new System.Windows.Forms.Label();
            this.pB_item1 = new System.Windows.Forms.PictureBox();
            this.pB_item2 = new System.Windows.Forms.PictureBox();
            this.pB_item3 = new System.Windows.Forms.PictureBox();
            this.pB_item4 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.timerCrystals = new System.Windows.Forms.Timer(this.components);
            this.pB_weapon = new System.Windows.Forms.PictureBox();
            this.pB_xp = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pB_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_life)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_item4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_weapon)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // pB_player
            // 
            this.pB_player.BackColor = System.Drawing.Color.Transparent;
            this.pB_player.Image = global::Jahresprojekt.Properties.Resources.player1;
            this.pB_player.Location = new System.Drawing.Point(322, 212);
            this.pB_player.Name = "pB_player";
            this.pB_player.Size = new System.Drawing.Size(60, 63);
            this.pB_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_player.TabIndex = 0;
            this.pB_player.TabStop = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_score.Location = new System.Drawing.Point(23, 94);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(143, 37);
            this.lbl_score.TabIndex = 2;
            this.lbl_score.Text = "Score: 0";
            // 
            // pB_life
            // 
            this.pB_life.BackColor = System.Drawing.Color.Transparent;
            this.pB_life.Image = global::Jahresprojekt.Properties.Resources.heart;
            this.pB_life.Location = new System.Drawing.Point(21, 12);
            this.pB_life.Name = "pB_life";
            this.pB_life.Size = new System.Drawing.Size(70, 70);
            this.pB_life.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_life.TabIndex = 8;
            this.pB_life.TabStop = false;
            this.pB_life.Tag = "heart";
            // 
            // pB_life2
            // 
            this.pB_life2.BackColor = System.Drawing.Color.Transparent;
            this.pB_life2.Image = global::Jahresprojekt.Properties.Resources.heart;
            this.pB_life2.Location = new System.Drawing.Point(107, 12);
            this.pB_life2.Name = "pB_life2";
            this.pB_life2.Size = new System.Drawing.Size(70, 70);
            this.pB_life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_life2.TabIndex = 9;
            this.pB_life2.TabStop = false;
            this.pB_life2.Tag = "heart";
            // 
            // pB_life3
            // 
            this.pB_life3.BackColor = System.Drawing.Color.Transparent;
            this.pB_life3.Image = global::Jahresprojekt.Properties.Resources.heart;
            this.pB_life3.Location = new System.Drawing.Point(192, 12);
            this.pB_life3.Name = "pB_life3";
            this.pB_life3.Size = new System.Drawing.Size(70, 70);
            this.pB_life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_life3.TabIndex = 10;
            this.pB_life3.TabStop = false;
            this.pB_life3.Tag = "heart";
            // 
            // PistolTimer
            // 
            this.PistolTimer.Tick += new System.EventHandler(this.PistolTimer_Tick);
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_money.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_money.Location = new System.Drawing.Point(20, 130);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(164, 37);
            this.lbl_money.TabIndex = 11;
            this.lbl_money.Text = "Crystal: 0";
            // 
            // pB_item1
            // 
            this.pB_item1.BackColor = System.Drawing.Color.DimGray;
            this.pB_item1.Image = global::Jahresprojekt.Properties.Resources.axe4;
            this.pB_item1.Location = new System.Drawing.Point(835, 946);
            this.pB_item1.Name = "pB_item1";
            this.pB_item1.Size = new System.Drawing.Size(60, 60);
            this.pB_item1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_item1.TabIndex = 13;
            this.pB_item1.TabStop = false;
            this.pB_item1.Tag = "item";
            // 
            // pB_item2
            // 
            this.pB_item2.BackColor = System.Drawing.Color.Black;
            this.pB_item2.Image = global::Jahresprojekt.Properties.Resources.sword1;
            this.pB_item2.Location = new System.Drawing.Point(901, 946);
            this.pB_item2.Name = "pB_item2";
            this.pB_item2.Size = new System.Drawing.Size(60, 60);
            this.pB_item2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_item2.TabIndex = 14;
            this.pB_item2.TabStop = false;
            this.pB_item2.Tag = "item";
            // 
            // pB_item3
            // 
            this.pB_item3.BackColor = System.Drawing.Color.Black;
            this.pB_item3.Location = new System.Drawing.Point(967, 946);
            this.pB_item3.Name = "pB_item3";
            this.pB_item3.Size = new System.Drawing.Size(60, 60);
            this.pB_item3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_item3.TabIndex = 15;
            this.pB_item3.TabStop = false;
            this.pB_item3.Tag = "item";
            // 
            // pB_item4
            // 
            this.pB_item4.BackColor = System.Drawing.Color.Black;
            this.pB_item4.Location = new System.Drawing.Point(1033, 946);
            this.pB_item4.Name = "pB_item4";
            this.pB_item4.Size = new System.Drawing.Size(60, 60);
            this.pB_item4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_item4.TabIndex = 16;
            this.pB_item4.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(827, 940);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(274, 73);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // timerEnemy
            // 
            this.timerEnemy.Enabled = true;
            this.timerEnemy.Interval = 4000;
            this.timerEnemy.Tag = "timerEnemy";
            this.timerEnemy.Tick += new System.EventHandler(this.TimerEnemy);
            // 
            // timerCrystals
            // 
            this.timerCrystals.Enabled = true;
            this.timerCrystals.Interval = 20000;
            this.timerCrystals.Tag = "timerCrystals";
            this.timerCrystals.Tick += new System.EventHandler(this.timerCrystals_Tick);
            // 
            // pB_weapon
            // 
            this.pB_weapon.Image = global::Jahresprojekt.Properties.Resources.axe4;
            this.pB_weapon.Location = new System.Drawing.Point(379, 212);
            this.pB_weapon.Name = "pB_weapon";
            this.pB_weapon.Size = new System.Drawing.Size(50, 50);
            this.pB_weapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_weapon.TabIndex = 18;
            this.pB_weapon.TabStop = false;
            // 
            // pB_xp
            // 
            this.pB_xp.ForeColor = System.Drawing.Color.Lime;
            this.pB_xp.Location = new System.Drawing.Point(23, 179);
            this.pB_xp.Name = "pB_xp";
            this.pB_xp.Size = new System.Drawing.Size(186, 32);
            this.pB_xp.TabIndex = 19;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pB_xp);
            this.Controls.Add(this.pB_weapon);
            this.Controls.Add(this.pB_life3);
            this.Controls.Add(this.pB_life);
            this.Controls.Add(this.pB_life2);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.pB_item4);
            this.Controls.Add(this.pB_item3);
            this.Controls.Add(this.pB_item2);
            this.Controls.Add(this.pB_item1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pB_player);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pB_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_life)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_item4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_weapon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private PictureBox pB_player;
        private Label lbl_score;
        private PictureBox pB_life;
        private PictureBox pB_life2;
        private PictureBox pB_life3;
        private System.Windows.Forms.Timer PistolTimer;
        private Label lbl_money;
        private PictureBox pB_item1;
        private PictureBox pB_item2;
        private PictureBox pB_item3;
        private PictureBox pB_item4;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.Timer timerCrystals;
        private PictureBox pB_weapon;
        private ProgressBar pB_xp;
    }
}