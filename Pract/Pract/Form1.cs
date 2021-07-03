using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

 
        }

        double firstNumber = 0, secondNumber = 0, answer = -1.77766622246;

        int  operationCounter;

        bool binaryCounter = false, commaBlock = true, blockAddSinCos = true;

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                CalculateLogic();
                label1.Text = "= " + answer.ToString("0.########");

                if (binaryCounter != false)
                {
                    label2.Text = "";
                    textBox1.Clear();

                    switch (operationCounter)
                    {
                        case 0:
                            textBox1.Text = firstNumber.ToString() + " + " + secondNumber.ToString();
                            break;

                        case 1:
                            textBox1.Text = firstNumber.ToString() + " - " + secondNumber.ToString();
                            break;

                        case 2:
                            textBox1.Text = firstNumber.ToString() + " x " + secondNumber.ToString();
                            break;

                        case 3:
                            textBox1.Text = firstNumber.ToString() + " / " + secondNumber.ToString();
                            break;

                        default:
                            break;
                    }
                }
            }
            else
            {
                label1.Text = "Error!";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (commaBlock)
            {
                textBox1.Text = textBox1.Text + ",";
                commaBlock = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!binaryCounter)
                {
                    if (answer == -1.77766622246) // КОСТЫЛЬ :D
                    {
                        string name = ((Button)sender).Text;



                        firstNumber = double.Parse(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Text = "arctang(" + firstNumber.ToString() + ")";

                      
                        binaryCounter = false;
                        blockAddSinCos = false;

                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            answer = -1.77766622246;
          
            commaBlock = true;
            binaryCounter = false;
            blockAddSinCos = true;

            textBox1.Clear();
            label1.Text = "";
            label2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (e.KeyChar >= 0)
            {
                e.Handled = true;
            }

        }

        private void CalculateLogic() // Логика калькулятора
        {
            if (binaryCounter == false)
            {
                answer = Math.Atan(firstNumber);
            }
            else
            {
                secondNumber = double.Parse(textBox1.Text);

                BinaryInterface Calculator = Class1.BinarySwitch(operationCounter);
                answer = Calculator.Calculate(firstNumber, secondNumber);
            }
        }


        private void input(object sender, EventArgs e)
        {
            string name = ((Button)sender).Text;

            switch (name)
            {
                case "1":
                    textBox1.Text = textBox1.Text + 1;
                    break;

                case "2":
                    textBox1.Text = textBox1.Text + 2;
                    break;

                case "3":
                    textBox1.Text = textBox1.Text + 3;
                    break;

                case "4":
                    textBox1.Text = textBox1.Text + 4;
                    break;

                case "5":
                    textBox1.Text = textBox1.Text + 5;
                    break;

                case "6":
                    textBox1.Text = textBox1.Text + 6;
                    break;

                case "7":
                    textBox1.Text = textBox1.Text + 7;
                    break;

                case "8":
                    textBox1.Text = textBox1.Text + 8;
                    break;

                case "9":
                    textBox1.Text = textBox1.Text + 9;
                    break;

                case "0":
                    textBox1.Text = textBox1.Text + 0;
                    break;

                default:
                    throw new Exception("Неизвестная операция");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (blockAddSinCos)
                {
                    if (answer == -1.77766622246) // КОСТЫЛЬ :D
                    {
                        string name = ((Button)sender).Text;

                        switch (name)
                        {
                            case "+":
                                label2.Text = "+";
                                firstNumber = double.Parse(textBox1.Text);
                                textBox1.Clear();

                                commaBlock = true;
                                
                                binaryCounter = true;
                                operationCounter = 0;

                                break;

                            case "-":

                                label2.Text = "-";
                                firstNumber = double.Parse(textBox1.Text);
                                textBox1.Clear();

                                commaBlock = true;
                                
                                binaryCounter = true;
                                operationCounter = 1;

                                break;

                            case "*":

                                label2.Text = "*";
                                firstNumber = double.Parse(textBox1.Text);
                                textBox1.Clear();

                                commaBlock = true;
                               
                                binaryCounter = true;
                                operationCounter = 2;

                                break;

                            case "/":

                                label2.Text = "/";
                                firstNumber = double.Parse(textBox1.Text);
                                textBox1.Clear();

                                commaBlock = true;
                                
                                binaryCounter = true;
                                operationCounter = 3;

                                break;

                            default:
                                throw new Exception("Неизвестная операция");
                        }
                    }
                }

            }
            else
            {
                label1.Text = "Error!";
            }
        }
    }
}
