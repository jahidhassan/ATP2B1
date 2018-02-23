using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATP2B1.Models;
using ATP2B1.ViewModel;

namespace ATP2B1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                ID = 1,
                Name = "Die Hard 1"
            };
            var customers = new List<Customer>();
            customers.Add(new Customer()
            {
                ID = 1,Name = "Rahat"
            });
            customers.Add(new Customer()
            {
                ID = 1,
                Name = "Sanju-Irani"
            });

            var rvm = new RandomMovieVM()
            {
                Movie = movie,
                Customers = customers
            };

            return View(rvm);
        }

        [Route("movie/release/{month:range(1,12)}/{year}")]
        public ActionResult ByRelease(int month, int year)
        {
            return Content(month+"/"+year);
        }
    }
}