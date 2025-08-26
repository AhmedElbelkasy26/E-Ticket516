namespace E_Ticket516.Models
{
    public class Cinema
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        public string? CinemaLogo { get; set; } = string.Empty;

        public string? Address { get; set; } = string.Empty;
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
