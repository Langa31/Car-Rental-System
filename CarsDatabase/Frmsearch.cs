using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class Frmsearch : Form
    {
        public Frmsearch()
        {
            InitializeComponent();
        }

        private void lblField_Click(object sender, EventArgs e)
        {

        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frmsearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.hireDataSet.Table);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcars f1 = new frmcars();
            f1.Show();
        }
    }
}
