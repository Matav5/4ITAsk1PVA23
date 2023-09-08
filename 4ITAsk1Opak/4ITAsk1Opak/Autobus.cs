using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk1Opak
{
    public partial class Autobus : UserControl
    {
        public int cisloAutobusu;

        public List<Pasazer> seznamPasazeru;

        public Autobus() : this(5)
        {

        }

        public Autobus(int cisloAutubusu)
        {
            InitializeComponent();
            this.cisloAutobusu = cisloAutobusu;
            seznamPasazeru = new List<Pasazer>();
        }

        public void PridejPasazera(Pasazer pasazer)
        {
            seznamPasazeru.Add(pasazer);
            comboBox1.Items.Add(pasazer);
        }
    }
}
