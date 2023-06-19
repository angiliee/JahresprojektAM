using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jahresprojekt
{
    public partial class PlayerScore : Form
    {
        SqlCommunication sql = new SqlCommunication();
        int score2 = 0;
        string username, accessoir = "";
        public PlayerScore()
        {
            InitializeComponent();
            
        }

        //score from Game(Endgame)
        public void Score(int score, string username)
        {
            //show score
            lbl_score2.Text = "" + score;
            this.score2 = score;
            this.username = username;
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            
            Mainmenu main = new Mainmenu(accessoir);
            main.StartPosition = FormStartPosition.WindowsDefaultLocation;
            main.ShowDialog();
            this.Close();
        }

        private void bttn_otherScores_Click(object sender, EventArgs e)
        {
            sql.AddToTable(score2,username);
            Score score = new Score();
            score.StartPosition = FormStartPosition.WindowsDefaultLocation;
            score.ShowDialog();
            this.Close();
        }

        
    }
}
