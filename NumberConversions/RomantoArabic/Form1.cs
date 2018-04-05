using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomantoArabic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Roman;
            int counter;
            int conversion;

            try
            {

                Roman = textBox1.Text.ToUpper();
                conversion = RomantoInteger.RomanToInteger(Roman);

                outPutLabel.BackColor = System.Drawing.Color.LightGreen;
                outPutLabel.Text = Roman + " = " + conversion.ToString();

                counter = conversion;
                listBox2.Items.Add(Roman + " = " + counter);
                
            }
            catch
            {
                
                outPutLabel.BackColor = System.Drawing.Color.Red;
                outPutLabel.Text = "Roman Numerals only";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            outPutLabel.Text = " ";
            outPutLabel.BackColor = System.Drawing.Color.LightGray;
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
