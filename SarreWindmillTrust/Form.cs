using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarreWindmillTrust
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            uiTierComboBox.DataSource = SarreWindmillTrust.DonorTiers;
        }

        public void NewDonor(string donorName, decimal donationAmount)
        {
            string messageBoxText = "Thank you {0} for your donation of £{1:#.00}!{2}Your Donor ID is {3}!";
            int donorId = SarreWindmillTrust.NewDonor(donationAmount, uiDonationDateTimePicker.Value, donorName);
            MessageBox.Show(String.Format(messageBoxText, donorName, donationAmount, Environment.NewLine, donorId));
        }

        public void ExistingDonor(decimal donationAmount, int donorId)
        {
            string messageBoxText = "Thank you {0} for your donation of £{1:#.00}!{2}Your highest donor tier is {3}!";
            Donor donor = SarreWindmillTrust.ExistingDonor(donationAmount, uiDonationDateTimePicker.Value, donorId);
            MessageBox.Show(String.Format(messageBoxText, donor.Name, donationAmount, Environment.NewLine, SarreWindmillTrust.DonorTier(donor)));
        }

        public void UpdateTierListing()
        {
            uiTierTextBox.Text = null;
            List<Donor> donorList = SarreWindmillTrust.TierList(uiTierComboBox.Text);

            for (int i = 0; i < donorList.Count; i++)
            {
                uiTierTextBox.Text += String.Format("[{0}] {1}", donorList[i].ID, donorList[i].Name) + Environment.NewLine;
            }
        }

        public void ResetForm()
        {
            uiDonationDateTimePicker.ResetText();
            uiDonationAmountTextBox.Text = null;

            if (uiNewDonorCheckBox.Checked)
            {
                uiDonorNameTextBox.Text = null;
            }
            else
            {
                uiDonorIdTextBox.Text = null;
            }

            UpdateTierListing();
        }

        private void uiDonateButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(uiDonationAmountTextBox.Text, out decimal donationAmount))
            {
                MessageBox.Show("Donation amount must be a decimal!");
                return;
            }

            try
            {
                if (uiNewDonorCheckBox.Checked)
                {
                    NewDonor(uiDonorNameTextBox.Text, donationAmount);
                }
                else
                {
                    if (!int.TryParse(uiDonorIdTextBox.Text, out int donorId))
                    {
                        MessageBox.Show("Donor ID must be an integer!");
                        return;
                    }

                    ExistingDonor(donationAmount, donorId);
                }
            }
            catch (ArgumentException ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }

            ResetForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTierListing();
        }

        private void uiNewDonorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uiNewDonorCheckBox.Checked)
            {
                uiDonorIdTextBox.Text = null;
                uiDonorIdTextBox.Enabled = false;
                uiDonorNameTextBox.Enabled = true;
            }
            else
            {
                uiDonorNameTextBox.Text = null;
                uiDonorNameTextBox.Enabled = false;
                uiDonorIdTextBox.Enabled = true;
            }
        }
    }
}
