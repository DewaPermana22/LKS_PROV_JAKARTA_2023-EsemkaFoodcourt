using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LKS_JAKARTA_2024
{
    public partial class manage_ingredients : Form
    {
        EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        int id_menu;
        public manage_ingredients()
        {
            InitializeComponent();
        }

        private void initial_state()
        {
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            numericUpDown1.Value = 0;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            numericUpDown1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void action_state()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            numericUpDown1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void manage_ingredients_Load(object sender, EventArgs e)
        {
            var menu_controll = new UserControl1();
            dgv_menu.DataSource = food.Menus.ToList();
            input_ingredients.DataSource = food.Ingredients.ToList();
            units_binding.DataSource = food.Units.ToList();
            initial_state();
            dataGridView1.AllowUserToAddRows = false;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is Menus menu)
            {
                if (edit_ingredients.Index == e.ColumnIndex)
                {
                     id_menu = menu.ID;
                    dgv_ingredients.DataSource = food.MenuIngredients.Where(ign => ign.MenuID == id_menu).ToList();
                    action_state();
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is Menus menu)
            {
                if (edit_ingredients.Index == e.ColumnIndex)
                {
                    e.Value = "Edit Ingredients";
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is MenuIngredients ingredients)
            {
                if (remove_btn.Index == e.ColumnIndex)
                {
                    e.Value = "Remove";
                }
                if (ing_id.Index == e.ColumnIndex)
                {
                    e.Value = ingredients.Ingredients.Name;
                }
                if (unit_id.Index == e.ColumnIndex)
                {
                    e.Value = ingredients.Units.Name;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBox1.Text.ToLower().Trim();
            var pencarian = food.Menus.Where( m => m.Name.ToLower().Contains(keywords) ).ToList();
            dgv_menu.DataSource = pencarian;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                dgv_menu.DataSource = food.Menus.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is MenuIngredients ingredients)
            {
                if (remove_btn.Index == e.ColumnIndex)
                {
                   food.MenuIngredients.Remove( ingredients );
                    var confirm = MessageBox.Show("Are you sure to delete this ingredients?","Warning!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                    food.SaveChanges();
                     dgv_ingredients.DataSource = food.MenuIngredients.Where(ign => ign.MenuID == id_menu).ToList();
                     OnLoad(null);    
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initial_state();
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            food.SaveChanges();
            dgv_ingredients.DataSource = food.MenuIngredients.Where(ign => ign.MenuID == id_menu).ToList();
            OnLoad(null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuIngredients menuIngredients = new MenuIngredients()
            {
                IngredientID = Convert.ToInt32(comboBox1.SelectedValue),
                MenuID = id_menu,
                Qty = Convert.ToInt32(numericUpDown1.Value),
                UnitID = Convert.ToInt32(comboBox2.SelectedValue),
            };
            var cek_sudah_ada_belum = food.MenuIngredients.FirstOrDefault(n => n.IngredientID == menuIngredients.IngredientID);
            if (cek_sudah_ada_belum != null)
            {
                MessageBox.Show("Food ingredients are available, please choose other ingredients!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.SelectedValue = 0;
                numericUpDown1.Value = 0;
                comboBox2.SelectedValue = 0;
            }
            food.MenuIngredients.Add(menuIngredients);
        }
    }
}
