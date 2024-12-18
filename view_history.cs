using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_JAKARTA_2024
{
    public partial class view_history : Form
    {
        Users user;
        EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        public view_history(Users user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void view_history_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                var ambil_data = (from rd in food.ReservationDetails join 
                                  r in food.Reservations on rd.ReservationID equals r.ID join
                                  mn in food.Menus on rd.MenuID equals mn.ID
                                  where r.UserID == user.ID group new { rd, r, mn } 
                                  by new { r.ID, r.UserID, r.ReservationDate} into g 
                                  select new
                                  {
                                      ID = g.Key.ID,
                                      ReservationDate = g.Key.ReservationDate,
                                      TableNo = g.FirstOrDefault().r.Tables.Name,
                                      NumberOfPeople = g.FirstOrDefault().r.NumberOfPeople,
                                      Subtotal = g.Sum( x => x.mn.Price * x.rd.Qty)
                                  }).ToList();
                dataGridView1.DataSource = ambil_data;
                dataGridView1.Columns["ReservationDate"].DefaultCellStyle.Format = "dd/MM/yyy";
                dataGridView1.Columns["Subtotal"].DefaultCellStyle.Format = "C";
                dataGridView1.Columns["Subtotal"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id_reservasi = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                var menu_dipesan = (from rd in food.ReservationDetails join 
                                    menu in food.Menus on rd.MenuID equals menu.ID
                                    where rd.ReservationID == id_reservasi
                                    select new
                                    {
                                        Menu = menu.Name,
                                        Qty = rd.Qty,
                                        Price = menu.Price,
                                        Subtotal = menu.Price * rd.Qty
                                    }).ToList();
                dataGridView2.DataSource = menu_dipesan;
                dataGridView2.Columns["Price"].DefaultCellStyle.Format = "C";
                dataGridView2.Columns["Subtotal"].DefaultCellStyle.Format = "C";
                dataGridView2.Columns["Price"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
                dataGridView2.Columns["Subtotal"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
            }
        }
    }
}
