using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockoutSamples.ViewModels;

namespace KnockoutSamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Knockout Samples";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Simple()
        {
            return View();
        }

        public ActionResult SimpleDynamic()
        {
            return View();
        }

        public ActionResult SimpleComputed()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult SimpleList()
        {
            return View();
        }

        public ActionResult ComplexList()
        {
            return View();
        }

        public ActionResult EditableList()
        {
            return View();
        }

        public ActionResult MvcViewModel()
        {
            var vm = new PersonViewModel()
            {
                FirstName = "Bill",
                LastName = "Brasky",
                Age = 37
            };

            return View(vm);
        }

        public ActionResult MvcListViewModel()
        {
            var vm = new List<PersonViewModel>()
            {
                new PersonViewModel() 
                {
                    FirstName = "Bill",
                    LastName = "Brasky",
                    Age = 37
                },
                new PersonViewModel() 
                {
                    FirstName = "Dave",
                    LastName = "Thomas",
                    Age = 88
                },
                new PersonViewModel() 
                {
                    FirstName = "Chris",
                    LastName = "Columbus",
                    Age = 53
                },

            };

            return View(vm);
        }

        public ActionResult MvcLoadViewModel() 
        {
            var vm = new PeopleViewModel() { Category = "Guitar Gods" };
            vm.People = new List<PersonViewModel>()
            {
                new PersonViewModel() 
                {
                    FirstName = "Jimmy",
                    LastName = "Hendrix",
                    Age = 67
                },
                new PersonViewModel() 
                {
                    FirstName = "Joe",
                    LastName = "Perry",
                    Age = 63
                },
                new PersonViewModel() 
                {
                    FirstName = "Lenny",
                    LastName = "Cravitz",
                    Age = 33
                },
            };

            return View(vm);
        }

        public ActionResult MoreThanData()
        {
            return View();
        }
    }
}
