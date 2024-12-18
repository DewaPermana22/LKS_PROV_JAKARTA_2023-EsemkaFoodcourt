using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_JAKARTA_2024
{
    public partial class ManageMember : Form
    {
        EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        private string kondisi_tombol = null;
        public ManageMember()
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
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void insert_condition()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            
        }
        private void edit_condition()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            
        }
        private void delete_condition()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void ManageMember_Load(object sender, EventArgs e)
        {
            dgvMember.DataSource = food.Users.ToList();
            load_button();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Users user)
            {
                if (join_date.Index == e.ColumnIndex)
                {
                    e.Value = $"{user.DateJoined.ToString("dd/MM/yyyy")} ({DateTime.Now.Year - user.DateJoined.Year} year(s)) ";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMember.Current is Users user)
            {
                inputMember.DataSource = user;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_condition();
            if (kondisi_tombol == null) kondisi_tombol = "INSERT";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_condition();
            if (kondisi_tombol == null) kondisi_tombol = "UPDATE";            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_condition();
            if (kondisi_tombol == null) kondisi_tombol = "DELETE";            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kondisi_tombol == "INSERT")
            {
                Users user = new Users()
                {
                    FirstName = textBox2.Text,
                    LastName = textBox3.Text,
                    Email = textBox4.Text,
                    Password = textBox5.Text,
                    DateJoined = DateTime.Now,
                    RoleID = 1,
                    PhoneNumber = textBox6.Text,
                };
                food.Users.AddOrUpdate(user);
            } else if (kondisi_tombol == "DELETE")
            {
                if (inputMember.Current is Users user)
                {
                    food.Users.Remove(user);
                }
            }
                food.SaveChanges();
            if (kondisi_tombol == "INSERT")
            {
                MessageBox.Show("Berhasil Tambah Data!");
            } else if (kondisi_tombol == "DELETE")
            {
                MessageBox.Show("Berhasil Menghapus Data!");
            }
            else
            {
                MessageBox.Show("Berhasil Update Data!");
            }
            OnLoad(null);
            kondisi_tombol = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower().Trim();
            var cari = food.Users.Where(usr => usr.FirstName.Contains(text) || usr.LastName.Contains(text)
            || usr.Email.Contains(text)).ToList();
            dgvMember.DataSource = cari;
            if (String.IsNullOrEmpty(text))
            {
                dgvMember.DataSource = food.Users.ToList();
            }
        }
    }
}
