using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = "data source =EFTY\\SQLEXPRESS; database=A; integrated security=SSPI";

        public Form2()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM A";
            FillDataGridView(query);
        }

        private void FillDataGridView(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            string searchText = textBox11.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string query = $"SELECT * FROM A WHERE ID LIKE '%{searchText}%' OR Name LIKE '%{searchText}%' OR Nationality LIKE '%{searchText}%' OR Address LIKE '%{searchText}%'";
                FillDataGridView(query);
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }
    }
}
