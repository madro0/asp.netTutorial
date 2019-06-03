using FirstCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstCrud.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonModel personModel)
        {
            if (ModelState.IsValid)
            {
                personModel.Save();
                return RedirectToAction("Success");
            }
            else
            {
                return View(personModel);
            }
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Show()
        {
            PersonModel pe = new PersonModel();
            pe.Lista = pe.show();
            return View(pe);
        }

    }
}