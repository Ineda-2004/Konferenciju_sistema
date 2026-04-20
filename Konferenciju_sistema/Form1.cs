using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Konferenciju_sistema
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=konferenciju_sistema";
        private Dictionary<string, int> miestaiMap = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            Miestas.SelectedIndexChanged += Miestas_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UzpildytiMiestus();
        }

        // Naudojama kitoms formoms atnaujinti sarasa
        public void AtnaujintiKonferencijuSarasa()
        {
            if (Miestas.SelectedItem != null)
            {
                string pasirinktasMiestas = Miestas.SelectedItem.ToString();
                if (miestaiMap.ContainsKey(pasirinktasMiestas))
                {
                    int miestasId = miestaiMap[pasirinktasMiestas];
                    UzpildytiKonferencijas(miestasId);
                }
            }
        }

        private void UzpildytiMiestus()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT MiestasID, Pavadinimas FROM miestai";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Miestas.Items.Clear();
                    miestaiMap.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("MiestasID");
                        string pavadinimas = reader.GetString("Pavadinimas");

                        Miestas.Items.Add(pavadinimas);
                        miestaiMap[pavadinimas] = id;
                    }

                    if (Miestas.Items.Count > 0)
                    {
                        Miestas.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida kraunant miestus: " + ex.Message);
                }
            }
        }

        private void Miestas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Miestas.SelectedItem == null) return;

            string pasirinktasMiestas = Miestas.SelectedItem.ToString();

            if (miestaiMap.ContainsKey(pasirinktasMiestas))
            {
                int miestasId = miestaiMap[pasirinktasMiestas];
                UzpildytiKonferencijas(miestasId);
            }
        }

        private void UzpildytiKonferencijas(int miestasId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            k.Pavadinimas AS 'Konferencija', 
                            k.Data AS 'Data',
                            v.PastatoPavadinimas AS 'Vieta',
                            CASE 
                                WHEN v.YraNuotolinis = 1 THEN 'Taip'
                                ELSE 'Ne'
                            END AS 'Nuotoliniu',
                            k.Busena AS 'Busena'
                        FROM konferencijos k
                        JOIN vietos v ON k.KonferencijosID = v.KonferencijosID
                        WHERE k.MiestasID = @miestas_id";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@miestas_id", miestasId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    KonferencijuLentele.DataSource = table;

                    // Spalvina eilutes pagal būsena
                    SpalvintiEilutesPagalBusena();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida kraunant konferencijas: " + ex.Message);
                }
            }
        }

        private void SpalvintiEilutesPagalBusena()
        {
            foreach (DataGridViewRow row in KonferencijuLentele.Rows)
            {
                if (row.Cells["Busena"].Value == null) continue;

                string busena = row.Cells["Busena"].Value.ToString();

                switch (busena)
                {
                    case "Planuojama":
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case "Patvirtinta":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "Vyksta":
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    case "Atšaukta":
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }

        private void Prisijungti_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 prisijungimoLangas = new Form2();
            prisijungimoLangas.Show();
        }
    }
}
