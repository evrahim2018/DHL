using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PersonalInformation : Form
    {
        string _firstname = String.Empty;
        string _lastname = String.Empty;
        string _fathername = String.Empty;
        string _mothername = String.Empty;
        string _addressname = String.Empty;

        public PersonalInformation()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void namebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_firstname +" "+ _lastname);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_addressname);              
        }

        private void showbutton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show( _firstname +" "+ _lastname + "\n" + _fathername + "\n"  + _mothername + "\n" + _addressname);
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            _firstname = firstNameTextBox.Text;
           /* if (_firstname.Length < 2)
            {
                MessageBox.Show("Sorry");
                return;
            }*/
            _lastname = lastNameTextBox.Text;
            _fathername = fatherTextBox.Text;
            _mothername = motherTextBox.Text;
            _addressname = addressTextBox.Text;

            MessageBox.Show("Success");
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            fatherTextBox.Text = "";
            motherTextBox.Text = "";
            addressTextBox.Text = "";

        }

        private void parentsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_fathername + "\n" + _mothername);
        }
    }
}
