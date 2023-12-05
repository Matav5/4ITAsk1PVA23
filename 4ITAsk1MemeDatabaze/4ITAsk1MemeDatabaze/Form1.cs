using MySqlConnector;

namespace _4ITAsk1MemeDatabaze
{
    public partial class Form1 : Form
    {
        /*
            CREATE TABLE memiky(
                id int PRIMARY KEY AUTO_INCREMENT,
                nazev varchar(50) NOT NULL,
                url varchar(128) NOT NULL,
                cas_vytvoreni timestamp DEFAULT NOW()
            );
         */
        int stranka = 1;
        Thread nacitaciVlakno = null;
        public Form1()
        {
            InitializeComponent();
            NacteniMemiku();
        }
        private void NacteniMemiku()
        {
            if (nacitaciVlakno != null)
                return;


            nacitaciVlakno = new Thread(NacteniMemikuVeVlakne);
            nacitaciVlakno.Start();
            
        }
        private void NacteniMemikuVeVlakne()
        {
            //ne
            Invoke( () => flowLayoutPanel1.Controls.Clear());
            Thread.Sleep(10000);
            using (MySqlConnection db = new MySqlConnection("server=localhost;user=root;database=databazememiku"))
            { 
                db.Open();
                MySqlCommand prikaz = db.CreateCommand();
                prikaz.CommandText = $"SELECT * FROM memiky LIMIT {(stranka - 1) * 2}, 2 ;";
                MySqlDataReader data = prikaz.ExecuteReader();
                while (data.Read())
                {
                    int id = data.GetInt32("id");
                    string nazev = data.GetString("nazev");
                    string url = data.GetString("url");
                    DateTime casVytvoreni = data.GetDateTime("cas_vytvoreni");
                    Memik memik = new Memik(id,nazev,url,casVytvoreni);
                    Invoke( () => flowLayoutPanel1.Controls.Add(memik));
                    memik.OnMemikPrenacti += Memik_OnMemikPrenacti;
                }
            }

            nacitaciVlakno = null;
        }

        private void Memik_OnMemikPrenacti(Memik memik)
        {
            NacteniMemiku();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PridavaciFormular pridavaciFormular = new PridavaciFormular();
            pridavaciFormular.ShowDialog();
            NacteniMemiku();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stranka--;
            NacteniMemiku();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stranka++;
            NacteniMemiku();
        }
    }
}