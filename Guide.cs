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
    public partial class Guide : Form
    {
        string accessoir = "";
        public Guide()
        {
            InitializeComponent();
            TextGuide();
        }
        public void TextGuide()

            //Guide Text 
        {
            string newLine = Environment.NewLine;

            txtB_guide.Text = "Welcome to the Game: Survive the Monsters!" + newLine;
            txtB_guide.Text += "Your goal is to eliminate the Monsters and to collect the Crystals." + newLine;
            txtB_guide.Text += "In this game are four weapons: a axe, a sword, a pistol and a shotgun." + newLine;
            txtB_guide.Text += "The weapons will be accessable after a certain amount of kills which will help you to destroy your enemys." + newLine;
            txtB_guide.Text += "With the crystals you can by yourself some fun accesoires in the Shop for your character. " + newLine;
            txtB_guide.Text += "" + newLine;
            txtB_guide.Text += "General:" + newLine;
            txtB_guide.Text += "" + newLine;
            txtB_guide.Text += "Hold WASD for movement" + newLine;
            txtB_guide.Text += "To shot or to attack press SPACE" + newLine;
            txtB_guide.Text += "To change weapons press E" + newLine;

        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            //go back to main menu 
            Mainmenu goBack = new Mainmenu(accessoir);
            goBack.StartPosition = FormStartPosition.WindowsDefaultLocation;
            goBack.ShowDialog();
            this.Close();
        }

        
    }
}
