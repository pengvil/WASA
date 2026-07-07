using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class NoticeManagementForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public NoticeManagementForm()
        {
            InitializeComponent();
            LoadNoticeTypes();
            LoadNotices();
        }

        private void LoadNoticeTypes()
        {
            if (cmbType.Items.Count == 0)
            {
                cmbType.Items.Add("General");
                cmbType.Items.Add("Maintenance");
                cmbType.Items.Add("Emergency");
                cmbType.Items.Add("Water Supply");
                cmbType.Items.Add("Low Pressure");
            }

            if (cmbType.SelectedIndex == -1)
            {
                cmbType.SelectedIndex = 0;
            }
        }

        private void LoadNotices()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    n.NoticeID,
                                    n.Title,
                                    n.Description,
                                    n.Area,
                                    n.NoticeType,
                                    n.PublishedBy,
                                    u.FullName AS PublishedByName,
                                    n.PublishDate
                                 FROM Notices n
                                 JOIN Users u ON n.PublishedBy = u.UserID
                                 ORDER BY n.PublishDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvNotices.DataSource = dt;
                dgvNotices.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notices: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged in user found. Please login again.");
                return;
            }

            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string area = txtArea.Text.Trim();
            string noticeType = cmbType.SelectedItem?.ToString();

            if (title == "")
            {
                MessageBox.Show("Title is required.");
                txtTitle.Focus();
                return;
            }

            if (description == "")
            {
                MessageBox.Show("Description is required.");
                txtDescription.Focus();
                return;
            }

            if (noticeType == null || noticeType == "")
            {
                noticeType = "General";
            }

            int publishedBy = LoginForm.LoggedInUserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"INSERT INTO Notices
                                 (Title, Description, Area, NoticeType, PublishedBy, PublishDate)
                                 VALUES
                                 (@Title, @Description, @Area, @NoticeType, @PublishedBy, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Area", area);
                cmd.Parameters.AddWithValue("@NoticeType", noticeType);
                cmd.Parameters.AddWithValue("@PublishedBy", publishedBy);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Notice published.");
                    txtTitle.Clear();
                    txtDescription.Clear();
                    txtArea.Clear();
                    LoadNotices();
                }
                else
                {
                    MessageBox.Show("Failed to publish notice.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error publishing notice: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a notice to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvNotices.SelectedRows[0].Cells["NoticeID"].Value);

            DialogResult result = MessageBox.Show(
                "Delete this notice?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "DELETE FROM Notices WHERE NoticeID=" + id;
                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Notice deleted.");
                    LoadNotices();
                }
                else
                {
                    MessageBox.Show("Notice was not deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting notice: " + ex.Message);
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

        private void NoticeManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void lblNTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
