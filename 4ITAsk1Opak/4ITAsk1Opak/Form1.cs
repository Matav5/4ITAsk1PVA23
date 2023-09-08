namespace _4ITAsk1Opak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autobus5.PridejPasazera(
                 new Pasazer(
                    textBox1.Text,
                    (uint)numericUpDown1.Value,
                    textBox2.Text
                    )
                );

        }
    }
}