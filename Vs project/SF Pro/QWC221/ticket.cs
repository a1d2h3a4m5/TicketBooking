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
    public partial class ticket : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=STRANGE-PC;Initial Catalog=ticketbooking;Integrated Security=True");
        SqlDataAdapter da1;
        DataTable dt1 = new DataTable();
        SqlCommandBuilder cmd1;
        public ticket()
        {
            


            InitializeComponent();
            da1 = new SqlDataAdapter("Select* From ticket", con1);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;




            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketbookingDataSet.ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.ticketbookingDataSet.ticket);

        }

        private void ticketbookingDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ticketBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd1 = new SqlCommandBuilder(da1);
            da1.Update(dt1);
            MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
