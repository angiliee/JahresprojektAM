using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jahresprojekt
{
    public partial class Login : Form
    {
        SqlCommunication sql = new SqlCommunication();
        string username = "", password = "", accessoir = "";

        public Login()
        {
            InitializeComponent();
            txtB_username.Focus();
            
        }

        private void bttn_continue_Click(object sender, EventArgs e)
        {

            username = txtB_username.Text;
            password = txtB_password.Text;

            //look if username and password is correct
            bool correct = sql.SignIn(username, password);

            //if login is correct go to next form
            if(correct)
            {
                Mainmenu goMainMenu = new Mainmenu(accessoir);
                goMainMenu.NameOfPlayer(username);
                goMainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong. Username or Password are wrong.");
                txtB_username.Clear();
                txtB_password.Clear();
                txtB_username.Focus();
            }
        }

        private void bttn_register_Click(object sender, EventArgs e)
        {
            //go to register Forms
            lbl_register register = new lbl_register();
            register.ShowDialog();
            this.Close();
           
            
        }

        private void txtB_username_MouseClick(object sender, MouseEventArgs e)
        {
            txtB_username.Clear();
        }

        private void txtB_password_MouseClick(object sender, MouseEventArgs e)
        {
            txtB_password.Clear();
            txtB_password.PasswordChar = '*';
        }

       
    }
}
