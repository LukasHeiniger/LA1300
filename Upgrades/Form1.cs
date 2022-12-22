using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upgrades
{
    public partial class Form1 : Form
    {
        int i = 0;
        int t = 0;
        int s = 0;
        int m = 0;
        int cookiepersec = 0;
        int reset = 0;
        int xclick = 1;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label8.Text = m.ToString() + " : " + s.ToString();
            label2.Text = i.ToString();
            timer1.Start();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            i = i + xclick;
            label2.Text = i.ToString();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            t++;

            if (t == 10)
            {

                i = i + cookiepersec;
                label2.Text = i.ToString();

                t = 0;
                s++;
                label8.Text = m.ToString() + " : " + s.ToString();




                if (s == 60)
                {
                    m++;
                    s = 0;
                    label8.Text = m.ToString() + " : " + s.ToString();

                }
            }

        }
       

        
        private void button1_Click(object sender, EventArgs e)
        {

            if (i >= 10)
            {
                i = i - 10;
                cookiepersec = cookiepersec + 1;
            }
            
            label2.Text = i.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if(i >= 10000)
            {

                i = i - 10000;
                label2.Text = i.ToString();

                reset++;

               

            }


            if (reset == 1)
            {

                i = 0;
                t = 0;
                s = 0;
                m = 0;
                cookiepersec = 0;
                reset = 0;
                xclick = xclick * 2;
                label2.Text = i.ToString();
                
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           if(i >= 100)
            {
                i = i - 100;
                cookiepersec = cookiepersec + 5;
            }
            
            
            label2.Text = i.ToString();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (i >= 1000)
            {

                i = i - 1000;
                cookiepersec = cookiepersec + 10;
            }
            
            label2.Text = i.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(i >= 5000) 
            
            {

                i = i - 5000;
                cookiepersec = cookiepersec + 50;
            }
            
            label2.Text = i.ToString();
        }

       

        
    }
}
