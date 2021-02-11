using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn1_Alby_N01462455.Controllers
{
    public class AddTenController : ApiController
    {
        ///GET api/addten/{id}
        ///Create a controller to get the input number added by 10
        /// <summary>
        /// This is a get method to calculate the addition of 10 to a number
        /// </summary>
        /// <param name="id"></param>
        /// <returns> The number added by 10 </returns>
        /// <example> api/addten/10    =>20 </example>
        /// <example> api/addten/-5     =>5 </example>
        public int Get(int id)
        {
            int result = id + 10;
            return (result);
        }
    }
}
