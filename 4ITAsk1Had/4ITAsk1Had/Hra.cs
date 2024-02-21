
namespace _4ITAsk1Had
{
    public partial class Hra : Form
    {
        public const int VELIKOST_POLICKA = 25;
        Had had;
        public Hra()
        {
            InitializeComponent();
            VytvorHada();

        }

        private void VytvorHada()
        {
            had = new Had();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (had != null)
            {
                had.Vykresli(e.Graphics);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    had.Hlava.ZmenSmer(0);
                    break;

                case Keys.D:
                case Keys.Right:
                    had.Hlava.ZmenSmer(1);
                    break;

                case Keys.S:
                case Keys.Down:
                    had.Hlava.ZmenSmer(2);
                    break;

                case Keys.A:
                case Keys.Left:
                    had.Hlava.ZmenSmer(3);
                    break;
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            had.Pohni();
            Refresh();
        }
    }
}