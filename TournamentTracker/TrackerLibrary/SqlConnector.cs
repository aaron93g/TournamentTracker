using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make the CreatePrize method save to database
        /// <summary>
        /// Sends a new Created Prize to SQL
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
