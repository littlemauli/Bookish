using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookish.Migrations
{
    public partial class CreateBookishDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCheckedOutModel",
                columns: table => new
                {
                    BookCheckedOutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookYear = table.Column<int>(type: "int", nullable: false),
                    BookCheckedOutByLibrarian = table.Column<int>(type: "int", nullable: false),
                    BookBorrowedByUser = table.Column<int>(type: "int", nullable: false),
                    BookCheckedOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookToBeReturned = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCheckedOutModel", x => x.BookCheckedOutId);
                });

            migrationBuilder.CreateTable(
                name: "BookModel",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookYear = table.Column<int>(type: "int", nullable: false),
                    BookTotalCopies = table.Column<int>(type: "int", nullable: false),
                    BookAvailableCopies = table.Column<int>(type: "int", nullable: false),
                    BookBorrowedCopies = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModel", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "LibrarianModel",
                columns: table => new
                {
                    LibrarianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibrarianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibrarianIsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibrarianModel", x => x.LibrarianId);
                });

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDOB = table.Column<int>(type: "int", nullable: false),
                    AmountBorrowedByUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCheckedOutModel");

            migrationBuilder.DropTable(
                name: "BookModel");

            migrationBuilder.DropTable(
                name: "LibrarianModel");

            migrationBuilder.DropTable(
                name: "UserModel");
        }
    }
}
