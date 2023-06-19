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
    public partial class Start : Form
    {
        SqlCommunication sql = new SqlCommunication();
        public Start()
        {
            InitializeComponent();
            sql.CreateDatabase();
        }
        //let the user decide if he wants to login or to register
        private void bttn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
            
            
        }

        private void bttn_register_Click(object sender, EventArgs e)
        {
            lbl_register register = new lbl_register();
            register.ShowDialog();
            this.Close();
           
            
        }

        private void bttn_quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
