namespace _4ITAsk1Kostky
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> seznamJmen = new List<string>();
            foreach (TextBox prvek in flowLayoutPanel1.Controls)
            {
                seznamJmen.Add(prvek.Text);
            }

            Hra hra = new Hra(seznamJmen);

            Hide();
            hra.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoï kostkou. Vyber kombinace, získej co nejvíce bodù a vyhraj!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.PlaceholderText = "Jméno hráèe...";
            flowLayoutPanel1.Controls.Add(textBox);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
                return;

            flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
        }
    }
}