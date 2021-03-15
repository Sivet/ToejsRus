using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace toejController.Controllers{

    /// <summary>Controller responsible for GET/POST/DELETE for managing Item Catalog </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class ItemOverviewController : ControllerBase{
        
        /// <summary>This method takes a gender type</summary>
        /// <returns>Returns a collection of clothes types for that gender</returns>
        [HttpGet]
        public string GetClothType(string gender)
        {
            return "s";
        }

        /// <summary>This method takes a clothes type and a gender</summary>
        /// <returns>Returns a collection of all available clothes of that type</returns>
        [HttpGet]
        public string GetAllClothesOfType(string type, string gender)
        {
            return "s";
        }

        /// <summary>This method takes the name of a given item</summary>
        /// <returns>Returns all information on that item</returns>
        [HttpGet]
        public string GetInfoOnItem(string item)
        {
            return "s";
        }
    }
}