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
    public partial class Register : Form
    {
        EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox3.Text.Contains("@"))
            {
                MessageBox.Show("Invalid Email", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            } else if (textBox4.Text.Length <= 12)
            {
                MessageBox.Show("Phone Number must be more than 12 digits", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            } else if (textBox6.Text != textBox5.Text)
            {
                MessageBox.Show("Passwords do not match! Please try again", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
            }
            else
            {
                Users user = new Users()
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Email = textBox3.Text,
                    PhoneNumber = textBox4.Text,
                    Password = textBox6.Text,
                    DateJoined = DateTime.Now,
                    RoleID = 2
                };
                food.Users.Add(user);
                food.SaveChanges();
                MessageBox.Show("Registration successful, please log in!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }
    }
}
