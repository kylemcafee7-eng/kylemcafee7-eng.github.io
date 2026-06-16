namespace Capstone
{
    partial class EditItemForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelMarketValue = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelRarity = new System.Windows.Forms.Label();
            this.labelSetName = new System.Windows.Forms.Label();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemType = new System.Windows.Forms.Label();
            this.txtMarketValue = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtRarity = new System.Windows.Forms.TextBox();
            this.txtSetName = new System.Windows.Forms.TextBox();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.groupBoxItemInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxMarketInfo = new System.Windows.Forms.GroupBox();
            this.txtAnnualDemand = new System.Windows.Forms.TextBox();
            this.txtOrderingCost = new System.Windows.Forms.TextBox();
            this.txtHoldingCost = new System.Windows.Forms.TextBox();
            this.txtDemandRate = new System.Windows.Forms.TextBox();
            this.labelEndingInventory = new System.Windows.Forms.Label();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.labelBeginningInventory = new System.Windows.Forms.Label();
            this.txtCOGS = new System.Windows.Forms.TextBox();
            this.labelCOGS = new System.Windows.Forms.Label();
            this.txtBeginningInventory = new System.Windows.Forms.TextBox();
            this.labelLeadTime = new System.Windows.Forms.Label();
            this.txtEndingInventory = new System.Windows.Forms.TextBox();
            this.labelDemandRate = new System.Windows.Forms.Label();
            this.labelHoldingCost = new System.Windows.Forms.Label();
            this.labelAnnualDemand = new System.Windows.Forms.Label();
            this.labelOrderingCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.pictureItemImage = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.groupBoxItemInfo.SuspendLayout();
            this.groupBoxMarketInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(778, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(697, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelMarketValue
            // 
            this.labelMarketValue.AutoSize = true;
            this.labelMarketValue.Location = new System.Drawing.Point(6, 329);
            this.labelMarketValue.Name = "labelMarketValue";
            this.labelMarketValue.Size = new System.Drawing.Size(101, 13);
            this.labelMarketValue.TabIndex = 37;
            this.labelMarketValue.Text = "Enter Market Value:";
            this.labelMarketValue.Click += new System.EventHandler(this.labelMarketValue_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(3, 290);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(59, 13);
            this.labelCost.TabIndex = 36;
            this.labelCost.Text = "Enter Cost:";
            this.labelCost.Click += new System.EventHandler(this.labelCost_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(3, 251);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(77, 13);
            this.labelQuantity.TabIndex = 35;
            this.labelQuantity.Text = "Enter Quantity:";
            this.labelQuantity.Click += new System.EventHandler(this.labelQuantity_Click);
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(6, 212);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(82, 13);
            this.labelCondition.TabIndex = 34;
            this.labelCondition.Text = "Enter Condition:";
            this.labelCondition.Click += new System.EventHandler(this.labelCondition_Click);
            // 
            // labelRarity
            // 
            this.labelRarity.AutoSize = true;
            this.labelRarity.Location = new System.Drawing.Point(3, 173);
            this.labelRarity.Name = "labelRarity";
            this.labelRarity.Size = new System.Drawing.Size(65, 13);
            this.labelRarity.TabIndex = 33;
            this.labelRarity.Text = "Enter Rarity:";
            this.labelRarity.Click += new System.EventHandler(this.labelRarity_Click);
            // 
            // labelSetName
            // 
            this.labelSetName.AutoSize = true;
            this.labelSetName.Location = new System.Drawing.Point(3, 134);
            this.labelSetName.Name = "labelSetName";
            this.labelSetName.Size = new System.Drawing.Size(97, 13);
            this.labelSetName.TabIndex = 32;
            this.labelSetName.Text = "Enter Name of Set:";
            this.labelSetName.Click += new System.EventHandler(this.labelSetName_Click);
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Location = new System.Drawing.Point(6, 95);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(109, 13);
            this.labelGameName.TabIndex = 31;
            this.labelGameName.Text = "Enter Name of Game:";
            this.labelGameName.Click += new System.EventHandler(this.labelGameName_Click);
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(3, 56);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(101, 13);
            this.labelItemName.TabIndex = 30;
            this.labelItemName.Text = "Enter Name of Item:";
            this.labelItemName.Click += new System.EventHandler(this.labelItemName_Click);
            // 
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Location = new System.Drawing.Point(6, 17);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(85, 13);
            this.labelItemType.TabIndex = 29;
            this.labelItemType.Text = "Enter Item Type:";
            this.labelItemType.Click += new System.EventHandler(this.labelItemType_Click);
            // 
            // txtMarketValue
            // 
            this.txtMarketValue.Location = new System.Drawing.Point(6, 345);
            this.txtMarketValue.Name = "txtMarketValue";
            this.txtMarketValue.Size = new System.Drawing.Size(295, 20);
            this.txtMarketValue.TabIndex = 28;
            this.txtMarketValue.TextChanged += new System.EventHandler(this.txtMarketValue_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(6, 306);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(295, 20);
            this.txtCost.TabIndex = 27;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(6, 267);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(295, 20);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(6, 228);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(295, 20);
            this.txtCondition.TabIndex = 25;
            this.txtCondition.TextChanged += new System.EventHandler(this.txtCondition_TextChanged);
            // 
            // txtRarity
            // 
            this.txtRarity.Location = new System.Drawing.Point(6, 189);
            this.txtRarity.Name = "txtRarity";
            this.txtRarity.Size = new System.Drawing.Size(295, 20);
            this.txtRarity.TabIndex = 24;
            this.txtRarity.TextChanged += new System.EventHandler(this.txtRarity_TextChanged);
            // 
            // txtSetName
            // 
            this.txtSetName.Location = new System.Drawing.Point(6, 150);
            this.txtSetName.Name = "txtSetName";
            this.txtSetName.Size = new System.Drawing.Size(295, 20);
            this.txtSetName.TabIndex = 23;
            this.txtSetName.TextChanged += new System.EventHandler(this.txtSetName_TextChanged);
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(6, 111);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(295, 20);
            this.txtGameName.TabIndex = 22;
            this.txtGameName.TextChanged += new System.EventHandler(this.txtGameName_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 20);
            this.txtName.TabIndex = 21;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(6, 33);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(295, 20);
            this.txtItemType.TabIndex = 20;
            this.txtItemType.TextChanged += new System.EventHandler(this.txtItemType_TextChanged);
            // 
            // groupBoxItemInfo
            // 
            this.groupBoxItemInfo.Controls.Add(this.label1);
            this.groupBoxItemInfo.Controls.Add(this.txtVendor);
            this.groupBoxItemInfo.Controls.Add(this.txtItemType);
            this.groupBoxItemInfo.Controls.Add(this.txtName);
            this.groupBoxItemInfo.Controls.Add(this.txtGameName);
            this.groupBoxItemInfo.Controls.Add(this.labelMarketValue);
            this.groupBoxItemInfo.Controls.Add(this.txtSetName);
            this.groupBoxItemInfo.Controls.Add(this.labelCost);
            this.groupBoxItemInfo.Controls.Add(this.txtRarity);
            this.groupBoxItemInfo.Controls.Add(this.labelQuantity);
            this.groupBoxItemInfo.Controls.Add(this.txtCondition);
            this.groupBoxItemInfo.Controls.Add(this.labelCondition);
            this.groupBoxItemInfo.Controls.Add(this.txtQuantity);
            this.groupBoxItemInfo.Controls.Add(this.labelRarity);
            this.groupBoxItemInfo.Controls.Add(this.txtCost);
            this.groupBoxItemInfo.Controls.Add(this.labelSetName);
            this.groupBoxItemInfo.Controls.Add(this.txtMarketValue);
            this.groupBoxItemInfo.Controls.Add(this.labelGameName);
            this.groupBoxItemInfo.Controls.Add(this.labelItemType);
            this.groupBoxItemInfo.Controls.Add(this.labelItemName);
            this.groupBoxItemInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxItemInfo.Name = "groupBoxItemInfo";
            this.groupBoxItemInfo.Size = new System.Drawing.Size(315, 407);
            this.groupBoxItemInfo.TabIndex = 40;
            this.groupBoxItemInfo.TabStop = false;
            this.groupBoxItemInfo.Text = "Item Info";
            this.groupBoxItemInfo.Enter += new System.EventHandler(this.groupBoxItemInfo_Enter);
            // 
            // groupBoxMarketInfo
            // 
            this.groupBoxMarketInfo.Controls.Add(this.txtAnnualDemand);
            this.groupBoxMarketInfo.Controls.Add(this.txtOrderingCost);
            this.groupBoxMarketInfo.Controls.Add(this.txtHoldingCost);
            this.groupBoxMarketInfo.Controls.Add(this.txtDemandRate);
            this.groupBoxMarketInfo.Controls.Add(this.labelEndingInventory);
            this.groupBoxMarketInfo.Controls.Add(this.txtLeadTime);
            this.groupBoxMarketInfo.Controls.Add(this.labelBeginningInventory);
            this.groupBoxMarketInfo.Controls.Add(this.txtCOGS);
            this.groupBoxMarketInfo.Controls.Add(this.labelCOGS);
            this.groupBoxMarketInfo.Controls.Add(this.txtBeginningInventory);
            this.groupBoxMarketInfo.Controls.Add(this.labelLeadTime);
            this.groupBoxMarketInfo.Controls.Add(this.txtEndingInventory);
            this.groupBoxMarketInfo.Controls.Add(this.labelDemandRate);
            this.groupBoxMarketInfo.Controls.Add(this.labelHoldingCost);
            this.groupBoxMarketInfo.Controls.Add(this.labelAnnualDemand);
            this.groupBoxMarketInfo.Controls.Add(this.labelOrderingCost);
            this.groupBoxMarketInfo.Location = new System.Drawing.Point(333, 12);
            this.groupBoxMarketInfo.Name = "groupBoxMarketInfo";
            this.groupBoxMarketInfo.Size = new System.Drawing.Size(316, 378);
            this.groupBoxMarketInfo.TabIndex = 41;
            this.groupBoxMarketInfo.TabStop = false;
            this.groupBoxMarketInfo.Text = "Restocking Metrics";
            this.groupBoxMarketInfo.Enter += new System.EventHandler(this.groupBoxMarketInfo_Enter);
            // 
            // txtAnnualDemand
            // 
            this.txtAnnualDemand.Location = new System.Drawing.Point(6, 32);
            this.txtAnnualDemand.Name = "txtAnnualDemand";
            this.txtAnnualDemand.Size = new System.Drawing.Size(295, 20);
            this.txtAnnualDemand.TabIndex = 38;
            this.txtAnnualDemand.TextChanged += new System.EventHandler(this.txtAnnualDemand_TextChanged);
            // 
            // txtOrderingCost
            // 
            this.txtOrderingCost.Location = new System.Drawing.Point(6, 71);
            this.txtOrderingCost.Name = "txtOrderingCost";
            this.txtOrderingCost.Size = new System.Drawing.Size(295, 20);
            this.txtOrderingCost.TabIndex = 39;
            this.txtOrderingCost.TextChanged += new System.EventHandler(this.txtOrderingCost_TextChanged);
            // 
            // txtHoldingCost
            // 
            this.txtHoldingCost.Location = new System.Drawing.Point(6, 110);
            this.txtHoldingCost.Name = "txtHoldingCost";
            this.txtHoldingCost.Size = new System.Drawing.Size(295, 20);
            this.txtHoldingCost.TabIndex = 40;
            this.txtHoldingCost.TextChanged += new System.EventHandler(this.txtHoldingCost_TextChanged);
            // 
            // txtDemandRate
            // 
            this.txtDemandRate.Location = new System.Drawing.Point(6, 149);
            this.txtDemandRate.Name = "txtDemandRate";
            this.txtDemandRate.Size = new System.Drawing.Size(295, 20);
            this.txtDemandRate.TabIndex = 41;
            this.txtDemandRate.TextChanged += new System.EventHandler(this.txtDemandRate_TextChanged);
            // 
            // labelEndingInventory
            // 
            this.labelEndingInventory.AutoSize = true;
            this.labelEndingInventory.Location = new System.Drawing.Point(6, 289);
            this.labelEndingInventory.Name = "labelEndingInventory";
            this.labelEndingInventory.Size = new System.Drawing.Size(87, 13);
            this.labelEndingInventory.TabIndex = 54;
            this.labelEndingInventory.Text = "Ending Inventory";
            this.labelEndingInventory.Click += new System.EventHandler(this.labelEndingInventory_Click);
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.Location = new System.Drawing.Point(6, 188);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.Size = new System.Drawing.Size(295, 20);
            this.txtLeadTime.TabIndex = 42;
            this.txtLeadTime.TextChanged += new System.EventHandler(this.txtLeadTime_TextChanged);
            // 
            // labelBeginningInventory
            // 
            this.labelBeginningInventory.AutoSize = true;
            this.labelBeginningInventory.Location = new System.Drawing.Point(3, 250);
            this.labelBeginningInventory.Name = "labelBeginningInventory";
            this.labelBeginningInventory.Size = new System.Drawing.Size(104, 13);
            this.labelBeginningInventory.TabIndex = 53;
            this.labelBeginningInventory.Text = "Beginning Inventory:";
            this.labelBeginningInventory.Click += new System.EventHandler(this.labelBeginningInventory_Click);
            // 
            // txtCOGS
            // 
            this.txtCOGS.Location = new System.Drawing.Point(6, 227);
            this.txtCOGS.Name = "txtCOGS";
            this.txtCOGS.Size = new System.Drawing.Size(295, 20);
            this.txtCOGS.TabIndex = 43;
            this.txtCOGS.TextChanged += new System.EventHandler(this.txtCOGS_TextChanged);
            // 
            // labelCOGS
            // 
            this.labelCOGS.AutoSize = true;
            this.labelCOGS.Location = new System.Drawing.Point(6, 211);
            this.labelCOGS.Name = "labelCOGS";
            this.labelCOGS.Size = new System.Drawing.Size(40, 13);
            this.labelCOGS.TabIndex = 52;
            this.labelCOGS.Text = "COGS:";
            // 
            // txtBeginningInventory
            // 
            this.txtBeginningInventory.Location = new System.Drawing.Point(6, 266);
            this.txtBeginningInventory.Name = "txtBeginningInventory";
            this.txtBeginningInventory.Size = new System.Drawing.Size(295, 20);
            this.txtBeginningInventory.TabIndex = 44;
            this.txtBeginningInventory.TextChanged += new System.EventHandler(this.txtBeginningInventory_TextChanged);
            // 
            // labelLeadTime
            // 
            this.labelLeadTime.AutoSize = true;
            this.labelLeadTime.Location = new System.Drawing.Point(3, 172);
            this.labelLeadTime.Name = "labelLeadTime";
            this.labelLeadTime.Size = new System.Drawing.Size(60, 13);
            this.labelLeadTime.TabIndex = 51;
            this.labelLeadTime.Text = "Lead Time:";
            // 
            // txtEndingInventory
            // 
            this.txtEndingInventory.Location = new System.Drawing.Point(6, 305);
            this.txtEndingInventory.Name = "txtEndingInventory";
            this.txtEndingInventory.Size = new System.Drawing.Size(295, 20);
            this.txtEndingInventory.TabIndex = 45;
            this.txtEndingInventory.TextChanged += new System.EventHandler(this.txtEndingInventory_TextChanged);
            // 
            // labelDemandRate
            // 
            this.labelDemandRate.AutoSize = true;
            this.labelDemandRate.Location = new System.Drawing.Point(6, 133);
            this.labelDemandRate.Name = "labelDemandRate";
            this.labelDemandRate.Size = new System.Drawing.Size(76, 13);
            this.labelDemandRate.TabIndex = 50;
            this.labelDemandRate.Text = "Demand Rate:";
            this.labelDemandRate.Click += new System.EventHandler(this.labelDemandRate_Click);
            // 
            // labelHoldingCost
            // 
            this.labelHoldingCost.AutoSize = true;
            this.labelHoldingCost.Location = new System.Drawing.Point(6, 94);
            this.labelHoldingCost.Name = "labelHoldingCost";
            this.labelHoldingCost.Size = new System.Drawing.Size(70, 13);
            this.labelHoldingCost.TabIndex = 49;
            this.labelHoldingCost.Text = "Holding Cost:";
            // 
            // labelAnnualDemand
            // 
            this.labelAnnualDemand.AutoSize = true;
            this.labelAnnualDemand.Location = new System.Drawing.Point(6, 16);
            this.labelAnnualDemand.Name = "labelAnnualDemand";
            this.labelAnnualDemand.Size = new System.Drawing.Size(86, 13);
            this.labelAnnualDemand.TabIndex = 47;
            this.labelAnnualDemand.Text = "Annual Demand:";
            this.labelAnnualDemand.Click += new System.EventHandler(this.labelAnnualDemand_Click);
            // 
            // labelOrderingCost
            // 
            this.labelOrderingCost.AutoSize = true;
            this.labelOrderingCost.Location = new System.Drawing.Point(6, 55);
            this.labelOrderingCost.Name = "labelOrderingCost";
            this.labelOrderingCost.Size = new System.Drawing.Size(74, 13);
            this.labelOrderingCost.TabIndex = 48;
            this.labelOrderingCost.Text = "Ordering Cost:";
            this.labelOrderingCost.Click += new System.EventHandler(this.labelOrderingCost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Enter Vendor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(6, 381);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(295, 20);
            this.txtVendor.TabIndex = 38;
            this.txtVendor.TextChanged += new System.EventHandler(this.txtVendor_TextChanged);
            // 
            // pictureItemImage
            // 
            this.pictureItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureItemImage.Location = new System.Drawing.Point(655, 184);
            this.pictureItemImage.Name = "pictureItemImage";
            this.pictureItemImage.Size = new System.Drawing.Size(198, 177);
            this.pictureItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureItemImage.TabIndex = 42;
            this.pictureItemImage.TabStop = false;
            this.pictureItemImage.Click += new System.EventHandler(this.pictureItemImage_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnChooseImage.Location = new System.Drawing.Point(778, 367);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(75, 23);
            this.btnChooseImage.TabIndex = 43;
            this.btnChooseImage.Text = "Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 431);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pictureItemImage);
            this.Controls.Add(this.groupBoxMarketInfo);
            this.Controls.Add(this.groupBoxItemInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "EditItemForm";
            this.Text = "EditItemForm";
            this.Load += new System.EventHandler(this.EditItemForm_Load);
            this.groupBoxItemInfo.ResumeLayout(false);
            this.groupBoxItemInfo.PerformLayout();
            this.groupBoxMarketInfo.ResumeLayout(false);
            this.groupBoxMarketInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelMarketValue;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelRarity;
        private System.Windows.Forms.Label labelSetName;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.TextBox txtMarketValue;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtRarity;
        private System.Windows.Forms.TextBox txtSetName;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.GroupBox groupBoxItemInfo;
        private System.Windows.Forms.GroupBox groupBoxMarketInfo;
        private System.Windows.Forms.TextBox txtAnnualDemand;
        private System.Windows.Forms.TextBox txtOrderingCost;
        private System.Windows.Forms.TextBox txtHoldingCost;
        private System.Windows.Forms.TextBox txtDemandRate;
        private System.Windows.Forms.Label labelEndingInventory;
        private System.Windows.Forms.TextBox txtLeadTime;
        private System.Windows.Forms.Label labelBeginningInventory;
        private System.Windows.Forms.TextBox txtCOGS;
        private System.Windows.Forms.Label labelCOGS;
        private System.Windows.Forms.TextBox txtBeginningInventory;
        private System.Windows.Forms.Label labelLeadTime;
        private System.Windows.Forms.TextBox txtEndingInventory;
        private System.Windows.Forms.Label labelDemandRate;
        private System.Windows.Forms.Label labelHoldingCost;
        private System.Windows.Forms.Label labelAnnualDemand;
        private System.Windows.Forms.Label labelOrderingCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.PictureBox pictureItemImage;
        private System.Windows.Forms.Button btnChooseImage;
    }
}