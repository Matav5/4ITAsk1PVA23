using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk1Kostky
{
    public partial class Kostka : UserControl
    {
        private int hodnota;

        private bool jeOdlozena = true;

        public bool JeOdlozena
        {
            get => jeOdlozena;
            set
            {
                jeOdlozena = value;
                panel1.BackColor = jeOdlozena ? Color.FromArgb(128, 128, 0, 128) : Color.Transparent;
            }
        }

        private bool jeVybrana;

        public bool JeVybrana
        {
            get => jeVybrana;
            set
            {
                jeVybrana = value;
                panel1.BackColor = jeVybrana ? Color.FromArgb(128, 0, 255, 255) : Color.Transparent;
            }
        }
        public int Hodnota
        {
            get => hodnota;
            set
            {
                hodnota = value;
                BackgroundImage = Image.FromFile($"{hodnota}.jpg");
            }
        }

        public event Action<Kostka> OnKostkaKliknuto;
        public Kostka()
        {
            InitializeComponent();
            panel1.BackColor = Color.Transparent;
        }

        private void Kostka_MouseClick(object sender, MouseEventArgs e)
        {
            if (jeOdlozena)
                return;

            OnKostkaKliknuto?.Invoke(this);
            JeVybrana = !JeVybrana;
        }
        public void Vylosuj()
        {
            Hodnota = Random.Shared.Next(1,7);
        }
    }
}
