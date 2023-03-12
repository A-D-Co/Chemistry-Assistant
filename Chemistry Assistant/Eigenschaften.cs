using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Chemistry_Assistant
{
    public partial class Eigenschaften : Form
    {
        public Eigenschaften()
        {
            InitializeComponent();
        }



        public void setEigenschaft(string Element)
        {
            this.Text = Element;
            Console.WriteLine(Element);
        }

    }

}
