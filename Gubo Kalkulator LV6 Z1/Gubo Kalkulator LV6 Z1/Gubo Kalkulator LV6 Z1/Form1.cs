using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gubo_Kalkulator_LV6_Z1
{
    public partial class Form1 : Form
    {
        double rezultat=0;
        string operationperformed = "";
        bool isoperationperformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            rezultat = 0;
            //vrijednost = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            //textBox1.Text = textBox1.Text + button.Text;
            isoperationperformed = false;

            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + button.Text;

            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }*/
            if ((textBox1.Text == "0") || (isoperationperformed)) // u proslom komentaru je falio is operationperformed, inace nakon odabira neke moguce funkcije kalkulatora vrijednost bi ostala na ekranu te bi se samo nadodala nova znamenka
            {
                textBox1.Clear();
            }

            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + button.Text;

            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            rezultat = double.Parse(textBox1.Text);
           // labeltrenutnaoperacija.Text = rezultat + " " + operationperformed;
            isoperationperformed = true;
        }

        private void jednakoclick(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textBox1.Text =(rezultat + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (rezultat - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (rezultat * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (rezultat / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }
            isoperationperformed = false;
        }

        private void labeltrenutnaoperacija(object sender, EventArgs e)
        {

        }

        private void SqrtButton(object sender, EventArgs e)
        {
            double variable = double.Parse(textBox1.Text);
            variable = Math.Sqrt(variable);
            textBox1.Text = System.Convert.ToString(variable);
        }

        private void SqrButton(object sender, EventArgs e)
        {
            double variable = double.Parse(textBox1.Text);
            variable = variable * variable;
            textBox1.Text = System.Convert.ToString(variable);
        }

        private void SinButton(object sender, EventArgs e)
        {
            double variable = double.Parse(textBox1.Text);
            variable = Math.Sin(variable);
            textBox1.Text = System.Convert.ToString(variable);
        }

        private void CosButton(object sender, EventArgs e)
        {
            double variable = double.Parse(textBox1.Text);
            variable = Math.Cos(variable);
            textBox1.Text = System.Convert.ToString(variable);
        }

        private void LogButton(object sender, EventArgs e)
        {
            double variable = double.Parse(textBox1.Text);
            variable = Math.Log10(variable);
            textBox1.Text = System.Convert.ToString(variable);
        }
    }
}
