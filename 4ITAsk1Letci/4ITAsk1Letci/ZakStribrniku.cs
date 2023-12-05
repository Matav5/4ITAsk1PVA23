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
    public partial class ZakStribrniku : UserControl, ILetec
    {
        public ZakStribrniku()
        {
            InitializeComponent();
        }

        public float CasVzletu { get => float.MinValue; set {} }

        public void Pristan()
        {
            timer1.Stop();
            BackgroundImage = Image.FromFile("zakSpinks.png");
        }

        public void Vzletni()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Location = new Point(
                Location.X,
                Location.Y + 5
                );
            if (Location.Y > Parent.Height - Height)
                Pristan();
        }
    }
}
