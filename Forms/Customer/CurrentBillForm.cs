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
    public partial class CurrentBillForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        int currentBillID = 0;
        int currentCustomerID = 0;
        string currentBillStatus = "";

        public CurrentBillForm()
        {
            InitializeComponent();
            LoadBill();
        }

        private void LoadBill()
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                lblBillID.Text = "No logged-in user.";
                lblMonth.Text = "";
                lblUnits.Text = "";
                lblAmount.Text = "";
                lblArrears.Text = "";
                lblTotal.Text = "";
                lblStatus.Text = "";

                btnDispute.Enabled = false;
                return;
            }

            int userID = LoginForm.LoggedInUserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT TOP 1
                                    b.BillID,
                                    b.CustomerID,
                                    b.BillingMonth,
                                    b.PreviousReading,
                                    b.CurrentReading,
                                    b.Amount,
                                    b.Arrears,
                                    b.Status,
                                    b.CreatedAt
                                 FROM Bills b
                                 JOIN Customers c ON b.CustomerID = c.CustomerID
                                 WHERE c.UserID = " + userID + @"
                                 ORDER BY b.CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    lblBillID.Text = "No bills found.";
                    lblMonth.Text = "";
                    lblUnits.Text = "";
                    lblAmount.Text = "";
                    lblArrears.Text = "";
                    lblTotal.Text = "";
                    lblStatus.Text = "";

                    btnDispute.Enabled = false;
                    return;
                }

                DataRow row = dt.Rows[0];

                currentBillID = Convert.ToInt32(row["BillID"]);
                currentCustomerID = Convert.ToInt32(row["CustomerID"]);
                currentBillStatus = row["Status"].ToString();

                int previousReading = Convert.ToInt32(row["PreviousReading"]);
                int currentReading = Convert.ToInt32(row["CurrentReading"]);
                int unitsUsed = currentReading - previousReading;

                decimal amount = Convert.ToDecimal(row["Amount"]);
                decimal arrears = Convert.ToDecimal(row["Arrears"]);
                decimal totalDue = amount + arrears;

                lblBillID.Text = "Bill #" + currentBillID;
                lblMonth.Text = "Month: " + row["BillingMonth"].ToString();

                lblUnits.Text = "Previous: " + previousReading +
                                "  |  Current: " + currentReading +
                                "  |  Units Used: " + unitsUsed;

                lblAmount.Text = "Bill Amount: Tk. " + amount.ToString("N2");
                lblArrears.Text = "Arrears: Tk. " + arrears.ToString("N2");
                lblTotal.Text = "Total Due: Tk. " + totalDue.ToString("N2");
                lblStatus.Text = "Status: " + currentBillStatus;

                if (currentBillStatus == "Paid")
                {
                    lblStatus.ForeColor = Color.Green;
                    btnDispute.Enabled = false;
                    btnPayBill.Enabled = false;
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    btnDispute.Enabled = true;
                    btnPayBill.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading current bill: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CurrentBillForm_Load(object sender, EventArgs e)
        {

        }

        private void panelBill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMonth_Click(object sender, EventArgs e)
        {

        }

        private void lblBillID_Click(object sender, EventArgs e)
        {

        }

        private void lblUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblArrears_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnDispute_Click(object sender, EventArgs e)
        {
            new SubmitBillDisputeForm(currentBillID).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            if (currentBillStatus == "Disputed")
            {
                MessageBox.Show("This bill is currently disputed. Please wait for dispute review before payment.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to pay this bill?",
                "Confirm Payment",
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

                string billQuery = @"SELECT BillID, CustomerID, Amount, Arrears, Status
                             FROM Bills
                             WHERE BillID = @BillID
                             AND CustomerID = @CustomerID";

                SqlCommand billCmd = new SqlCommand(billQuery, conn);
                billCmd.Parameters.AddWithValue("@BillID", currentBillID);
                billCmd.Parameters.AddWithValue("@CustomerID", currentCustomerID);

                SqlDataAdapter adp = new SqlDataAdapter(billCmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bill not found.");
                    return;
                }

                string billStatus = dt.Rows[0]["Status"].ToString();

                if (billStatus == "Paid")
                {
                    MessageBox.Show("This bill is already paid.");
                    LoadBill();
                    return;
                }

                if (billStatus == "Disputed")
                {
                    MessageBox.Show("This bill is currently disputed. Please wait for dispute review before payment.");
                    LoadBill();
                    return;
                }

                decimal amount = Convert.ToDecimal(dt.Rows[0]["Amount"]);
                decimal arrears = Convert.ToDecimal(dt.Rows[0]["Arrears"]);
                decimal totalPayable = amount + arrears;

                string receiptNo = "RCPT-" + DateTime.Now.ToString("yyyyMMddHHmmss");

                string insertPaymentQuery = @"INSERT INTO Payments
                                      (
                                          BillID,
                                          CustomerID,
                                          PaymentDate,
                                          Amount,
                                          Method,
                                          ReceiptNo
                                      )
                                      VALUES
                                      (
                                          @BillID,
                                          @CustomerID,
                                          GETDATE(),
                                          @Amount,
                                          @Method,
                                          @ReceiptNo
                                      )";

                SqlCommand paymentCmd = new SqlCommand(insertPaymentQuery, conn);
                paymentCmd.Parameters.AddWithValue("@BillID", currentBillID);
                paymentCmd.Parameters.AddWithValue("@CustomerID", currentCustomerID);
                paymentCmd.Parameters.AddWithValue("@Amount", totalPayable);
                paymentCmd.Parameters.AddWithValue("@Method", "Cash");
                paymentCmd.Parameters.AddWithValue("@ReceiptNo", receiptNo);

                int paymentRows = paymentCmd.ExecuteNonQuery();

                if (paymentRows > 0)
                {
                    string updateBillQuery = @"UPDATE Bills
                                       SET Status = 'Paid'
                                       WHERE BillID = @BillID";

                    SqlCommand updateBillCmd = new SqlCommand(updateBillQuery, conn);
                    updateBillCmd.Parameters.AddWithValue("@BillID", currentBillID);

                    int billRows = updateBillCmd.ExecuteNonQuery();

                    if (billRows > 0)
                    {
                        MessageBox.Show("Bill paid successfully.\nReceipt No: " + receiptNo);

                        currentBillStatus = "Paid";
                        LoadBill();
                    }
                    else
                    {
                        MessageBox.Show("Payment saved, but bill status was not updated.");
                    }
                }
                else
                {
                    MessageBox.Show("Payment failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
