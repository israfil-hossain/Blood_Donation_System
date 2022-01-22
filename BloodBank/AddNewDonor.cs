using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void AddNewDonor_Load(object sender,EventArgs e)
        {
            string query = "select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            // Here generate a Problem , input string not in correct format . 
            //int count =Convert.Int32(ds.Tables[0].Rows[0][0]);
            int count = 0;
            int.TryParse(ds.Tables[0].Rows[0][0].ToString(),out count);
            labelNewID.Text = (count+1).ToString();

           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtFather.Text !="" && txtMother.Text !="" && txtDOB.Text !="" && txtMobile.Text !="" &&txtGender.Text != "" && txtEmail.Text !="" && txtCity.Text !="" && txtBloodGroup.Text !="" && txtAddress.Text !="" )
            {
                string dname = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string bgroup = txtBloodGroup.Text;
                string city = txtCity.Text;
                string address = txtAddress.Text;

                string query = "insert into newDonor(dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values('"+dname+"','"+fname+"','"+mname+"','"+dob+"',"+mobile+",'"+gender+"','"+email+"','"+bgroup+"','"+city+"','"+address+"')";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtMobile.Clear();
            txtGender.ResetText();
            txtEmail.Clear();
            txtBloodGroup.ResetText();
            txtCity.Clear();
            txtAddress.Clear();


        }
    }
}
