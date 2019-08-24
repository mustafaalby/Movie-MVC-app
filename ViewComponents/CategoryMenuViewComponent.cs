using Microsoft.AspNetCore.Mvc;
using Movie_MVC_app.Data;

namespace Movie_MVC_app.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(){

            return View(CategoryRepository.Category);
        }
    }
}