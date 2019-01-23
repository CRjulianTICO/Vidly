using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sherk!" };
            return View(movie);
            // return Content("Hola Mundo!");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index","Home", new { page = 1, sortBy = "name"});

        }

        public ActionResult Edit(Int32 id)
        {
            return Content("ID = "+id);
        }

        //El signo de pregunta hace que el valor que llega a esa variable pueda ser nulo, 
        //por defecto el tipo String puede ser nulo, entonces no hace falta poner el signo de pregunta
        public ActionResult Index(Int32? pageIndex, String sortBy )
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("Page Index is = {0} & sortBy is = {1}", pageIndex,sortBy));
        }


        public ActionResult ByReleaseDate(Int32 year, Int32 month)
        {
            return Content(year + "/" + month);
        }


    }
}