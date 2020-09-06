using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreWindmillTrust
{
    public class Donor
    {
        // attributes
        public String Name { get; }
        public int ID { get; }
        private Decimal mTotalAmountGiven;
        private Decimal mLastAmountGiven;
        private DateTime mDateOfLastDonation;
        private DateTime mDateOfFirstDonation;

        // constructor
        public Donor(String Name, int ID, Decimal DonationAmount, DateTime DonationDate)
        {
            this.Name = Name;
            this.ID = ID;
            mTotalAmountGiven = DonationAmount;
            mLastAmountGiven = DonationAmount;
            mDateOfLastDonation = DonationDate;
            mDateOfFirstDonation = DonationDate;
        }

        // methods
        public void NewDonation(Decimal DonationAmount, DateTime DonationDate)
        {
            mTotalAmountGiven += DonationAmount;
            mLastAmountGiven = DonationAmount;
            mDateOfLastDonation = DonationDate;
        }

        public int DonorScore()
        {
            int donorScore = 1;

            // check if the last donation was within the last year
            if (DateTime.Now.AddYears(-1).Subtract(mDateOfLastDonation).TotalDays < 0)
            {
                if (mLastAmountGiven > 100)
                {
                    donorScore += 2;
                }
                else if (mLastAmountGiven > 25)
                {
                    donorScore += 1;
                }
            }

            if (mTotalAmountGiven > 500)
            {
                donorScore += 5;
            }

            if (mDateOfFirstDonation.Year < 2010)
            {
                donorScore += 2;
            }

            for (int i = 2000; i < mTotalAmountGiven; i += 500)
            {
                donorScore += 1;
            }

            return donorScore;
        }
    }
}
