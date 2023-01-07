using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Portal___Login_Form
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var username = txtUsername.Text;
            var password = PasswordHash.hashPassword(txtPassword.Text);

            if (ValidateInput())
            {
                if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
                {

                    foreach (var user in InMemoryDB.Users)
                    {
                        if (username == user.Username && password == user.Password)
                        {

                            if (user.Active)
                            {
                                MessageBox.Show(string.Format(_Resources.Get("welcome"), user));
                                UniversityPortalApp.loggedInUser = user;
                                return;
                            }

                            else
                            {
                                MessageBox.Show(string.Format(_Resources.Get("accountNotActive"), user));
                                return;
                            }
                        }
                        MessageBox.Show(string.Format(_Resources.Get("dataNotValid")));
                        return;

                    }
                }
            }
        }

        private bool ValidateInput()
        {
            return Validator.ValidateControl(txtUsername, err, _Resources.Get("required")) &&
                    Validator.ValidateControl(txtPassword, err, _Resources.Get("required"));
        }

        private void lblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registration = new frmSignUp();
            registration.Show();
        }
    }
}
