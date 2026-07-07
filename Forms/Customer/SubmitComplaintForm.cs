using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WaterSewageManagementSystem;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class SubmitComplaintForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public SubmitComplaintForm()
        {
            InitializeComponent();
        }

        private void SubmitComplaintForm_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblPriority_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged-in user found. Please login again.");
                return;
            }

            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please describe your complaint.");
                return;
            }

            int userID = LoginForm.LoggedInUserID;
            int customerID = 0;

            string category = "Other";
            string priority = "Medium";

            if (cmbCategory.SelectedItem != null)
            {
                category = cmbCategory.SelectedItem.ToString();
            }

            if (cmbPriority.SelectedItem != null)
            {
                priority = cmbPriority.SelectedItem.ToString();
            }

            string description = txtDescription.Text.Trim();

            category = category.Replace("'", "''");
            priority = priority.Replace("'", "''");
            description = description.Replace("'", "''");

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string customerQuery = "SELECT CustomerID FROM Customers WHERE UserID = " + userID;

                SqlCommand customerCmd = new SqlCommand(customerQuery, conn);

                object customerResult = customerCmd.ExecuteScalar();

                if (customerResult == null)
                {
                    MessageBox.Show("Customer record not found.");
                    return;
                }

                customerID = Convert.ToInt32(customerResult);

                string insertQuery = "INSERT INTO Complaints " +
                                     "(CustomerID, Category, Description, Priority, Status, DateSubmitted) " +
                                     "VALUES (" +
                                     customerID + ", '" +
                                     category + "', '" +
                                     description + "', '" +
                                     priority + "', 'Pending', GETDATE())";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                int rows = insertCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Complaint submitted successfully. We will attend to it shortly.");

                    txtDescription.Text = "";

                    if (cmbCategory.Items.Count > 0)
                    {
                        cmbCategory.SelectedIndex = 0;
                    }

                    if (cmbPriority.Items.Count > 0)
                    {
                        cmbPriority.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to submit complaint. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting complaint: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
