using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn1_Alby_N01462455.Controllers
{
    public class GreetingController : ApiController
    {
        ///POST api/greeting  ===>see the output in the command prompt by using {curl -d "" "url"}
        ///Create a controller to return a simple greeting
        /// <summary>
        /// it is a post request to return a simple greeting 
        /// </summary>
        /// <returns>"Hello World!" </returns>
        public string Post()
        {
            return "Hello World!";
        }
        ///GET api/greeting/{id}
        ///Create a controller to return a greetig to specific number of people specified in the input
        /// <summary>
        /// This is a get request to output greetings to a number of people
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Greetings to {id} people</returns>
        /// <example>api/greeting/4 =>Greetings to 4 people</example>
        /// <example>api/greeting/6 =>Greetings to 6 people</example>
        /// number.Tostring() ====>To convert the integer to string
        public string Get(int id)
        {
            int number = id;
            string message = "Greetings to " + number.ToString() + " people";
            return message;
        }
    }
}
