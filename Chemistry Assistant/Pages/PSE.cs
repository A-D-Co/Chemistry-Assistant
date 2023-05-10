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





        private void EigenschaftenWindow(int id)
        {
            // wenn neue eigenschaften page erstellt wird wird direkt das elementen id gegeben um darauf der element in daten bank zu weißen
            Eigenschaften eigenschaften = new Eigenschaften(id);
            //der code offnet den eigenschaften page
            eigenschaften.Show(this);
        }




        #region Temp
        /*
        public void SimpelSql()
        {
            
            data = MainPage.DM.ds;

            MainPage.DM.LoadData2Table("SELECT * FROM T_ELEMENTE_EIGENSCHAFT", "ElementTable");

            dataGridView1.DataSource = MainPage.DM.ds.Tables[0];
            
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            //SimpelSql();
        }
        
        #endregion


        private void PT_Wasserstoff_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(1);
        }

        private void PT_Lithium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(3);
        }

        private void _PT_Lithium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(11);
        }

        private void _Pt_Kalium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(19);
        }

        private void _PT_Rubidium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(37);
        }

        private void _PT_Casium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(55);
        }

        private void _PT_Francium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(87);
        }

        private void _PT_Radium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(88);
        }

        private void _PT_Barium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(56);
        }

        private void _PT_Strontium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(38);
        }

        private void _PT_Calcium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(20);
        }

        private void _PT_Magnesium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(12);
        }

        private void _PT_Beryllium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(4);
        }

        private void _PT_Scandium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(21);
        }

        private void _PT_Yttrium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(39);
        }

        private void _PT_Lanthan_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(57);
        }

        private void _PT_Actinium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(89);
        }

        private void _PT_Titan_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(22);
        }

        private void _PT_Zirkonium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(40);
        }

        private void _PT_Hafnium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(72);
        }

        private void _PT_Rutherfordium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(104);
        }

        private void _PT_Vanadium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(23);
        }

        private void _PT_Niob_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(41);
        }

        private void _PT_Tantal_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(73);
        }

        private void _PT_Dubnium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(105);
        }

        private void _PT_Chrom_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(24);
        }

        private void _PT_Molybdän_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(42);
        }

        private void _PT_Wolfram_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(74);
        }

        private void _PT_Seaborgium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(106);
        }
    }
}
