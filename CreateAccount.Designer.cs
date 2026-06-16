namespace Capstone
{
    partial class CreateAccount
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
            this.groupBoxCreateAccount = new System.Windows.Forms.GroupBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxCreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreateAccount
            // 
            this.groupBoxCreateAccount.Controls.Add(this.buttonCancel);
            this.groupBoxCreateAccount.Controls.Add(this.buttonCreateAccount);
            this.groupBoxCreateAccount.Controls.Add(this.labelStatus);
            this.groupBoxCreateAccount.Controls.Add(this.labelConfirmPassword);
            this.groupBoxCreateAccount.Controls.Add(this.labelPassword);
            this.groupBoxCreateAccount.Controls.Add(this.labelUsername);
            this.groupBoxCreateAccount.Controls.Add(this.textBoxConfirmPassword);
            this.groupBoxCreateAccount.Controls.Add(this.textBoxPassword);
            this.groupBoxCreateAccount.Controls.Add(this.textBoxUsername);
            this.groupBoxCreateAccount.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCreateAccount.Name = "groupBoxCreateAccount";
            this.groupBoxCreateAccount.Size = new System.Drawing.Size(263, 188);
            this.groupBoxCreateAccount.TabIndex = 0;
            this.groupBoxCreateAccount.TabStop = false;
            this.groupBoxCreateAccount.Text = "Create An Account";
            this.groupBoxCreateAccount.Enter += new System.EventHandler(this.groupBoxCreateAccount_Enter);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(14, 41);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(197, 20);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(14, 80);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(197, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(14, 123);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(197, 20);
            this.textBoxConfirmPassword.TabIndex = 2;
            this.textBoxConfirmPassword.TextChanged += new System.EventHandler(this.textBoxConfirmPassword_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(11, 25);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 13);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Enter Username:";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(13, 64);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Enter Password:";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(13, 107);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.labelConfirmPassword.TabIndex = 5;
            this.labelConfirmPassword.Text = "Confirm Password:";
            this.labelConfirmPassword.Click += new System.EventHandler(this.labelConfirmPassword_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelStatus.Location = new System.Drawing.Point(13, 146);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status";
            this.labelStatus.Visible = false;
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCreateAccount.Location = new System.Drawing.Point(101, 159);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateAccount.TabIndex = 7;
            this.buttonCreateAccount.Text = "Create";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCancel.Location = new System.Drawing.Point(182, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 213);
            this.Controls.Add(this.groupBoxCreateAccount);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.groupBoxCreateAccount.ResumeLayout(false);
            this.groupBoxCreateAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreateAccount;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonCancel;
    }
}