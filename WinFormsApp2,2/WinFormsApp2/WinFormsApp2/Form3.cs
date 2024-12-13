using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            string id = textboxid.Text;

            string connectionString = "data source=EFTY\\SQLEXPRESS; database=A; integrated security=SSPI";


            string query = $"SELECT Name, Gender, Nationality, Address FROM A WHERE ID = {id}";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                           
                            textboxname.Text = reader["Name"].ToString();
                            textboxgender.Text = reader["Gender"].ToString();
                            textboxnationality.Text = reader["Nationality"].ToString();
                            textboxaddress.Text = reader["Address"].ToString();
                        }
                        else
                        {
                           
                            MessageBox.Show("Record not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void update_Click(object sender, EventArgs e)
        {
            string id = textboxid.Text;
            string name = textboxname.Text;
            string gender = textboxgender.Text;
            string nationality = textboxnationality.Text;
            string address = textboxaddress.Text;

            string connectionString = "data source=EFTY\\SQLEXPRESS; database=A; integrated security=SSPI";

            string query = $"UPDATE A SET Name = '{name}', Gender = '{gender}', Nationality = '{nationality}', Address = '{address}' WHERE ID = {id}";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            string id = textboxid.Text;

            string connectionString = "data source=EFTY\\SQLEXPRESS; database=A; integrated security=SSPI";

            string query = $"DELETE FROM A WHERE ID = {id}";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

    }
}
