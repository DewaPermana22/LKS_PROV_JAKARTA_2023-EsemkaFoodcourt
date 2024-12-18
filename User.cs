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
    public partial class User : Form
    {
        EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        Users users;
        public User(Users user)
        {
            this.users = user;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("HH:MM:ss");
        }

        private void User_Load(object sender, EventArgs e)
        {
            label2.Text = users.FirstName + " " + users.LastName;
            flowLayoutPanel1.Controls.Clear();
            var data_reservasi = food.ReservationDetails.Where(rd => rd.Reservations.ReservationDate == DateTime.Today).ToList();

            var table_sudah_dipesan = food.Tables.ToList();
            foreach (var item in table_sudah_dipesan)
            {
                var usc = new manage_table(item, data_reservasi);
                flowLayoutPanel1.Controls.Add(usc);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reserve_table reserve = new reserve_table(users);
            reserve.ShowDialog();
        }

        private void User_Activated(object sender, EventArgs e)
        {
            User_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_history view = new view_history(users);
            view.ShowDialog();
        }
    }
}
