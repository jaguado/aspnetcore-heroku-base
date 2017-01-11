using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Values Controller
    /// </summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        /// <summary>
        /// Return all values
        /// </summary>
        /// <returns>Return a list of string values</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
