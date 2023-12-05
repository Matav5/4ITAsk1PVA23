using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk1MemeDatabaze
{
    public partial class Memik : UserControl
    {
        int id;
        string nazev;
        string urlObrazku;
        DateTime casVytvoreni;
        public event Action<Memik> OnMemikPrenacti;
        private Memik()
        {
            InitializeComponent();
        }

        public Memik(int id, string nazev, string urlObrazku, DateTime casVytvoreni) : this()
        {
            this.id = id;
            this.nazev = nazev;
            this.urlObrazku = urlObrazku;
            this.casVytvoreni = casVytvoreni;

            UpdateUI();

        }

        private void UpdateUI()
        {
            pictureBox1.ImageLocation = urlObrazku;
            label1.Text = nazev;
            label2.Text = casVytvoreni.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ObrazkovyForm obrazkovyForm = new ObrazkovyForm(urlObrazku);
            obrazkovyForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection("server=localhost;user=root;database=databazememiku"))
            {
                db.Open();
                MySqlCommand prikaz = db.CreateCommand();
                prikaz.CommandText = $"DELETE FROM memiky WHERE id = {id};";
                prikaz.ExecuteNonQuery();

                OnMemikPrenacti?.Invoke(this);
            }
        }
    }
}
