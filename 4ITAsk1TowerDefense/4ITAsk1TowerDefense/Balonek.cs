using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk1TowerDefense
{
    public partial class Balonek : UserControl,IUpdate
    {
        public int Zivoty { get; private set; }
        public int Rychlost { get; private set; }
        public Color BarvaBalonku { get; private set; }

        public Balonek(int zivoty, int rychlost, Color barvaBalonku) : this()
        {
            Zivoty = zivoty;
            Rychlost = rychlost;
            BarvaBalonku = barvaBalonku;
        }
        public Balonek()
        {
            InitializeComponent();
        }

        public void GameUpdate()
        {
            //Pohyb a případně kontrola doražení do cíle (konec hry)
        }
    }
}
