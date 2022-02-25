using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (listBoxDzialanie.Items.Count > 0)
            {
                listBoxDzialanie.SelectedIndex = 0;
            }
        }

        private void buttonLicz_Click(object sender, EventArgs e)
        {
            Double l1, l2;
            Double wynik = 0;

            //try
            //{
            //    wynik = Double.Parse(textBoxLiczba1.Text) + Double.Parse(textBoxLiczba2.Text);
            //}
            //catch
            //{
            //    labelBlad.Text = "Nieprawidłowe dane wejściowe";
            //}

            if (Double.TryParse(textBoxLiczba1.Text, out l1) &&
                Double.TryParse(textBoxLiczba2.Text, out l2))
            {
                switch (listBoxDzialanie.Text)
                {
                    case "+":
                        wynik = l1 + l2;
                        break;
                    case "-":
                        wynik = l1 - l2;
                        break;
                    case "*":
                        wynik = l1 * l2;
                        break;
                    case "/":
                        wynik = l1 / l2;
                        break;
                }
                textBoxWynik.Text = wynik.ToString();
                labelBlad.Text = "";
            }
            else
            {
                textBoxWynik.Text = "";
                labelBlad.Text = "Nieprawidłowe dane wejściowe";
            }    
        }
    }
}
