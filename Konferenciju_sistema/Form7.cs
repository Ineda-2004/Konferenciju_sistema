using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Konferenciju_sistema
{
    public partial class Form7 : Form
    {
        private int naudotojoID;
        private string connectionString = "server=localhost;user=root;password=;database=konferenciju_sistema";

        public Form7(int naudotojoId)
        {
            InitializeComponent();
            naudotojoID = naudotojoId;
            this.Load += Form7_Load;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            UzpildytiDalyvavimus();
        }

        private void UzpildytiDalyvavimus()
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
                            m.Pavadinimas AS 'Miestas'
                        FROM dalyvioistorija d
                        JOIN konferencijos k ON d.KonferencijosID = k.KonferencijosID
                        JOIN vietos v ON k.KonferencijosID = v.KonferencijosID
                        JOIN miestai m ON k.MiestasID = m.MiestasID
                        WHERE d.NaudotojoID = @naudotojoID";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@naudotojoID", naudotojoID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridDalyvavimai.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida kraunant dalyvavimus: " + ex.Message);
                }
            }
        }
    }
}
