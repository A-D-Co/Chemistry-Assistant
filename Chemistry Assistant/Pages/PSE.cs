using System;
using System.Data;
using System.Windows.Forms;

namespace Chemistry_Assistant
{
    public partial class PSE : UserControl
    {
        public PSE()
        {
            InitializeComponent();
        }

        private void EigenschaftenWindow(int id)
        {
            // wenn neue eigenschaften page erstellt wird wird direkt das elementen id gegeben um darauf der element in daten bank zu weißen
            Eigenschaften eigenschaften = new Eigenschaften(id);
            //der code offnet den eigenschaften page
            eigenschaften.Show(this);
        }


        private void PT_Wasserstoff_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(1);

        }
        private void _PT_Helium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(2);
        }

        private void PT_Lithium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(3);
        }
        private void _PT_Beryllium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(4);
        }
        private void _PT_Bor_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(5);
        }
        private void _PT_Kohlenstoff_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(6);
        }
        private void _PT_Stickstoff_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(7);
        }
        private void _PT_Sauerstoff_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(8);
        }
        private void _PT_Fluor_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(9);
        }
        private void _PT_Neon_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(10);
        }
        private void _PT_Lithium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(11);
        }
        private void _PT_Magnesium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(12);
        }
        private void _PT_Aluminium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(13);
        }
        private void _PT_Sillicium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(14);
        }
        private void _PT_Phosphor_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(15);
        }
        private void _PT_Schwefel_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(16);
        }
        private void _PT_Chlor_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(17);
        }

        private void _PT_Argon_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(18);
        }

        private void _Pt_Kalium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(19);
        }
        private void _PT_Calcium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(20);
        }

        private void _PT_Scandium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(21);
        }
        private void _PT_Titan_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(22);
        }
        private void _PT_Vanadium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(23);
        }
        private void _PT_Chrom_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(24);
        }
        private void _PT_Mangan_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(25);
        }
        private void _PT_Eisen_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(26);
        }
        private void _PT_Cobalt_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(27);
        }
        private void _PT_Nickel_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(28);
        }
        private void _PT_Kupfer_Click(object sender, EventArgs e)
        {

            EigenschaftenWindow(29);
        }
        private void _PT_Zink_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(30);
        }
        private void _PT_Gallium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(31);
        }
        private void _PT_Germanium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(32);
        }
        private void _PT_Arsen_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(33);
        }
        private void _PT_Selen_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(34);
        }
        private void _PT_Barom_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(35);
        }

        private void Krypton_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(36);
        }
        private void _PT_Rubidium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(37);
        }
        private void _PT_Strontium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(38);
        }
        private void _PT_Yttrium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(39);
        }
        private void _PT_Zirkonium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(40);
        }
        private void _PT_Niob_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(41);
        }
        private void _PT_Molybdän_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(42);
        }
        private void _PT_Technetium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(43);
        }
        private void _PT_Ruthenium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(44);
        }
        private void _PT_Rhodium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(45);
        }
        private void _PT_Palladium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(46);
        }
        private void _PT_Silber_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(47);
        }
        private void _PT_Cadmium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(48);
        }
        private void _PT_Indium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(49);
        }
        private void _PT_Zinn_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(50);
        }
        private void _PT_Antimon_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(51);
        }
        private void _PT_Tellur_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(52);
        }
        private void _PT_Iod_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(53);
        }
        private void _PT_Xeon_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(54);
        }
        private void _PT_Casium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(55);
        }
        private void _PT_Barium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(56);
        }
        private void _PT_Lanthan_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(57);
        }
        private void _PT_Cer_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(58);
        }
        private void _PT_Praseodym_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(59);
        }
        private void _PT_Neodym_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(60);
        }
        private void _PT_Promethium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(61);
        }
        private void _PT_Samarium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(62);
        }

        private void _PT_Europium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(63);
        }

        private void _PT_Gadolinium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(64);
        }
        private void _PT_Terbium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(65);
        }
        private void _PT_Dysprosium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(66);
        }
        private void _PT_Holmium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(67);
        }
        private void _PT_Erbium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(68);
        }
        private void _PT_Thulium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(69);
        }
        private void _PT_Ytterbium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(70);
        }
        private void _PT_Lutetium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(71);
        }
        private void _PT_Hafnium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(72);
        }
        private void _PT_Tantal_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(73);
        }
        private void _PT_Wolfram_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(74);
        }
        private void _PT_Rhenium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(75);
        }
        private void _PT_Osmium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(76);
        }
        private void _PT_Iridium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(77);
        }
        private void _PT_Platin_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(78);
        }
        private void _PT_Gold_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(79);
        }
        private void _PT_QueckSilber_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(80);
        }
        private void _PT_Thallium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(81);
        }
        private void _PT_Blei_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(82);
        }
        private void _PT_Bismut_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(83);
        }
        private void _PT_Polonium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(84);
        }
        private void _PT_Asta_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(85);
        }

        private void _PT_Radon_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(86);
        }
        private void _PT_Francium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(87);
        }

        private void _PT_Radium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(88);
        }
        private void _PT_Actinium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(89);
        }
        private void _PT_Thorium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(90);
        }
        private void _PT_Protactinium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(91);
        }
        private void _PT_Uran_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(92);
        }
        private void _PT_Neptunium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(93);
        }
        private void _PT_Plutonium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(94);
        }
        private void _PT_Americium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(95);
        }
        private void _PT_Curium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(96);
        }
        private void _PT_Berkelium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(97);
        }
        private void _PT_Californium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(98);
        }
        private void _PT_Einsteinium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(99);
        }
        private void _PT_Fermium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(100);
        }
        private void _PT_Mendelevium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(101);
        }
        private void _PT_Nebelium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(102);
        }

        private void _PT_Lawrencium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(103);
        }
        private void _PT_Rutherfordium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(104);
        }
        private void _PT_Dubnium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(105);
        }
        private void _PT_Seaborgium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(106);
        }
        private void _PT_Bohrium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(107);
        }
        private void _PT_Hassium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(108);
        }
        private void _PT_Meitnerium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(109);
        }
        private void _PT_Darmstadtium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(110);
        }
        private void _PT_Roentagenium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(111);
        }
        private void _PT_Copernicium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(112);
        }
        private void _PT_Ununtrium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(113);
        }
        private void _PT_Flerovium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(114);
        }
        private void _PT_Moscovium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(115);
        }
        private void _PT_Livermorium_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(116);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(117);
        }

        private void _PT_Oganesson_Click(object sender, EventArgs e)
        {
            EigenschaftenWindow(118);
        }

    }
}