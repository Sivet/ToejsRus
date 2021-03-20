using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreInventory.Models;
using StoreInventory.Services;

namespace StoreInventory.Controllers{

    /// <summary>Controller responsible for GET/POST/DELETE for managing Item Catalog </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class InventoryController : ControllerBase{
        IService _service;

        public InventoryController(IService service){
            _service = service;
        }
        
        /// <summary>This method takes a gender type</summary>
        /// <returns>Returns a collection of clothes types for that gender</returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetClothTypes(string gender)
        {
            return Ok("s");
        }

        /// <summary>This method takes a clothes type and a gender</summary>
        /// <returns>Returns a collection of all available clothes of that type</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Clothes>> GetAllClothesOfType(string type, string gender)
        {
            return Ok("s");
        }

        /// <summary>This method takes the name of a given item</summary>
        /// <returns>Returns all information on that item</returns>
        [HttpGet]
        public ActionResult<Clothes> GetInfoOnItem(string item)
        {
            return Ok("s");
        }
    }
}