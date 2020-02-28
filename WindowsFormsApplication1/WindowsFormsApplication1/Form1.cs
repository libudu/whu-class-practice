using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = true;
            double result = 0;
            try
            {
                double num1 = Convert.ToDouble(TextBox_Num1.Text);
                double num2 = Convert.ToDouble(TextBox_Num2.Text);
                switch (ComboBox_Sign.Text)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default
                        break;
                }
                error = false;
            }
            catch (FormatException)
            {
                TextBox_Result.Text = "输入错误！输入数字！";
            }
            catch (OverflowException)
            {
                TextBox_Result.Text = "运算溢出！";
            }
            catch(Exception)
            {
                TextBox_Result.Text = "其他错误";
            }

            if(!error)
                TextBox_Result.Text = Convert.ToString(result);
        }

        private void Label_Num1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Result_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Num2_Click(object sender, EventArgs e)
        {

        }
    }
}
