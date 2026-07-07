using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public CustomerDashboardForm()
        {
            InitializeComponent();
            LoadDashboardCounts();
            SetWelcomeText();
            LoadNotices();
        }

        private void LoadDashboardData()
        {
            LoadDashboardCounts();
            LoadNotices();

        }

        private void SetWelcomeText()
        {
            if (!string.IsNullOrWhiteSpace(LoginForm.LoggedInFullName))
            {
                lblWelcome.Text = "Welcome, " + LoginForm.LoggedInFullName;
            }
            else
            {
                lblWelcome.Text = "Welcome, Customer";
            }
        }

        private void LoadDashboardCounts()
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                lblBillCount.Text = "0";
                lblHistoryCount.Text = "0";
                lblComplaintCount.Text = "0";
                lblApplicationCount.Text = "N/A";
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                int customerID = 0;

                string customerQuery = "SELECT CustomerID FROM Customers WHERE UserID = " + LoginForm.LoggedInUserID;
                SqlCommand customerCmd = new SqlCommand(customerQuery, conn);

                object customerResult = customerCmd.ExecuteScalar();

                if (customerResult == null || customerResult == DBNull.Value)
                {
                    lblBillCount.Text = "0";
                    lblHistoryCount.Text = "0";
                    lblComplaintCount.Text = "0";
                    lblApplicationCount.Text = "N/A";
                    return;
                }

                customerID = Convert.ToInt32(customerResult);

                string currentBillQuery = "SELECT ISNULL(SUM(Amount + Arrears), 0) FROM Bills WHERE CustomerID = " + customerID + " AND Status = 'Unpaid'";
                SqlCommand currentBillCmd = new SqlCommand(currentBillQuery, conn);
                decimal currentBill = Convert.ToDecimal(currentBillCmd.ExecuteScalar());
                lblBillCount.Text = currentBill.ToString("N0");

                string billHistoryQuery = "SELECT COUNT(*) FROM Bills WHERE CustomerID = " + customerID;
                SqlCommand billHistoryCmd = new SqlCommand(billHistoryQuery, conn);
                int billHistoryCount = Convert.ToInt32(billHistoryCmd.ExecuteScalar());
                lblHistoryCount.Text = billHistoryCount.ToString();

                string complaintQuery = "SELECT COUNT(*) FROM Complaints WHERE CustomerID = " + customerID + " AND Status NOT IN ('Resolved', 'Closed')";
                SqlCommand complaintCmd = new SqlCommand(complaintQuery, conn);
                int openComplaintCount = Convert.ToInt32(complaintCmd.ExecuteScalar());
                lblComplaintCount.Text = openComplaintCount.ToString();

                string connectionQuery = "SELECT TOP 1 ApprovalStatus FROM ConnectionApplications WHERE CustomerID = " + customerID + " ORDER BY ApplicationDate DESC, ApplicationID DESC";
                SqlCommand connectionCmd = new SqlCommand(connectionQuery, conn);
                object connectionResult = connectionCmd.ExecuteScalar();

                if (connectionResult == null || connectionResult == DBNull.Value)
                {
                    lblApplicationCount.Text = "N/A";
                }
                else
                {
                    lblApplicationCount.Text = connectionResult.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard counts: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadNotices()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            NoticeID,
                            Title,
                            Description,
                            Area,
                            NoticeType,
                            PublishedBy,
                            CONVERT(varchar(20), PublishDate, 106) AS PublishDate
                        FROM Notices
                        ORDER BY PublishDate DESC, NoticeID DESC;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dgvNotices.AutoGenerateColumns = true;
                        dgvNotices.DataSource = dt;

                        FormatNoticeGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading notices: " + ex.Message,
                    "Notice Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FormatNoticeGrid()
        {
            if (dgvNotices.Columns.Count == 0)
                return;

            dgvNotices.ReadOnly = true;
            dgvNotices.AllowUserToAddRows = false;
            dgvNotices.AllowUserToDeleteRows = false;
            dgvNotices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotices.MultiSelect = false;
            dgvNotices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotices.RowHeadersVisible = false;

            if (dgvNotices.Columns.Contains("NoticeID"))
                dgvNotices.Columns["NoticeID"].HeaderText = "Notice ID";

            if (dgvNotices.Columns.Contains("NoticeType"))
                dgvNotices.Columns["NoticeType"].HeaderText = "Notice Type";

            if (dgvNotices.Columns.Contains("PublishedBy"))
                dgvNotices.Columns["PublishedBy"].HeaderText = "Published By";

            if (dgvNotices.Columns.Contains("PublishDate"))
                dgvNotices.Columns["PublishDate"].HeaderText = "Publish Date";

            if (dgvNotices.Columns.Contains("Description"))
                dgvNotices.Columns["Description"].FillWeight = 180;
        }

        private void lblRecentRecords_Click(object sender, EventArgs e)
        {

        }

        private void dgvNotices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadNotices();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCurrentBill_Click(object sender, EventArgs e)
        {
            new CurrentBillForm().ShowDialog();
            LoadDashboardData();

        }

        private void btnBillHistory_Click(object sender, EventArgs e)
        {
            new BillHistoryForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnDispute_Click(object sender, EventArgs e)
        {
            new SubmitBillDisputeForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            new SubmitComplaintForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnTrackComplaint_Click(object sender, EventArgs e)
        {
            new TrackComplaintForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            new ConnectionApplicationForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnTrackApp_Click(object sender, EventArgs e)
        {
            new TrackApplicationForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().ShowDialog();
            LoadDashboardData();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm.LoggedInUserID = 0;
                LoginForm.LoggedInFullName = "";
                LoginForm.LoggedInEmail = "";
                LoginForm.LoggedInRole = "";
                LoginForm.LoggedInStatus = "";

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void cardBill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}
