using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic_Clone.Models;
using MvcBasic_Clone.ViewModels;

namespace MvcBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Kevin";		    //儲存字串
            ViewData["Age"] = 33;               //儲存整數
            ViewData["Single"] = true;          //儲存布林值


            return View();
        }

        public ActionResult PassViewBag()
        {
            ViewBag.Nickname = "Mary";
            ViewData["nickname"] = "David";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;


            return View();
        }

        public ActionResult PassViewModel()
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.Employees = null;
            peopleVM.Friends = null;


            return View(peopleVM);
        }
    }
}