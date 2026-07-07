using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public static int LoggedInUserID;
        public static string LoggedInFullName;
        public static string LoggedInEmail;
        public static string LoggedInRole;
        public static string LoggedInStatus;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (email == "" && password == "")
            {
                MessageBox.Show("Please enter your email and password.");
                return;
            }

            if (email == "")
            {
                MessageBox.Show("Please enter your email.");
                txtEmail.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT UserID, FullName, Email, Role, Status
                                 FROM Users
                                 WHERE Email = @Email
                                 AND [Password] = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    int userID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    string fullName = dt.Rows[0]["FullName"].ToString();
                    string userEmail = dt.Rows[0]["Email"].ToString();
                    string role = dt.Rows[0]["Role"].ToString();
                    string status = dt.Rows[0]["Status"].ToString();

                    if (status != "Active")
                    {
                        MessageBox.Show("Your account is not active. Please wait for admin approval.");
                        return;
                    }

                    LoggedInUserID = userID;
                    LoggedInFullName = fullName;
                    LoggedInEmail = userEmail;
                    LoggedInRole = role;
                    LoggedInStatus = status;

                    Form dashboard = null;

                    if (role == "Admin")
                    {
                        dashboard = new Forms.Admin.AdminDashboardForm();
                    }
                    else if (role == "Customer")
                    {
                        dashboard = new Forms.Customer.CustomerDashboardForm();
                    }
                    else if (role == "ServiceOfficer")
                    {
                        dashboard = new Forms.ServiceOfficer.ServiceOfficerDashboardForm();
                    }
                    else if (role == "MaintenanceEngineer")
                    {
                        dashboard = new Forms.MaintenanceEngineer.MaintenanceDashboardForm();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role. Please contact admin.");
                        return;
                    }

                    this.Hide();
                    dashboard.FormClosed += (s, args) => this.Close();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                    txtPassword.Clear();
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Common.RegisterForm form = new Forms.Common.RegisterForm();
            form.ShowDialog();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Common.ForgotPasswordForm form = new Forms.Common.ForgotPasswordForm();
            form.ShowDialog();
        }

        private void login_close_clicked(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}