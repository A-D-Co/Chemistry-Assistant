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
            ConnectToDatabank();

        }

        public static string dm_;

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
                    DM = new Datamodule("SYSDBA",
                                   "Diyar1010",
                                   "F:\\Chemistry Assistant\\Chemistry Assistant\\DB\\Elementen.FDB",
                                   "localhost",
                                   3050
                                   );

                }
                catch(Exception ex)
                {

                    MessageBox.Show("Datenbank kann nicht geöffnet werden allllloooo verpiss dich " + ex.Message);

                }
                string ServerConnector = DM.GetServerVersion();
                string Database = DM.GetDatabaseName();
                string Servername = DM.GetDatasourceName();

                this.TSS_Status.Text = ServerConnector + " / " + Servername + " / " + Database;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            // pse page zugeweist
            PSE pse = new PSE(); 
            //methode addusercontrill wird wieder gerufen
            AddUserControll(pse);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // pse page zugeweist
            Rechner rechner = new Rechner();
            //methode addusercontrill wird wieder gerufen
            AddUserControll(rechner);
        }

        private void TSL_Status_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
