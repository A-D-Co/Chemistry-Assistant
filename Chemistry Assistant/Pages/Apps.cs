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

        private void Pb_Simulation_Click(object sender, EventArgs e)
        {

            ChemischeReaktion chemischeReaktion = new ChemischeReaktion();
            chemischeReaktion.Show();

        }

        private void Pb_Rechnen_Click(object sender, EventArgs e)
        {
            MolareMasse molare = new MolareMasse();
            molare.Show();
        }
    }

}