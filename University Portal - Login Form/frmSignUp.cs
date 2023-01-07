using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Portal___Login_Form
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var newUser = new User()
                {
                    Id = InMemoryDB.Users.Count + 1,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Username = txtUsername.Text,
                    Password = PasswordHash.hashPassword(txtPassword.Text),
                    Active = cbActive.Checked
                };

                InMemoryDB.Users.Add(newUser);
                MessageBox.Show(string.Format(_Resources.Get("signupSuccessful")), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidateInput()
        {
            return Validator.ValidateControl(txtFirstName, err, _Resources.Get("required")) &&
                    Validator.ValidateControl(txtLastName, err, _Resources.Get("required")) &&
                    Validator.ValidateControl(txtUsername, err, _Resources.Get("required")) &&
                    Validator.ValidateControl(txtPassword, err, _Resources.Get("required"));
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            GenerateUsername();
        }

        private void GenerateUsername()
        {
            txtUsername.Text = $"{txtFirstName.Text}.{txtLastName.Text}".ToLower();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            GenerateUsername();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            foreach (var user in InMemoryDB.Users)
            {
                txtUsername.BackColor = (txtUsername.Text==user.Username) ? Color.Red : Color.Empty;
            }
        }

        //// generating password on a registration
        //private void frmSignUp_Load(object sender, EventArgs e)
        //{
        //    txtPassword.Text = GeneratePassword();
        //}

        //private string GeneratePassword()
        //{
        //    var password = "";
        //    var allowedCharacters = "0123456789qwertzuiopasdfghjklyxcvbnm,.-_*/%";
        //    var rand = new Random();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        int nextCharacter = rand.Next(0, allowedCharacters.Length);
        //        password += allowedCharacters[nextCharacter];
        //    }
        //    return password;
        //}
    }
}
