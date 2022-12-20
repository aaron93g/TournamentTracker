using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {

        //TODO - Make the CreatePrize method save to text file

        /// <summary>
        /// Sends a new Created Prize to a Text file
        /// </summary>
        /// <param name="model">Takes the prize information from the CreatePrize form</param>
        /// <returns>returns prize information, with the unique ID</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
