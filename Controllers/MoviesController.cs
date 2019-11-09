using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // Get: Movies
        [HttpGet]
        public ActionResult Index()
        {
            List<Movie> movies = GetMovies();

            return View(movies);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var movie = GetMovies().Where(x => x.Id == id).FirstOrDefault();

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        //GET: Movies/Random
        [HttpGet]
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        private static List<Movie> GetMovies()
        {
            var movies = new List<Movie>();
            movies.Add(new Movie { Id = 1, Name = "Shrek" });
            movies.Add(new Movie { Id = 2, Name = "Vikings" });
            return movies;
        }

        //[Route("movies/released/{year}/{month:regex(\\d{2}:range(1, 12))}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}