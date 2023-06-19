using System.Security.Cryptography.X509Certificates;

namespace Jahresprojekt
{
    public partial class Mainmenu : Form
    {
        string username, accessoir;

        //just forms where you can go to other forms
     
        public Mainmenu(string accessoir)
        {
            InitializeComponent();
            this.accessoir = accessoir;


        }

        public void NameOfPlayer(string username)
        {
            lbl_welcome.Text = "Welcome \n " + username + "!";  
            this.username = username;
        }
        private void bttn_start_Click_1(object sender, EventArgs e)
        {
            Game startGame = new Game(username, this.accessoir);
            startGame.StartPosition = FormStartPosition.WindowsDefaultLocation;
            startGame.ShowDialog();
            this.Close();
            
        }
        
        private void bttn_score_Click_1(object sender, EventArgs e)
        {
            Score goScore = new Score();
            goScore.StartPosition = FormStartPosition.WindowsDefaultLocation;
            goScore.ShowDialog();
            this.Close();
            
        }

        private void bttn_guide_Click_1(object sender, EventArgs e)
        {
           Guide help = new Guide();
            help.StartPosition = FormStartPosition.WindowsDefaultLocation;
            help.ShowDialog();
            this.Close();

           
        }

        private void bttn_exit_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.WindowsDefaultLocation;
            login.ShowDialog();
            this.Close();

            
            
        }

        private void bttn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bttn_skins_Click(object sender, EventArgs e)
        {
            Shop skin = new Shop(username);
            skin.StartPosition= FormStartPosition.WindowsDefaultLocation;
            skin.ShowDialog();
            this.Close();
        }
    }
}