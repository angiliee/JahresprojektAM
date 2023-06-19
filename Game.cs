using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;
using System.DirectoryServices.ActiveDirectory;
using static System.Net.Mime.MediaTypeNames;
using System.Xml;

namespace Jahresprojekt
{
    public partial class Game : Form
    {
        //set variables
        bool goUp, goDown, goLeft, goRight;
        int playerSpeed = 10, enemySpeed = 4, score, progressBar = 0, crystals, bulletLeft, bulletTop;
        string bulletDirection, username, direction; 
        Random randNum = new Random();
        List<PictureBox> enemys = new List<PictureBox>();
        PictureBox bullet = new PictureBox();
        PictureBox crystal = new PictureBox();

        SqlCommunication sql = new SqlCommunication();

        bool collision = false;
        bool secondLevel = false, thirdLevel = false;
        string accessoir = "";

        #region Random
        public Game(string username, string accessoir)
        {
            InitializeComponent();
            this.username = username;   
            this.accessoir = accessoir;
            ResetGame();
        }

        public void ResumeGame()
        {
            mainTimer.Start();
        }
        public void EndGame()
        {
            mainTimer.Stop();
            this.Hide();

            //save the money you made of this round
            sql.Crystals(crystals, username);
            
            //take current score to the playerScore Forms
            PlayerScore playerScore = new PlayerScore();
            playerScore.Score(score, username);
            playerScore.ShowDialog();
            this.Close();
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            //go back to the menu
            Mainmenu startform = new Mainmenu(accessoir);
            this.Hide();
            startform.ShowDialog();
            this.Close();
        }
        #endregion

        #region CreateCrystals

        public void CreateCrystals()
        {
            //create crystals which will spawn randomly
            PictureBox crystal = new PictureBox();
            crystal.Width = 60;
            crystal.Height = 60;
            crystal.Image = Properties.Resources.crystal;
            crystal.BringToFront();
            crystal.Tag = "crystal";
            crystal.SizeMode = PictureBoxSizeMode.Zoom;

            int x = randNum.Next(10, this.ClientSize.Width - crystal.Width);
            int y = randNum.Next(10, this.ClientSize.Height - crystal.Height);

            crystal.Location = new Point(x, y);
           
            Controls.Add(crystal);
        }

       
        #endregion

        #region CreateEnemysSpawnLocation
        public  void CreateEnemys()
        {

            bool monsterType = true;

            //create new PictureBoxes (enemys) 
            PictureBox enemy = new PictureBox();
            enemy.Tag = "enemy";
           
      
           
            //Random Pick which monster will spawn
            int monster = randNum.Next(2);

            switch (monster)
            {
                case 1:
                    enemy.Height = 50;
                    enemy.Width = 41;
                    break;
                case 2:
                    enemy.Height = 30;
                    enemy.Width = 50;
                    monsterType = false;
                    break;
            }
            if (monsterType)
            {
                if (pB_player.Left > enemy.Left)
                {
                    enemy.Image = Properties.Resources.enemy2Ll;
                    enemy.SizeMode = PictureBoxSizeMode.Zoom;
                    enemy.BackColor = Color.Transparent;
                }
                else
                {
                    enemy.Image = Properties.Resources.enemyR3;
                    enemy.SizeMode = PictureBoxSizeMode.Zoom;
                    enemy.BackColor = Color.Transparent;
                }
            }
            else if (!monsterType)
            {
                if (pB_player.Left > enemy.Left)
                {
                    enemy.Image = Properties.Resources.enemyL;
                    enemy.SizeMode = PictureBoxSizeMode.Zoom;
                    enemy.BackColor = Color.Transparent;
                }
                else
                {
                    enemy.Image = Properties.Resources.enemyR;
                    enemy.SizeMode = PictureBoxSizeMode.Zoom;
                    enemy.BackColor = Color.Transparent;
                }
            }

            //code for spawn Location of the enemys
            int spawnSide = randNum.Next(4);
            switch (spawnSide)
            {
                case 0:
                    //Spawn on Top edge
                    enemy.Left = randNum.Next(ClientRectangle.Width - enemy.Width);
                    enemy.Top = 0;
                    break;

                case 1:
                    //Spawn on Right edge
                    enemy.Left = ClientRectangle.Width - enemy.Width ;
                    enemy.Top = randNum.Next(ClientRectangle.Height - enemy.Height);
                    break;

                case 2:
                    //Spawn on  Bottom edge
                    enemy.Left = randNum.Next(ClientRectangle.Width - enemy.Width );
                    enemy.Top = ClientRectangle.Height -enemy.Height;
                    break;

                case 3:
                    //Spawn on Left edge
                    enemy.Left = 0;
                    enemy.Top = randNum.Next(ClientRectangle.Height - enemy.Height);
                    break;
            }

            //add to Form
            this.Controls.Add(enemy);
            
            //add to List
            enemys.Add(enemy);
        }

        private void timerCrystals_Tick(object sender, EventArgs e)
        {
            
            CreateCrystals();
        }
        private void TimerEnemy(object sender, EventArgs e)
        {
            CreateEnemys();
        }


        #endregion

        #region KeyIsUp
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            //set the movement keys for the game
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }

        }
        #endregion

        #region KeyIsDown
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            //set the movement keys for the game
            
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                direction = "up";
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                direction = "down";
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                direction = "left";
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                direction = "right";

            }
            //look which weapon you use and make something different each time 
            if (e.KeyCode == Keys.E && secondLevel == false)
            {
                if (pB_item1.BackColor == Color.DimGray) { pB_item1.BackColor = Color.Black; pB_item2.BackColor = Color.DimGray; pB_weapon.Tag = "sword"; }
                else if(pB_item2.BackColor == Color.DimGray){ pB_item2.BackColor = Color.Black; pB_item1.BackColor = Color.DimGray; pB_weapon.Tag = "axe"; }
            }
            else if(e.KeyCode == Keys.E && secondLevel && !thirdLevel)
            {
                if (pB_item1.BackColor == Color.DimGray) { pB_item1.BackColor = Color.Black; pB_item2.BackColor = Color.DimGray; pB_weapon.Tag = "sword"; }
                else if (pB_item2.BackColor == Color.DimGray) { pB_item2.BackColor = Color.Black; pB_item3.BackColor = Color.DimGray; pB_weapon.Tag = "pistol"; }
                else if (pB_item3.BackColor == Color.DimGray) { pB_item3.BackColor = Color.Black; pB_item1.BackColor = Color.DimGray; pB_weapon.Tag = "axe"; }
            }
            else if(e.KeyCode == Keys.E && thirdLevel)
            {
                if (pB_item1.BackColor == Color.DimGray) { pB_item1.BackColor = Color.Black; pB_item2.BackColor = Color.DimGray; pB_weapon.Tag = "sword"; }
                else if (pB_item2.BackColor == Color.DimGray) { pB_item2.BackColor = Color.Black; pB_item3.BackColor = Color.DimGray; pB_weapon.Tag = "pistol"; }
                else if (pB_item3.BackColor == Color.DimGray) { pB_item3.BackColor = Color.Black; pB_item4.BackColor = Color.DimGray; pB_weapon.Tag = "shotgun"; }
                else if(pB_item4.BackColor == Color.DimGray) { pB_item4.BackColor = Color.Black; pB_item1.BackColor = Color.DimGray; pB_weapon.Tag = "axe"; }
            }


            if (e.KeyCode == Keys.Space && pB_weapon.Tag.Equals("axe"))
            {
                DestroyedCrystal();

            }
            else if (e.KeyCode == Keys.Space && secondLevel && pB_weapon.Tag.Equals("pistol"))
            {
                ShootBullet(direction);
                pB_weapon.Tag = "pistol";
            }
            else if (e.KeyCode == Keys.Space && thirdLevel && pB_weapon.Tag.Equals("shotgun"))
            {
                ShootBullet(direction);
                pB_weapon.Tag = "shotgun";
            }
            if (e.KeyCode == Keys.Space && pB_weapon.Tag.Equals("sword"))
            {
                 KilledEnemy();
            }
            
        }
        #endregion

        #region Crystal
        public void DestroyedCrystal()
        {
            
            //crystals cant break immediately there are 3 stages
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "crystal" || (string)x.Tag == "broken" || (string)x.Tag == "damage")
                {
                    if (pB_weapon.Bounds.IntersectsWith(x.Bounds))

                    {
                        crystal.Width = 60;
                        crystal.Height = 60;
                        crystal.Top = x.Top;
                        crystal.Left = x.Left;
                       
                        crystal.Visible = false;
                      
                        Controls.Add(crystal);

                        if (crystal.Tag.Equals("crystal"))
                        {
                            Controls.Remove(x);
                            crystal.Visible = true;
                            crystal.Tag = "damage";
                            crystal.Image = Properties.Resources.crystalDamage;
                            crystal.SizeMode = PictureBoxSizeMode.Zoom;
                            return;

                        }
                        else if (crystal.Tag.Equals("damage"))
                        {
                            crystal.Visible = true;
                            crystal.Image = Properties.Resources.crystalMuchDamage;
                            crystal.SizeMode = PictureBoxSizeMode.Zoom;

                            crystal.Tag = "broken";
                            return;
                            
                        }
                        else
                        {
                            crystal.Tag = "crystal";
                            Controls.Remove(x);
                            crystals = crystals + 10;
                            lbl_money.Text = "Crystals: " + crystals;
                            return;
                        }

                    }
                }
            }
        }
        #endregion 

        #region Enemy
        public void KilledEnemy()
        {
           //if you eliminate enemy xp gets dropped 
            foreach (Control x in this.Controls)
            {
               
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    if (pB_weapon.Bounds.IntersectsWith(x.Bounds))
                    {
                        int enemyX = x.Location.X;
                        int enemyY = x.Location.Y;
                        this.Controls.Remove(x);
                        PictureBox xp = new PictureBox();
                        xp.Left = enemyX;
                        xp.Top = enemyY;
                        xp.Height = 5;
                        xp.Width = 5;
                        xp.BackColor = Color.Lime;
                        xp.BringToFront();
                        xp.Tag = "xp";


                        this.Controls.Add(xp);
                        score++;
                        lbl_score.Text = "Score: " + score;

                    }
                }
            }
           
        }
        #endregion

        #region bullet 
        //in which direction bullet gets shot and how fast etc.
        private void ShootBullet(string direction)
        {
            bulletDirection = direction;
            bulletLeft = pB_player.Left +(pB_player.Width / 2);
            bulletTop = pB_player.Top +(pB_player.Height / 2) -15;
            MakeBullet();

            
        }

        private void MakeBullet()
        {
            
            bullet.Size = new Size(5, 5);
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop; 
            bullet.BringToFront();
            bullet.Tag = "bullet";
            bullet.BackColor = Color.White;

            Controls.Add(bullet);
            //PistolTimer.Interval = 100;
            PistolTimer.Start();
 
        }

        private void PistolTimer_Tick(object sender, EventArgs e)
        {
            if(bulletDirection== "left")
            {
                bullet.Left -= 20;

            }
            if(bulletDirection == "right")
            {
                bullet.Left += 20;
            }
            if(bulletDirection == "up")
            {
                bullet.Top -= 20;
            }
            if(bulletDirection == "down")
            {
                bullet.Top += 20;
            }

            if(bullet.Left < 5 || bullet.Left > 1920 || bullet.Top < 5 || bullet.Top > 1080)
            {
                PistolTimer.Stop();
                PistolTimer.Dispose();

            }
           
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {

                    if (bullet.Bounds.IntersectsWith(x.Bounds))
                    {
                       
                        
                            int enemyX = x.Location.X;
                            int enemyY = x.Location.Y;
                            this.Controls.Remove(x);
                            this.Controls.Remove(bullet);
                            PistolTimer.Stop();
                            PistolTimer.Dispose();
                            PictureBox xp = new PictureBox();
                            xp.Left = enemyX;
                            xp.Top = enemyY;
                            xp.Height = 5;
                            xp.Width = 5;
                            xp.BackColor = Color.Lime;
                            xp.BringToFront();
                            xp.Tag = "xp";

                            this.Controls.Add(xp);
                            score++;
                            lbl_score.Text = "Score: " + score;

                  
                    }
                }
            }
            
            
        }
        #endregion

        #region MainTimer

        //PlayerMovement, EnemyMovement, PlayerLives
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            int playerX = pB_player.Location.X;
            int playerY = pB_player.Location.Y;

            if (collision == false)
            {
                if (goUp == true && pB_player.Top > 0)
                {
                    pB_player.Top -= playerSpeed;
                    pB_weapon.Top -= playerSpeed;

                    pB_weapon.Top = playerY - 60;
                    pB_weapon.Left = playerX + 20;
                }
                if (goDown == true && pB_player.Top + pB_player.Height < this.ClientSize.Height)
                {
                    pB_player.Top += playerSpeed;
                    pB_weapon.Top += playerSpeed;

                    pB_weapon.Top = playerY + 63;
                    pB_weapon.Left = playerX + 20;
                }
                if (goLeft == true && pB_player.Left > 0)
                {
                    pB_player.Left -= playerSpeed;
                    pB_weapon.Left -= playerSpeed;

                    pB_weapon.Top = playerY;
                    pB_weapon.Left = playerX - 45;
                }
                if (goRight == true && pB_player.Left + pB_player.Width < this.ClientSize.Width)
                {
                    pB_player.Left += playerSpeed;
                    pB_weapon.Left += playerSpeed;

                    pB_weapon.Top = playerY;
                    pB_weapon.Left = playerX + 60;
                }
                //which image is shown when
                if (pB_weapon.Tag.Equals("axe"))
                {
                    if (goUp == true) { pB_weapon.Image = Properties.Resources.axe4; }
                    else if (goDown == true) { pB_weapon.Image = Properties.Resources.axedown; }
                    else if (goLeft == true) { pB_weapon.Image = Properties.Resources.axeLeft; }
                    else if (goRight) { pB_weapon.Image = Properties.Resources.axe4; }

                }
                if( pB_weapon.Tag.Equals("sword"))
                {
                    if (goUp == true) { pB_weapon.Image = Properties.Resources.sword; }
                    else if (goDown == true) { pB_weapon.Image = Properties.Resources.swordDown; }
                    else if (goLeft == true) { pB_weapon.Image = Properties.Resources.swordLeft; }
                    else if (goRight) { pB_weapon.Image = Properties.Resources.sword; }
                }
                else if (secondLevel && pB_weapon.Tag.Equals("pistol"))
                {
                    if (goUp == true) { pB_weapon.Image = Properties.Resources.pistolUp; }
                    else if (goDown == true) { pB_weapon.Image = Properties.Resources.pistolDown; }
                    else if (goLeft == true) { pB_weapon.Image = Properties.Resources.pistolLeft; }
                    else if (goRight) { pB_weapon.Image = Properties.Resources.pistol; }
                }
                else if (thirdLevel && pB_weapon.Tag.Equals("shotgun"))
                {
                    if (goUp == true) { pB_weapon.Image = Properties.Resources.shotgunOben; }
                    else if (goDown == true) { pB_weapon.Image = Properties.Resources.shotgunUnten; }
                    else if (goLeft == true) { pB_weapon.Image = Properties.Resources.shotgunLinks; }
                    else if (goRight) { pB_weapon.Image = Properties.Resources.shotgun; }
                }
            }
            
           
            collision = false;

           



            //movement of the enemys
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "enemy")
                {
                    if(x.Left > pB_player.Left)
                    {
                        x.Left -= enemySpeed;  
                    }
                    if (x.Left < pB_player.Left)
                    {
                        x.Left += enemySpeed;
                    }
                    if (x.Top > pB_player.Top)
                    {
                        x.Top -= enemySpeed;
                    }
                    if (x.Top < pB_player.Top)
                    {
                        x.Top += enemySpeed;
                    }
                }
                //Players Lives 
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                   if (pB_player.Bounds.IntersectsWith(x.Bounds))
                   {
                        if(pB_life3.Visible)
                        {
                            pB_life3.Visible = false; 
                        }
                        else if(pB_life2.Visible && !pB_life3.Visible)
                        {
                            pB_life2.Visible = false;
                        }
                        else if(!pB_life2.Visible)
                        {
                            EndGame();
                        }

                   }
                }
                //what happens when player touches enemy
                if(x is PictureBox && (string)x.Tag == "crystal")
                {
                    if (pB_player.Bounds.IntersectsWith(x.Bounds))
                    {
                        collision = true;
                        int i = pB_player.Location.X;
                        int y = pB_player.Location.Y;
                        pB_player.Location = new Point(i - 20, y - 20);
                        

                    }
                }
               
               
                //what happens when player touches xp
                if (x is PictureBox && (string)x.Tag == "xp")
                {
                    if (pB_player.Bounds.IntersectsWith(x.Bounds))
                    {
                        
                        Controls.Remove(x);
                        progressBar = progressBar + 10;

                        if (progressBar == pB_xp.Maximum && pB_xp.Maximum == 100)
                        {

                            PistolTimer.Start();
                            secondLevel= true;
                            pB_weapon.Tag = "pistol";
                            pB_item3.BackColor = Color.DimGray;
                            pB_item1.BackColor = Color.Black;
                            pB_item2.BackColor = Color.Black;
                            pB_xp.Value = 0;
                            //progressBar = 0; 
                            pB_xp.Maximum = 110;
                            pB_item3.Image = Properties.Resources.pistol;
                            
                            
                        }
                        else if(progressBar == pB_xp.Maximum && pB_xp.Maximum == 110)
                        {
                            PistolTimer.Start();
                            thirdLevel = true;
                            pB_weapon.Tag = "shotgun";
                            pB_item4.BackColor = Color.DimGray;
                            pB_item1.BackColor = Color.Black;
                            pB_item2.BackColor = Color.Black;
                            pB_item3.BackColor = Color.Black;

                            pB_xp.Value = 0;
                            progressBar = 0;
                            pB_xp.Maximum = 1000;
                            pB_item4.Image = Properties.Resources.shotgun;
                        }
                        else
                        {
                            pB_xp.Value = progressBar;
                        }
                        
                    }
                    
                }

            }
            //how fast enemys spawn
            if (secondLevel) { timerEnemy.Interval = 2000;  }
           
            else if(thirdLevel) { timerEnemy.Interval = 1000;  }

        }
        #endregion

        #region ResetGame
        public void ResetGame()
        {
            //start of the game 


            //give variables values
            lbl_score.Text = "Score: 0";
            score = 0;

            //starting position
            pB_player.Top = 400; 
            pB_player.Left = 600;
            pB_weapon.Top = 400;
            pB_weapon.Left = 650;

            //if you have skin applied 
            PictureBox headAccessoir = new PictureBox();
            headAccessoir.Top = 300;
            headAccessoir.Left = 600;
            headAccessoir.Width = 100;
            headAccessoir.Height = 100;
            headAccessoir.BackColor = Color.Transparent;
            headAccessoir.SizeMode = PictureBoxSizeMode.Zoom;
            
            if(accessoir.Equals(null)) { }
            else if (accessoir.Equals("pb_skin1")) { headAccessoir.Image = Properties.Resources.ente3; }
            else if (accessoir.Equals("pb_skin2")) { headAccessoir.Image = Properties.Resources.hut; }
            else if (accessoir.Equals("pb_skin3")) { headAccessoir.Image = Properties.Resources.magierHut; }
            else if (accessoir.Equals("pb_skin4")) { headAccessoir.Image = Properties.Resources.pirat; }
            else if (accessoir.Equals("pb_skin5")) { headAccessoir.Image = Properties.Resources.schlaufe; }
            else if (accessoir.Equals("pb_skin6")) { headAccessoir.Image = Properties.Resources.schleifeRot; }
            else if (accessoir.Equals("pb_skin7")) { headAccessoir.Image = Properties.Resources.trichter; }
            else if (accessoir.Equals("pb_skin8")) { headAccessoir.Image = Properties.Resources.christmasHut; }
            else if (accessoir.Equals("pb_skin9")) { headAccessoir.Image = Properties.Resources.farmerHut; }

            headAccessoir.BringToFront();
            Controls.Add(headAccessoir);

           

            pB_xp.Value = 0; 

            //remove all remaining ghosts of the previous game
            foreach (PictureBox i in enemys)
            {
                this.Controls.Remove(i)
;
            }
            enemys.Clear();

            //give the crystal PictureBox a Tag
            crystal.Tag = "crystal";

            //Create 5 ghost in Form
            for (int i = 0; i < 5; i++)
            {
                CreateEnemys();
                CreateCrystals();
            }

            goDown = false; 
            goUp = false;
            goLeft = false;
            goRight = false;
            PistolTimer.Stop();
            mainTimer.Start();


            pB_weapon.Tag = "axe";
            progressBar = 90;
            

 
        }

     


        #endregion
    }
}
