using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabictoRoman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arabic;
            string output;

            try
            {
                arabic = int.Parse(textBox1.Text);

                output = arabic + " = " + ArabictoRoman.IntegerToRoman(arabic);

                outPutLabel.BackColor = System.Drawing.Color.LightGreen;
                outPutLabel.Text = output;
                listBox2.Items.Add(output);
            }
            catch
            {
                outPutLabel.BackColor = System.Drawing.Color.Red;
                outPutLabel.Text = "Arabic Numbers Only";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outPutLabel.BackColor = System.Drawing.Color.LightGray;
            outPutLabel.Text = " ";
            listBox2.Items.Clear();
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
