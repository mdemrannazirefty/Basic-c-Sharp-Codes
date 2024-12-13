using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlClient;


namespace DonerDetailsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] bg = new string[3];
            bg[0] = "+a";
            bg[1] = "+b";
            bg[2] = "+ab";
            bgroupbox.DataSource = bg;

            string[] sx = new string[2];
            sx[0] = "Male";
            sx[1] = "Female";
            sexbox.DataSource = sx;

            string[] count = new string[3];
            count[0] = "bd";
            count[1] = "ind";
            count[2] = "pk";
            countrybox.DataSource = count;


            string[] st = new string[2];
            st[0] = "Dhaka";
            st[1] = "Khulna";
            statebox.DataSource = st;


            string[] ct = new string[2];
            ct[0] = "Dhaka";
            ct[1] = "Khulna";
            citybox.DataSource = ct;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection c = new SqlConnection();
            SqlConnection con= new SqlConnection("Data Source=EFTY\\SQLEXPRESS;Initial Catalog=DonorDetails;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            string insertQuary = "INSERT INTO DonorDetails VALUES (@Id,@DonorNo,@BloodGroup,@Age,@Sex,@Name,@Address,@Password,@Date,@Country,@State,@City,@Mobile,@Email)";
            SqlCommand cmd= new SqlCommand(insertQuary, con);
            int randomId = new Random().Next(1000, int.MaxValue);
            cmd.Parameters.AddWithValue("@Id", randomId);

            cmd.Parameters.AddWithValue("@DonorNo", dnobox.Text);

            /*
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =A; " +
                                   "integrated security = SSPI"; */

            string dno = dnobox.Text;
            string bgroup = bgroupbox.SelectedItem.ToString();
            string age = agebox.Text;
            string sex = sexbox.SelectedItem.ToString();
            string name = namebox.Text;
            string address = addressbox.Text;
            string password = passwordbox.Text;
            string date = datebox.Value.ToString();
            string country = countrybox.SelectedItem.ToString();
            string state = statebox.SelectedItem.ToString();
            string city = citybox.SelectedItem.ToString();
            string mobile = mobilebox.Text;
            string email = emailbox.Text;

            
            MessageBox.Show("Successfully Updated");
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
