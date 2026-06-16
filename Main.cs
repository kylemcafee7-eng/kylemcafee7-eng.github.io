using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class Main : Form

    {
        public Main()
        {
            InitializeComponent();
        }

        private int _userId;

        public Main(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }


        private int? GetSelectedItemId()
        {
            if (dgvInventory.CurrentRow == null)
                return null;

            object value = dgvInventory.CurrentRow.Cells["item_id"].Value;

            if (value == null || value == DBNull.Value)
                return null;

            return Convert.ToInt32(value);
        }


        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.LoggedInRole != "admin")
                return;

            if (e.RowIndex < 0)
                return;

            int itemId = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["item_id"].Value);

            EditItemForm editForm = new EditItemForm(itemId);
            editForm.ShowDialog();

            LoadInventoryGrid();
        }

        // default handler that doesn't match the actual dgv name, but visual studio won't let me delete this handler for some reason
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addForm = new AddItem(_userId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadInventoryGrid();
            }
       
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            int itemId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["item_id"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM inventory_items WHERE item_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Refresh the grid
                LoadInventoryGrid();


                MessageBox.Show("Item deleted successfully.");
            }
        }

        private void btnUsageHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnRestockInfo_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            int itemId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["item_id"].Value);

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"SELECT 
                            name, 
                            quantity, 
                            eoq, 
                            rop, 
                            itr 
                         FROM inventory_items 
                         WHERE item_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", itemId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            int quantity = Convert.ToInt32(reader["quantity"]);
                            double eoq = Convert.ToDouble(reader["eoq"]);
                            double rop = Convert.ToDouble(reader["rop"]);
                            double itr = Convert.ToDouble(reader["itr"]);

                            string status = quantity < rop
                                ? "Restock Recommended"
                                : "Stock Level Sufficient";

                            string report =
                                $"Item: {name}\n" +
                                $"Quantity On Hand: {quantity} units\n" +
                                $"EOQ (Optimal Order Quantity): {eoq:F2} units\n" +
                                $"ROP (Reorder Point): {rop:F2} units\n" +
                                $"ITR (Turnover Rate): {itr:F2} cycles/year\n\n" +
                                $"Status: {status}\n";

                            if (quantity < rop)
                            {
                                report += $"Suggested Order Quantity: {eoq:F0} units\n";
                            }


                            MessageBox.Show(report, "Restocking Report");
                        }
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
        {
            if (Form1.LoggedInRole != "admin")
            {
                btnAddItem.Enabled = false;
                btnDeleteItem.Enabled = false;
                btnRestockInfo.Enabled = false;
                btnTurnoverReport.Enabled = false;
            }
        }

        LoadInventoryGrid();
        }

        private void LoadInventoryGrid()
        {
            try
            {
                DataTable table = DatabaseHelper.GetInventoryItems();
                dgvInventory.DataSource = table;
                // some minor visual changes to make the table looks a bit nicer
                // should probably reorganize and capitalize all fields, but I don't have time
                dgvInventory.Columns["date_added"].DisplayIndex = 3;
                dgvInventory.Columns["vendor"].HeaderText = "Vendor";
                dgvInventory.Columns["eoq"].HeaderText = "EOQ";
                dgvInventory.Columns["rop"].HeaderText = "ROP";
                dgvInventory.Columns["itr"].HeaderText = "ITR";
                dgvInventory.Columns["vendor"].DisplayIndex = 5;


                if (dgvInventory.Columns.Contains("item_id"))
                {
                    dgvInventory.Columns["item_id"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory");

            }
        }

        private void btnTurnoverReport_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            DataGridViewRow row = dgvInventory.SelectedRows[0];

            string name = row.Cells["name"].Value?.ToString();
            double itr = Convert.ToDouble(row.Cells["itr"].Value);

            string speed;

            if (itr >= 12)
                speed = "This item sells extremely fast.";
            else if (itr >= 6)
                speed = "This item sells at a healthy pace.";
            else if (itr >= 3)
                speed = "This item sells moderately.";
            else
                speed = "This item sells slowly.";

            string report =
                $"Item: {name}\n" +
                $"Inventory Turnover Rate: {itr:F2} cycles/year\n\n" +
                $"{speed}\n";

            MessageBox.Show(report, "Sales / Turnover Report");
        }
    }
}
