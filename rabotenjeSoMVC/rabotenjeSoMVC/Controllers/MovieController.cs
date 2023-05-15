using rabotenjeSoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace rabotenjeSoMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie

        public static List<Movie> movies = new List<Movie>()
        {
            new Movie(){ Name = "Titanic", Id = 7, DonwlaudUrl = "test", reating = 7.5f, ImageUrl = @"https://pbs.twimg.com/media/Fon8-EDXsAEv8T1?format=jpg&name=large" }
        };
        public static List<Clint> clints = new List<Clint>()
        {
        };


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowMovie(int id)
        {
            MovieRentals model = new MovieRentals();
            model.clintsList = clints;
            model.movie = movies.ElementAt(id);
            return View(model);
        }
        public ActionResult ShowClient(int id)
        {
            var model = clints.ElementAt(id);
            return View(model);
        }

        public ActionResult GetAllMovies()
        {
            return View(movies);
        }
        public ActionResult NewMovie()
        {
            Movie model = new Movie();
            return View(model);
        }
        public ActionResult NewClient()
        {
            Clint model = new Clint();
            return View(model);
        }

        [HttpPost]
        public ActionResult InsertNewClient(Clint model)
        {
            if (!ModelState.IsValid)
            {
                return View("NewClient", model);
            }
            else
            {
                clints.Add(model);
                return View("GetAllMovies", movies);
            }
        }

        [HttpPost]
        public ActionResult InsertNewMovie(Movie model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewMovie", model);
            }
            else
            {
                movies.Add(model);
                return View("GetAllMovies", movies);
            }
        }
        public ActionResult EditMovie(int id)
        {
            var model = movies.ElementAt(id);
            model.Id = id;
            return View(model);
        }
        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewMovie", model);
            }
            var foredit = movies.ElementAt(model.Id);
            foredit.reating = model.reating;
            foredit.DonwlaudUrl = model.DonwlaudUrl;
            foredit.ImageUrl = model.ImageUrl;
            foredit.Name = model.Name;
            return View("GetAllMovies", movies);
        }
        public ActionResult DeleteMovie(int id)
        {
            movies.RemoveAt(id);
            return View("GetAllMovies", movies);
        }
    }


}