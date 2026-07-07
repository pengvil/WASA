using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class CorrectBillForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";
        decimal selectedArrears = 0;

        public CorrectBillForm(int billID)
        {
            InitializeComponent();

            txtBillID.Text = billID.ToString();
            txtBillID.ReadOnly = true;
            LoadBillByID(billID);
        }
        private void LoadBillByID(int billID)
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
                            b.Amount,
                            b.Arrears,
                            b.Status
                         FROM Bills b
                         JOIN Customers c ON b.CustomerID = c.CustomerID
                         JOIN Users u ON c.UserID = u.UserID
                         WHERE b.BillID = @BillID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BillID", billID);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bill not found.");
                    lblBillInfo.Text = "";
                    txtNewAmount.Text = "";
                    txtNewAmount.Enabled = false;
                    btnSave.Enabled = false;
                    return;
                }

                DataRow row = dt.Rows[0];

                decimal amount = Convert.ToDecimal(row["Amount"]);
                selectedArrears = Convert.ToDecimal(row["Arrears"]);
                decimal totalAmount = amount + selectedArrears;

                lblBillInfo.Text = "Customer: " + row["CustomerName"].ToString()
                                    + " | Meter: " + row["MeterNumber"].ToString()
                                    + " | Month: " + row["BillingMonth"].ToString()
                                    + " | Arrears: " + selectedArrears.ToString("N2")
                                    + " | Status: " + row["Status"].ToString();

                txtNewAmount.Text = totalAmount.ToString("N2");

                txtNewAmount.Enabled = true;
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bill: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBillID.Text == "")
            {
                MessageBox.Show("Enter Bill ID.");
                return;
            }

            int billID;

            if (!int.TryParse(txtBillID.Text, out billID))
            {
                MessageBox.Show("Enter a valid Bill ID.");
                return;
            }

            decimal newTotalAmount;

            if (!decimal.TryParse(txtNewAmount.Text, out newTotalAmount))
            {
                MessageBox.Show("Enter a valid corrected total amount.");
                return;
            }

            if (newTotalAmount <= 0)
            {
                MessageBox.Show("Corrected total amount must be greater than 0.");
                return;
            }

            decimal newBillAmount = newTotalAmount - selectedArrears;

            if (newBillAmount < 0)
            {
                MessageBox.Show("Corrected total amount cannot be less than arrears.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Correct this bill total amount to Tk. " + newTotalAmount.ToString("N2") + "?",
                "Confirm Correction",
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

                string query = @"UPDATE Bills
                 SET Amount = @Amount,
                     Status = 'Unpaid'
                 WHERE BillID = @BillID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Amount", newBillAmount);
                cmd.Parameters.AddWithValue("@BillID", billID);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Bill amount corrected successfully. Bill is now unpaid and ready for payment.");

                    txtBillID.Text = "";
                    txtNewAmount.Text = "";
                    lblBillInfo.Text = "";

                    selectedArrears = 0;

                    txtNewAmount.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Bill correction failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error correcting bill: " + ex.Message);
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