using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Konferenciju_sistema
{
    public partial class Form4 : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=konferenciju_sistema";
        private Dictionary<string, int> miestaiMap = new Dictionary<string, int>();
        private int naudotojoID; // Dalyvio ID perduodamas per konstruktorių

        public Form4(int naudotojoId)
        {
            InitializeComponent();
            naudotojoID = naudotojoId;
            comboMiestai.SelectedIndexChanged += ComboBoxMiestai_SelectedIndexChanged;
            btnRegistruotis.Click += ButtonRegistruoti_Click;
            this.Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UzpildytiMiestus();
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

                    comboMiestai.Items.Clear();
                    miestaiMap.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("MiestasID");
                        string pavadinimas = reader.GetString("Pavadinimas");
                        comboMiestai.Items.Add(pavadinimas);
                        miestaiMap[pavadinimas] = id;
                    }

                    if (comboMiestai.Items.Count > 0)
                        comboMiestai.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida kraunant miestus: " + ex.Message);
                }
            }
        }

        private void ComboBoxMiestai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMiestai.SelectedItem == null) return;

            string pasirinktas = comboMiestai.SelectedItem.ToString();
            if (miestaiMap.TryGetValue(pasirinktas, out int miestasId))
            {
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
                            k.KonferencijosID,
                            k.Pavadinimas AS 'Konferencija', 
                            k.Data AS 'Data',
                            v.PastatoPavadinimas AS 'Vieta'
                        FROM konferencijos k
                        JOIN vietos v ON k.KonferencijosID = v.KonferencijosID
                        WHERE k.MiestasID = @miestas_id";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@miestas_id", miestasId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataKonferencijos.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida kraunant konferencijas: " + ex.Message);
                }
            }
        }

        private void ButtonRegistruoti_Click(object sender, EventArgs e)
        {
            if (dataKonferencijos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pasirinkite konferenciją.");
                return;
            }

            int konferencijosID = Convert.ToInt32(dataKonferencijos.SelectedRows[0].Cells["KonferencijosID"].Value);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO dalyvioistorija (NaudotojoID, KonferencijosID) 
                                     VALUES (@naudotojoID, @konferencijosID)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@naudotojoID", naudotojoID);
                    cmd.Parameters.AddWithValue("@konferencijosID", konferencijosID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sėkmingai užsiregistravote!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registracijos klaida: " + ex.Message);
                }
            }
        }

        private void btnAtsijungti_Click(object sender, EventArgs e)
        {
            this.Hide(); // Paslepia dabartinį langą (Form4)
            Form1 prisijungimoLangas = new Form1(); // Naujas prisijungimo langas
            prisijungimoLangas.Show();
        }

        private void Dalyvavimai_Click(object sender, EventArgs e)
        {
            Form7 dalyvavimuLangas = new Form7(naudotojoID);
            dalyvavimuLangas.ShowDialog(); 
        }

    }
}
