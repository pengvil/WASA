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
    public partial class SubmitBillDisputeForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        private int _preloadedBillID;

        public SubmitBillDisputeForm()
        {
            InitializeComponent();
            _preloadedBillID = 0;
        }

        public SubmitBillDisputeForm(int billID)
        {
            InitializeComponent();

            _preloadedBillID = billID;
            txtBillID.Text = billID.ToString();
            txtBillID.ReadOnly = true;
        }

        private void SubmitBillDisputeForm_Load(object sender, EventArgs e)
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

        private void txtBillID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBillID_Click(object sender, EventArgs e)
        {

        }

        private void lblReason_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            int billID;
            if (!int.TryParse(txtBillID.Text, out billID))
            {
                MessageBox.Show("Enter a valid Bill ID.");
                return;
            }

            if (txtReason.Text.Trim() == "")
            {
                MessageBox.Show("Please describe your reason.");
                return;
            }

            int userID = LoginForm.LoggedInUserID;
            int customerID = 0;

            string reason = txtReason.Text.Trim();
            reason = reason.Replace("'", "''");

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

                string billCheckQuery = "SELECT COUNT(*) FROM Bills " +
                                        "WHERE BillID = " + billID +
                                        " AND CustomerID = " + customerID;

                SqlCommand billCheckCmd = new SqlCommand(billCheckQuery, conn);

                int billCount = Convert.ToInt32(billCheckCmd.ExecuteScalar());

                if (billCount == 0)
                {
                    MessageBox.Show("Bill not found for your account.");
                    return;
                }

                string statusQuery = "SELECT Status FROM Bills WHERE BillID = " + billID;

                SqlCommand statusCmd = new SqlCommand(statusQuery, conn);

                object statusResult = statusCmd.ExecuteScalar();

                if (statusResult != null && statusResult.ToString() == "Paid")
                {
                    MessageBox.Show("Paid bill cannot be disputed.");
                    return;
                }

                string pendingCheckQuery = "SELECT COUNT(*) FROM BillDisputes " +
                                           "WHERE BillID = " + billID +
                                           " AND CustomerID = " + customerID +
                                           " AND Status = 'Pending'";

                SqlCommand pendingCheckCmd = new SqlCommand(pendingCheckQuery, conn);

                int pendingCount = Convert.ToInt32(pendingCheckCmd.ExecuteScalar());

                if (pendingCount > 0)
                {
                    MessageBox.Show("You already have a pending dispute for this bill.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Submit dispute for this bill?",
                    "Confirm Dispute",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                string insertQuery = "INSERT INTO BillDisputes " +
                                     "(BillID, CustomerID, Reason, Status, SubmittedAt) " +
                                     "VALUES (" +
                                     billID + ", " +
                                     customerID + ", '" +
                                     reason + "', 'Pending', GETDATE())";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                int rows = insertCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    string updateQuery = "UPDATE Bills SET Status = 'Disputed' WHERE BillID = " + billID;

                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Dispute submitted. A Service Officer will review it.");

                    txtReason.Text = "";

                    if (_preloadedBillID == 0)
                    {
                        txtBillID.Text = "";
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dispute was not submitted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting dispute: " + ex.Message);
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
