using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// the unique identifier for the prize created
        /// </summary>
        public int Id { get; set; } 

        /// <summary>
        /// is the placement number of the team 1, 2, 3, or 21 etc.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// What is the name of the number placement? 1 == Champions of the Peninsula!, 2 == "2nd Place"?? etc.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// What is the cash value for this specific placement?
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// What is the percentage for the said placed team?
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}
