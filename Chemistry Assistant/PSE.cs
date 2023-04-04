using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chemistry_Assistant;

namespace Chemistry_Assistant
{
    public partial class PSE : UserControl
    {
        public PSE()
        {
            InitializeComponent();
        }

        public DataSet data = new DataSet();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(2,"Helium");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(1,"WasserStoff");
        }




        private void EigenschaftenWindow(int id, string elementname)
        {
            // wenn neue eigenschaften page erstellt wird wird direkt das elementen id gegeben um darauf der element in daten bank zu weißen
            Eigenschaften eigenschaften = new Eigenschaften(id, elementname);
            //der code offnet den eigenschaften page
            eigenschaften.Show(this);
        }



        #region Temp

        public void SimpelSql()
        {
            
            data = MainPage.DM.ds;

            MainPage.DM.LoadData2Table("SELECT * FROM Eigenschaften", "ElementTable");

            dataGridView1.DataSource = MainPage.DM.ds.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpelSql();
        }

        #endregion
    }
}
