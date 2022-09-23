using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_HERENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SUMA OO = new SUMA();
            OO.V1 = double.Parse(textBox1.Text);
            OO.V2 = double.Parse(textBox2.Text);
            textBox3.Text = OO.operar().ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            RESTA SS = new RESTA();
            SS.V1 = double.Parse(textBox1.Text);
            SS.V2 = double.Parse(textBox2.Text);
            textBox3.Text = SS.rest().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MULTIPL mm = new MULTIPL();
            mm.V1 = double.Parse(textBox1.Text);
            mm.V2 = double.Parse(textBox2.Text);
            textBox3.Text = mm.mul().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DVSN dd = new DVSN();
            dd.V1 = double.Parse(textBox1.Text);
            dd.V2 = double.Parse(textBox2.Text);
            textBox3.Text = dd.dividir().ToString();
        }   
    }
}  
