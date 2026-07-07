using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class CustomerBillListForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public CustomerBillListForm()
        {
            InitializeComponent();
            LoadBills();
        }

        private void LoadBills()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    b.BillID,
                                    b.CustomerID,
                                    u.FullName AS CustomerName,
                                    c.MeterNumber,
                                    b.BillingMonth,
                                    b.PreviousReading,
                                    b.CurrentReading,
                                    b.Amount,
                                    b.Arrears,
                                    b.Status,
                                    b.CreatedAt
                                 FROM Bills b
                                 JOIN Customers c ON b.CustomerID = c.CustomerID
                                 JOIN Users u ON c.UserID = u.UserID
                                 ORDER BY b.CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvBills.DataSource = dt;
                dgvBills.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bills: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a bill first.");
                return;
            }

            int billID = Convert.ToInt32(dgvBills.SelectedRows[0].Cells["BillID"].Value);
            string status = dgvBills.SelectedRows[0].Cells["Status"].Value.ToString();

            if (status == "Paid")
            {
                MessageBox.Show("This bill is already paid.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Mark this bill as Paid?",
                "Confirm Payment Status",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE Bills SET Status='Paid' WHERE BillID=" + billID;

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Bill marked as Paid.");
                    LoadBills();
                }
                else
                {
                    MessageBox.Show("Bill status was not updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating bill status: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}