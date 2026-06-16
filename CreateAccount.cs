using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        // Same functionality as the hashing function in form1 (the login form)
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        // function to check if a username already exists in the database, usernames must be unique
        private bool UsernameExists(string username)
        {
            // calls my Database class that connects to the database 
            using (var conn = Database.GetConnection())
            {
                // opens database
                conn.Open();
                // sql counts how many times the username occurs in the username field
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";

                // variable that stores sql command that actually executes the query
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // replaces the placeholder value @username with the actual entered value
                cmd.Parameters.AddWithValue("@username", username);

                // executes the sql query and stores the result in count, should only ever result in 1 or 0
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                // true if username already exists in database, false if it doesn't
                return count > 0;
            }
        }


        private void groupBoxCreateAccount_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            labelStatus.Visible = false; // hide old messages

            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            // 1. Validate fields
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                labelStatus.Text = "All fields are required.";
                labelStatus.ForeColor = Color.Red; // need to update form1 so it's error label is also red and defaults to not visible
                labelStatus.Visible = true;
                return;
            }

            // 2. Check password match
            if (password != confirmPassword)
            {
                labelStatus.Text = "Passwords do not match.";
                labelStatus.ForeColor = Color.Red;
                labelStatus.Visible = true;
                return;
            }

            // 3. Check if username already exists
            if (UsernameExists(username))
            {
                labelStatus.Text = "Username already exists.";
                labelStatus.ForeColor = Color.Red;
                labelStatus.Visible = true;
                return;
            }

            // 4. Hash password
            string hashedPassword = HashPassword(password);

            // 5. Insert into database
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO users (username, password_hash, role) VALUES (@username, @password, 'standard')";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                cmd.ExecuteNonQuery();
            }

            // 6. Success message
            labelStatus.Text = "Account created successfully!";
            labelStatus.ForeColor = Color.Green;
            labelStatus.Visible = true;

            // Clear fields for sanitation
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Show();


        }
    }
}
