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
    public partial class tbForm6 : Form
    {

        

        public tbForm6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!=""&& textBox3.Text!="") 
            {
               // MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("INVALID Booking", "ERROR");
            }


            doneForm6 form = new doneForm6();
            form.Show();
        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketbookingDataSet);

        }

        private void tbForm6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketbookingDataSet.ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.ticketbookingDataSet.ticket);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void t_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn4 = new SqlConnection(@"Data Source=STRANGE-PC;Initial Catalog=Ticketbooking;Integrated Security=True");
            conn4.Open();
            SqlCommand cmd4 = new SqlCommand("Select match_name,stadium_name,price From ticket Where match_name=@match_name",conn4);
            cmd4.Parameters.AddWithValue("match_name", textBox1.Text);
            SqlDataReader reader1;
            reader1=cmd4.ExecuteReader();
            if (reader1.Read())
            {

                textBox2.Text = reader1["stadium_name"].ToString();
                textBox3.Text = reader1["price"].ToString();
            }
            else
            {
                MessageBox.Show("N0 Data Found");



            }
            conn4.Close();           
            

            

                
            
        }

    }
            







        }
    
