using AngiesVehicles.Services;
using AngiesVehicles.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngiesVehicles.Models;

namespace AngiesVehicles.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInventoryHelper _inventoryHelper;

        public HomeController(IInventoryHelper inventoryHelper)
        {
            _inventoryHelper = inventoryHelper;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Angie's Inventory.";

            return View(_inventoryHelper.GetInventoryViewModel());
        }
    }
}