using Movie_MVC_app.Models;
using System.Collections.Generic;
using System.Linq;
namespace Movie_MVC_app.Data

{
    public class CategoryRepository
    {
     private static List<Category> _Category=null;

        static CategoryRepository(){
            _Category=new List<Category>(){
             new Category{
                 id=0,
                 Name="Aksiyon"
             },
             new Category{
                 id=1,
                 Name="Bilim Kurgu"
             },
             new Category{
                 id=2,
                 Name="Komedi"
             },
             new Category{
                 id=3,
                 Name="Macera"
             }, 
             new Category {
                 id=4,
                 Name="Romantik"
             }
            };
        }
        public static List<Category> Category{
            get{
                return _Category;
            }
        }
        public static void AddMovie(Category entity)
        {
            _Category.Add(entity);
        }
        public static Category getByID(int id){
            return _Category.FirstOrDefault(i=>i.id==id);
            
        }
    }
}