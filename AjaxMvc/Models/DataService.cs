using AjaxMvc.Views.Home;

namespace AjaxMvc.Models
{
    public class DataService
    {
        List<IndexVM> Movies = new List<IndexVM>
        {
            new IndexVM { Id = 0, Title="Fast and Furious", Description= "Movie about fast cars and family"},
            new IndexVM { Id = 1, Title="Mamma Mu", Description= "Movie about a cow called Mamma Mu and her friend the crow"},
            new IndexVM { Id = 2, Title="Iron Man", Description= "Movie about a man building an iron suit in the dessert and ultimately joining the Avengers"},
        };

        public IndexVM GetMovieById(int id)
        {
            return Movies.Single(o => o.Id == id);
        }
    }
}
