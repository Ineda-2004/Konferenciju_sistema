using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Konferenciju_sistema
{
    public partial class Organizatorius : Form
    {
        private string connStr = "server=localhost;user=root;password=;database=konferenciju_sistema";
        private int naudotojoId; // 👈 Pridedame kintamąjį

        public Organizatorius(int naudotojoId)
        {
            InitializeComponent();
            this.naudotojoId = naudotojoId; // 👈 Išsaugome perduotą ID

            UzpildytiMiestus();
            UzpildytiTemas();
            cmbBusena.Items.AddRange(new string[] { "Planuojama", "Patvirtinta", "Vyksta", "Atšaukta" });
        }

        private void UzpildytiMiestus()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT MiestasID, Pavadinimas FROM miestai", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMiestas.DataSource = dt;
                cmbMiestas.DisplayMember = "Pavadinimas";
                cmbMiestas.ValueMember = "MiestasID";
            }
        }

        private void UzpildytiTemas()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT TemosID, Pavadinimas FROM temos", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTema.DataSource = dt;
                cmbTema.DisplayMember = "Pavadinimas";
                cmbTema.ValueMember = "TemosID";
            }
        }

        private void btnPrideti_Click(object sender, EventArgs e)
        {
            string pavadinimas = txtPavadinimas.Text.Trim();
            DateTime data = dtpData.Value.Date;
            string aprasymas = txtAprasymas.Text.Trim();
            int miestasID = Convert.ToInt32(cmbMiestas.SelectedValue);
            int temaID = Convert.ToInt32(cmbTema.SelectedValue);
            string busena = cmbBusena.SelectedItem?.ToString();

            string adresas = txtAdresas.Text.Trim();
            string pastatoPav = txtPastas.Text.Trim();
            bool nuotolinis = chkNuotolinis.Checked;

            if (string.IsNullOrEmpty(pavadinimas) || string.IsNullOrEmpty(busena))
            {
                MessageBox.Show("Prasome uzpildyti visus laukus.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // 1. Įrašome konferenciją
                string query = @"INSERT INTO konferencijos 
                         (Pavadinimas, Data, Aprasymas, MiestasID, TemaID, Busena, NaudotojoID) 
                         VALUES 
                         (@pav, @data, @apras, @miestas, @tema, @busena, @naudotojas)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pav", pavadinimas);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@apras", aprasymas);
                cmd.Parameters.AddWithValue("@miestas", miestasID);
                cmd.Parameters.AddWithValue("@tema", temaID);
                cmd.Parameters.AddWithValue("@busena", busena);
                cmd.Parameters.AddWithValue("@naudotojas", naudotojoId); // 👈 naudojame ID
                cmd.ExecuteNonQuery();

                long konfId = cmd.LastInsertedId;

                // 2. Įrašome susijusią vietą
                string vietosQuery = @"INSERT INTO vietos (KonferencijosID, Adresas, PastatoPavadinimas, YraNuotolinis) 
                               VALUES (@kid, @adr, @pastatas, @nuotolinis)";
                MySqlCommand vietosCmd = new MySqlCommand(vietosQuery, conn);
                vietosCmd.Parameters.AddWithValue("@kid", konfId);
                vietosCmd.Parameters.AddWithValue("@adr", adresas);
                vietosCmd.Parameters.AddWithValue("@pastatas", pastatoPav);
                vietosCmd.Parameters.AddWithValue("@nuotolinis", nuotolinis ? 1 : 0);
                vietosCmd.ExecuteNonQuery();

                MessageBox.Show("Konferencija ir vieta prideta sekmingai!");

                // Atnaujiname Form1 jeigu atidaryta
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Form1 form1)
                    {
                        form1.AtnaujintiKonferencijuSarasa();
                        break;
                    }
                }

            }
        }

        private void Keist_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(naudotojoId); 
            form6.Show();
        }

        private void btnAtsijungti_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 pradinisLangas = new Form1();
            pradinisLangas.Show();
        }

    }
}
