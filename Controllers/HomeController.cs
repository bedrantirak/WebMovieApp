using AppForMovie.Data;
using AppForMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppForMovie.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           //ProductRepository.Movies
           //CategoryRepository.Categories
           MovieCategoryModel model= new MovieCategoryModel();
           model.Categories=CategoryRepository.Categories;
           model.Movies=MovieRepository.Movies;


            return View(model);
        }
        public IActionResult Details(int id)
        {
         MovieCategoryModel model= new MovieCategoryModel();
         model.Categories = CategoryRepository.Categories;
         model.Movie=MovieRepository.GetById(id);
          return View(model);
        }
        public IActionResult Contact()
        {
        
          return View();
        }
        
    }
}