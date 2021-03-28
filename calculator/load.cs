using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    public partial class load : Form
    {
        
        public load()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Width = textBox1.Width +8 ;
            label3.Text = label3.Text + ".";
            if (label3.Text == "loading.....")
                label3.Text = "loading";
            if (textBox1.Width >= 380)
            {
                timer1.Enabled = false;
                calculation clc = new calculation();
                clc.Show();
                this.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void load_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
