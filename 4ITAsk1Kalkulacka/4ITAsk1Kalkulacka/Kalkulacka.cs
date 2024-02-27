using System.Data;
using System.Linq.Expressions;

namespace _4ITAsk1Kalkulacka
{
    public partial class Kalkulacka : Form
    {
        decimal? ANS = null;
        public Kalkulacka()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Pøidávání cifer
            Button tlacitko = sender as Button;
            textBox1.Text += tlacitko.Text;
        }

        private void vypoctiButton_Click(object sender, EventArgs e)
        {
            //Vypoèíst, vypsat, zapamatovat si do ANS

            try
            {
                decimal vysledek = decimal.Parse(new NCalc.Expression(textBox1.Text).Evaluate().ToString());
                textBox1.Text = vysledek.ToString();
                ANS = vysledek;
            }
            catch (Exception err)
            {
                textBox1.Text = "Error";
                MessageBox.Show(err.Message);
            }
        }

        private void desetinnyButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith(".") || !char.IsDigit(textBox1.Text.Last()))
                return;


            textBox1.Text += ".";
        }

        private void deleniButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void nasobeniButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void odcitaniButton_Click(object sender, EventArgs e)
        {

        }

        private void scitaniButton_Click(object sender, EventArgs e)
        {

        }
    }
}
