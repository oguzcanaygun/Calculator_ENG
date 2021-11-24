using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double pi = 3.14;
        private void button3_Click(object sender, EventArgs e)
        {
            int shrtside, lngside, area, perimeter;
            shrtside = Convert.ToInt16(textBox1.Text);
            lngside = Convert.ToInt16(textBox2.Text);
            area = (shrtside*lngside);
            perimeter = (2 * shrtside) + (2 * lngside);
            textBox3.Text = area.ToString();
            textBox4.Text = perimeter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius, area, perimeter;
            radius = Convert.ToInt16(textBox5.Text);
            area = (Math.Pow(radius,2)*pi);
            perimeter = (2 * pi * radius);
            textBox13.Text = area.ToString();
            textBox14.Text = perimeter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mark1, mark2, mark3, avg;
            mark1 = Convert.ToInt16(Txtmrk1.Text);
            mark2 = Convert.ToInt16(Txtmrk2.Text);
            mark3 = Convert.ToInt16(Txtmrk3.Text);
            avg = (mark1 + mark2 + mark3) / 3;
            Txtavg.Text = avg.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum, subs, multi, num1, num2, num3;
            num1 = Convert.ToInt16(Txtnum1.Text);
            num2 = Convert.ToInt16(Txtnum2.Text);
            num3 = Convert.ToInt16(Txtnum3.Text);
            sum = num1 + num2 + num3;
            subs = -num1 - num2 - num3;
            multi = num1 * num2 * num3;
            TxtSummary.Text = sum.ToString();
            TxtSubst.Text = subs.ToString();
            TxtMultip.Text = multi.ToString();
        }
    }
}
