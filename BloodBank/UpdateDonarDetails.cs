using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class UpdateDonarDetails : Form
    {
        function fn = new function();
        public UpdateDonarDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDonorID.Text.ToString());
            String query = "select * from newDonor where did = "+id+"";  //get data from database
            DataSet ds = fn.getData(query); //return a dataset 
            
            if(ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][3].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][10].ToString();

            }
            else
            {
                MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorID.Text =="")
            {
                txtName.Clear();
                txtFather.Clear();
                txtMother.Clear();
                txtDOB.ResetText();
                txtMobile.Clear();
                txtGender.ResetText();
                txtEmail.Clear();
                txtBloodGroup.ResetText();
                txtCity.Clear();
                txtAddress.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String query = "update newDonor set dname ='"+txtName.Text+"',fname ='"+txtFather.Text+"',mname='"+txtMother.Text+"',dob='"+txtDOB.Text+"',mobile='"+txtMobile.Text+"',gender='"+txtGender.Text+"',email='"+txtEmail.Text+"',bloodgroup='"+txtBloodGroup.Text+"',city='"+txtCity.Text+"',daddress='"+txtAddress.Text+"' where did ="+txtDonorID.Text+"";
            fn.setData(query);
            UpdateDonarDetails_Load(this,null);
        }

        private void UpdateDonarDetails_Load(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }
    }
}
