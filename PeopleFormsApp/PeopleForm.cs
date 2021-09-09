using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalTestSemester2;


namespace PeopleFormsApp
{
    public partial class PeopleForm : Form
    {
        People people = new People();
        public PeopleForm()
        {
            InitializeComponent();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            numAge.Value = 0;
            rbAndroid.Checked = false;
            rbApple.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age = (int)numAge.Value;
            
            if (firstName.Length > 0 && lastName.Length > 0)
            {
                Person newPerson = new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };
                if (rbAndroid.Checked)
                {
                    newPerson.MobileType = MobileType.Android;
                }
                else if (rbApple.Checked)
                {
                    newPerson.MobileType = MobileType.Apple;
                }
                else
                {
                    newPerson.MobileType = MobileType.None;
                }
                people.Add(newPerson);
                string allPeople = people.GetAllPeople().Count().ToString();
                lblTotalPeople.Text = $"Total People: {allPeople}";
                btnClear.PerformClick();
            }
            else
            {
                MessageBox.Show("You cannot leave first and last names empty");
            } 
        }


        private void rbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            dgvPeople.DataSource = null;
            dgvPeople.Rows.Clear();
            if (rbShowAll.Checked)
            {
                dgvPeople.DataSource = people.GetAllPeople();
                string allPeople = dgvPeople.Rows.Count.ToString();
                lblTotalPeople.Text = $"Total People: {allPeople}";
                lblVisiblePeople.Text = $"Visible People: {allPeople}";
            }
        }

        private void rbShowApple_CheckedChanged(object sender, EventArgs e)
        {
            dgvPeople.DataSource = null;
            dgvPeople.Rows.Clear();
            if (rbShowApple.Checked)
            {
                string allPeople = people.GetAllPeople().Count().ToString();
                dgvPeople.DataSource = people.GetApplePeople();
                string visiblePeople = dgvPeople.Rows.Count.ToString();
                lblTotalPeople.Text = $"Total People: {allPeople}";
                lblVisiblePeople.Text = $"Visible People: {visiblePeople}";
            }     
        }

        private void rbShowAndroid_CheckedChanged(object sender, EventArgs e)
        {
            dgvPeople.DataSource = null;
            dgvPeople.Rows.Clear();
            if (rbShowAndroid.Checked)
            {
                string allPeople = people.GetAllPeople().Count().ToString();
                dgvPeople.DataSource = people.GetAndroidPeople();
                string visiblePeople = dgvPeople.Rows.Count.ToString();
                lblTotalPeople.Text = $"Total People: {allPeople}";
                lblVisiblePeople.Text = $"Visible People: {visiblePeople}";
            }     
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            people.Clear();
            dgvPeople.DataSource = null;
            dgvPeople.Rows.Clear();
        }

        private void rbShowApple_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
