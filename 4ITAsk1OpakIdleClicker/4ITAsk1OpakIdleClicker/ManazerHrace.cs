using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ITAsk1OpakIdleClicker
{
    internal class ManazerHrace 
    {
        private static ManazerHrace __instance;
        public static ManazerHrace Instance
        {
            get
            {
                if(__instance == null)
                    __instance = new ManazerHrace();

               return __instance;
            }
        }

        private float poskozeni = 1;
        public float Poskozeni
        {
            get => poskozeni;
            set => poskozeni = value;
        }


    }
}
