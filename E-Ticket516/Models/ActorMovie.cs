namespace E_Ticket516.Models
{
    public class ActorMovie
    {

        public int Id { get; set; }
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
        public Actor Actor { get; set; } = null!;

    }
}
