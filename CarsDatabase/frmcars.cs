using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarsDatabase
{
    public partial class frmcars : Form
    {
        public frmcars()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn;
        SqlCommand cmd;
        private void frmcars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.hireDataSet1.Table);
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\LANGA\Desktop\CarsDatabase methuli\Hire.mdf"";Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRPD_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRPD_Click(object sender, EventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtVRN.Text != "" && txtM.Text != "" && txtENG.Text != "" && txtDR.Text != "" && txtRPD.Text != "")
                {
                    cmd = new SqlCommand("insert into dbo.[Table](VehicleRegNo,Make,EngineSize,DateRegistered,RentalPerDay) values(@VRN,@M,@ENG,@DR,@RPD)", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@VRN", txtVRN.Text);
                    cmd.Parameters.AddWithValue("@M", txtM.Text);
                    cmd.Parameters.AddWithValue("@ENG", txtENG.Text);
                    cmd.Parameters.AddWithValue("@DR", txtDR.Text);
                    cmd.Parameters.AddWithValue("@RPD", txtRPD.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Car Details Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Please enter mandatory details!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
    
            }
        }
        



        private void displaydata()
        {
            throw new NotImplementedException();
        }

        private void cleardata()
        {
            txtVRN.Clear();
            txtM.Clear();
            txtENG.Clear();
            txtDR.Clear();
            txtRPD.Clear();
            chkA.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtVRN.Text != "" && txtM.Text != "" && txtENG.Text != "" && txtDR.Text != "" && txtRPD.Text != "")
                {
                    cmd = new SqlCommand("update dbo.[Table]set Make=@M, EngineSize=@ENG, DateRegistered=@DR, RentalPerDay=@RPD where VehicleRegNo=@VRN", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@VRN", txtVRN.Text);
                    cmd.Parameters.AddWithValue("@M", txtM.Text);
                    cmd.Parameters.AddWithValue("@ENG", txtENG.Text);
                    cmd.Parameters.AddWithValue("@DR", txtDR.Text);
                    cmd.Parameters.AddWithValue("@RPD", txtRPD.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Car Details Updated Successfully");

                }
                else
                {
                    MessageBox.Show("Please enter mandatory details!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
              
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)

        {
            this.Hide();
            Frmsearch f2 = new Frmsearch();
            f2.Show();
        }
        
        
       
        private void chkA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtVRN.Clear();
            txtM.Clear();
            txtENG.Clear();
            txtDR.Clear();
            txtRPD.Clear();
            chkA.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrEmpty(txtVRN.Text))
                    cmd = new SqlCommand("DELETE FROM dbo. [Table] WHERE VehicleRegNo = @VRN", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@VRN", txtVRN.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                if (rowsAffected > 0) MessageBox.Show(" Deleted Successfully!");

                else MessageBox.Show("Car not found in the database.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            tableBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tableBindingSource.MoveFirst();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            tableBindingSource.MovePrevious();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tableBindingSource.MoveLast();
        }

        private void txtVRN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
