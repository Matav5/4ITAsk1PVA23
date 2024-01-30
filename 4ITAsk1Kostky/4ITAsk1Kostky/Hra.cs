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
    public partial class Hra : Form
    {
        List<Label> seznamLabelu = new List<Label>();
        List<Kostka> seznamKostek = new List<Kostka>();
        int skoreOdlozenychKostek = 0;
        
        bool prvniHod = true;
        private Hra()
        {
            InitializeComponent();
        }
        public Hra(List<string> seznamJmen) : this()
        {
            foreach (string jmeno in seznamJmen)
            {
                Label label = new Label();
                label.Text = jmeno;
                label.Height = flowLayoutPanel2.Height;
                label.Width = 50;
                flowLayoutPanel2.Controls.Add(label);
                seznamLabelu.Add(label);
            }

            VytvorKostky();
        }

        private void VytvorKostky()
        {
            for (int i = 0; i < 6; i++)
            {
                Kostka kostka = new Kostka();
                flowLayoutPanel1.Controls.Add(kostka);
                seznamKostek.Add(kostka);
                kostka.OnKostkaKliknuto += Kostka_OnKostkaKliknuto;
            }
        }

        private void Kostka_OnKostkaKliknuto(Kostka kostka)
        {
            // Kostku vyberu




            // Zjistit kombinace vybraných kostek
            int skore = ZjistiKombinace(seznamKostek.FindAll(kostka => kostka.JeVybrana));
            label1.Text = $"Skóre: {skore + skoreOdlozenychKostek}";
            // Podmínka výherní kombinace

            // Výpočet skóre

        }

        private int ZjistiKombinace(List<Kostka> vybraneKostky)
        {
            int skore = 0;
            //Postupka
            bool postupka = true;
            for (int i = 1; i < 7; i++)
            {
                if(!vybraneKostky.Exists(kostka => kostka.Hodnota == i))
                {
                    postupka = false;
                }
            }
            if (postupka)
            {
                //Skóre je 3000
                skore = 3000;
                return skore;
            }

            int pocetDvojic = 0;
            for (int i = 1; i < 7; i++)
            {
                if (vybraneKostky.FindAll(kostka => kostka.Hodnota == i).Count() == 2)
                    pocetDvojic++;
            }

            if (pocetDvojic == 3)
            {
                //Skóre je o 1500+
                skore = 1500;
                return skore;
            }


            //Vyberu všechny kostky s hodnotou 1 a zeptám se jestli je 1
            if (vybraneKostky.FindAll(kostka => kostka.Hodnota == 1).Count() == 1 )
            {
                //Skóre je o 100+
                skore += 100;
            }

            //Vyberu všechny kostky s hodnotou 1 a zeptám se jestli je 1
            if (vybraneKostky.FindAll(kostka => kostka.Hodnota == 5).Count() == 1)
            {
                //Skóre je o 50+
                skore += 50;
            }

            //Vyberu všechny kostky s hodnotou 1 a zeptám se jestli jsou 3
            if (vybraneKostky.FindAll(kostka => kostka.Hodnota == 1).Count() == 3)
            {
                //Skóre je o 1000+
                skore += 1000;
            }

            for (int i = 2; i < 7; i++)
            {
                if(vybraneKostky.FindAll(kostka => kostka.Hodnota == i  ).Count() == 3)
                {
                    //Skóre je o (i * 100)+
                    skore += i * 100;
                }
            }
           

            return skore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Kostka> vybraneKostky = seznamKostek.FindAll(kostka => kostka.JeVybrana);
            if (vybraneKostky.Count > 0)
            {
                int skore = ZjistiKombinace(vybraneKostky);
                skoreOdlozenychKostek += skore;
                label1.Text = $"Skóre: {skoreOdlozenychKostek}";
                foreach (Kostka kostka in vybraneKostky)
                {
                    kostka.Odloz();
                }
            }

            // Vylosování kostek mimo zamklé

            // Podmínka prohry => při prohře resetuje kostky

            // Případně odemykat / zamykat tlačítka


            for (int i = 0; i < seznamKostek.Count; i++)
            {
                if (prvniHod) {
                    seznamKostek[i].JeOdlozena = false;
                }
                if (!seznamKostek[i].JeOdlozena)
                    seznamKostek[i].Vylosuj();
            }
            prvniHod = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Při nějakých vybraných kombinacích zápis a přepnutí na dalšího hráče
        }
    }
}
