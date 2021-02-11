using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn1_Alby_N01462455.Controllers
{
    public class NumberMachineController : ApiController
    {
        ///GET api/numbermachine/{id}
        ///Create a controller to calculate some arthematic operations
        /// <summary>
        /// This is a get method to calculate some mathematiacal operations
        /// </summary>
        /// <param name="id"></param>
        /// <returns> The number added by 10 divided by the number then multiplied
        ///           by the difference of the number and 5 </returns>
        /// <example> api/numbermachine/10    =>10 </example>
        /// <example> api/numbermachine/-5    =>10 </example>
        public int Get(int id)
        {
            int result = (id + 10) / id * (id - 5);
            return (result);
        }
    }
}
