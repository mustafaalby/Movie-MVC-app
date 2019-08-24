using System.Collections.Generic;
using System.Linq;
using Movie_MVC_app.Models;

namespace Movie_MVC_app.Data
{
    public class MovieRepository
    {
        private static List<Movies> _Movies=null;

        static MovieRepository(){
            _Movies=new List<Movies>{
                new Movies(){ id=0,
                Name="Shazam",
                shortDescription="Shazam",
                ImageUrl="1.jpg",
                Description="ajsdlfjasdlfşasdjkfşsadkjfşasdfjkasdşjkfsaşfjksajsadkş",
                CategoryId=1},
                
                new Movies(){ id=1,Name="Amazing Grace",
                shortDescription="Amazing Grace",ImageUrl="2.jpg", CategoryId=2,
                Description="iasşldkfiasdkfisdkflas"},
                new Movies(){ id=2,Name="High Life",shortDescription="High Life",ImageUrl="3.jpg",CategoryId=3,
                Description="şlkajsdşflkjasdşfjsadfşdsa"},
                new Movies(){ id=3,Name="Bilboard",shortDescription="Bilboard",ImageUrl="4.jpg",CategoryId=4,
                Description="aksdjfşlasjdşflksdjfşksda"},
                new Movies(){ id=4,Name="Storm boy",shortDescription="Storm Boy",ImageUrl="5.jpg",CategoryId=2,
                Description="askfşasdkfmxncçvmxnzwpeırpoweırwop"}

            };
        }
        public static List<Movies> Movies{
            get{
                return _Movies;
            }
        }
        public static void AddMovie(Movies entity)
        {
            _Movies.Add(entity);
        }
        public static Movies getByID(int id){
            return _Movies.FirstOrDefault(i=>i.id==id);
            
        }
    }
}