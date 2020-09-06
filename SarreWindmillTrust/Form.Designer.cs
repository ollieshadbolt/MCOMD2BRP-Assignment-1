namespace SarreWindmillTrust
{
    partial class Form
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
            this.uiNewDonorCheckBox = new System.Windows.Forms.CheckBox();
            this.uiAmountLabel = new System.Windows.Forms.Label();
            this.uiDonationAmountTextBox = new System.Windows.Forms.TextBox();
            this.uiPoundLabel = new System.Windows.Forms.Label();
            this.uiDonorNameTextBox = new System.Windows.Forms.TextBox();
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiIdLabel = new System.Windows.Forms.Label();
            this.uiDonorIdTextBox = new System.Windows.Forms.TextBox();
            this.uiDonateButton = new System.Windows.Forms.Button();
            this.uiDonationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiTierComboBox = new System.Windows.Forms.ComboBox();
            this.uiTierLabel = new System.Windows.Forms.Label();
            this.uiTierTextBox = new System.Windows.Forms.TextBox();
            this.uiDonationGroupBox = new System.Windows.Forms.GroupBox();
            this.uiDonorRatingGroupBox = new System.Windows.Forms.GroupBox();
            this.uiDonationGroupBox.SuspendLayout();
            this.uiDonorRatingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiNewDonorCheckBox
            // 
            this.uiNewDonorCheckBox.AutoSize = true;
            this.uiNewDonorCheckBox.Checked = true;
            this.uiNewDonorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiNewDonorCheckBox.Location = new System.Drawing.Point(9, 84);
            this.uiNewDonorCheckBox.Name = "uiNewDonorCheckBox";
            this.uiNewDonorCheckBox.Size = new System.Drawing.Size(86, 17);
            this.uiNewDonorCheckBox.TabIndex = 0;
            this.uiNewDonorCheckBox.Text = "New Donor?";
            this.uiNewDonorCheckBox.UseVisualStyleBackColor = true;
            this.uiNewDonorCheckBox.CheckedChanged += new System.EventHandler(this.uiNewDonorCheckBox_CheckedChanged);
            // 
            // uiAmountLabel
            // 
            this.uiAmountLabel.AutoSize = true;
            this.uiAmountLabel.Location = new System.Drawing.Point(6, 16);
            this.uiAmountLabel.Name = "uiAmountLabel";
            this.uiAmountLabel.Size = new System.Drawing.Size(43, 13);
            this.uiAmountLabel.TabIndex = 1;
            this.uiAmountLabel.Text = "Amount";
            // 
            // uiDonationAmountTextBox
            // 
            this.uiDonationAmountTextBox.Location = new System.Drawing.Point(25, 32);
            this.uiDonationAmountTextBox.Name = "uiDonationAmountTextBox";
            this.uiDonationAmountTextBox.Size = new System.Drawing.Size(184, 20);
            this.uiDonationAmountTextBox.TabIndex = 2;
            // 
            // uiPoundLabel
            // 
            this.uiPoundLabel.AutoSize = true;
            this.uiPoundLabel.Location = new System.Drawing.Point(6, 35);
            this.uiPoundLabel.Name = "uiPoundLabel";
            this.uiPoundLabel.Size = new System.Drawing.Size(13, 13);
            this.uiPoundLabel.TabIndex = 3;
            this.uiPoundLabel.Text = "£";
            // 
            // uiDonorNameTextBox
            // 
            this.uiDonorNameTextBox.Location = new System.Drawing.Point(9, 120);
            this.uiDonorNameTextBox.Name = "uiDonorNameTextBox";
            this.uiDonorNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.uiDonorNameTextBox.TabIndex = 4;
            // 
            // uiNameLabel
            // 
            this.uiNameLabel.AutoSize = true;
            this.uiNameLabel.Location = new System.Drawing.Point(6, 104);
            this.uiNameLabel.Name = "uiNameLabel";
            this.uiNameLabel.Size = new System.Drawing.Size(35, 13);
            this.uiNameLabel.TabIndex = 5;
            this.uiNameLabel.Text = "Name";
            // 
            // uiIdLabel
            // 
            this.uiIdLabel.AutoSize = true;
            this.uiIdLabel.Location = new System.Drawing.Point(6, 143);
            this.uiIdLabel.Name = "uiIdLabel";
            this.uiIdLabel.Size = new System.Drawing.Size(18, 13);
            this.uiIdLabel.TabIndex = 6;
            this.uiIdLabel.Text = "ID";
            // 
            // uiDonorIdTextBox
            // 
            this.uiDonorIdTextBox.Enabled = false;
            this.uiDonorIdTextBox.Location = new System.Drawing.Point(6, 159);
            this.uiDonorIdTextBox.Name = "uiDonorIdTextBox";
            this.uiDonorIdTextBox.Size = new System.Drawing.Size(203, 20);
            this.uiDonorIdTextBox.TabIndex = 7;
            // 
            // uiDonateButton
            // 
            this.uiDonateButton.Location = new System.Drawing.Point(6, 185);
            this.uiDonateButton.Name = "uiDonateButton";
            this.uiDonateButton.Size = new System.Drawing.Size(203, 23);
            this.uiDonateButton.TabIndex = 8;
            this.uiDonateButton.Text = "Donate!";
            this.uiDonateButton.UseVisualStyleBackColor = true;
            this.uiDonateButton.Click += new System.EventHandler(this.uiDonateButton_Click);
            // 
            // uiDonationDateTimePicker
            // 
            this.uiDonationDateTimePicker.Location = new System.Drawing.Point(9, 58);
            this.uiDonationDateTimePicker.Name = "uiDonationDateTimePicker";
            this.uiDonationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.uiDonationDateTimePicker.TabIndex = 11;
            // 
            // uiTierComboBox
            // 
            this.uiTierComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uiTierComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uiTierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiTierComboBox.FormattingEnabled = true;
            this.uiTierComboBox.Location = new System.Drawing.Point(9, 31);
            this.uiTierComboBox.Name = "uiTierComboBox";
            this.uiTierComboBox.Size = new System.Drawing.Size(200, 21);
            this.uiTierComboBox.TabIndex = 12;
            this.uiTierComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // uiTierLabel
            // 
            this.uiTierLabel.AutoSize = true;
            this.uiTierLabel.Location = new System.Drawing.Point(6, 16);
            this.uiTierLabel.Name = "uiTierLabel";
            this.uiTierLabel.Size = new System.Drawing.Size(25, 13);
            this.uiTierLabel.TabIndex = 13;
            this.uiTierLabel.Text = "Tier";
            // 
            // uiTierTextBox
            // 
            this.uiTierTextBox.Location = new System.Drawing.Point(9, 58);
            this.uiTierTextBox.Multiline = true;
            this.uiTierTextBox.Name = "uiTierTextBox";
            this.uiTierTextBox.ReadOnly = true;
            this.uiTierTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uiTierTextBox.Size = new System.Drawing.Size(200, 150);
            this.uiTierTextBox.TabIndex = 14;
            this.uiTierTextBox.WordWrap = false;
            // 
            // uiDonationGroupBox
            // 
            this.uiDonationGroupBox.Controls.Add(this.uiDonationAmountTextBox);
            this.uiDonationGroupBox.Controls.Add(this.uiAmountLabel);
            this.uiDonationGroupBox.Controls.Add(this.uiIdLabel);
            this.uiDonationGroupBox.Controls.Add(this.uiDonorIdTextBox);
            this.uiDonationGroupBox.Controls.Add(this.uiDonateButton);
            this.uiDonationGroupBox.Controls.Add(this.uiNewDonorCheckBox);
            this.uiDonationGroupBox.Controls.Add(this.uiPoundLabel);
            this.uiDonationGroupBox.Controls.Add(this.uiDonationDateTimePicker);
            this.uiDonationGroupBox.Controls.Add(this.uiNameLabel);
            this.uiDonationGroupBox.Controls.Add(this.uiDonorNameTextBox);
            this.uiDonationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.uiDonationGroupBox.Name = "uiDonationGroupBox";
            this.uiDonationGroupBox.Size = new System.Drawing.Size(217, 217);
            this.uiDonationGroupBox.TabIndex = 15;
            this.uiDonationGroupBox.TabStop = false;
            this.uiDonationGroupBox.Text = "Donation";
            // 
            // uiDonorRatingGroupBox
            // 
            this.uiDonorRatingGroupBox.Controls.Add(this.uiTierLabel);
            this.uiDonorRatingGroupBox.Controls.Add(this.uiTierTextBox);
            this.uiDonorRatingGroupBox.Controls.Add(this.uiTierComboBox);
            this.uiDonorRatingGroupBox.Location = new System.Drawing.Point(235, 12);
            this.uiDonorRatingGroupBox.Name = "uiDonorRatingGroupBox";
            this.uiDonorRatingGroupBox.Size = new System.Drawing.Size(218, 217);
            this.uiDonorRatingGroupBox.TabIndex = 16;
            this.uiDonorRatingGroupBox.TabStop = false;
            this.uiDonorRatingGroupBox.Text = "Donor Rating";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 243);
            this.Controls.Add(this.uiDonorRatingGroupBox);
            this.Controls.Add(this.uiDonationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Sarre Windmill Trust";
            this.Load += new System.EventHandler(this.Form_Load);
            this.uiDonationGroupBox.ResumeLayout(false);
            this.uiDonationGroupBox.PerformLayout();
            this.uiDonorRatingGroupBox.ResumeLayout(false);
            this.uiDonorRatingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox uiNewDonorCheckBox;
        private System.Windows.Forms.Label uiAmountLabel;
        private System.Windows.Forms.TextBox uiDonationAmountTextBox;
        private System.Windows.Forms.Label uiPoundLabel;
        private System.Windows.Forms.TextBox uiDonorNameTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Label uiIdLabel;
        private System.Windows.Forms.TextBox uiDonorIdTextBox;
        private System.Windows.Forms.Button uiDonateButton;
        private System.Windows.Forms.DateTimePicker uiDonationDateTimePicker;
        private System.Windows.Forms.ComboBox uiTierComboBox;
        private System.Windows.Forms.Label uiTierLabel;
        private System.Windows.Forms.TextBox uiTierTextBox;
        private System.Windows.Forms.GroupBox uiDonationGroupBox;
        private System.Windows.Forms.GroupBox uiDonorRatingGroupBox;
    }
}

