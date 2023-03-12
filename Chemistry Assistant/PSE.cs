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

            Eigenschaften eigenschaften = new Eigenschaften();
            eigenschaften.Show(this);
            eigenschaften.setEigenschaft("Hdid");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Eigenschaften eigenschaften = new Eigenschaften();
            eigenschaften.Show(this);
            eigenschaften.setEigenschaft("Helium");
        }
    }
}
