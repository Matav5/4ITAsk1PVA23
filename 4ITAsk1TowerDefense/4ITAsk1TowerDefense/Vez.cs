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
    public partial class Vez : UserControl, IUpdate
    {
        public int Poskozeni { get; private set; }
        public int Dosah { get; private set; }

        public float RychlostUtoku { get; private set; }

        public Vez(int poskozeni, int dosah, float rychlostUtoku) : this()
        {
            Poskozeni = poskozeni;
            Dosah = dosah;
            RychlostUtoku = rychlostUtoku;
        }
        public Vez()
        {
            InitializeComponent();
        }

        private void Vez_MouseClick(object sender, MouseEventArgs e)
        { 

        }

        public void GameUpdate()
        {
            // Bude střílet po okolí jednou za dobu rychlosti útoku
        }
    }
}
