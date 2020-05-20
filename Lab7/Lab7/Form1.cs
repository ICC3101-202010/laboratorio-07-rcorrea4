using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        double finalResult;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        

        private void buton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0"||textBox1.Text==finalResult.ToString()||textBox1.Text=="Math Error"|| textBox1.Text =="Syntax Error")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            try
            {
                result = double.Parse(textBox1.Text);
            }
            catch (System.FormatException ex)
            {
                textBox1.Text = "Syntax Error";
            }
            textBox1.Clear();


        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
               
                case "+":
                    try
                    {
                        result += double.Parse(textBox1.Text);
                        textBox1.Text = result.ToString();
                        finalResult = result;
                    }
                    catch
                    {
                        textBox1.Text = "Syntax Error";
                    }
                   
                    break;
                case "-":
                    try
                    {
                        result -= double.Parse(textBox1.Text);
                        textBox1.Text = result.ToString();
                        finalResult = result;
                    }
                    catch
                    {
                        textBox1.Text = "Syntax Error";
                    }
                    
                    break;
                case "x":
                    try
                    {
                        result *= double.Parse(textBox1.Text);
                        textBox1.Text = result.ToString();
                        finalResult = result;
                    }
                    catch
                    {
                        textBox1.Text = "Syntax Error";
                    }
                    
                    break;
                case "÷":
                    try
                    {
                        if (textBox1.Text == "0")
                        {
                            textBox1.Text = "Math Error";
                        }
                        else
                        {
                            result /= double.Parse(textBox1.Text);
                            textBox1.Text = result.ToString();
                            finalResult = result;
                        }
                    }
                    catch
                    {
                        textBox1.Text = "Syntax Error";
                    }
                    
                    
                    break;

            }
        }

        private void buttonAc_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = "0";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = result.ToString();
        }
    }
}
