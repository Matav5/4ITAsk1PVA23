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
    public partial class KlavesovyMonstrum : Monstrum
    {
       public KlavesovyMonstrum() : base("Žádné koule",25, "koule.png",10)
       {

       }
        public override void Monstrum_MouseClick(object sender, MouseEventArgs e)
        {

        }
        public override void Monstrum_KeyDown(object sender, KeyEventArgs e)
        {
            Zasah(ManazerHrace.Instance.Poskozeni);
        }
    }
}
