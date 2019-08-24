using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Movie_MVC_app.Data;
using Movie_MVC_app.Models;

namespace Movie_MVC_app.Controllers
{
    public class HomeController:Controller
    {
        
        public IActionResult index(int? id)
        {
          //TODO: Implement Realistic Implementation
        /*   MovieCategoryModel model=new MovieCategoryModel();
          model.Movies=MovieRepository.Movies;
          model.Categories=CategoryRepository.Category;*/
          var movies=MovieRepository.Movies;
           
          if(id!=null){

              movies=movies.Where(i=>i.CategoryId==id).ToList();
          }
          return View(movies);
        }
        public IActionResult Contact()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        public IActionResult Details(int id)
        {
          MovieCategoryModel model=new MovieCategoryModel();
          model.Categories=CategoryRepository.Category;
          model.Movie=MovieRepository.getByID(id);
          return View(model);
        }
    }
}