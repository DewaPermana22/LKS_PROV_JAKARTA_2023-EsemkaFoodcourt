using LKS_JAKARTA_2024.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_JAKARTA_2024
{
    public partial class manage_table : UserControl
    {
        Tables Tables;
        public Action Action;
        public Reservations Reservations {  get; private set; } 
        List<ReservationDetails> ReservationDetails;
        EsemkaFoodcourtEntities food = new EsemkaFoodcourtEntities();
        public manage_table(Tables tables, List<ReservationDetails> rd)
        {
            this.ReservationDetails = rd;
            this.Reservations = rd.FirstOrDefault(res => res.Reservations.TableID == tables.ID)?.Reservations;
            this.Tables = tables;
            InitializeComponent();
        } 

        private void manage_table_Load(object sender, EventArgs e)
        {
            if (this.ReservationDetails.FirstOrDefault( tbl => tbl.Reservations.TableID == Tables.ID) != null)
            {
                pictureBox1.Image = Resources.table_reserved;
            } else
            {
                pictureBox1.Image = Resources.table_free;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.Reservations != null)
            {
                Action?.Invoke();
            }
        }
    }
}
