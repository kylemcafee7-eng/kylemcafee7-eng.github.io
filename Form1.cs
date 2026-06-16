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
    public partial class Form1 : Form
    {
        public static string LoggedInRole;

        public Form1()
        {
            InitializeComponent();
        }

        // this method converts plain text into a SHA-256 hash
        // turns the normal text into a hexidecimal encryption
        private string ComputeSha256Hash(string rawData)
        {
            // uses the .NET crypto library for sha256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // turns string into bytes with GetBytes() then stores those values in an array of bytes
                // hashing algorithms can't operate on strings, so it needs to be converted to bytes 
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                // initialize string builder object 
                StringBuilder builder = new StringBuilder();

                // enhanced for loop that goes through all the bytes in the array and appends them 
                // as a 2 digit hex value, basically we're just turnging the hash back into a readable 
                // string because the password field holds a string value 
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }


        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShow.Checked;
        }

        // Login button, can't change the name of this handler because of how fagile visual studio is
        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            if (username == "" || password == "")
            {
                labelError.Text = "Please enter username and password";
                labelError.Visible = true;
                return;
            }

            string hashed = ComputeSha256Hash(password);

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT user_id, password_hash, role FROM users WHERE username = @u";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["password_hash"].ToString();

                            if (storedHash == hashed)
                            {
                                // Store role globally
                                Form1.LoggedInRole = reader["role"].ToString();

                                int userId = Convert.ToInt32(reader["user_id"]);

                                Main main = new Main(userId);
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                labelError.Text = "Invalid username or password";
                                labelError.Visible = true;
                            }
                        }
                        else
                        {
                            labelError.Text = "Invalid username or password";
                            labelError.Visible = true;
                        }
                    }
                }
            }
        }

        private void linkLabelCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount create = new CreateAccount();
            create.Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
    

        }
    }
}
