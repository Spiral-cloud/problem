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
        public int webViewCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            testButton.BringToFront();
            testButton.Show();
            progressBar1.Hide();
            webView21.Hide();
            panel1.Hide();
            webView22.Hide();
            panel2.Hide();
            panel3.Hide();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
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
            if (this.progressBar1.Value == this.progressBar1.Maximum && counter % 2 == 0)
            {
                testButton.Hide();
                panel1.Show();
                adButton.Show();
                progressBar1.Value = 0;
                this.timer1.Stop();
                timer1.Enabled = false;
                progressBar1.SendToBack();
                counter++;
                MessageBox.Show("Progress complete!");

            }
            else if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                adButton.Show();
                testButton.Show();
                panel1.Hide();
                this.timer1.Stop();
                timer1.Enabled = false;
                counter++;
                progressBar1.Value = 0;
                progressBar1.SendToBack();
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
            webView21.Hide();
            timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

        }

        private void adButton_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            progressBar1.BringToFront();
            timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            //webView21.Show();
            //webView21.BringToFront();
            // webView21.CoreWebView2.Navigate("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            //adButton.Hide();
            // webBrowser1.Document.InvokeScript("play", null);
        }

        private void Text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                if (webViewCounter % 2 == 0)
                {
                    webView21.Show();
                    webView21.BringToFront();
                    webView21.CoreWebView2.Navigate("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                    webViewCounter++;
                }
                else
                {
                    webView22.Show();
                    webView22.BringToFront();
                    webView22.CoreWebView2.Navigate("https://downloadmoreram.com");
                    webViewCounter++;
                }
                adButton.Hide();
                this.timer2.Stop();
                timer2.Enabled = false;
                progressBar1.Value = 0;
                progressBar1.SendToBack();
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

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            progressBar1.BringToFront();
            timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {

                adButton.Hide();
                this.timer2.Stop();
                timer2.Enabled = false;
                progressBar1.Value = 0;
                progressBar1.SendToBack();
                MessageBox.Show("Progress complete!");
                Application.Exit();
            }
            else if (this.progressBar1.Value == 25)
            {
                panel3.BringToFront();
                panel3.Show();
                MessageBox.Show("Viruses detected");
                this.progressBar1.Increment(1);
            }
            else if (this.progressBar1.Value == 50)
            {
                this.progressBar1.Increment(1);
                panel2.BringToFront();
                panel2.Show();
                MessageBox.Show("Halfway there!");
            }
            else
            {
                this.progressBar1.Increment(1);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

