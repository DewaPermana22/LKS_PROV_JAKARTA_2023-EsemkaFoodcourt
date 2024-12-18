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
    public partial class UserControl1 : UserControl
    {
        public Action<List<Menus>> Action;
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Menus menu)
            {
                if (edit_ingredients.Index == e.ColumnIndex)
                {
                    Action?.Invoke(db.Menus.ToList());
                }
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            dgv_usr_controll.DataSource = db.Menus.ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Menus menu)
            {
                if (edit_ingredients.Index == e.ColumnIndex)
                {
                    e.Value = "Edit_Ingredients";
                }
            }
        }
    }
}
