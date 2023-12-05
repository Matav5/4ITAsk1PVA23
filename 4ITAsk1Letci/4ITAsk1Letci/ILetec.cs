using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ITAsk1Letci
{
    internal interface ILetec
    {
        float CasVzletu { get; set; }
        void Vzletni();

        void Pristan();
    }
}
