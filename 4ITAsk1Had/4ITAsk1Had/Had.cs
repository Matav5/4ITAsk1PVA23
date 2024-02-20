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


        public Had()
        {

        }
    }

    internal class Segment
    {
        int x;
        int y;
        int smer;
        public Segment(int x, int y, int smer)
        {
            this.x = x;
            this.y = y;
            this.smer = smer;
        }
        public void ZmenSmer(int smer)
        {
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
