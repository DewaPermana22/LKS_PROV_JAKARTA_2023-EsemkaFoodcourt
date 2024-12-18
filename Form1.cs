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
    public partial class Form1 : Form
    {
        EsemkaFoodcourtEntities esemka = new EsemkaFoodcourtEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("@"))
            {
                MessageBox.Show("Invalid Email, Email must contains @.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                var login = esemka.Users.Where(usr => usr.Email == textBox1.Text && usr.Password == textBox2.Text).FirstOrDefault();
                if (login != null)
                {
                    var is_admin = login.RoleID;
                    if (is_admin == 1)
                    {
                        Admin admin = new Admin(login);
                        admin.ShowDialog();
                    }
                    else
                    {
                        User user = new User(login);
                        user.ShowDialog();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "chadaway2@globo.com";
            textBox2.Text = "rB9|/0<`";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
