using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] country = new string[5];
            country[0] = "Bangladeshi";
            country[1] = "Indian";
            country[2] = "Pakistani";
            country[3] = "Nepalese";

            nationalityCombo.DataSource = country;
            profilePictureBox1.ImageLocation = "C:\\Users\\Teacher\\Downloads\\profile.png";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameTextbox.Text;
            string id = IdTextbox.Text;
            string dateofbirth= DateOfBirthPicker.Value.ToString();
            string gender = maleRB.Checked ? "Male" : "Female";
            string nationality= nationalityCombo.SelectedItem.ToString();

            string details = "Name:" + name + "\nID:" + id+"\nDate of Birth:"+dateofbirth+"\nGender:"+gender+"\nNationality:"+nationality;

            // MessageBox.Show(details);
           // outputTextbox.Text= details;

          //profilePictureBox1.ImageLocation = "C:\\Users\\Teacher\\Downloads\\profile.png";

            Form2 form2 = new Form2(details);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Choose(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(openFileDialog.ShowDialog() == DialogResult.OK )
            {
                profilePictureBox1.Image=Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
