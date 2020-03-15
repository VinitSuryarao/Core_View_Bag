using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace View_Bag.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            // Sending Simple Data
            base.ViewBag.FirstName = "Vinit";
            base.ViewBag.LastName = "Suryarao";

            // Sending COmplex Data By Convert in Json
            var clientModelObj = new
            {
                FirstName = "Avinash",
                LastName = "Suryarao"
            };

            var clientModelJson = JsonConvert.SerializeObject(clientModelObj);
            base.ViewBag.ClientModel = clientModelJson;

            return View();
        }
    }
}