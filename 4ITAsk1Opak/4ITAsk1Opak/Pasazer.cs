using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ITAsk1Opak
{
    public class Pasazer
    {
        protected string jmeno;
        protected uint vek;
        protected string cilCesty;

        public Pasazer(string jmeno, uint vek, string cilCesty)
        {
            this.jmeno = jmeno;
            this.vek = vek;
            this.cilCesty = cilCesty;
        }
        public override string ToString()
        {
            return $"{this.jmeno} ({vek}) jede do: {cilCesty}";
        }
    }
}
