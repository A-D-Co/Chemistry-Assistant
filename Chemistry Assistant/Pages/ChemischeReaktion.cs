using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chemistry_Assistant.Pages
{
    public partial class ChemischeReaktion : Form
    {
        public ChemischeReaktion()
        {
            InitializeComponent();


        }


        // Instanz der Move-Klasse für die Bewegung der Moleküle
        Move move;

        // Listen für verschiedene Moleküle
        List<Move> SauerstoffItems = new List<Move>();
        List<Move> WasserstoffItems = new List<Move>();
        List<Move> wasserItems = new List<Move>();
        List<Move> NewSauerstoff = new List<Move>();

        // Panel-Paint-Event, um die Moleküle zu zeichnen
        private void _P_Container_Paint1(object sender, PaintEventArgs e)
        {

            // Aktualisiere die Anzeige der Molekülzahlen
            _lbl_sauerstoff.Text = SauerstoffItems.Count.ToString();
            _lbl_wasserstoff.Text = WasserstoffItems.Count.ToString();
            _lbl_Wasser.Text = wasserItems.Count.ToString();


            // Zeichne die Moleküle in den entsprechenden Listen
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
            foreach (Move item in wasserItems)
            {
                item.Update();
                item.OnpaintWasser(e.Graphics);
            }
            foreach (Move item in NewSauerstoff)
            {
                item.Update();
                item.OnpaintNewSauerstoff(e.Graphics);
            }


            // Überprüfe auf Überlappungen zwischen Sauerstoff- und Wasserstoff-Molekülen
            bool hasOverlap = false;
            List<Move> itemsToRemove = new List<Move>();

            foreach (Move sauerstoffItem in SauerstoffItems)
            {
                foreach (Move wasserstoffItem in WasserstoffItems)
                {
                    if (wasserstoffItem.wasserstoff.IntersectsWith(sauerstoffItem.sauerstoff))
                    {
                        hasOverlap = true;
                        itemsToRemove.Add(sauerstoffItem);
                        itemsToRemove.Add(wasserstoffItem);
                        break;
                    }
                }
                if (hasOverlap)
                    break;
            }

            // Wenn Überlappungen gefunden wurden
            if (hasOverlap)
            {
                // Entferne überlappende Moleküle aus den Listen
                foreach (Move item in itemsToRemove)
                {
                    SauerstoffItems.Remove(item);
                    WasserstoffItems.Remove(item);
                }
                // Füge ein neues Wassermolekül hinzu
                move = new Move(this._P_Container.Width, this._P_Container.Height);
                wasserItems.Add(move);

                // Füge neue Sauerstoffmoleküle hinzu, bis die Anzahl 4 erreicht
                while (SauerstoffItems.Count <= 4)
                {
                    move = new Move(this._P_Container.Width, this._P_Container.Height);
                    SauerstoffItems.Add(move);

                }



            }


            if(SauerstoffItems.Count >=4 && wasserItems.Count >= 10)
            {
                _lbl_Vollstaedige.Visible = true;
            }

        }


        // Lösche das letzte Element aus der gegebenen Liste von Molekülen
        private void Delete(List<Move> moves)
        {
            if (moves.Count > 0)
            {
                Move move = moves[moves.Count - 1];
                moves.RemoveAt(moves.Count - 1);
            }
        }


        // Timer-Event-Handler zum Aktualisieren des Panels
        private void Timer_Tick(object sender, EventArgs e)
        {
            this._P_Container.Invalidate();

        }

        // Event-Handler für den Scroll des Sauerstoff-Schiebereglers
        private int lastvalue;
        private void _Trb_Sauerstoff_Scroll(object sender, EventArgs e)
        {
            int change = _Trb_Sauerstoff.Value - lastvalue;
            if (change > 0)
            {
                // Inkrementiere die Anzahl der Sauerstoff-Moleküle
                move = new Move(this._P_Container.Width, this._P_Container.Height);
                this.SauerstoffItems.Add(move);
            }
            else if (change < 0)
            {
                // Dekrementiere die Anzahl der Sauerstoff-Moleküle
                Delete(SauerstoffItems);
            }
            lastvalue = _Trb_Sauerstoff.Value;
            _lbl_sauerstoff_zustand.Text = _Trb_Sauerstoff.Value.ToString();
        }

        // Event-Handler für den Scroll des Wasserstoff-Schiebereglers
        private int _lastvalue;
        private void _Trb_Wasserstoff_Scroll(object sender, EventArgs e)
        {

            int change = _Trb_Wasserstoff.Value - _lastvalue;
            if (change > 0)
            {
                // Inkrementiere die Anzahl der Wasserstoff-Moleküle
                move = new Move(this._P_Container.Width, this._P_Container.Height);
                WasserstoffItems.Add(move);
            }
            else if (change < 0)
            {
                // Dekrementiere die Anzahl der Wasserstoff-Moleküle
                Delete(WasserstoffItems);
            }
            _lastvalue = _Trb_Wasserstoff.Value;
            _lbl_Wasserstoff_zustand.Text = _Trb_Wasserstoff.Value.ToString();
        }

        // Event-Handler beim Laden des Formulars
        private void ChemischeReaktion_Load(object sender, EventArgs e)
        {
            // Initialisiere und starte den Timer für das Panel-Update
            this.DoubleBuffered = true;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}
