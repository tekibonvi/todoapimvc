using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace todoapimvc.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id_user = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_user);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id_todo_item = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ritle = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    UserId_user = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id_todo_item);
                    table.ForeignKey(
                        name: "FK_TodoItems_Users_UserId_user",
                        column: x => x.UserId_user,
                        principalTable: "Users",
                        principalColumn: "Id_user",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_user", "Address", "Email", "Name" },
                values: new object[,]
                {
                    { 3, "Balcarce 16", "ezequiasbonvi@utn.com", "Ezequias" },
                    { 5, "Av Alberdi 16", "hermankuka@utn.com", "Herman" },
                    { 9, "Rio de Janeiro 300", "juanperez@utn.com", "Juan" },
                    { 15, "Hermano Indio 24", "marcefrac@utn.com", "Marcelo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_UserId_user",
                table: "TodoItems",
                column: "UserId_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
