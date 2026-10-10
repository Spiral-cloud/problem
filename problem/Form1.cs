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
        public int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            webView21.Hide();
            panel1.Hide();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
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
            if (this.progressBar1.Value == this.progressBar1.Maximum && counter %2 == 0)
            {
                testButton.Show();
                panel1.Show();
                progressBar1.Value = 0;
                this.timer1.Stop();
                timer1.Enabled = false;
                counter++;
                MessageBox.Show("Progress complete!");
                
            }
            else if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                testButton.Show();
                panel1.Hide();
                this.timer1.Stop();
                timer1.Enabled = false;
                progressBar1.Value = 0;
                MessageBox.Show("Progress complete!");
            }
            else if (this.progressBar1.Value == 50)
            {
                this.progressBar1.Increment(1);
                MessageBox.Show("Halfway there!");
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
            progressBar1.BringToFront();
            timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

        }

        private void adButton_Click(object sender, EventArgs e)
        {
            webView21.Show();
            webView21.BringToFront();
            webView21.CoreWebView2.Navigate("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            // webBrowser1.Document.InvokeScript("play", null);
        }
    }
}

