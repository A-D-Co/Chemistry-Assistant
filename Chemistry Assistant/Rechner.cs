using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistry_Assistant
{
    public partial class Rechner : UserControl
    {
        public Rechner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Molaremasse();
            //label1.Text = Convert.ToString( Molaremasse());
        }

        private void Molaremasse()
        {
            string formula = textBox1.Text;
            double Molare = 0;
            string element = "";

            for (int i = 0; i < formula.Length; i++)
            {
                //Alle Buchstaben wirden in ein Char gespeichter an laufe einer schleife
                char c = formula[i];

                //Wird geguckt ob Der Charakter groß ist 
                if (char.IsUpper(c))
                {
                    //Charakter wird in Element gespeichert
                    element = c.ToString();

                    //Wird geguckt ob nächte Buchstabe Klein ist Wenn ja dann ist das Anders element und das erste und zweite Charakter wirden zusammen gefügt
                    if (i + 1 < formula.Length && char.IsLower(formula[i + 1]))
                    {
                        element += formula[i + 1];
                        Molare += GetElementMass(element);
                    }
                    //Wird gegucht ob nächte charakter ein zahl ist damit es mal gemacht wird 
                    else if (i + 1 < formula.Length && char.IsDigit(formula[i + 1]))
                    {
                        Console.WriteLine();
                        Molare += GetElementMass(element)*2;

                    }
                    // wenn garnicht trefft dass soll das element in element mass gesuchen werden 
                    else
                    {
                        Molare += GetElementMass(element);
                    }    
                }


            }
            Console.WriteLine(Molare);
             label1.Text = Molare.ToString();
        }

        static double GetElementMass(string symbol)
        {
            switch (symbol)
            {
                case "H": return 1.0079;
                case "He": return 4.0026;
                case "Li": return 6.941;
                case "Be": return 9.0122;
                case "B": return 10.81;
                case "C": return 12.01;
                case "N": return 14.01;
                case "O": return 15.999;
                case "F": return 19.00;
                case "Ne": return 20.18;
                default: throw new ArgumentException("Invalid element symbol: " + symbol);
            }
        }
    }


}
