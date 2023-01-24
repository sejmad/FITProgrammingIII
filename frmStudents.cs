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
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
            dgvStudents.AutoGenerateColumns = false;
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents(List<Student> Data =  null)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = Data ?? InMemoryDB.Students;
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            var form = new frmNewStudent();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void dgvStudents_CellDoubleSClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudents.SelectedRows[0].DataBoundItem as Student;
            if (student !=null)
            {

                var form = new frmNewStudent(student);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadStudents();
                }

            }
        }

        private void txtFilterSearch_TextChanged(object sender, EventArgs e)
        {
            var filter = txtFilterSearch.Text;
            var result = new List<Student>();

            foreach (var student in InMemoryDB.Students)
            {
                if (student.FirstName.ToLower().Contains(filter) || student.LastName.ToLower().Contains(filter))
                {
                    result.Add(student);
                }
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = result;
            }
            LoadStudents(result);
        }
    }
}
