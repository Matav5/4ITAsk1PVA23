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
        public Form1()
        {
            InitializeComponent();
            NacteniMemiku();
        }

        private void NacteniMemiku()
        {
            //ne

            using (MySqlConnection db = new MySqlConnection("server=localhost;user=root;database=databazememiku"))
            {
                db.Open();
                MySqlCommand prikaz = db.CreateCommand();
                prikaz.CommandText = "SELECT * FROM memiky;";
                MySqlDataReader data = prikaz.ExecuteReader();
                while (data.Read())
                {
                    int id = data.GetInt32("id");
                    string nazev = data.GetString("nazev");
                    string url = data.GetString("url");
                    DateTime casVytvoreni = data.GetDateTime("cas_vytvoreni");
                    MessageBox.Show(nazev);
                }
            }
        }
    }
}