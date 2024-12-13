
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] country = new string[3];
            country[0] = "bd";
            country[1] = "ind";
            country[2] = "pk";

            comboBox1.DataSource = country;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =A; " +
                                   "integrated security = SSPI";

            string name = textBox1.Text;
            string dob = dateTimePicker1.Value.ToString();
            string gender = string.Empty;
            gender = radioButton1.Checked ? "Male" : "Female";
            string nationality = comboBox1.SelectedItem.ToString();
            string address = richTextBox1.Text;

            string sql = "INSERT INTO A(ID,Name,Dob,Gender,Nationality,Address) VALUES("
             + 1 + ","
             + "'" + name + "'" + ","
             + "'" + dob + "'" + ","
             + "'" + gender + "'" + ","
             + "'" + nationality + "'" + ","
             + "'" + address + "'" +
             ")";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }

            //MessageBox.Show("Inserted ");


            /* Form2 form2 = new Form2();
             form2.Show(); */

            
            Form2 form2 = new Form2();
            form2.Show();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
