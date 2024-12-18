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
    public partial class reserve_table : Form
    {
        public class pesanan_user
        {
            public int ID {  get; set; }
            public string Name { get; set; }
            public int Qty { get; set; }
            public double Price { get; set; }
            public double Subtotal => Qty * Price;
        }

        Users users;
        private List<pesanan_user> list_menu = new List<pesanan_user>();
        List<int> list_id_pesanan = new List<int>();
        EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        public reserve_table(Users orang)
        {
            this.users = orang;
            InitializeComponent();
        }

        private void is_check()
        {
            textBox1.Text = users.FirstName.ToString();
            textBox2.Text = users.LastName.ToString();
            textBox3.Text = users.Email.ToString();
            textBox4.Text = users.PhoneNumber.ToString();
            groupBox2.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void not_check()
        {
            groupBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void reserve_table_Load(object sender, EventArgs e)
        {
            menu_binding.DataSource = food.Menus.ToList();
            table_binding.DataSource = food.Tables.ToList();
            lb_res_fee.Text = 50000.ToString("C", new CultureInfo("id-ID"));
            DateTime hari_ini = DateTime.Today;
            var cek_tanggal = food.Reservations.Where( md => md.ReservationDate == hari_ini).Select( md => md.TableID ).ToList();
            var ambil_meja = food.Tables.Where( t => !cek_tanggal.Contains(t.ID)).Select( t => new {t.ID , t.Name} ).ToList();
            table_binding.DataSource = ambil_meja;
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            not_check();
            dataGridView1.DataSource = null;
            checkBox1.Checked = false;
            lb_menutotal.Text = 0.ToString("C", new CultureInfo("id-ID"));
            lb_total.Text = 0.ToString("C", new CultureInfo("id-ID"));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
               is_check();
            }
            else
            {
                not_check();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id_menu = Convert.ToInt32(comboBox2.SelectedValue);
            var menu = food.Menus.FirstOrDefault(m => m.ID == id_menu);
            if (menu != null)
            {
                if (numericUpDown2.Value == 0)
                {
                    MessageBox.Show("Orders Must be more than 0", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    var qty = Convert.ToInt32(numericUpDown2.Value);
                    list_menu.Add(new pesanan_user
                    {
                        ID = menu.ID,
                        Name = menu.Name,
                        Qty = qty,
                        Price = menu.Price,
                    });
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list_menu;
                    dataGridView1.Columns["ID"].Visible = false;
                    dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C";
                    dataGridView1.Columns["Price"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
                    dataGridView1.Columns["Subtotal"].DefaultCellStyle.Format = "C";
                    dataGridView1.Columns["Subtotal"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
                    if (!list_id_pesanan.Contains(menu.ID))
                    {
                        list_id_pesanan.Add(menu.ID);
                    }
                    Console.WriteLine($"ID Pesanan Saat Ini: {string.Join(", ", list_id_pesanan)}");
                    double harga = list_menu.Sum(m => m.Subtotal);
                    double total = Convert.ToDouble(harga) + 50000;
                    lb_menutotal.Text = harga.ToString("C", new CultureInfo("id-ID"));
                    lb_total.Text = total.ToString("C", new CultureInfo("id-ID"));
                }
            }
            else
            {
                MessageBox.Show("Menu not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cmb_1 = Convert.ToInt32(comboBox1.SelectedValue);
            var num_1 = Convert.ToInt32(numericUpDown1.Value);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please complete the information user!", "Action rejected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (cmb_1 == 0 || numericUpDown1.Value == 0) {
                MessageBox.Show("Please select an available table first!", "Action rejected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (dataGridView1.DataSource == null) {
                MessageBox.Show("Please select the menu first!", "Action rejected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!textBox3.Text.Contains("@"))
            {
                MessageBox.Show("Invalid Email! Email must contain '@'.");
                textBox3.Focus();
            } else if (textBox4.Text.Length <= 12)
            {
                MessageBox.Show("Phone number must be at least 12 digits!");
                textBox4.Focus();
            }
            else
            {
                Reservations res = new Reservations()
                {
                    UserID = users.ID,
                    NumberOfPeople = num_1,
                    CustomerFirstName = textBox1.Text,
                    CustomerLastName = textBox2.Text,
                    CustomerEmail = textBox3.Text,
                    ReservationDate = dateTimePicker1.Value,
                    CustomerPhoneNumber = textBox4.Text,
                    TableID = cmb_1,
                };
                food.Reservations.Add(res);
                food.SaveChanges();
                foreach (var item in list_menu)
                {
                    ReservationDetails details = new ReservationDetails()
                    {
                        ReservationID = res.ID,
                        MenuID = item.ID,
                        Qty = item.Qty,
                    };
                    food.ReservationDetails.Add(details);
                }

                food.SaveChanges();
                MessageBox.Show("Successfully made a reservation!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnLoad(null);
                dataGridView1.Columns.Clear();
                list_id_pesanan.Clear();
                list_menu.Clear();
            }
        }
    }
}
