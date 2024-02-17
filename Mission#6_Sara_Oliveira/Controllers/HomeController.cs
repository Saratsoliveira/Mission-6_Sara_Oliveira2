
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

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Getjoel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Film()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Film(Application response)
        
        {
            _context.Applications.Add(response);//adding record to database
            _context.SaveChanges();
            return View("Confirmation");
        }  
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
