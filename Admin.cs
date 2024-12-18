using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_JAKARTA_2024
{
    public partial class Admin : Form
    {
        public Users User;
        public Admin(Users user)
        {
            this.User = user;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            var first_name = User.FirstName;
            var last_name = User.LastName;
            label2.Text = first_name + " " + last_name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manage_menu menu = new manage_menu();
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageMember manageMember = new ManageMember();
            manageMember.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manage_ingredients manage_Ingredients = new manage_ingredients();
            manage_Ingredients.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view_reservation view_Reservation = new view_reservation();
            view_Reservation.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
