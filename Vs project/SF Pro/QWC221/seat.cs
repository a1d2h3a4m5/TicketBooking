using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWC221
{
    public partial class seat : Form
    {

        SqlConnection con4 = new SqlConnection(@"Data Source=STRANGE-PC;Initial Catalog=Ticketbooking;Integrated Security=True");
        SqlDataAdapter da4;
        DataTable dt4 = new DataTable();
        SqlCommandBuilder cmd4;

        public seat()
        {


            InitializeComponent();
            da4 = new SqlDataAdapter("Select* From seat", con4);
            da4.Fill(dt4);
            dataGridView1.DataSource = dt4;

            InitializeComponent();
        }

        private void seat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketbookingDataSet.seat' table. You can move, or remove it, as needed.
            this.seatTableAdapter.Fill(this.ticketbookingDataSet.seat);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd4 = new SqlCommandBuilder(da4);
            da4.Update(dt4);
            MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
