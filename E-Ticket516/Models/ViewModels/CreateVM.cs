namespace E_Ticket516.Models.ViewModels
{
    public class CreateVM
    {
        public List<Actor> Actors { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Category> Categories { get; set; }
        public Movie Movie { get; set; }
        public List<int> SelectedActors { get; set; }
    }
}
