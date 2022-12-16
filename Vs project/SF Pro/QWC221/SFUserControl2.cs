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
    public partial class SFUserControl2 : UserControl
    {


        SqlConnection conn3 = new SqlConnection(@"Data Source=STRANGE-PC;Initial Catalog=Ticketbooking;Integrated Security=True");
        SqlCommand cmd3;




        public SFUserControl2()
        {



            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            

            tbForm6 form = new tbForm6();
            form.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
          





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
