
using Mission_6_Sara_Oliveira.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Mission_6_Sara_Oliveira.Controllers
{
    public class HomeController : Controller
    {
        private FilmContext _context;
        public HomeController(FilmContext tempdata) 
        {
            _context = tempdata;
        }

        public IActionResult Index()//gets index
        {
            return View();//renders index
        }
        [HttpGet]
        public IActionResult Getjoel()//this is for the joel view
        {
            return View();
        }
        [HttpGet]
        public IActionResult Film()//gets the form to submit a moview
        {
           ViewBag.Categories= _context.Categories
                .OrderBy(x => x.Category)
                .ToList();
            
            return View("Film", new Movies());
        }

        
        [HttpPost]
        public IActionResult Film(Movies response)
        
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);//adding record to database
                _context.SaveChanges();
                return View("Confirmation");
            }
            else//Invalid
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();
                return View(response);
            }
        }  
        
       

        public IActionResult MoviesList()//displays database
        {
           var movies= _context.Movies.ToList();

            return View(movies);
 

        }

        [HttpGet]
        public IActionResult Edit(int id)//gets the id of the record im editing and returns it to be edited

        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();
            return View("Film", recordToEdit);
        }

        [HttpPost]

        public IActionResult Edit(Movies updatedInfo)//updates the record
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction  ("MoviesList");
        }

        [HttpGet]
        public IActionResult Delete(int id)//gets the id of the record im editing and returns it to be deleteed
        {

            var recordToDelete = _context.Movies
                .Single(x =>   x.MovieId == id);

            //ViewBag.Categories = _context.Categories
            //    .OrderBy(x => x.Category)
            //    .ToList();
            return View("Delete", recordToDelete);


        }
        [HttpPost]
        public IActionResult Delete(Movies movie)//actually deeletes record
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MoviesList");

        }


    }
}
