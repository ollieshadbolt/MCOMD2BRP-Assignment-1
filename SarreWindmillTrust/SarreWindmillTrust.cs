using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreWindmillTrust
{
    public class SarreWindmillTrust
    {
        // attributes
        private static Dictionary<string, int> mDonorTiers = new Dictionary<string, int>()
        {
            {"Bronze", 0 },
            {"Silver", 5 },
            {"Gold", 10 },
            {"Diamond", 25 },
            {"Platinum", 50 },
        };
        public static List<string> DonorTiers { get { return mDonorTiers.Keys.ToList(); } }
        private static List<Donor> mDonors = new List<Donor>();
        private static int mUserId = 0;

        // methods
        private static void ErrorChecking(Decimal DonationAmount, DateTime DonationDate)
        {
            int maxValue = 1000000;

            // check if DonationAmount has more than 2 decimal places
            if (BitConverter.GetBytes(decimal.GetBits(DonationAmount)[3])[2] > 2)
            {
                throw new ArgumentException("Donation amount cannot be more than 2 decimal places!");
            }
            else if (DonationAmount <= 0)
            {
                throw new ArgumentException("Donation amount must be positive!");
            }
            else if (DonationAmount > 1000000)
            {
                throw new ArgumentException(String.Format("Donation amount must be less than £{0:#.00}!", maxValue));
            }
            else if (DonationDate > DateTime.Now)
            {
                throw new ArgumentException("Donation date cannot be in the future!");
            }
        }

        public static int NewDonor(Decimal DonationAmount, DateTime DonationDate, String DonorName)
        {
            ErrorChecking(DonationAmount, DonationDate);

            if (DonorName == "")
            {
                throw new ArgumentException("Donor name needed!");
            }
            else
            {
                mUserId++;
                mDonors.Add(new Donor(DonorName, mUserId, DonationAmount, DonationDate));
                return mUserId;
            }
        }

        public static Donor ExistingDonor(Decimal DonationAmount, DateTime DonationDate, int DonorID)
        {
            ErrorChecking(DonationAmount, DonationDate);

            foreach (Donor donor in mDonors)
            {
                if (donor.ID == DonorID)
                {
                    donor.NewDonation(DonationAmount, DonationDate);
                    return donor;
                }
            }

            throw new ArgumentException("Invalid Donor ID!");
        }

        public static List<Donor> TierList(String DonorTier)
        {
            List<Donor> donorList = new List<Donor>();

            foreach (Donor donor in mDonors)
            {
                if (donor.DonorScore() > mDonorTiers[DonorTier])
                {
                    donorList.Add(donor);
                }
            }

            return donorList;
        }

        public static string DonorTier(Donor donor)
        {
            for (int i = mDonorTiers.Count - 1; i >= 0; i--)
            {
                string donorTier = DonorTiers[i];

                if (donor.DonorScore() > mDonorTiers[donorTier])
                {
                    return DonorTiers[i];
                }
            }

            return null;
        }
    }
}