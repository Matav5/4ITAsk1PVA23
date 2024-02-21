using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ITAsk1Had
{
    internal class Had
    {
        List<Segment> seznamSegmentu = new List<Segment>();

        public Segment Hlava => seznamSegmentu[0];

        public Had()
        {
            seznamSegmentu.Add(new Segment(0, 0, 1));
            seznamSegmentu.Add(new Segment(-1, 0, 1));
            seznamSegmentu.Add(new Segment(-2, 0, 1));
        }
        public void Pohni()
        {
            //Pohne se všemi segmenty po jejich určeném směru a nastaví nový
            Segment segment = Hlava;
            segment.Pohni();

            //Pohnu postupně
            for (int i = 1; i < seznamSegmentu.Count; i++)
            {
                segment = seznamSegmentu[i];
                segment.Pohni();
            }

            //Změnim směr od ocasu k segmentu před hlavou => směr vezme podle segmentu před ním
            for (int i = seznamSegmentu.Count - 1; i > 0; i--)
            {
                segment = seznamSegmentu[i];
                segment.ZmenSmer(seznamSegmentu[i - 1].Smer);
            }
        }
        public bool KolidovalaHlavaSTelem()
        {
            //Pokud hlava kolidovala s jiným segmentem => vrátí TRUE
            return seznamSegmentu.Any(segment => 
                                        segment != Hlava && 
                                        Hlava.X == segment.X &&
                                        Hlava.Y == segment.Y
                                        );
        }

        internal void Vykresli(Graphics g)
        {
            seznamSegmentu.ForEach(segment => segment.Vykresli(g));
        }
    }

    internal class Segment
    {
        int x;
        public int X => x;
        int y;
        public int Y => y;
        int smer;
        public int Smer => smer;
        public Segment(int x, int y, int smer)
        {
            this.x = x;
            this.y = y;
            this.smer = smer;
        }
        public void ZmenSmer(int smer)
        {
     //          3               1  + 2  % 4
            if(this.smer != (smer + 2) % 4)
                this.smer = smer;
        }
        public void Pohni()
        {
            switch (smer)
            {
                case 0:
                    y--;
                    break;
                case 1:
                    x++;
                    break;
                case 2:
                    y++;
                    break;
                case 3:
                    x--;
                    break;
            }
        }
        public void Vykresli(Graphics g)
        {
            g.FillRectangle(Brushes.Black,
                x * Hra.VELIKOST_POLICKA,
                y * Hra.VELIKOST_POLICKA,
                Hra.VELIKOST_POLICKA,
                Hra.VELIKOST_POLICKA
                );
        }
    }
}
