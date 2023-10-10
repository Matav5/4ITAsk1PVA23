namespace _4ITAsk1HledaniMin
{
    public partial class Form1 : Form
    {
        Policko[,] herniPole;
        public Form1()
        {
            InitializeComponent();
            VytvorHerniPole();
            ZaminujPole();
            NastavCiselniky();
        }

        private void NastavCiselniky()
        {
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    int pocetMin = ZkontrolujSousedy(j,i);

                }
            }
        }

        private int ZkontrolujSousedy(int x, int y)
        {
            int pocetMin = 0;
            //TODO dodìlat kontrolu sousedù a vrátit poèet min
            /*
            for (int i = 0; i < ; i++)
            {
                for (int j = 0; j <; j++)
                {

                }
            }*/
        }

        private void ZaminujPole()
        {
            Random rnd = new Random();
            int x;
            int y;
            Policko policko;
            for (int i = 0; i < 20; i++)
            {
                x = rnd.Next(herniPole.GetLength(1));
                y = rnd.Next(herniPole.GetLength(0));

                policko = herniPole[y, x];
                if (policko.MaMinu)
                {
                    i--;
                    continue;
                }

                policko.NastavMinovost();
            }
        }

        private void VytvorHerniPole()
        {
            herniPole = new Policko[12,12];
            Policko policko;
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    policko = new Policko(j, i);
                    herniPole[i, j] = policko;
                    herniPanel.Controls.Add(policko);

                }
            }
        }
    }
}