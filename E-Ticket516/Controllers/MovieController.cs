using E_Ticket516.DataAccess;
using E_Ticket516.Models;
using E_Ticket516.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Ticket516.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            var movies = _dbContext.Movies.Include(e => e.Cinema).Include(e => e.Category).Include(e => e.Images);
            return View(movies.ToList());
        }

        public IActionResult Details(int id)
        {
            var movie = _dbContext.Movies.Include(e => e.Cinema).Include(e => e.Category).Include(e => e.Images).FirstOrDefault();
            var actorMovies = _dbContext.ActorsMovies.Include(e => e.Actor).Where(e => e.MovieId == id).ToList();

            var m = new MovieAndActorMoviesVM() { ActorMovies = actorMovies, Movie = movie };
            return View(m);
        }


        public IActionResult Create()
        {
            var Cinemas = _dbContext.Cinemas.ToList();
            var CAtegories = _dbContext.Categories.ToList();
            var Actors = _dbContext.Actors.ToList();
            var m = new CreateVM() { Categories = CAtegories, Actors = Actors, Cinemas = Cinemas ,Movie = new Movie(), SelectedActors = new() };
            return View(m);
        }

        [HttpPost]
        public IActionResult Create(Movie movie , List<int>actors , List<IFormFile>imgs)
        {
            if (imgs.Any())
            {
                List<string> newImgs = new List<string>();
                foreach (var item in imgs)
                {
                    //sadghjtfr6743576sf236.png
                    var fileName = Guid.NewGuid() + Path.GetExtension(item.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\movies", fileName);
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        item.CopyTo(stream);
                    }
                    newImgs.Add(fileName);
                }
                _dbContext.Movies.Add(movie);
                _dbContext.SaveChanges();
                foreach (var item in actors)
                {
                    _dbContext.ActorsMovies.Add(new() { ActorId = item, MovieId = movie.Id });
                }
                foreach (var item in newImgs)
                {
                    _dbContext.Images.Add(new() { ImageUrl = item, MovieId = movie.Id });
                }
                _dbContext.SaveChanges();
                return RedirectToAction("index");
            }

            var Cinemas = _dbContext.Cinemas.ToList();
            var CAtegories = _dbContext.Categories.ToList();
            var Actors = _dbContext.Actors.ToList();
            var m = new CreateVM() { Categories = CAtegories, Actors = Actors, Cinemas = Cinemas , Movie = movie , SelectedActors=actors};
            return View(m);
        }
    }
}
