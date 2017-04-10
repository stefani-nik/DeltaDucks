using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeltaDucks.Models;
using DeltaDucks.Service.Interfaces;
using DeltaDucks.Service.Services;
using DeltaDucks.Web.Models;
using DeltaDucks.Web.ViewModels;

namespace DeltaDucks.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILandmarkService _landmarkService;


        public HomeController(ILandmarkService landmarkService)
        {
<<<<<<< HEAD
            _landmarkService = landmarkService;
=======
            this._landmarkService = landmarkService;
<<<<<<< HEAD
=======
=======
        public HomeController()
        {
            // add service object to _landmarkService here
>>>>>>> d7713e7a9e6ad1e27839dc744e045cb4661d65e9
>>>>>>> 8a5bd95cef1941d504cd5b5d3d448794adb35d00
>>>>>>> 2cc19fa0b4eb16e9e5db0b1fcccba23b2aaf345c
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
    }
}