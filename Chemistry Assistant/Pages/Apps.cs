using Chemistry_Assistant.Pages;
using System;
using System.Windows.Forms;

namespace Chemistry_Assistant
{
    public partial class Apps : UserControl
    {
        public Apps()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ChemischeReaktion chemischeReaktion = new ChemischeReaktion();
            chemischeReaktion.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MolareMasse molare = new MolareMasse();
            molare.Show();
        }
    }

}