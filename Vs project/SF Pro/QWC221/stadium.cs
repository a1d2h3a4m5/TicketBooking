using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace QWC221
{
    public partial class stadium : Form
    {

        SqlConnection con4 = new SqlConnection(@"Data Source=STRANGE-PC;Initial Catalog=Ticketbooking;Integrated Security=True");
        SqlDataAdapter da4;
        DataTable dt4 = new DataTable();
        SqlCommandBuilder cmd5;


        public stadium()
        {

            InitializeComponent();
            da4 = new SqlDataAdapter("Select* From stadium", con4);
            da4.Fill(dt4);
            dataGridView1.DataSource = dt4;

            InitializeComponent();
        }

        private void stadium_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketbookingDataSet.stadium' table. You can move, or remove it, as needed.
            this.stadiumTableAdapter.Fill(this.ticketbookingDataSet.stadium);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd5 = new SqlCommandBuilder(da4);
            da4.Update(dt4);
            MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
