using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk1OpakIdleClicker
{
    public partial class Monstrum : UserControl
    {
        string jmeno;
        float zivoty;
        public event Action<Monstrum> OnUmrel;
        public float Zivoty
        {
            get => zivoty;
            private set
            {
                zivoty = value;
                try {
                    progressBar1.Value = (int)Math.Clamp(zivoty, progressBar1.Minimum, progressBar1.Maximum);
                }
                catch
                {

                }
                if(zivoty <= 0)
                {
                    OnUmrel?.Invoke(this);

                }
            }
        }
        Image obrazek;
        int pocetZlatakuVPenezence;
        public int PocetZlatakuVPenezence => pocetZlatakuVPenezence;
        public Monstrum() : this("Zlobr (Pavka)", 10, "zlobr.jpg", 5)
        {
        }
        public Monstrum(string jmeno, float zivoty, string cestaKObrazku, int pocetZlatakuVPenezence){
            InitializeComponent();
            this.jmeno = jmeno;
            this.zivoty = zivoty;
            this.obrazek = Image.FromFile(cestaKObrazku);
            this.pocetZlatakuVPenezence = pocetZlatakuVPenezence;
            NastavGrafiku();
        }
        public void NastavGrafiku()
        {
            pictureBox1.Image = obrazek;
            label1.Text = jmeno;
            progressBar1.Maximum = (int)zivoty;
            progressBar1.Value = progressBar1.Maximum;
        }
        public void Zasah(float poskozeni = 1)
        {
            Zivoty -= poskozeni;
        }
        public virtual void Monstrum_MouseClick(object sender, MouseEventArgs e)
        {
            Zasah(ManazerHrace.Instance.Poskozeni);
        }

        public virtual void Monstrum_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
