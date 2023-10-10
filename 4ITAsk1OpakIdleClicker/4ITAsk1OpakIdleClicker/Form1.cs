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

                label1.Text = $"Zlaù·ky: {zlataky}";
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
            // Zjistit vöechny typy kter˝ m˘ûu spawnout
            List<TypeInfo> typyMonster = Assembly.GetExecutingAssembly().DefinedTypes
                .Where(typ => typ.IsAssignableTo(typeof(Monstrum)))
                .ToList();

            int nahodnejIndex = Random.Shared.Next(0, typyMonster.Count);

            //Slosovat jak˝ typ

            //VzÌt ten typ a vytvo¯it objekt danÈho typu
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