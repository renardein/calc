using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double Result = 0;
        String OperDef = " ";
        bool IsOperator = false;


        public Form1()
        {
            InitializeComponent();
        }

    

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || IsOperator)
                textBox_Result.Clear();

            IsOperator = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }

            else
            textBox_Result.Text += button.Text;
        }


        private void Operator_click_Event(object sender, EventArgs e)
        {

            Button button = (Button)sender;
          
            if (Result != 0)
            {
                button16.PerformClick();
                OperDef = button.Text;
                label_Show_Op.Text = Result + " " + OperDef;
                IsOperator = true;
            }
            else
            {

                OperDef = button.Text;
                Result = Double.Parse(textBox_Result.Text);
                label_Show_Op.Text = Result + " " + OperDef;
                IsOperator = true;
            }
        
        }
        private void button5_Click(object sender, EventArgs e)
        {         
            textBox_Result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label_Show_Op.Text = null;
            textBox_Result.Text = null;
            Result = 0;
        }
        private void button16_Click(object sender, EventArgs e)
        {
   
            switch (OperDef)
            {
                case "+":
                    textBox_Result.Text = (Result + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (Result - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "x":
                    textBox_Result.Text = (Result * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "÷":
                    textBox_Result.Text = (Result / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;
            }
            Result = Double.Parse(textBox_Result.Text);
            label_Show_Op.Text = null;
        }

       
    }
}
