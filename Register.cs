using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Jahresprojekt
{
    public partial class lbl_register : Form
    {
        SqlCommunication sql = new SqlCommunication();
        public lbl_register()
        {
            
            InitializeComponent();
            
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            //go back to Login Form
            Login login = new Login();
            login.ShowDialog();
            this.Close();


        }

        private void bttn_create_Click(object sender, EventArgs e)
        {
        //create new account and see if 1 password and 2 password are equal

            string nUsername, nPassword;
            if (txtB_password.Equals(string.Empty))
            {
                return;
            }
            txtB_password.MaxLength = 20;

            if (txtB_password.Text.Equals(txtB_password2.Text))
            {
                nUsername = txtB_username.Text;
                nPassword = txtB_password.Text;
                sql.Register(nUsername, nPassword);

                Login login = new Login();
                this.Close();
                login.ShowDialog();
            }
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

        private void txtB_password2_MouseClick(object sender, MouseEventArgs e)
        {
            txtB_password2.Clear();
            txtB_password2.PasswordChar = '*';
        }
    }
}
