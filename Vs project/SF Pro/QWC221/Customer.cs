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
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=STRANGE-PC;Initial Catalog=Ticketbooking;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;


        public Customer()
        {
            InitializeComponent();
            da = new SqlDataAdapter("Select* From Customer",con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
           
         

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketbookingDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.ticketbookingDataSet.customer);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
