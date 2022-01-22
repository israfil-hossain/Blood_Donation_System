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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void addNewDonarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();
            and.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonarDetails udd = new UpdateDonarDetails();
            udd.Show();
        }

        private void allDonarDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails add = new AllDonorDetails();
            add.Show();
        }
    }
}
