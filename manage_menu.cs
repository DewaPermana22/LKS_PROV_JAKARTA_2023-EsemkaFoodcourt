using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_JAKARTA_2024
{
    public partial class manage_menu : Form
    {
        private string kondisi_tombol = null;

        EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        public manage_menu()
        {
            InitializeComponent();
        }

        private void load_button()
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBoxMenuName.Enabled = false;
            textBoxDeskripsi.Enabled = false;
            harga_numeric.Enabled = false;
            comboBoxKategori.Enabled = false;

            textBoxMenuName.Text = "";
            textBoxDeskripsi.Text = "";
            harga_numeric.Value = 0;
            comboBoxKategori.SelectedValue = 0;
        }

        private void insert_condition()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            textBoxMenuName.Enabled = true;
            textBoxDeskripsi.Enabled = true;
            harga_numeric.Enabled = true;
            comboBoxKategori.Enabled = true;
        }
        private void edit_condition()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = false;
            textBoxMenuName.Enabled = true;
            textBoxDeskripsi.Enabled = true;
            harga_numeric.Enabled = true;
            comboBoxKategori.Enabled = true;
        }
        private void delete_condition()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Menus menu)
            {
                if (kategori.Index == e.ColumnIndex)
                {
                    e.Value = menu.Categories.Name;
                }
            }
        }

        private void manage_menu_Load(object sender, EventArgs e)
        {
            dgvMenu.DataSource = food.Menus.ToList();
            categoriesBindingSource.DataSource = food.Categories.ToList();
            load_button();
            dataGridView1.Columns["harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
            dataGridView1.Columns["harga"].DefaultCellStyle.Format = "C2"; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Menus menu)
            {
                inputBindingMenu.DataSource = menu;
                comboBoxKategori.SelectedValue = menu.CategoryID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_condition();
            if (kondisi_tombol == null)
            {
                kondisi_tombol = "INSERT".ToLower();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kondisi_tombol == "INSERT".ToLower())
            {
                Menus menu = new Menus()
                {
                    Name = textBoxMenuName.Text,
                    CategoryID = Convert.ToInt32(comboBoxKategori.SelectedValue),
                    Description = textBoxDeskripsi.Text,
                    Price = Convert.ToInt32(harga_numeric.Value)
                };
                food.Menus.AddOrUpdate(menu);
            } else if (kondisi_tombol == "DELETE".ToLower())
            {
                if (inputBindingMenu.Current is Menus menu)
                {
                    food.Menus.Remove(menu);
                }
            }
            food.SaveChanges();
            if (kondisi_tombol == "INSERT".ToLower())
            {
                MessageBox.Show("Berhasil Tambah Data!");
            } else if (kondisi_tombol == "UPDATE".ToLower())
            {
                MessageBox.Show("Berhasil Update Data!");
            } else if (kondisi_tombol == "DELETE".ToLower())
            {
                MessageBox.Show("Berhasil Hapus Data!");
            }
            OnLoad(null);
            kondisi_tombol = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_condition();
            if (kondisi_tombol == null) kondisi_tombol = "UPDATE".ToLower();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_condition();
            if (kondisi_tombol == null) kondisi_tombol = "DELETE".ToLower();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword_user = textBox1.Text.ToLower().Trim();
            var cari = (from menu in food.Menus join
                        kategori in food.Categories on menu.CategoryID equals kategori.ID
                        where menu.Name.ToLower().Contains(keyword_user) || kategori.Name.ToLower().Contains(keyword_user)
                        select new
                        {
                            Name = menu.Name, 
                            CategoryID = kategori.Name,
                            Price = menu.Price,
                            Description = menu.Description,

                        }).ToList();
            dgvMenu.DataSource = cari;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                dgvMenu.DataSource = food.Menus.ToList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            load_button();
        }
    }
}
