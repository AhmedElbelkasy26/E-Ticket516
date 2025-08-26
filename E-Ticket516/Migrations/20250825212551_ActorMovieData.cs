using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Ticket516.Migrations
{
    /// <inheritdoc />
    public partial class ActorMovieData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into ActorsMovies (ActorId, MovieId) values (4, 4);\r\ninsert into ActorsMovies (ActorId, MovieId) values (13, 14);\r\ninsert into ActorsMovies (ActorId, MovieId) values (30, 17);\r\ninsert into ActorsMovies (ActorId, MovieId) values (13, 16);\r\ninsert into ActorsMovies (ActorId, MovieId) values (13, 6);\r\ninsert into ActorsMovies (ActorId, MovieId) values (17, 24);\r\ninsert into ActorsMovies (ActorId, MovieId) values (16, 9);\r\ninsert into ActorsMovies (ActorId, MovieId) values (12, 2);\r\ninsert into ActorsMovies (ActorId, MovieId) values (21, 4);\r\ninsert into ActorsMovies (ActorId, MovieId) values (5, 6);\r\ninsert into ActorsMovies (ActorId, MovieId) values (18, 2);\r\ninsert into ActorsMovies (ActorId, MovieId) values (19, 23);\r\ninsert into ActorsMovies (ActorId, MovieId) values (18, 8);\r\ninsert into ActorsMovies (ActorId, MovieId) values (16, 16);\r\ninsert into ActorsMovies (ActorId, MovieId) values (3, 20);\r\ninsert into ActorsMovies (ActorId, MovieId) values (29, 2);\r\ninsert into ActorsMovies (ActorId, MovieId) values (18, 19);\r\ninsert into ActorsMovies (ActorId, MovieId) values (23, 16);\r\ninsert into ActorsMovies (ActorId, MovieId) values (19, 12);\r\ninsert into ActorsMovies (ActorId, MovieId) values (15, 10);\r\ninsert into ActorsMovies (ActorId, MovieId) values (26, 9);\r\ninsert into ActorsMovies (ActorId, MovieId) values (18, 5);\r\ninsert into ActorsMovies (ActorId, MovieId) values (5, 7);\r\ninsert into ActorsMovies (ActorId, MovieId) values (13, 21);\r\ninsert into ActorsMovies (ActorId, MovieId) values (13, 16);\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("truncate table ActorsMovies");
        }
    }
}
