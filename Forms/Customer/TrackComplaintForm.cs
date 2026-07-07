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
    public partial class TrackComplaintForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public TrackComplaintForm()
        {
            InitializeComponent();
            LoadComplaints();
        }

        private void LoadComplaints()
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged-in customer found. Please login again.");
                return;
            }

            int userID = LoginForm.LoggedInUserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    cm.ComplaintID,
                                    cm.CustomerID,
                                    cm.Category,
                                    cm.Description,
                                    cm.Priority,
                                    cm.Status,
                                    cm.DateSubmitted
                                 FROM Complaints cm
                                 JOIN Customers c ON cm.CustomerID = c.CustomerID
                                 WHERE c.UserID = " + userID + @"
                                 ORDER BY cm.DateSubmitted DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvComplaints.DataSource = dt;
                dgvComplaints.AutoGenerateColumns = true;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No complaints found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading complaints: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void TrackComplaintForm_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvComplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadComplaints();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
