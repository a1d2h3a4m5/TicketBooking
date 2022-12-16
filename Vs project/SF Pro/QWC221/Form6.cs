using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWC221
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();        }

        private void mainEntitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticket t = new ticket();    
            t.Show();   
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matches m = new matches();
            m.Show();

        }

        private void seatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seat se = new seat();
            se.Show();
        }

        private void stadiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stadium st = new stadium();
            st.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void rEportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report RE = new Report();
            RE.Show();
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
