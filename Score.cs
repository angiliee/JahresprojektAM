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
    public partial class Score : Form
    {
        SqlCommunication sql = new SqlCommunication();
        string accessoir = "";
        public Score()
        {
            InitializeComponent();

            //sql.ShowScore(dgv_scores);
            sql.NewScore(txtB_rank, txtB_username, txtB_score);

        }
        public void ViewScore()
        {
            //sql.ShowScore(dgv_scores);
            sql.NewScore(txtB_rank, txtB_username, txtB_score);

        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            Mainmenu goBack = new Mainmenu(accessoir);
            goBack.StartPosition = FormStartPosition.WindowsDefaultLocation;
            goBack.ShowDialog();
            this.Close();
            
        }

      
    }
}
