using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LKS_JAKARTA_2024
{
    public partial class view_reservation : Form
    {
       EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        public view_reservation()
        {
            InitializeComponent();
        }

        private void view_reservation_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data_reservasi = food.ReservationDetails.Where( rd => rd.Reservations.ReservationDate == dateTimePicker1.Value.Date).ToList();

            var table_sudah_dipesan = food.Tables.ToList();
            foreach (var item in table_sudah_dipesan)
            {
                var usc = new manage_table(item,data_reservasi);
                usc.Action = () => detail_booking(usc.Reservations);
                flowLayoutPanel1.Controls.Add(usc);
            }
        }

        private void detail_booking(Reservations rsesrvations)
        {
            if (rsesrvations != null)
            {
                binding_input.DataSource = rsesrvations;
            }
            else
            {
                binding_input.DataSource = null;
            }
            var ambil_menu_id = (from rd in food.ReservationDetails join
                                 res in food.Reservations on rd.ReservationID equals res.ID join
                                 menu in food.Menus on rd.MenuID equals menu.ID where rd.ReservationID == rsesrvations.ID
                                 select new
                                 {
                                     
                                     MenuID = menu.Name,
                                     Qty = rd.Qty,
                                     Price = menu.Price,
                                     Subtotal = menu.Price * rd.Qty,
                                 }).ToList();
            
            dataGridView1.DataSource = ambil_menu_id;
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C";
            dataGridView1.Columns["Subtotal"].DefaultCellStyle.Format = "C";
            dataGridView1.Columns["Subtotal"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
            dataGridView1.Columns["Price"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            OnLoad(null);
        } 
    }
}
