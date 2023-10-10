using System.Reflection;

namespace _4ITAsk1OpakIdleClicker
{
    public partial class Form1 : Form
    {
        int zlataky;

        public int Zlataky
        {
            get => zlataky;
            set
            {
                zlataky = value;

                label1.Text = $"Zla��ky: {zlataky}";
            }
        }

        public Form1()
        {
            InitializeComponent();
            VytvorMonstrum();
        }
        public void VytvorMonstrum()
        {
            //Monstrum monstrum = new Monstrum("Zlobr (Pavka)", 10, "zlobr.jpg", 5);
            // Zjistit v�echny typy kter� m��u spawnout
            List<TypeInfo> typyMonster = Assembly.GetExecutingAssembly().DefinedTypes
                .Where(typ => typ.IsAssignableTo(typeof(Monstrum)))
                .ToList();

            int nahodnejIndex = Random.Shared.Next(0, typyMonster.Count);

            //Slosovat jak� typ

            //Vz�t ten typ a vytvo�it objekt dan�ho typu
            Monstrum monstrum = (Monstrum)Activator.CreateInstance(typyMonster[nahodnejIndex]);
            monstrum.OnUmrel += Monstrum_OnUmrel;
            panel1.Controls.Add(monstrum);
            monstrum.Select();
        }

        private void Monstrum_OnUmrel(Monstrum monstrum)
        {
            Zlataky += monstrum.PocetZlatakuVPenezence;
            monstrum.OnUmrel -= Monstrum_OnUmrel;
            panel1.Controls.Remove(monstrum);
            VytvorMonstrum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Zlataky >= 50)
            {
                ManazerHrace.Instance.Poskozeni++;
                Zlataky -= 50;
            }
        }
    }
}