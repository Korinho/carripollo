using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carripollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SidePanel.height = button1.Height;
            ufVentas1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //SidePanel.height = button1.Height;
            ufVentas1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ufClientes1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ufHistorial1.BringToFront();
        }
    }
}
