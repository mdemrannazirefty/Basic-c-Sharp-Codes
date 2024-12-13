using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=A; integrated security=SSPI";

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

            // new column for delete option
            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value); // Assuming the ID column name is "ID"
                    string query = $"DELETE FROM A WHERE ID = {id}";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            con.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    //dataGridViewaissudata.Rows.RemoveAt(e.RowIndex);
                    //MessageBox.Show("Record resolved successfully.");
                }
            }
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
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value); // Assuming the ID column name is "ID"
                    string query = $"DELETE FROM A WHERE ID = {id}";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            con.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1(); 
            form1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
