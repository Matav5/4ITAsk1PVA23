using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk1Letci
{
    public partial class Letadlo : UserControl, ILetec
    {
        public Letadlo()
        {
            InitializeComponent();
        }
        private float casVzletu;
        public float CasVzletu { get => casVzletu; set => casVzletu = value; }

        public void Pristan()
        {
            timer1.Stop();
        }

        public void Vzletni()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Location = new Point(
                    Location.X + 1,
                    Location.Y - 2
                );
        }
    }
}
