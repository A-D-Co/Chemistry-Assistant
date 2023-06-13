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


        public static Datamodule DM;
        public void ConnectToDatabank()
        {
                try
                {
                    DM = new Datamodule(
                        /*Benutzername*/   "SYSDBA",
                        /*Passwort*/       "Diyar1010",
                        /*Datenbank Path*/ @"F:\Chemistry Assistant\Chemistry Assistant\Datenbank\CHEMISTRY_ASSISTANT.FDB",
                        /*Servername*/     "localhost",
                        /*Port*/           3050
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

        private void Bt_Apps_Click(object sender, EventArgs e)
        {
            // pse page zugeweist
            Apps apps = new Apps();
            //methode addusercontrill wird wieder gerufen
            AddUserControll(apps);
        }

        private void BT_Pse_Click(object sender, EventArgs e)
        {   
            // pse page zugeweist
            PSE pse = new PSE();
            //methode addusercontrill wird wieder gerufen
            AddUserControll(pse);

        }
    }
}
