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
    }
}
