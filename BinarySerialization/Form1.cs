using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {           
            User user = new User();
            user.Username = txtUserName.Text;
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtPhone.Text;
            user.DateOfBirth = txtDateOfBirth.Text;
            user.SerializeBinary("UserSaved.bin");

            txtValidationMsg.Text = "Hello " + user.Username + " you've been registered";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            User user = User.Deserialize("UserSaved.bin");
            txtUserName.Text = user.Username;
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.Phone;
            txtDateOfBirth.Text = user.DateOfBirth;

            txtValidationMsg.Text = "User's " + user.Username + " data have been loaded";
        }
    }
}
