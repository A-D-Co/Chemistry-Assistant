using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chemistry_Assistant.Pages
{
    public partial class ChemischeReaktion : Form
    {
        public ChemischeReaktion()
        {
            InitializeComponent();
            _T_Movement.Start();
        }

        Random random = new Random();
        List<PictureBox> sauerstoffitems = new List<PictureBox>();
        List<PictureBox> wasserstoffitems = new List<PictureBox>();
        public void SpawnPicture(string ImagePath, List<PictureBox> items)
        {
            PictureBox pic = new PictureBox();
            pic.Height = 30;
            pic.Width = 30;
            pic.BackColor = Color.Transparent;
            pic.Image = Image.FromFile(ImagePath);

            int x = random.Next(1, this.panel1.Width - pic.Width);
            int y = random.Next(1, this.panel1.Height - pic.Height);

            pic.Location = new Point(x, y);
            items.Add(pic);
            this.panel1.Controls.Add(pic);


        }

        public void deletePicture(List<PictureBox> items)
        {
            if (items.Count > 0)
            {
                PictureBox pic = items[items.Count - 1];
                this.panel1.Controls.Remove(pic);
                items.RemoveAt(items.Count - 1);
            }

        }

        private int lastvalue;
        private void _Trb_Sauerstoff_Scroll(object sender, EventArgs e)
        {
            int change = _Trb_Sauerstoff.Value - lastvalue;
            if (change > 0)
            {
                //increasing
                SpawnPicture(@"F:\Chemistry Assistant\Chemistry Assistant\Resources\Sauerstoff.png", sauerstoffitems);
            }
            else if (change < 0)
            {

                //decreasing
                deletePicture(sauerstoffitems);
            }
            lastvalue = _Trb_Sauerstoff.Value;
        }

        private int _lastvalue;
        private void _Trb_Wasserstoff_Scroll(object sender, EventArgs e)
        {
            int change = _Trb_Wasserstoff.Value - _lastvalue;
            if (change > 0)
            {
                //increasing
                SpawnPicture(@"F:\Chemistry Assistant\Chemistry Assistant\Resources\Wasserstoffmol.png",wasserstoffitems);
            }
            else if (change < 0)
            {
                //decreasing
                deletePicture(wasserstoffitems);
            }
            _lastvalue = _Trb_Wasserstoff.Value;
        }

        private void _T_Movement_Tick(object sender, EventArgs e)
        {
            if (wasserstoffitems.Count > 0)
            {
                foreach (PictureBox pic in wasserstoffitems)
                {
                    int targetX = random.Next(1, this.panel1.Width - pic.Width);
                    int targetY = random.Next(1, this.panel1.Height - pic.Height);

                    int speed = 20; //

                    int deltaX = (targetX - pic.Left) / speed;
                    int deltaY = (targetY - pic.Top) / speed;

                    pic.Left += deltaX;
                    pic.Top += deltaY;


                }
            }
            if (sauerstoffitems.Count > 0)
            {
                foreach (PictureBox pic in sauerstoffitems)
                {
                    int targetX = random.Next(1, this.panel1.Width - pic.Width);
                    int targetY = random.Next(1, this.panel1.Height - pic.Height);

                    int speed = 20; //

                    int deltaX = (targetX - pic.Left) / speed;
                    int deltaY = (targetY - pic.Top) / speed;

                    pic.Left += deltaX;
                    pic.Top += deltaY;


                }
            }
        }
    }
}
