using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ReviewDisputesForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";
        int billID = 0;

        public ReviewDisputesForm()
        {
            InitializeComponent();
            btnCorrectBill.Enabled = false;
            LoadDisputes();
        }

        private void LoadDisputes()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    d.DisputeID,
                                    d.BillID,
                                    d.CustomerID,
                                    u.FullName AS CustomerName,
                                    b.BillingMonth,
                                    b.Amount AS BillAmount,
                                    d.Reason,
                                    d.Status,
                                    d.ReviewedBy,
                                    d.SubmittedAt
                                 FROM BillDisputes d
                                 JOIN Customers c ON d.CustomerID = c.CustomerID
                                 JOIN Users u ON c.UserID = u.UserID
                                 JOIN Bills b ON d.BillID = b.BillID
                                 ORDER BY d.SubmittedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvDisputes.DataSource = dt;
                dgvDisputes.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading disputes: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnMarkReviewed_Click(object sender, EventArgs e)
        {
            if (dgvDisputes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a dispute first.");
                return;
            }

            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged in user found. Please login again.");
                return;
            }

            int disputeID = Convert.ToInt32(dgvDisputes.SelectedRows[0].Cells["DisputeID"].Value);
            billID = Convert.ToInt32(dgvDisputes.SelectedRows[0].Cells["BillID"].Value);

            string currentStatus = dgvDisputes.SelectedRows[0].Cells["Status"].Value.ToString();

            if (currentStatus == "Reviewed")
            {
                MessageBox.Show("This dispute is already reviewed.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Mark this dispute as Reviewed?",
                "Confirm Review",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            int reviewedBy = LoginForm.LoggedInUserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE BillDisputes SET Status='Reviewed', ReviewedBy=" + reviewedBy +
                               " WHERE DisputeID=" + disputeID;

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Dispute marked as Reviewed. You can now open Correct Bill to adjust the amount.");
                    LoadDisputes();
                    btnCorrectBill.Enabled = true;
                    btnCorrectBill.Focus();
                }
                else
                {
                    MessageBox.Show("Dispute was not updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reviewing dispute: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    LoadDisputes();
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCorrectBill_Click(object sender, EventArgs e)
        {

            CorrectBillForm form = new CorrectBillForm(billID);
            form.ShowDialog();

            LoadDisputes();
        }
    }
}