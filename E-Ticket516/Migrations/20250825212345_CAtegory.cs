using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Ticket516.Migrations
{
    /// <inheritdoc />
    public partial class CAtegory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categories (Name) values ('Comedy');\r\ninsert into Categories (Name) values ('Action');\r\ninsert into Categories (Name) values ('Romantic');\r\ninsert into Categories (Name) values ('Cartoon');\r\ninsert into Categories (Name) values ('dramatic');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Truncate Table Categories");
        }
    }
}
