using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string text;
            int conversion;
           
            try
            {
                
                text = textBox1.Text.ToUpper();
                conversion = NumberConversion.RomanToInteger(text);

                outPutLabel.Text = conversion.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int integer;
            string conversion;

            try
            {
                integer = int.Parse(textBox1.Text.ToString());
                conversion = NumberConversion.IntegerToRoman(integer);

                outPutLabel.Text = conversion.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            outPutLabel.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
