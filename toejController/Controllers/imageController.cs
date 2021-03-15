using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace toejController.Controllers{

    /// <summary>Controller responsible for GET/POST/DELETE for managing Images </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class ImageController : ControllerBase{
        
        /// <summary>This method takes the name of a given item</summary>
        /// <returns>Returns the path of the first image of specified item</returns>
        [HttpGet]
        public string GetImage(string item)
        {
            return "s";
        }

        /// <summary>This method takes a collection of items</summary>
        /// <returns>Returns a list of the first image of each item</returns>
        [HttpGet]
        public List<string> GetListOfImage(List<string> items)
        {
            return new List<string>(){"img1", "img2"};
        }

        /// <summary>This method takes the name of an item</summary>
        /// <returns>Returns a collection of paths to all images associated with that item</returns>
        [HttpGet]
        public string GetAllImgOnItem(string item)
        {
            return "s";
        }
    }
}