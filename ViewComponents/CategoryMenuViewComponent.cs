using Microsoft.AspNetCore.Mvc;
using Movie_MVC_app.Data;

namespace Movie_MVC_app.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        //RouteData.Values["action"]=index
        //RouteData.Values["controller"]=hhome
        //RouteData.Values["id"]=3
        public IViewComponentResult Invoke(){
            if(RouteData.Values["action"].ToString()=="Index")
                ViewBag.SelectedCategory=RouteData?.Values["id"];
            return View(CategoryRepository.Category);
        }
    }
}