using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThriftShopManagementSystem
{
    public partial class Form1 : Form
    {

        public static string LoggedInRole;
        public static string LoggedInUsername;

        SqlConnection connect = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saman\Documents\thrift.mdf;Integrated Security=True;Connect Timeout=30"
        );

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        public bool emptyFields()
        {
            return login_username.Text == "" || login_password.Text == "";
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show(
                    "All fields are required to be filled.",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();

                connect.Open();

                string query = @"
                    SELECT role, status 
                    FROM users 
                    WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        string status = reader["status"].ToString();

                        LoggedInRole = role;
                        LoggedInUsername = login_username.Text.Trim();


                        if (status != "Active")
                        {
                            MessageBox.Show(
                                "Your account is not active.",
                                "Access Denied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }

                        Session.Role = role;
                        Session.Username = login_username.Text.Trim();

                        MessageBox.Show(
                            "Login successfully!",
                            "Information Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        this.Hide();

                        if (role == "Admin")
                        {
                            AdminMainForm adminForm = new AdminMainForm();
                            adminForm.Show();
                        }
                        else if (role == "User")
                        {
                            UserMainForm userForm = new UserMainForm();
                            userForm.Show();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid role detected.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Incorrect Username or Password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Connection failed: " + ex.Message,
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                connect.Close();
            }
        }

        private void login_registerBtn_Click_1(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }
    }
}
