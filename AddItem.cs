using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private int _userId;

        public AddItem(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }


        private void txtItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRarity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarketValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelItemType_Click(object sender, EventArgs e)
        {

        }

        private void labelItemName_Click(object sender, EventArgs e)
        {

        }

        private void labelSetName_Click(object sender, EventArgs e)
        {

        }

        private void labelGameName_Click(object sender, EventArgs e)
        {

        }

        private void labelCondition_Click(object sender, EventArgs e)
        {

        }

        private void labelRarity_Click(object sender, EventArgs e)
        {

        }

        private void labelQuantity_Click(object sender, EventArgs e)
        {

        }

        private void labelCost_Click(object sender, EventArgs e)
        {

        }

        private void labelMarketValue_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation so that if you put in bad data it doesn't crash
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty))
            {
                MessageBox.Show("Quantity must be a number");
                return;
            }

            if (!decimal.TryParse(txtCost.Text, out decimal cost))
            {
                MessageBox.Show("Cost must be a valid number");
                return;
            }

            if (!decimal.TryParse(txtMarketValue.Text, out decimal mv))
            {
                MessageBox.Show("Market value must be a valid number");
                return;
            }



            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO inventory_items 
                 (user_id, item_type, name, game_name, set_name, rarity, `condition`, quantity, cost, market_value, date_added)
                 VALUES
                 (@user_id, @item_type, @name, @game_name, @set_name, @rarity, @condition, @quantity, @cost, @market_value, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", _userId);


                        cmd.Parameters.AddWithValue("@item_type", txtItemType.Text);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@game_name", txtGameName.Text);
                        cmd.Parameters.AddWithValue("@set_name", txtSetName.Text);
                        cmd.Parameters.AddWithValue("@rarity", txtRarity.Text);
                        cmd.Parameters.AddWithValue("@condition", txtCondition.Text);
                        cmd.Parameters.AddWithValue("@quantity", qty);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@market_value", mv);


                        cmd.ExecuteNonQuery();
                    }


                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
