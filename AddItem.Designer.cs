namespace Capstone
{
    partial class AddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.txtSetName = new System.Windows.Forms.TextBox();
            this.txtRarity = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtMarketValue = new System.Windows.Forms.TextBox();
            this.labelItemType = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelSetName = new System.Windows.Forms.Label();
            this.labelRarity = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelMarketValue = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(12, 25);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(295, 20);
            this.txtItemType.TabIndex = 0;
            this.txtItemType.TextChanged += new System.EventHandler(this.txtItemType_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(12, 103);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(295, 20);
            this.txtGameName.TabIndex = 2;
            this.txtGameName.TextChanged += new System.EventHandler(this.txtGameName_TextChanged);
            // 
            // txtSetName
            // 
            this.txtSetName.Location = new System.Drawing.Point(12, 142);
            this.txtSetName.Name = "txtSetName";
            this.txtSetName.Size = new System.Drawing.Size(295, 20);
            this.txtSetName.TabIndex = 3;
            this.txtSetName.TextChanged += new System.EventHandler(this.txtSetName_TextChanged);
            // 
            // txtRarity
            // 
            this.txtRarity.Location = new System.Drawing.Point(12, 181);
            this.txtRarity.Name = "txtRarity";
            this.txtRarity.Size = new System.Drawing.Size(295, 20);
            this.txtRarity.TabIndex = 4;
            this.txtRarity.TextChanged += new System.EventHandler(this.txtRarity_TextChanged);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(12, 220);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(295, 20);
            this.txtCondition.TabIndex = 5;
            this.txtCondition.TextChanged += new System.EventHandler(this.txtCondition_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(12, 259);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(295, 20);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(12, 298);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(295, 20);
            this.txtCost.TabIndex = 7;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // txtMarketValue
            // 
            this.txtMarketValue.Location = new System.Drawing.Point(12, 337);
            this.txtMarketValue.Name = "txtMarketValue";
            this.txtMarketValue.Size = new System.Drawing.Size(295, 20);
            this.txtMarketValue.TabIndex = 8;
            this.txtMarketValue.TextChanged += new System.EventHandler(this.txtMarketValue_TextChanged);
            // 
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Location = new System.Drawing.Point(12, 9);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(85, 13);
            this.labelItemType.TabIndex = 9;
            this.labelItemType.Text = "Enter Item Type:";
            this.labelItemType.Click += new System.EventHandler(this.labelItemType_Click);
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(9, 48);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(101, 13);
            this.labelItemName.TabIndex = 10;
            this.labelItemName.Text = "Enter Name of Item:";
            this.labelItemName.Click += new System.EventHandler(this.labelItemName_Click);
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Location = new System.Drawing.Point(12, 87);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(109, 13);
            this.labelGameName.TabIndex = 11;
            this.labelGameName.Text = "Enter Name of Game:";
            this.labelGameName.Click += new System.EventHandler(this.labelGameName_Click);
            // 
            // labelSetName
            // 
            this.labelSetName.AutoSize = true;
            this.labelSetName.Location = new System.Drawing.Point(9, 126);
            this.labelSetName.Name = "labelSetName";
            this.labelSetName.Size = new System.Drawing.Size(97, 13);
            this.labelSetName.TabIndex = 12;
            this.labelSetName.Text = "Enter Name of Set:";
            this.labelSetName.Click += new System.EventHandler(this.labelSetName_Click);
            // 
            // labelRarity
            // 
            this.labelRarity.AutoSize = true;
            this.labelRarity.Location = new System.Drawing.Point(9, 165);
            this.labelRarity.Name = "labelRarity";
            this.labelRarity.Size = new System.Drawing.Size(65, 13);
            this.labelRarity.TabIndex = 13;
            this.labelRarity.Text = "Enter Rarity:";
            this.labelRarity.Click += new System.EventHandler(this.labelRarity_Click);
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(12, 204);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(82, 13);
            this.labelCondition.TabIndex = 14;
            this.labelCondition.Text = "Enter Condition:";
            this.labelCondition.Click += new System.EventHandler(this.labelCondition_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(9, 243);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(77, 13);
            this.labelQuantity.TabIndex = 15;
            this.labelQuantity.Text = "Enter Quantity:";
            this.labelQuantity.Click += new System.EventHandler(this.labelQuantity_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(9, 282);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(59, 13);
            this.labelCost.TabIndex = 16;
            this.labelCost.Text = "Enter Cost:";
            this.labelCost.Click += new System.EventHandler(this.labelCost_Click);
            // 
            // labelMarketValue
            // 
            this.labelMarketValue.AutoSize = true;
            this.labelMarketValue.Location = new System.Drawing.Point(12, 321);
            this.labelMarketValue.Name = "labelMarketValue";
            this.labelMarketValue.Size = new System.Drawing.Size(101, 13);
            this.labelMarketValue.TabIndex = 17;
            this.labelMarketValue.Text = "Enter Market Value:";
            this.labelMarketValue.Click += new System.EventHandler(this.labelMarketValue_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(151, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(232, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 418);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelMarketValue);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelRarity);
            this.Controls.Add(this.labelSetName);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.labelItemType);
            this.Controls.Add(this.txtMarketValue);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtRarity);
            this.Controls.Add(this.txtSetName);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtItemType);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.TextBox txtSetName;
        private System.Windows.Forms.TextBox txtRarity;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtMarketValue;
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label labelSetName;
        private System.Windows.Forms.Label labelRarity;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelMarketValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}