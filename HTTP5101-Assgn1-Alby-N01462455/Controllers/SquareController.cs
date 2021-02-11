using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn1_Alby_N01462455.Controllers
{
    public class SquareController : ApiController
    {
        ///GET api/square/{id}
        ///Create a controller to get the square of the number in the input
        /// <summary>
        /// This get method is used to get the square of a number
        /// </summary>
        /// <param name="id"></param>
        /// <returns>the square</returns>
        /// <example>api/square/2   => 4</example>
        /// <example>api/square/7   =>49</example>

        public int Get(int id)
        {
            int result = id * id;
            return (result);
        }
    }
}
