using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ComPort
{
    public partial class Form2 : Form
    {
        private int value;
       
        private Action show;

        public Form2(string value)
        {
            InitializeComponent();
            textBox1.Text = value;
           
        }

        public Form2(int value)
        {
            this.value = value;
        }

        public Form2(ProgressBar progressBar2)
        {
            
            this.progressBar1 = progressBar1;
            this.progressBar2 = progressBar2;
        }

        public Form2(Action show)
        {
            this.show = show;
            
        }

        public Form2(bool enabled)
        {
            Enabled = enabled;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(textBox1.Enabled = true)
            {
                if (timer2.Enabled = true)
                {

                    this.progressBar1.Increment(1);

                    this.progressBar2.Increment(0);
                }

                else if (textBox1.Enabled = false)
                {if (timer2.Enabled = true)
                    {
                        this.progressBar1.Increment(0);

                        this.progressBar2.Increment(1);
                    }
                }
            }
            
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    

        private void timer1_Tick_1(object sender, EventArgs e)
        {if (textBox1.Enabled = true)
            {
                if (timer2.Enabled = true)
                {

                    this.progressBar1.Increment(1);

                    this.progressBar2.Increment(0);
                }
                else if (textBox1.Enabled = false)
                {
                    if (timer2.Enabled = true)
                    {
                        this.progressBar1.Increment(0);

                        this.progressBar2.Increment(1);
                    }
                }
                DateTime now = DateTime.Now;
              
                 label1.Text = DateTime.Now.ToString("dd-MM-yyyy   hh:mm:ss"); 

                 

            }

        }

        private static void timer1_Tick_1(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
