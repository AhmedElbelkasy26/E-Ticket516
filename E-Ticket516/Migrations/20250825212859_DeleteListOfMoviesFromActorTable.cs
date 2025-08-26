using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Ticket516.Migrations
{
    /// <inheritdoc />
    public partial class DeleteListOfMoviesFromActorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ActorId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ActorId",
                table: "Movies",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id");
        }
    }
}
