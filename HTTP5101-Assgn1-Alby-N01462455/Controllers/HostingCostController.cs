using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn1_Alby_N01462455.Controllers
{
    public class HostingCostController : ApiController
    {

        ///GET api/hostingcost/{id}
        ///Calculate the charge for a client based on the working days
        ///$5.50 / FN (fortnight = 14 days) 
        ///additional 13% HST.
        ///The input { id } represents the number of days which has elapsed
        /// <summary>
        /// Calculate the charge of a client based on working hours
        /// </summary>
        /// <param name="id"></param>
        /// <returns>How much for fortnight,After tax,Total amount</returns>
        /// <example>api/hosingcost/10        => 1 fortnight at $5.50/fn = $5.50CAD
        ///                                      HST 13% = $0.72CAD
        ///                                      Total = $6.22CAD
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            int count = (id / 14) + 1;
            decimal amount = (decimal)(count * 5.50);
            decimal tax = Math.Round((decimal)(0.13) * amount, 2);
            decimal total = amount + tax;
            string fortnight = count.ToString() + " fortnight at $5.50/FN= $" + amount.ToString() + "CAD";
            string taxamount = "HST 13% = $" + tax.ToString() + "CAD";
            string totalamount = "Total = $" + total.ToString() + "CAD";
            return new string[] { fortnight, taxamount, totalamount };
        }
    }
}
