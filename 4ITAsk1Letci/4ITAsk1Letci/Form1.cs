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
    public partial class Form1 : Form
    {
        List<ILetec> seznamLetcu = new List<ILetec>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ILetec letec in seznamLetcu)
            {
                letec.Vzletni();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ZakStribrniku zakStribrniku = new ZakStribrniku();
                zakStribrniku.Location = e.Location;
                panel1.Controls.Add(zakStribrniku);
                seznamLetcu.Add(zakStribrniku);
            }
            else if(e.Button == MouseButtons.Right)
            {
                Letadlo letadlo = new Letadlo();
                letadlo.Location = e.Location;
                panel1.Controls.Add(letadlo);
                seznamLetcu.Add(letadlo);
            }
        }
    }
}
