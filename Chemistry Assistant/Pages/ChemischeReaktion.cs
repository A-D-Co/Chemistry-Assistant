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
        }


        //Move klasse verärbt
        Move move;

        //listen für mölekulen
        List<Move> SauerstoffItems = new List<Move>();
        List<Move> WasserstoffItems = new List<Move>();



        // um Kugel in das Panel zu zeichen 
        private void _P_Container_Paint1(object sender, PaintEventArgs e)
        {
            foreach (Move item in SauerstoffItems)
            {
                item.Update();
                item.OnpaintSauerstoff(e.Graphics);
            }
            foreach (Move item in WasserstoffItems)
            {
                item.Update();
                item.OnpaintWasserstoff(e.Graphics);
            }
        }


        //werden von panel gelöscht
        private void Delete(List<Move> moves)
        {
            if (moves.Count > 0)
            {
                Move move = moves[moves.Count - 1];
                moves.RemoveAt(moves.Count - 1);
            }
        }

        //panel jedes mal updaten
        private void Timer_Tick(object sender, EventArgs e)
        {
            this._P_Container.Invalidate();

        }



        //wenn benutzer es scrollt wirden mölekule gespawnt oder gelöscht
        private int lastvalue;
        private void _Trb_Sauerstoff_Scroll(object sender, EventArgs e)
        {


            int change = _Trb_Sauerstoff.Value - lastvalue;
            if (change > 0)
            {
                //zunehmen
                move = new Move(this._P_Container.Width, this._P_Container.Height);
                this.SauerstoffItems.Add(move);
            }
            else if (change < 0)
            {
                //verringen
                Delete(SauerstoffItems);

            }

            lastvalue = _Trb_Sauerstoff.Value;
            _lbl_sauerstoff.Text = _Trb_Sauerstoff.Value.ToString();
        }

        private int _lastvalue;
        private void _Trb_Wasserstoff_Scroll(object sender, EventArgs e)
        {
            int change = _Trb_Wasserstoff.Value - _lastvalue;
            if (change > 0)
            {
                //zunehmen
                move = new Move(this._P_Container.Width, this._P_Container.Height);
                WasserstoffItems.Add(move);
            }
            else if (change < 0)
            {

                //verringen
                Delete(WasserstoffItems);


            }
            _lastvalue = _Trb_Wasserstoff.Value;
            _lbl_wasserstoff.Text = _Trb_Wasserstoff.Value.ToString();
        }


        //wenn der page lädt
        private void ChemischeReaktion_Load(object sender, EventArgs e)
        {
            //this.DoubleBuffered = true;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}
