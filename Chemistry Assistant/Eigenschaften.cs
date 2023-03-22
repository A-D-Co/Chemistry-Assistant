using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Chemistry_Assistant
{
    public partial class Eigenschaften : Form
    {
        public Eigenschaften(int elementId)
        {
            InitializeComponent();
            ElementId = elementId;
        }


        private DataSet data = new DataSet();


        private int elementId;
        public int ElementId
        {
            get { return elementId; }
            set { elementId = value; }

        }


        public void setEigenschaft(string Element)
        {
            this.Text = Element;
        }

        private void Eigenschaften_Load(object sender, EventArgs e)
        {


            //Auf dataset refrenciert die im datamoul um table herzustellen
            data = MainPage.DM.ds;

            //das loaddata2 aufrufne damit er auf datenbank zu greift und und selcet command ausfüht 
            MainPage.DM.LoadData2Table("SELECT * FROM Eigenschaften where id ="+ elementId , "ElementTable");




            TB_Deutschername.Text = data.Tables[0].Rows[0][1].ToString();



        }

    }

}
