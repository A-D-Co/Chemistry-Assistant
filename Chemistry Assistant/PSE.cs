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



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Eigenschaften eigenschaften = new Eigenschaften(2);
            eigenschaften.Show(this);
            eigenschaften.setEigenschaft("Hdid");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Eigenschaften eigenschaften = new Eigenschaften(1);
            eigenschaften.Show(this);
            eigenschaften.setEigenschaft("Helium");
        }

        public DataSet data = new DataSet();

        public void SimpelSql()
        {
            string elemnt = TB_SQL.Text;
            data = MainPage.DM.ds;

            //MainPage.DM.ExecuteSimpleDML("INSERT INTO Elemente (Element ) VALUES ('"+elemnt+"');");


            //Console.WriteLine(MainPage.DM.TableExists("Elemente", false)); 

            MainPage.DM.LoadData2Table("SELECT * FROM Eigenschaften where id = 1", "ElementTable");

            dataGridView1.DataSource = MainPage.DM.ds.Tables[0];

            label2.Text = data.Tables[0].Rows[0][2].ToString();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpelSql();
        }


    }
}
