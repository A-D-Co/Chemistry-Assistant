using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private double molare = 0;
        private double mol = 0;
        private double masse = 0;
        private bool checkFirstChange = false;

        private void Molaremasse()
        {
            #region V1
            /*
            string formula = Tb_Formel.Text;
            double Molare = 0;
            string element = "";
            int exponent = 0;
            string temp = "";

            for (int i = 0; i < formula.Length; i++)
            {
                temp = "";
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
                    }/*
                    //Wird gegucht ob nächte charakter ein zahl ist damit es mal gemacht wird 
                    else if (char.IsNumber(c))
                    {
                        exponent= c;
                        Console.WriteLine(exponent);
                        Molare += GetElementMass(element) * exponent;

                    }
                    // wenn garnicht trefft dass soll das element in element mass gesuchen werden 
                    else
                    {
                        Molare += GetElementMass(element);
                    }    
                }
                //Wird gegucht ob nächte charakter ein zahl ist damit es mal gemacht wird 
                else if (char.IsNumber(c))
                {
                    //um Char zu string machen weil wenn man direkt char zu in macht kommt unicode für das nummer
                    temp= c.ToString();
                    exponent =  Convert.ToInt16(temp);
                    Console.WriteLine(exponent);
                    Molare = GetElementMass(element) * exponent;

                }
            }
             
            double Mol= Convert.ToDouble(TB_Mol.Text);
            Mol = Molare * Mol;
            Console.WriteLine(Mol);
            TB_Masse.Text = Mol.ToString();*/
            #endregion
            #region v2

            checkFirstChange= false;
            string formula = Tb_Formel.Text;
            string element = "";
            molare = 0;
            int temp = 0;

            for (int i = 0; i < formula.Length; i++)
            {
                element = "";
                if (char.IsUpper(formula[i]))
                {
                    if (i + 1 < formula.Length && char.IsLower(formula[i + 1]))
                    {
                        element += formula[i];
                        element += formula[i+1];
                        molare += GetElementMass(element);

                    }
                    else
                    {
                        molare += GetElementMass(formula[i].ToString());
                    }


                }
                if (i + 1 < formula.Length && char.IsDigit(formula[i + 1]))
                {

                    //https://www.techiedelight.com/convert-char-to-int-csharp/
                    temp = (int)Char.GetNumericValue(formula[i + 1]); 
                    molare = molare * temp;
                    Console.WriteLine(molare);

                }

            }

            TB_MolareMass.Text = molare.ToString(); 

            mol = Convert.ToDouble(TB_Mol.Text);
            mol = molare * mol;
            TB_Masse.Text = mol.ToString();

            checkFirstChange = true;


            #endregion
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

        private void TB_Masse_TextChanged(object sender, EventArgs e)
        {
            //Check wenn es durch Button geändert würde oder durch benutzer
            if(checkFirstChange == true)
            {
                try
                {
                     masse = Convert.ToDouble(TB_Masse.Text);
                    mol = masse / molare;
                    TB_Mol.Text = mol.ToString();
                }
                catch (FormatException)
                {
                    TB_Masse.Text = "Bitte Nur Zahlen schreiben!!";
                }
                
                

            }
            

        }

        private void TB_Mol_TextChanged(object sender, EventArgs e)
        {

            //Check wenn es durch Button geändert würde oder durch benutzer
            if (checkFirstChange == true)
            {
                try
                {
                    mol = Convert.ToDouble(TB_Mol.Text);
                    mol = molare * mol;
                    TB_Masse.Text = mol.ToString();
                }
                catch (FormatException)
                {
                    TB_Masse.Text = "Bitte Nur Zahlen schreiben!!";
                }



            }
        }
    }


}
