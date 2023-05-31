using Chemistry_Assistant.Pages;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace Chemistry_Assistant
{
    public partial class MainPage : Form
    {
        public MainPage()
        {

            InitializeComponent();

            PSE pse = new PSE();
            AddUserControll(pse);
            //wird zum daten bank verbunden und alle daten wird selected
            ConnectToDatabank();

        }






        public static Datamodule DM;

        // quelle https://www.youtube.com/watch?v=ILGUQBFjZUk
        public void AddUserControll(UserControl userControll)
        {
            //der userControll Soll ganz panel benutzenb
            userControll.Dock= DockStyle.Fill;
            //Der panel soll leer werden bevor was rein geschrieben wird
            MainPanel.Controls.Clear();

            //der neue user controller wird zum panel hinzugefüt 
            MainPanel.Controls.Add(userControll);  

            //der user Controller kommt Ganz vorne
            userControll.BringToFront();

            
        }
        

        public void ConnectToDatabank()
        {
                try
                {
                    DM = new Datamodule("SYSDBA",
                                   "Diyar1010",
                                   @"F:\Chemistry Assistant\Chemistry Assistant\Datenbank\CHEMISTRY_ASSISTANT.FDB",
                                   "localhost",
                                   3050
                                   );

                }
                catch(Exception ex)
                {

                    MessageBox.Show("Datenbank kann nicht geöffnet werden allllloooo verpiss dich " + ex.Message);

                }



            //das loaddata2 aufrufne damit er auf datenbank zu greift und und selcet command ausfüht
            string sqlCommnad = "SELECT * FROM T_ELEMENTE_EIGENSCHAFT order by id ; ";
            DM.LoadData2Table(sqlCommnad, "ElementTable");


        }

        private void Bt_Rechner_Click(object sender, EventArgs e)
        {
            // pse page zugeweist
            Rechner rechner = new Rechner();
            //methode addusercontrill wird wieder gerufen
            AddUserControll(rechner);
        }

        private void BT_Pse_Click(object sender, EventArgs e)
        {   
            // pse page zugeweist
            PSE pse = new PSE();
            //methode addusercontrill wird wieder gerufen
            AddUserControll(pse);

        }

        private void Bt_simulation_Click(object sender, EventArgs e)
        {
            simulation simulation= new simulation();
            AddUserControll(simulation);
        }
    }
}
