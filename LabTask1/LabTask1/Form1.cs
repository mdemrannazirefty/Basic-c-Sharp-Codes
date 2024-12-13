namespace LabTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cn = new string[6];
            cn[0] = "Bangladeshi";
            cn[1] = "Indian";
            cn[2] = "Pakistani";
            cn[3] = "Nepalese";
            cn[4] = "Us";
            cn[5] = "Uk";
            CountryCombo.DataSource = cn;

            string[] st = new string[2];
            st[0] = "Dhaka";
            st[1] = "Khulna";
            StateCombo.DataSource = st;

            string[] ct = new string[2];
            ct[0] = "Dhaka";
            ct[1] = "Khulna";
            CityCombo.DataSource = ct;

            string[] dpt = new string[2];
            dpt[0] = "CSE";
            dpt[1] = "BBA";
            DeptCombo.DataSource = dpt;

            string[] ro = new string[2];
            ro[0] = "Admin";
            ro[1] = "User";
            RoleCombo.DataSource = ro;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = IdTextbox.Text;
            string name = NameTextbox.Text;
            string dateofbirth = DateOfBirthPicker.Value.ToString();
            string address = AddressTextbox.Text;
            string country = CountryCombo.SelectedItem.ToString();
            string state = StateCombo.SelectedItem.ToString();
            string city = CityCombo.SelectedItem.ToString();
            string pincode = PinCodeTextbox.Text;
            string datejoin = DateJoinPicker.Value.ToString();
            string dept = DeptCombo.SelectedItem.ToString();
            string role = RoleCombo.SelectedItem.ToString();
            string eid = EIdTextbox.Text;
            string password = PassTextbox.Text;

            string details = "Id: " + id + "\nName: " + name + "\nDate of Birth: " + dateofbirth + "\nAddress :" + address + "\nCountry :" + country + "\nState :" + state + "\nCity :" + city + "\nPincode :" + pincode + "\nDate of Join :" + datejoin + "\nDept :" + dept + "\nRole :" + role + "\nEmail Id :" + eid + "\nPassword :" + password;

            Form2 form2 = new Form2(details);
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
