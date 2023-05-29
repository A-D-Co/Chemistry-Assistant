using System;
using System.Windows.Forms;

namespace Chemistry_Assistant
{
    public partial class Rechner : UserControl
    {
        public Rechner()
        {
            InitializeComponent();
        }


        private double molare = 0;
        private double mol = 0;
        private double molmasse = 0;


        private void Molaremasse()
        {


            #region v2
            string formula = Tb_Formel.Text;
            string element = "";
            molare = 0;
            int temp = 0;

            //schreifle um jedes Char in formel einzeilnm
            for (int i = 0; i < formula.Length; i++)
            {
                //element wird geleert für neues Char 
                element = "";

                //checken ob Ist Groß buchstabe
                if (char.IsUpper(formula[i]))
                {
                    //Checken ob nächste buchstabe ein klein buchstabe ist
                    if (i + 1 < formula.Length && char.IsLower(formula[i + 1]))
                    {
                        //das groß buchstabe wird in element string gespeicht 
                        element += formula[i];
                        //das zweite buchstabe in string hinzugefütt um daten bank zu suchen 
                        element += formula[i + 1];
                        //im daten bank suchen
                        molare += GetElementMass(element);

                    }
                    //sonst das Element in Datenbank suchen
                    else
                    {
                        molare += GetElementMass(formula[i].ToString());
                    }


                }
                //chenken ob sich um zahl handelt 
                if (i + 1 < formula.Length && char.IsDigit(formula[i + 1]))
                {

                    //https://www.techiedelight.com/convert-char-to-int-csharp/
                    //Char zu int Conventern 
                    temp = (int)Char.GetNumericValue(formula[i + 1]);
                    molare = molare * temp;

                }

            }

            
            // Das molare molmasse eingeben 
            TB_MolareMass.Text = molare.ToString();

            #endregion
        }

        static double GetElementMass(string symbol)
        {
            // auf datamodule im Mainpage zuweisen
            Datamodule data = MainPage.DM;


            //Das SelectElement löschen 
            data.RemoveTable(ref data.ds, "SelectElement");

            string sqlcom = "SELECT a.RELATIVE_ATOMMASSE FROM T_ELEMENTE_EIGENSCHAFT a WHERE   a.ELEMENTSYMBOL = '" + symbol + "'";

            //Tabelle loaden vom datenbank
            data.LoadData2Table(sqlcom, "SelectElement");

            //die autom molmasse von tabelle holen
            string AtomMasse = data.ds.Tables["SelectElement"].Rows[0][0].ToString();

            

            //checken wenn im tabelle punkt ist wird ersetzt zum komma
            if (AtomMasse.IndexOf('.') != -1)
            {
                AtomMasse = AtomMasse.Replace('.', ',');
            }


            double mass = Convert.ToDouble(AtomMasse);
            return mass;

        }


        private void Rechnen()
        {
            Molaremasse();
            mol = Convert.ToDouble(TB_Mol.Text);
            molmasse = Convert.ToDouble(TB_Masse.Text);

            mol = molare * mol;
            mol = Math.Round(mol, 3);
            TB_Masse.Text = mol.ToString();

            mol = molmasse / molare;
            mol = Math.Round(mol, 3);
            TB_Mol.Text = mol.ToString();

        }


        private void BT_Rechnen_Click(object sender, EventArgs e)
        {
            Rechnen();

        }
    }


}
