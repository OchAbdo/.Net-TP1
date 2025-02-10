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

        public IActionResult Affich(int id) 
        {
           var ss =  lfilm.Customer.FirstOrDefault(ss =>  ss.Id == id);
            return View(ss);
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

            FilmCostumer lfilm = new FilmCostumer(new Movie(1, "movie1") , new List<Customer>()
            {
                new Customer(1 , "cus1"),
                new Customer(2 , "cus2"),
                new Customer(3 , "cus3")
            });
        public IActionResult ListFilm() 
        {
            //Customer k = lfilm.Customer[id];

            return View(lfilm);
        }



    }
}
