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
        string HistOp="";
        List<string> Historial = new List<string>();
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
            HistOp += button.Text;

        }

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            try
            {
                result = double.Parse(textBox1.Text);
                HistOp += button.Text;
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
            HistOp += "=";
            HistOp += result.ToString();
            Historial.Add(HistOp);
            HistOp = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if(panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            try
            {
                textBox2.Text = Historial[Historial.Count() - 1];
            }
            catch
            {
                textBox2.Text = "";
            }
            try
            {
                textBox3.Text = Historial[Historial.Count() - 2];
            }
            catch
            {
                textBox3.Text = "";
            }
            try
            {
                textBox4.Text = Historial[Historial.Count() - 3];
            }
            catch
            {
                textBox4.Text = "";
            }
            try
            {
                textBox5.Text = Historial[Historial.Count() - 4];
            }
            catch
            {
                textBox5.Text = "";
            }
            try
            {
                textBox6.Text = Historial[Historial.Count() - 5];
            }
            catch
            {
                textBox6.Text = "";
            }
        }
    }
}
