using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSearch
{
    public partial class frmNewStudent : Form
    {
        private Student student;

        public frmNewStudent(Student student=null)
        {
            InitializeComponent();
            this.student = student ?? new Student();
        }

        private void frmNewStudent_Load(object sender, EventArgs e)
        {
            GenerateYears();
            if (student.Id==0)
            {
                GenerateIndex();
            }
            else
            {
                LoadStudentData();
            }
        }

        private void LoadStudentData()
        {

            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            dtDOB.Value = student.DOB;
            txtIndex.Text = student.Index;
            cbActive.Checked = student.Active;
            cmbStudyYear.SelectedValue = student.StudyYear;
            txtEmail.Text = student.Email;
            txtPassword.Text = student.Password;
            pbPicture.Image = student.Picture;

        }

        private void GenerateIndex()
        {

            txtIndex.Text = $"IB{(DateTime.Now.Year - 2000) * 10000 + InMemoryDB.Students.Count + 1}"; 
            //to get ex.: IB230005
        }

        private void GenerateYears()
        {
            cmbStudyYear.DataSource = InMemoryDB.Years;
            cmbStudyYear.ValueMember = "Id";
            cmbStudyYear.DisplayMember = "Description";
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
           
           if ( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
                pbPicture.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

      
                student.FirstName = txtFirstName.Text;
                student.LastName = txtLastName.Text;
                student.DOB = dtDOB.Value;
                student.Index = txtIndex.Text;
                student.Active = cbActive.Checked;
                student.StudyYear = int.Parse(cmbStudyYear.SelectedValue.ToString());
                student.Email = txtEmail.Text;
                student.Password = txtPassword.Text;
                student.Picture = pbPicture.Image;

                string poruka = Resources.Resource1.SuccessfulEdit;
                if (student.Id==0)
                {
                    student.Id = InMemoryDB.Students.Count+1;
                    InMemoryDB.Students.Add(student);
                    poruka = Resources.Resource1.SuccessfulSignUp;
                }

                MessageBox.Show(poruka, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateInput()
        {
            return Validator.ValidateControl(txtFirstName, err, string.Format(Resources.Resource1.Required))
                && Validator.ValidateControl(txtLastName, err, string.Format(Resources.Resource1.Required))
                && Validator.ValidateControl(txtIndex, err, string.Format(Resources.Resource1.Required))
                && Validator.ValidateControl(txtPassword, err, string.Format(Resources.Resource1.Required))
                && Validator.ValidateControl(cmbStudyYear, err, string.Format(Resources.Resource1.Required))
                && Validator.ValidateControl(pbPicture, err, string.Format(Resources.Resource1.Required));

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            GenerateEmail();
        }

        private void GenerateEmail()
        {
            txtEmail.Text = $"{txtFirstName.Text.ToLower()}.{txtLastName.Text.ToLower()}@edu.fit.ba";
        }


        private void txtLastName_TextChanged_1(object sender, EventArgs e)
        {
            GenerateEmail();
        }
    }
    
}
