using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class RegisterForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public RegisterForm()
        {
            InitializeComponent();

            errorlblAdress.Text = "";
            errorlblConfPass.Text = "";
            errorlblPhone.Text = "";
            errorlblEmail.Text = "";
            errorlblGender.Text = "";
            errorlblName.Text = "";
            errorlblPass.Text = "";
            errorlblRole.Text = "";
            errorlblPassNotMatch.Text = "";
            errorlblDOB.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirmPass = txtConfirmPass.Text;
            string role = cmbRole.SelectedItem?.ToString();
            string address = txtAddress.Text.Trim();
            string gender = "";
            DateTime dob = dateTimePickerDOB.Value.Date;

            if (radioButton_Male.Checked)
            {
                gender = "Male";
            }
            else if (radioButton_Female.Checked)
            {
                gender = "Female";
            }

            bool hasError = false;

            errorlblAdress.Text = "";
            errorlblConfPass.Text = "";
            errorlblPhone.Text = "";
            errorlblEmail.Text = "";
            errorlblGender.Text = "";
            errorlblName.Text = "";
            errorlblPass.Text = "";
            errorlblRole.Text = "";
            errorlblPassNotMatch.Text = "";
            errorlblDOB.Text = "";

            if (name == "")
            {
                errorlblName.Text = "Please enter your name";
                hasError = true;
            }

            if (email == "")
            {
                errorlblEmail.Text = "Please enter your email";
                hasError = true;
            }

            if (phone == "")
            {
                errorlblPhone.Text = "Please enter your phone";
                hasError = true;
            }

            if (password == "")
            {
                errorlblPass.Text = "Please enter a password";
                hasError = true;
            }

            if (confirmPass == "")
            {
                errorlblConfPass.Text = "Enter your password again";
                hasError = true;
            }

            if (password != confirmPass)
            {
                errorlblPassNotMatch.Text = "Password do not match";
                hasError = true;
            }

            if (role == null || role == "")
            {
                errorlblRole.Text = "Select a role";
                hasError = true;
            }

            if (address == "")
            {
                errorlblAdress.Text = "Please enter your address";
                hasError = true;
            }

            if (gender == "")
            {
                errorlblGender.Text = "Choose a gender";
                hasError = true;
            }

            if (dateTimePickerDOB.Checked == false)
            {
                errorlblDOB.Text = "Please select your date of birth";
                hasError = true;
            }
            else if (dateTimePickerDOB.Value.Date >= DateTime.Today)
            {
                errorlblDOB.Text = "Date of birth cannot be today or future date";
                hasError = true;
            }


            if (hasError == true)
            {
                return;
            }

            string status = "";

            if (role == "Customer")
            {
                status = "Active";
            }
            else
            {
                status = "Pending";
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string checkQuery = "SELECT * FROM Users WHERE Email = @Email";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Email", email);

                SqlDataAdapter adp = new SqlDataAdapter(checkCmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This email is already registered. Please use a different email.");
                    txtEmail.Focus();
                    return;
                }

                string insertUserQuery = @"
                                            INSERT INTO Users
                                            (
                                                FullName,
                                                Email,
                                                Phone,
                                                Password,
                                                Role,
                                                Address,
                                                Gender,
                                                DOB,
                                                Status,
                                                CreatedAt
                                            )
                                            OUTPUT INSERTED.UserID
                                            VALUES
                                            (
                                                @FullName,
                                                @Email,
                                                @Phone,
                                                @Password,
                                                @Role,
                                                @Address,
                                                @Gender,
                                                @DOB,
                                                @Status,
                                                GETDATE()
                                            )";

                SqlCommand insertUserCmd = new SqlCommand(insertUserQuery, conn);
                insertUserCmd.Parameters.AddWithValue("@FullName", name);
                insertUserCmd.Parameters.AddWithValue("@Email", email);
                insertUserCmd.Parameters.AddWithValue("@Phone", phone);
                insertUserCmd.Parameters.AddWithValue("@Password", password);
                insertUserCmd.Parameters.AddWithValue("@Role", role);
                insertUserCmd.Parameters.AddWithValue("@Address", address);
                insertUserCmd.Parameters.AddWithValue("@Gender", gender);
                insertUserCmd.Parameters.AddWithValue("@DOB", dob);
                insertUserCmd.Parameters.AddWithValue("@Status", status);

                int newUserID = Convert.ToInt32(insertUserCmd.ExecuteScalar());

                if (role == "Customer")
                {
                    string insertCustomerQuery = @"
                    INSERT INTO Customers
                    (
                        UserID,
                        MeterNumber,
                        HoldingNumber,
                        ConnectionType
                        
                    )
                    VALUES
                    (
                        @UserID,
                        @MeterNumber,
                        @HoldingNumber,
                        @ConnectionType
                    )";

                    SqlCommand insertCustomerCmd = new SqlCommand(insertCustomerQuery, conn);
                    insertCustomerCmd.Parameters.AddWithValue("@UserID", newUserID);
                    insertCustomerCmd.Parameters.AddWithValue("@MeterNumber", DBNull.Value);
                    insertCustomerCmd.Parameters.AddWithValue("@HoldingNumber", DBNull.Value);
                    insertCustomerCmd.Parameters.AddWithValue("@ConnectionType", DBNull.Value);

                    insertCustomerCmd.ExecuteNonQuery();
                }

                if (role == "Customer")
                {
                    MessageBox.Show("Registration successful! You can now log in.");
                }
                else
                {
                    MessageBox.Show("Account created! Please wait for Admin approval before logging in.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message);
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}