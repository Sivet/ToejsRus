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

        /// <summary>This GET method returns </summary>
        /// <returns>An arrey of MakerSpases</returns>
        [HttpGet]
        public string GetImage(string imageName)
        {
            return "s";
        }

        /// <summary>This GET method returns all MakerSpaces from DB</summary>
        /// <returns>An arrey of MakerSpases</returns>
        [HttpGet]
        public string GetClothType(string gender)
        {
            return "s";
        }

        /// <summary>This GET method returns all MakerSpaces from DB</summary>
        /// <returns>An arrey of MakerSpases</returns>
        [HttpGet]
        public string GetAllofType(string type, string gender)
        {
            return "s";
        }

        /// <summary>This GET method returns all MakerSpaces from DB</summary>
        /// <returns>An arrey of MakerSpases</returns>
        [HttpGet]
        public string GetInfoOnItem(string item)
        {
            return "s";
        }

        /// <summary>This GET method returns all MakerSpaces from DB</summary>
        /// <returns>An arrey of MakerSpases</returns>
        [HttpGet]
        public string GetAllImgOnItem(string item)
        {
            return "s";
        }
    }
}