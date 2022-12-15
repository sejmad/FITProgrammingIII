using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class frmIgraci : Form
    {
        public frmIgraci()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var igrac1 = txtIgrac1.Text;
            var igrac2 = txtIgrac2.Text;

            if (igrac1 != "" && igrac2 != "")
            {
                var xo = new frmXO(igrac1,igrac2);
                xo.ShowDialog();
            }
        }

        private void frmIgraci_Load(object sender, EventArgs e)
        {

        }
    }
}
