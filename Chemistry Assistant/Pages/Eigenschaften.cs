using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            Eigenschaften_Load(elementId);

        }


        public DataSet data = new DataSet();
        private void Eigenschaften_Load(int elementId)
        {
            //-1 weil die Rows beginnen mir 0 
            elementId -= 1;
            //Auf dataset refrenciert die im datamoul um table herzustellen
            data = MainPage.DM.ds;

            this.Text = data.Tables[0].Rows[elementId][3].ToString(); ;
            if (data.Tables[0].Rows.Count > 0)
            {
                _lbl_Ordnungzahl.Text = data.Tables[0].Rows[elementId][1].ToString();
                _lbl_Elementssymbol.Text = data.Tables[0].Rows[elementId][2].ToString();
                TB_Deutschername.Text = data.Tables[0].Rows[elementId][3].ToString();
                TB_Englischername.Text = data.Tables[0].Rows[elementId][4].ToString();
                TB_Elektronenkonfiguration.Text = data.Tables[0].Rows[elementId][5].ToString();
                TB_Relative_Atommasse.Text = data.Tables[0].Rows[elementId][6].ToString();
                TB_Oxidationsstufen.Text = data.Tables[0].Rows[elementId][7].ToString();
                TB_Schmeltzpunkt.Text = data.Tables[0].Rows[elementId][8].ToString();
                TB_Siedepunkt.Text = data.Tables[0].Rows[elementId][9].ToString();
                TB_Dichte.Text = data.Tables[0].Rows[elementId][10].ToString();
                TB_Atomradius.Text = data.Tables[0].Rows[elementId][11].ToString();
                TB_Kovalenzradius.Text = data.Tables[0].Rows[elementId][12].ToString();
                TB_Pauling.Text = data.Tables[0].Rows[elementId][13].ToString();
                TB_Allred.Text= data.Tables[0].Rows[elementId][14].ToString();
                TB_Pearson.Text = data.Tables[0].Rows[elementId][15].ToString();
            }
        }
    }

}
