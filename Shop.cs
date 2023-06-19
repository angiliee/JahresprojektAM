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
    public partial class Shop : Form
    {
        string currentBox = "";
        SqlCommunication sql = new SqlCommunication();
        string username;
        string buyingObject;
        int crystal;
        int cost;
        string accessoir = "";
        public Shop(string username)
        {
            InitializeComponent();
            this.username = username;
            ShopStart();


        }

        public void ShopStart()
        {
            //show the money the user has

            crystal = sql.ShowCrystals(this.username);
            lbl_money.Text = "Crystal: " + crystal;


        }

        private void bttn_start_Click(object sender, EventArgs e)
        {
            Mainmenu goBack = new Mainmenu(accessoir);
            goBack.StartPosition = FormStartPosition.WindowsDefaultLocation;
            goBack.ShowDialog();
            this.Close();
        }

        private void bttn_buy_Click(object sender, EventArgs e)
        {
            //if the user has enough money buy the item
            
            if(crystal > cost)
            {
                sql.BuyObject(buyingObject, this.username);
            }
            else
            {
                MessageBox.Show("You don't have enough money for this item.");
            }
            
          
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            //show the item the user wants to buy in the big pictureBox
            pB_accessoir.Left = 1064;
            pB_accessoir.Top = 196;
        
            PictureBox pb = sender as PictureBox;
            if(pb.Name.Equals(pB_skin1.Name)) { cost = 30;  lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.ente3;   }
            else if (pb.Name.Equals(pB_skin2.Name)) { cost = 400; lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.hut;  }
            else if (pb.Name.Equals(pB_skin3.Name)) { cost = 500; lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.magierHut;  }
            else if (pb.Name.Equals(pB_skin4.Name)) { cost = 300; lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.pirat;  }
            else if (pb.Name.Equals(pB_skin5.Name)) { cost = 200; lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.schlaufe; }
            else if (pb.Name.Equals(pB_skin6.Name)) { cost = 200; lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.schleifeRot;  }
            else if (pb.Name.Equals(pB_skin7.Name)) { cost = 400; lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.trichter;  }
            else if (pb.Name.Equals(pB_skin8.Name)) { cost = 400; lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.christmasHut;  }
            else if (pb.Name.Equals(pB_skin9.Name)) { cost = 500; lbl_cost.Text = "COST: " + cost; pB_accessoir.Image = Properties.Resources.farmerHut; }

            buyingObject = pb.Name;



        }

        private void bttn_use_Click(object sender, EventArgs e)
        {
            //player wants to apply item
            bool owner =  sql.OwnsItem(this.username, buyingObject);
            if(owner)
            {
                MessageBox.Show("The item was applied.");
                Mainmenu goBack = new Mainmenu(buyingObject);
                goBack.StartPosition = FormStartPosition.WindowsDefaultLocation;
                goBack.ShowDialog();
                this.Close();

            }
            else
            {
                buyingObject = "";
                MessageBox.Show("Buy the item first so you can apply it.");
                Mainmenu goBack = new Mainmenu(buyingObject);
                goBack.StartPosition = FormStartPosition.WindowsDefaultLocation;
                goBack.ShowDialog();
                this.Close();

            }
        }







    }
}
