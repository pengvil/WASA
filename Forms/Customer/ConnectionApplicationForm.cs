using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class ConnectionApplicationForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ConnectionApplicationForm()
        {
            InitializeComponent();

            errorlblConn.Text = "";
            errorlblHold.Text = "";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string holdingNumber = txtHoldingNumber.Text.Trim();
            string connectionType = cmbConType.SelectedItem?.ToString();

            bool hasError = false;

            errorlblConn.Text = "";
            errorlblHold.Text = "";

            if (holdingNumber == "")
            {
                errorlblHold.Text = "Please enter your nid number";
                hasError = true;
            }

            if (connectionType == null || connectionType == "")
            {
                errorlblConn.Text = "Select a connection type";
                hasError = true;
            }

            if (hasError == true)
            {
                return;
            }

            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged-in user found. Please login again.");
                return;
            }

            int userID = LoginForm.LoggedInUserID;
            int customerID = 0;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string customerQuery = "SELECT CustomerID FROM Customers WHERE UserID = @UserID";

                SqlCommand customerCmd = new SqlCommand(customerQuery, conn);
                customerCmd.Parameters.AddWithValue("@UserID", userID);

                SqlDataAdapter customerAdp = new SqlDataAdapter(customerCmd);
                DataSet customerDs = new DataSet();
                customerAdp.Fill(customerDs);

                DataTable customerDt = customerDs.Tables[0];

                if (customerDt.Rows.Count == 0)
                {
                    MessageBox.Show("Customer record not found.");
                    return;
                }

                customerID = Convert.ToInt32(customerDt.Rows[0]["CustomerID"]);

                string checkQuery = @"SELECT ApplicationID 
                                      FROM ConnectionApplications 
                                      WHERE CustomerID = @CustomerID 
                                      AND ApprovalStatus = 'Pending'";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@CustomerID", customerID);

                SqlDataAdapter checkAdp = new SqlDataAdapter(checkCmd);
                DataSet checkDs = new DataSet();
                checkAdp.Fill(checkDs);

                DataTable checkDt = checkDs.Tables[0];

                if (checkDt.Rows.Count > 0)
                {
                    MessageBox.Show("You already have a pending connection application.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Submit a new connection application?",
                    "Confirm Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                string updateCustomerQuery = @"UPDATE Customers
                                               SET HoldingNumber = @HoldingNumber,
                                                   ConnectionType = @ConnectionType
                                               WHERE CustomerID = @CustomerID";

                SqlCommand updateCustomerCmd = new SqlCommand(updateCustomerQuery, conn);
                updateCustomerCmd.Parameters.AddWithValue("@HoldingNumber", holdingNumber);
                updateCustomerCmd.Parameters.AddWithValue("@ConnectionType", connectionType);
                updateCustomerCmd.Parameters.AddWithValue("@CustomerID", customerID);

                updateCustomerCmd.ExecuteNonQuery();

                string insertQuery = @"INSERT INTO ConnectionApplications
                                       (
                                           CustomerID,
                                           ApplicationDate,
                                           DocumentStatus,
                                           ApprovalStatus
                                       )
                                       VALUES
                                       (
                                           @CustomerID,
                                           GETDATE(),
                                           'Pending',
                                           'Pending'
                                       )";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@CustomerID", customerID);

                int rows = insertCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Connection application submitted successfully!");

                    txtHoldingNumber.Clear();
                    cmbConType.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Failed to submit application. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting connection application: " + ex.Message);
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

        private void ConnectionApplicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}