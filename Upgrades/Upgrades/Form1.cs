using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upgrades
{
    public partial class Form1 : Form
    {
        int i = 0;
        int s = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           if(i >= 10)
            {
                i = i - 10;

            }else
            {
                

            }
            
            label2.Text = i.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = i - 10000;
            label2.Text = i.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(i >= 100)
            {
                i = i - 100;

            }
            
            
            label2.Text = i.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i = i + 1000;
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
            }
            
            label2.Text = i.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(i >= 5000) 
            
            {

                i = i - 5000;

            }
            
            label2.Text = i.ToString();
        }
    }
}
