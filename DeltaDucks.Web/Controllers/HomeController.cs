using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeltaDucks.Models;
using DeltaDucks.Service;
using DeltaDucks.Web.Models;

namespace DeltaDucks.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILandmarkService _landmarkService;

        public HomeController(ILandmarkService landmarkService)
        {
            this._landmarkService = landmarkService;
        }

        public ActionResult Index()
        {

            Landmark landmark = _landmarkService.GetLandmarkById(1);

            LandmarkViewModel landmarkViewModel = new LandmarkViewModel
            {
               Name = landmark.Name
            };
            return View(landmarkViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}