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
    public partial class Form1 : Form
    {

        SqlConnection obj1 = new SqlConnection(@"Data Source=STRANGE-PC;Initial Catalog=ticketbooking;Integrated Security=True");
        
                                              
 
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string c_email, c_pass;
            c_email = textBox1.Text;
            c_pass = textBox2.Text;

            try
            {
                string querry = "select * From View_1 WHERE  c_email = '" + textBox1.Text + "' AND c_pass = '" + textBox2.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry,obj1);
                DataTable dtable= new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    c_email = textBox1.Text;
                    c_pass = textBox2.Text;
                    Form5 form = new Form5();
                    form.Show();

                    
                }
                else
                {
                    MessageBox.Show("Inavild login","Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();

                }
   
            }

            catch {

                MessageBox.Show("Error");
            
            
            }
            finally
            {
                obj1.Close();
            }


            
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
