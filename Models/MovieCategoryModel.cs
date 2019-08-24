using System.Collections.Generic;

namespace Movie_MVC_app.Models
{
    public class MovieCategoryModel
    {
        public Movies Movie { get; set; }
        public  IEnumerable<Movies> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}