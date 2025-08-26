using System.ComponentModel.DataAnnotations;

namespace E_Ticket516.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public MovieStatus Status { get; set; }
        public ICollection<MovieImage> Images { get; set; } = new List<MovieImage>();
        public DateTime StartDate { get; set; }
        [Display(Name = "Cinema")]
        public int CinemaId { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Cinema Cinema { get; set; }
        public Category Category { get; set; }

        public ICollection<ActorMovie> actorsMovies { get; set; } = new List<ActorMovie>();

    }

    public enum MovieStatus
    {
        coming,
        available,
        expire
    }

}
