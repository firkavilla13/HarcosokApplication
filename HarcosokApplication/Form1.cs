using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        const string AdatLetrehozasSql = @"
            CREATE TABLE IF NOT EXISTS harcosok(
                id INTEGER AUTO_INCREMENT PRIMARY KEY,
                nev VARCHAR(80) NOT NULL UNIQUE,                
                letrehozas DATE NOT NULL
        )";
        const string AdatLetrehozasSql2 = @"
            CREATE TABLE IF NOT EXISTS kepessegek(
                id INTEGER AUTO_INCREMENT PRIMARY KEY,
                leiras VARCHAR(80) NOT NULL UNIQUE,    
                harcos_id INTEGER NOT NULL,            
                FOREIGN KEY (harcos_id) REFERENCES harcosok(id)
        )";
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            try
            {
                conn = new MySqlConnection("Server=localhost;Database=cs_harcosok;Uid=root;Password=;");
                conn.Open();
                var letrehozas = conn.CreateCommand();
                var letrehozas2 = conn.CreateCommand();
                letrehozas.CommandText = AdatLetrehozasSql;
                letrehozas2.CommandText = AdatLetrehozasSql2;
                letrehozas.ExecuteNonQuery();
                letrehozas2.ExecuteNonQuery();

                UpdateHarcosok();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Adatbazis hiba:\n" + ex.Message);
                this.Close();
            }
            FormClosed += (sender, e) => conn.Close();

        }

        private void UpdateHarcosok()
        {
            //Ez számolja meg azt ,hogy összesen hány darab felhasználónk van 
            string kiirando = "Regisztralt {0} db user";
            var c = conn.CreateCommand();
            c.CommandText = "SELECT COUNT(*) FROM harcosok";
            long darabszam = (long)c.ExecuteScalar();
            regUserekLabel.Text = string.Format(kiirando, darabszam);

            //Ki listázni a regisztrált harcosok (felhasználók) neveit :)
            regUserekLabel.Text = string.Format(kiirando, darabszam);
            var cFelhasznalok = conn.CreateCommand();
            cFelhasznalok.CommandText = "SELECT nev FROM harcosok ORDER BY nev"; //SQL Kód Ami Kijelöli a harcosokat

            using (var reader = cFelhasznalok.ExecuteReader())
            {
                hasznaloComboBox.Items.Clear();
                while (reader.Read())
                {
                    var nev = reader.GetString("nev");
                    hasznaloComboBox.Items.Add(string.Format("{0}",nev));
                   

                    /* Le lehetne kérni a dátumot is, és az alábbi szerint szépre formázni, de erre nincs szükség az esetemben.
                     * var datum = reader.GetDateTime("letrehozas");
                     hasznaloComboBox.Items.Add(
                         string.Format("{0} - {1:yyyy. MM. dd.}", nev, datum)
                         );
                         */
                }
            }
            

        }

        private void letrehozasButton_Click(object sender, EventArgs e)
        {
            string nev = harcosNeveTextBox.Text;
            DateTime letrehozas;
            letrehozas = DateTime.Now;

            var ellenorzes = conn.CreateCommand();
            ellenorzes.CommandText = "SELECT COUNT(*) FROM harcosok WHERE nev = @nev";
            ellenorzes.Parameters.AddWithValue(@"nev", nev);
            var darab = (long)ellenorzes.ExecuteScalar();
            if (darab != 0)
            {
                MessageBox.Show("A user mar letezik");
                return;
            }

            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO harcosok (nev, letrehozas) VALUES (@nev, @letrehozas)";
            command.Parameters.AddWithValue("@nev", harcosNeveTextBox.Text);            
            command.Parameters.AddWithValue("@letrehozas", letrehozas);
            int erintettSorok = command.ExecuteNonQuery();
            UpdateHarcosok();

        }

        

        private void kepessegHozzaadasButton_Click(object sender, EventArgs e)
        {
            string kepesseg = kepessegNeveTextBox.Text;
            string leiras = leirasTextBox.Text;
            string neve = hasznaloComboBox.Text;          
            var id = conn.CreateCommand();

            id.CommandText = "SELECT id FROM harcosok WHERE nev = @neve";
            id.Parameters.AddWithValue("@neve", neve);

            long harcos_id;
            harcos_id = ((int)id.ExecuteScalar()); //Ki lehet nyerni, egy adatot jelent esetben a hozzá tartozó id-t nyertem ki

            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO kepessegek (harcos_id, leiras, nev) VALUES (@harcos_id, @leiras, @nev)";
            command.Parameters.AddWithValue("@harcos_id", harcos_id);
            command.Parameters.AddWithValue("@leiras", leiras);
            command.Parameters.AddWithValue("@nev", kepesseg);

            int erintettSorok = command.ExecuteNonQuery();
            


        }
    }
}
