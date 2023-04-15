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

        }

        private void Molaremasse()
        {
            string formula = Tb_Formel.Text;
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
             
            double Mol= Convert.ToDouble(TB_Mol.Text);
            Mol = Molare * Mol;
            Console.WriteLine(Mol);
            TB_Masse.Text = Mol.ToString();
        }

        static double GetElementMass(string symbol)
        {
            // auf datamodule im Mainpage zuweisen
            Datamodule data = MainPage.DM;

            //Das SelectElement löschen 
            data.RemoveTable(ref data.ds, "SelectElement");
            
            string sqlcom = "SELECT a.RELATIVE_ATOMMASSE FROM T_ELEMENTE_EIGENSCHAFT a WHERE   a.ELEMENTSYMBOL = '"+symbol+"'";

            //Tabelle loaden vom datenbank
            data.LoadData2Table(sqlcom,"SelectElement");

            //die autom masse von tabelle holen
            string AtomMasse = data.ds.Tables["SelectElement"].Rows[0][0].ToString();

            //checken wenn im tabelle punkt ist wird ersetzt zum komma
            if(AtomMasse.IndexOf('.') != -1)
            {

                AtomMasse = AtomMasse.Replace('.', ',');
            }


            double mass = Convert.ToDouble(AtomMasse);
            return mass;

        }


    }


}
