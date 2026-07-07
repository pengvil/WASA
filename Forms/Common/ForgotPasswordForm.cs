using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class ForgotPasswordForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string newPass = txtNewPassword.Text;
            string confirm = txtConfirm.Text;

            if (email == "" && newPass == "" && confirm == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (email == "")
            {
                MessageBox.Show("Please enter your email.");
                txtEmail.Focus();
                return;
            }

            if (newPass == "")
            {
                MessageBox.Show("Please enter new password.");
                txtNewPassword.Focus();
                return;
            }

            if (confirm == "")
            {
                MessageBox.Show("Please confirm your password.");
                txtConfirm.Focus();
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Invalid email address.");
                txtEmail.Focus();
                return;
            }

            if (newPass.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.");
                txtNewPassword.Focus();
                return;
            }

            if (newPass != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                txtConfirm.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string checkQuery = @"SELECT UserID, Email 
                                      FROM Users 
                                      WHERE Email = @Email";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Email", email);

                SqlDataAdapter adp = new SqlDataAdapter(checkCmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No account found with this email.");
                    txtEmail.Focus();
                    return;
                }

                string updateQuery = @"UPDATE Users
                                       SET Password = @NewPassword
                                       WHERE Email = @Email";

                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@NewPassword", newPass);
                updateCmd.Parameters.AddWithValue("@Email", email);

                int rows = updateCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Password reset successfully. You can now log in.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not reset password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Password reset error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}