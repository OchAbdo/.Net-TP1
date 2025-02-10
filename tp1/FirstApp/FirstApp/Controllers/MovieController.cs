using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie(1 , "movie1"),
                new Movie(2 , "movie2")
            };

            return View(movies);
        }

        public IActionResult Affich() 
        {
            List<Movie> ms = new List<Movie>()
            {
                new Movie(3 , "movie3"),
                new Movie(4 , "moviz4")
            };
            return View(ms);
        }

        public IActionResult Edit(int id) 
        {
            return Content("id est "+id);
        }

        [Route("Movie/released/{year:int}/{month:int}")]
        public IActionResult released(int year , int month) 
        {
            return Content($"{year}/{month}");
        }

        public IActionResult ListFilm(int id) 
        {
            Movie m1 = new Movie(1, "movie1");
            List<Customer> l = new List<Customer>()
            {
                new Customer(1 , "cus1"),
                new Customer(2 , "cus2"),
                new Customer(3 , "cus3")
            };
            FilmCostumer lfilm = new FilmCostumer(m1 , l);
            Customer k = lfilm.Customer[id];

            return View(k);
        }



    }
}
