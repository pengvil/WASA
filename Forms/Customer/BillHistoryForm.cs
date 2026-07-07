using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class BillHistoryForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public BillHistoryForm()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged in customer found. Please login again.");
                return;
            }

            int userID = LoginForm.LoggedInUserID;

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
                                    (b.Amount + b.Arrears) AS TotalDue,
                                    b.Status,
                                    b.CreatedAt
                                 FROM Bills b
                                 JOIN Customers c ON b.CustomerID = c.CustomerID
                                 JOIN Users u ON c.UserID = u.UserID
                                 WHERE c.UserID = " + userID + @"
                                 ORDER BY b.CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvBills.DataSource = dt;
                dgvBills.AutoGenerateColumns = true;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No bill history found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bill history: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BillHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
