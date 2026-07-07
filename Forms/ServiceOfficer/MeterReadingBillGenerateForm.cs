using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class MeterReadingBillGenerateForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public MeterReadingBillGenerateForm()
        {
            InitializeComponent();

            txtBillingMonth.Text = DateTime.Now.ToString("MMMM yyyy");
            txtArrears.Text = "0";

            txtPrevious.ReadOnly = true;

            LoadCustomers();

            if (cmbCustomer.Items.Count > 0)
            {
                LoadPreviousReading();
            }
        }
        private void LoadPreviousReading()
        {

            int customerID;

            if (!int.TryParse(cmbCustomer.SelectedValue.ToString(), out customerID))
            {
                txtPrevious.Text = "0";
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT TOP 1 CurrentReading
                         FROM Bills
                         WHERE CustomerID = @CustomerID
                         ORDER BY CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    txtPrevious.Text = dt.Rows[0]["CurrentReading"].ToString();
                }
                else
                {
                    txtPrevious.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading previous reading: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadCustomers()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                    c.CustomerID,
                    c.ConnectionType,
                    CONCAT(
                        u.FullName, 
                        ' - Meter: ', 
                        ISNULL(CAST(c.MeterNumber AS VARCHAR(20)), 'N/A'),
                        ' - ',
                        c.ConnectionType
                    ) AS CustomerDisplay
                 FROM Customers c
                 JOIN Users u ON c.UserID = u.UserID
                 ORDER BY u.FullName";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "CustomerDisplay";
                cmbCustomer.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (txtBillingMonth.Text == "")
            {
                MessageBox.Show("Enter billing month.");
                return;
            }

            int officerID = LoginForm.LoggedInUserID;

            if (officerID == 0)
            {
                MessageBox.Show("No logged in service officer found. Please login again.");
                return;
            }

            int previousReading;
            int currentReading;

            if (!int.TryParse(txtPrevious.Text, out previousReading))
            {
                MessageBox.Show("Enter a valid previous meter reading.");
                return;
            }

            if (!int.TryParse(txtCurrent.Text, out currentReading))
            {
                MessageBox.Show("Enter a valid current meter reading.");
                return;
            }

            if (currentReading <= previousReading)
            {
                MessageBox.Show("Current reading must be greater than previous reading.");
                txtCurrent.Focus();
                return;
            }

            decimal arrears;

            if (txtArrears.Text == "")
            {
                arrears = 0;
            }
            else if (!decimal.TryParse(txtArrears.Text, out arrears))
            {
                MessageBox.Show("Enter a valid arrears amount.");
                return;
            }

            if (arrears < 0)
            {
                MessageBox.Show("Arrears cannot be negative.");
                return;
            }

            int customerID = Convert.ToInt32(cmbCustomer.SelectedValue);
            string billingMonth = txtBillingMonth.Text.Trim().Replace("'", "''");

            DataRowView selectedCustomer = (DataRowView)cmbCustomer.SelectedItem;
            string connectionType = selectedCustomer["ConnectionType"].ToString();

            int unitsUsed = currentReading - previousReading;
            decimal ratePerUnit = 0;

            if (connectionType == "Residential")
            {
                ratePerUnit = 8.0m;
            }
            else if (connectionType == "Commercial")
            {
                ratePerUnit = 12.0m;
            }
            else if (connectionType == "Industrial")
            {
                ratePerUnit = 14.0m;
            }
            else
            {
                MessageBox.Show("Invalid connection type for this customer.");
                return;
            }

            decimal amount = unitsUsed * ratePerUnit;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"INSERT INTO Bills
                (
                    CustomerID,
                    BillingMonth,
                    PreviousReading,
                    CurrentReading,
                    Amount,
                    Arrears,
                    Status,
                    CreatedAt,
                    GeneratedBy
                )
                VALUES
                (
                    @CustomerID,
                    @BillingMonth,
                    @PreviousReading,
                    @CurrentReading,
                    @Amount,
                    @Arrears,
                    'Unpaid',
                    GETDATE(),
                    @GeneratedBy
                )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@BillingMonth", billingMonth);
                cmd.Parameters.AddWithValue("@PreviousReading", previousReading);
                cmd.Parameters.AddWithValue("@GeneratedBy", officerID);
                cmd.Parameters.AddWithValue("@CurrentReading", currentReading);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Arrears", arrears);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Bill generated successfully!\n\n" +
                        "Connection Type: " + connectionType + "\n" +
                        "Units Used: " + unitsUsed + "\n" +
                        "Rate Per Unit: Tk. " + ratePerUnit.ToString("N2") + "\n" +
                        "Amount: Tk. " + amount.ToString("N2") + "\n" +
                        "Arrears: Tk. " + arrears.ToString("N2") + "\n" +
                        "Total Due: Tk. " + (amount + arrears).ToString("N2")
                    );

                    txtCurrent.Text = "";
                    txtArrears.Text = "0";
                    txtBillingMonth.Text = DateTime.Now.ToString("MMMM yyyy");

                    LoadPreviousReading();
                }
                else
                {
                    MessageBox.Show("Bill was not generated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating bill: " + ex.Message);
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

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPreviousReading();
        }
    }
}