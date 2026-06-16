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
using System.IO;


namespace Capstone
{
    public partial class EditItemForm : Form
    {
        public EditItemForm()
        {
            InitializeComponent();
        }

        private int _itemId;

        public EditItemForm(int itemId)
        {
            InitializeComponent();
            _itemId = itemId;
        }


        private void labelItemType_Click(object sender, EventArgs e)
        {

        }

        private void txtItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelItemName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelGameName_Click(object sender, EventArgs e)
        {

        }

        private void txtGameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSetName_Click(object sender, EventArgs e)
        {

        }

        private void txtSetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRarity_Click(object sender, EventArgs e)
        {

        }

        private void txtRarity_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCondition_Click(object sender, EventArgs e)
        {

        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelQuantity_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCost_Click(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMarketValue_Click(object sender, EventArgs e)
        {

        }

        private void txtMarketValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int annualDemand = int.Parse(txtAnnualDemand.Text);
            decimal orderingCost = decimal.Parse(txtOrderingCost.Text);
            decimal holdingCost = decimal.Parse(txtHoldingCost.Text);
            decimal demandRate = decimal.Parse(txtDemandRate.Text);
            int leadTime = int.Parse(txtLeadTime.Text);
            decimal cogs = decimal.Parse(txtCOGS.Text);
            decimal beginningInv = decimal.Parse(txtBeginningInventory.Text);
            decimal endingInv = decimal.Parse(txtEndingInventory.Text);
            int quantity = int.Parse(txtQuantity.Text);

            // EOQ
            double eoq = Math.Sqrt((2 * annualDemand * (double)orderingCost) / (double)holdingCost);

            // ROP
            double rop = (double)demandRate * leadTime;

            // ITR
            double averageInventory = ((double)beginningInv + (double)endingInv) / 2.0;
            double itr = (double)cogs / averageInventory;

            string query = @"UPDATE inventory_items SET
                        name = @name,
                        game_name = @game,
                        set_name = @set,
                        rarity = @rarity,
                        `condition` = @condition,
                        quantity = @quantity,
                        cost = @cost,
                        market_value = @marketValue,
                        item_type = @itemType,
                        vendor = @vendor,
                        image_path = @imagePath,

                        annual_demand = @annualDemand,
                        ordering_cost = @orderingCost,
                        holding_cost = @holdingCost,
                        demand_rate = @demandRate,
                        lead_time_days = @leadTime,
                        cogs = @cogs,
                        beginning_inventory = @beginningInv,
                        ending_inventory = @endingInv,

                        eoq = @eoq,
                        rop = @rop,
                        itr = @itr

                    WHERE item_id = @id";

            using (MySqlConnection conn = Database.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // Formula inputs
                cmd.Parameters.AddWithValue("@annualDemand", annualDemand);
                cmd.Parameters.AddWithValue("@orderingCost", orderingCost);
                cmd.Parameters.AddWithValue("@holdingCost", holdingCost);
                cmd.Parameters.AddWithValue("@demandRate", demandRate);
                cmd.Parameters.AddWithValue("@leadTime", leadTime);
                cmd.Parameters.AddWithValue("@cogs", cogs);
                cmd.Parameters.AddWithValue("@beginningInv", beginningInv);
                cmd.Parameters.AddWithValue("@endingInv", endingInv);

                // Formula outputs
                cmd.Parameters.AddWithValue("@eoq", eoq);
                cmd.Parameters.AddWithValue("@rop", rop);
                cmd.Parameters.AddWithValue("@itr", itr);

                // Basic item fields
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@game", txtGameName.Text);
                cmd.Parameters.AddWithValue("@set", txtSetName.Text);
                cmd.Parameters.AddWithValue("@rarity", txtRarity.Text);
                cmd.Parameters.AddWithValue("@condition", txtCondition.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@cost", txtCost.Text);
                cmd.Parameters.AddWithValue("@marketValue", txtMarketValue.Text);
                cmd.Parameters.AddWithValue("@itemType", txtItemType.Text);

                // Vendor field
                cmd.Parameters.AddWithValue("@vendor", txtVendor.Text);

                cmd.Parameters.AddWithValue("@id", _itemId);

                // Adds image path to the image path column
                string imagePath = pictureItemImage.Tag?.ToString() ?? "";
                cmd.Parameters.AddWithValue("@imagePath", imagePath);


                conn.Open();
                cmd.ExecuteNonQuery();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBoxItemInfo_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxMarketInfo_Enter(object sender, EventArgs e)
        {

        }

        private void labelAnnualDemand_Click(object sender, EventArgs e)
        {

        }

        private void txtAnnualDemand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderingCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOrderingCost_Click(object sender, EventArgs e)
        {

        }

        private void txtHoldingCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDemandRate_Click(object sender, EventArgs e)
        {

        }

        private void txtDemandRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLeadTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCOGS_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelBeginningInventory_Click(object sender, EventArgs e)
        {

        }

        private void txtBeginningInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEndingInventory_Click(object sender, EventArgs e)
        {

        }

        private void txtEndingInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM inventory_items WHERE item_id = @id";

            using (MySqlConnection conn = Database.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", _itemId);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        txtAnnualDemand.Text = reader["annual_demand"]?.ToString();
                        txtOrderingCost.Text = reader["ordering_cost"]?.ToString();
                        txtHoldingCost.Text = reader["holding_cost"]?.ToString();
                        txtDemandRate.Text = reader["demand_rate"]?.ToString();
                        txtLeadTime.Text = reader["lead_time_days"]?.ToString();
                        txtCOGS.Text = reader["cogs"]?.ToString();
                        txtBeginningInventory.Text = reader["beginning_inventory"]?.ToString();
                        txtEndingInventory.Text = reader["ending_inventory"]?.ToString();
                        txtVendor.Text = reader["vendor"]?.ToString();


                        txtName.Text = reader["name"].ToString();
                        txtGameName.Text = reader["game_name"].ToString();
                        txtSetName.Text = reader["set_name"].ToString();
                        txtRarity.Text = reader["rarity"].ToString();
                        txtCondition.Text = reader["condition"].ToString();
                        txtQuantity.Text = reader["quantity"].ToString();
                        txtCost.Text = reader["cost"].ToString();
                        txtMarketValue.Text = reader["market_value"].ToString();
                        txtItemType.Text = reader["item_type"].ToString();

                        string imagePath = reader["image_path"]?.ToString();

                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            pictureItemImage.Image = Image.FromFile(imagePath);
                            pictureItemImage.Tag = imagePath; // store the path for saving later
                        }
                        else
                        {
                            pictureItemImage.Image = null;
                            pictureItemImage.Tag = null;
                        }


                    }
                }
            }
        }

        private void txtVendor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureItemImage_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureItemImage.Image = Image.FromFile(ofd.FileName);
                    pictureItemImage.Tag = ofd.FileName; // store path temporarily
                }
            }
        }
    }
}
