namespace _4ITAsk1TowerDefense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Vez vez = new Vez(25,50,1.5f);
            Point pozice = e.Location;
            pozice.Offset(-vez.Width / 2, -vez.Height / 2);
            vez.Location = pozice;
            pictureBox1.Controls.Add(vez);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
           foreach( Control control in pictureBox1.Controls)
            {
                if (control is IUpdate update)
                {
                    update.GameUpdate();
                }
            }
        }
    }
}