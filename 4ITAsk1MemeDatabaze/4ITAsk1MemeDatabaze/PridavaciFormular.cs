using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace _4ITAsk1MemeDatabaze
{
    public partial class PridavaciFormular : Form
    {
        public PridavaciFormular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task ulozMemikTask = new Task(UlozMemik);
            ulozMemikTask.Start();
        }

        private void UlozMemik()
        {
            using (MySqlConnection db = new MySqlConnection("server=localhost;user=root;database=databazememiku"))
            {
                db.Open();
                Thread.Sleep(10000);
              //Poslat nějakou Query -> INSERT
                MySqlCommand prikaz = db.CreateCommand();
                prikaz.CommandText = $"INSERT INTO memiky(nazev,url) VALUES('{textBox2.Text}', '{textBox1.Text}');";
                prikaz.ExecuteNonQuery();
                //Ukončit spojení
                db.Close();
            }
            //Vypnu formulář
            //Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }
    }
}
