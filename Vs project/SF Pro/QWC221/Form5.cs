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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spanel1.Height = hbutton1.Height;
            spanel1.Top = hbutton1.Top;
            hUserControl31.Show();
            sfUserControl21.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            spanel1.Height = sfbutton2.Height;
            spanel1.Top = sfbutton2.Top;
            hUserControl31.Hide();
            sfUserControl21.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
