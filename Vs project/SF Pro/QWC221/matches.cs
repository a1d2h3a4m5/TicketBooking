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

namespace QWC221
{
    public partial class matches : Form
    {
        SqlConnection con2 = new SqlConnection(@"Data Source=STRANGE-PC;Initial Catalog=Ticketbooking;Integrated Security=True");
        SqlDataAdapter da2;
        DataTable dt2 = new DataTable();
        SqlCommandBuilder cmd1;
        public matches()
        {
         

            InitializeComponent();

            da2 = new SqlDataAdapter("Select* From matches", con2);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            
        }

        private void matches_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketbookingDataSet.matches' table. You can move, or remove it, as needed.
            this.matchesTableAdapter.Fill(this.ticketbookingDataSet.matches);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd1 = new SqlCommandBuilder(da2);
            da2.Update(dt2);
            MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
