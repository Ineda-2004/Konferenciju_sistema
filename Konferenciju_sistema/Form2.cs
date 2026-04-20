using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Konferenciju_sistema
{
    public partial class Form2 : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=konferenciju_sistema";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnPrisijungti_Click(object sender, EventArgs e)
        {
            string elPastas = elpastas.Text.Trim();
            string slaptazodis = slapt.Text.Trim();

            if (string.IsNullOrEmpty(elPastas) || string.IsNullOrEmpty(slaptazodis))
            {
                MessageBox.Show("Prasome ivesti el. pasta ir slaptazodi.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT NaudotojoID, Vaidmuo 
                FROM naudotojai 
                WHERE ElPastas = @elpastas AND Slaptazodis = @slaptazodis";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@elpastas", elPastas);
                    cmd.Parameters.AddWithValue("@slaptazodis", slaptazodis);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int naudotojoId = reader.GetInt32("NaudotojoID");
                        string vaidmuo = reader.GetString("Vaidmuo").ToLower();

                        if (vaidmuo == "dalyvis")
                        {
                            this.Hide();
                            Form4 dalyvioLangas = new Form4(naudotojoId);
                            dalyvioLangas.Show();
                        }
                        else if (vaidmuo == "organizatorius")
                        {
                            this.Hide();
                            Organizatorius organizatoriausLangas = new Organizatorius(naudotojoId); 
                            organizatoriausLangas.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sis vaidmuo neturi prieigos prie sistemos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Neteisingas el. pastas arba slaptazodis.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Prisijungimo klaida: " + ex.Message);
                }
            }
        }

    }
}
