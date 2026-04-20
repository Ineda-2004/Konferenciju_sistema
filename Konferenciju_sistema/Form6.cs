using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Konferenciju_sistema
{
    public partial class Form6 : Form
    {
        private string connStr = "server=localhost;user=root;password=;database=konferenciju_sistema";
        private int naudotojoId;

        public Form6(int naudotojoId)
        {
            InitializeComponent();
            this.naudotojoId = naudotojoId;

            this.Load += Form6_Load;
            KonferencijuLentele.CellValueChanged += KonferencijuLentele_CellValueChanged;
            KonferencijuLentele.CellContentClick += KonferencijuLentele_CellContentClick;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            UzkrautiKonferencijas();
        }

        private void UzkrautiKonferencijas()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            KonferencijosID,
                            Pavadinimas AS 'Konferencija',
                            Data AS 'Data',
                            Busena
                        FROM konferencijos
                        WHERE NaudotojoID = @naudotojoId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@naudotojoId", naudotojoId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    KonferencijuLentele.DataSource = dt;

                    // Paslėpti ID
                    if (KonferencijuLentele.Columns.Contains("KonferencijosID"))
                        KonferencijuLentele.Columns["KonferencijosID"].Visible = false;

                    // ComboBox būsenai
                    if (KonferencijuLentele.Columns.Contains("Busena"))
                    {
                        DataGridViewComboBoxColumn comboCol = new DataGridViewComboBoxColumn();
                        comboCol.HeaderText = "Busena";
                        comboCol.Name = "Busena";
                        comboCol.DataPropertyName = "Busena";
                        comboCol.Items.AddRange("Planuojama", "Patvirtinta", "Vyksta", "Atšaukta");

                        int index = KonferencijuLentele.Columns["Busena"].Index;
                        KonferencijuLentele.Columns.Remove("Busena");
                        KonferencijuLentele.Columns.Insert(index, comboCol);
                    }

                    // Mygtukas „Pašalinti“
                    if (!KonferencijuLentele.Columns.Contains("Salinti"))
                    {
                        DataGridViewButtonColumn salintiBtn = new DataGridViewButtonColumn();
                        salintiBtn.HeaderText = "Veiksmas";
                        salintiBtn.Text = "Pašalinti";
                        salintiBtn.Name = "Salinti";
                        salintiBtn.UseColumnTextForButtonValue = true;
                        KonferencijuLentele.Columns.Add(salintiBtn);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida kraunant konferencijas: " + ex.Message);
                }
            }
        }

        private void KonferencijuLentele_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (KonferencijuLentele.Columns[e.ColumnIndex].Name == "Busena" && e.RowIndex >= 0)
            {
                string naujaBusena = KonferencijuLentele.Rows[e.RowIndex].Cells["Busena"].Value?.ToString();
                int konfID = Convert.ToInt32(KonferencijuLentele.Rows[e.RowIndex].Cells["KonferencijosID"].Value);

                AtnaujintiBusena(konfID, naujaBusena);
            }
        }

        private void AtnaujintiBusena(int konfID, string busena)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE konferencijos 
                                     SET Busena = @busena 
                                     WHERE KonferencijosID = @id AND NaudotojoID = @naudotojoId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@busena", busena);
                    cmd.Parameters.AddWithValue("@id", konfID);
                    cmd.Parameters.AddWithValue("@naudotojoId", naudotojoId);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida atnaujinant būseną: " + ex.Message);
                }
            }
        }

        private void KonferencijuLentele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KonferencijuLentele.Columns[e.ColumnIndex].Name == "Salinti" && e.RowIndex >= 0)
            {
                int konfID = Convert.ToInt32(KonferencijuLentele.Rows[e.RowIndex].Cells["KonferencijosID"].Value);
                string pavadinimas = KonferencijuLentele.Rows[e.RowIndex].Cells["Konferencija"].Value?.ToString();

                var confirm = MessageBox.Show($"Ar tikrai norite pašalinti konferenciją „{pavadinimas}“?", "Patvirtinimas", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    PasalintiKonferencija(konfID);
                    UzkrautiKonferencijas();
                }
            }
        }

        private void PasalintiKonferencija(int konfID)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string deleteVieta = "DELETE FROM vietos WHERE KonferencijosID = @id";
                    MySqlCommand cmd1 = new MySqlCommand(deleteVieta, conn);
                    cmd1.Parameters.AddWithValue("@id", konfID);
                    cmd1.ExecuteNonQuery();

                    string deleteKonf = "DELETE FROM konferencijos WHERE KonferencijosID = @id AND NaudotojoID = @naudotojoId";
                    MySqlCommand cmd2 = new MySqlCommand(deleteKonf, conn);
                    cmd2.Parameters.AddWithValue("@id", konfID);
                    cmd2.Parameters.AddWithValue("@naudotojoId", naudotojoId);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Konferencija sėkmingai pašalinta.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida trinant konferenciją: " + ex.Message);
                }
            }
        }
    }
}
