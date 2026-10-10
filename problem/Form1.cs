using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Button Clicked!";
            progressBar1.Value = 0;
            timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
           
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            testButton.Hide();
            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                testButton.Show();
                panel1.Show();
                progressBar1.Value = 0;
                this.timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Progress complete!");
                
            }
            else 
            {
                this.progressBar1.Increment(1);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}

