using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookish.Migrations
{
    public partial class CreateForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookAuthor",
                table: "BookCheckedOutModel");

            migrationBuilder.DropColumn(
                name: "BookTitle",
                table: "BookCheckedOutModel");

            migrationBuilder.RenameColumn(
                name: "BookYear",
                table: "BookCheckedOutModel",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "BookToBeReturned",
                table: "BookCheckedOutModel",
                newName: "ReturnDate");

            migrationBuilder.RenameColumn(
                name: "BookCheckedOutByLibrarian",
                table: "BookCheckedOutModel",
                newName: "LibrarianId");

            migrationBuilder.RenameColumn(
                name: "BookCheckedOut",
                table: "BookCheckedOutModel",
                newName: "IssueDate");

            migrationBuilder.RenameColumn(
                name: "BookBorrowedByUser",
                table: "BookCheckedOutModel",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "BookCheckedOutId",
                table: "BookCheckedOutModel",
                newName: "CopyId");

            migrationBuilder.DropColumn(
                name: "UserDOB",
                table: "UserModel");

            migrationBuilder.AddColumn<DateTime>(
                name: "UserDOB",
                table: "UserModel",
                type: "datetime2",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "BookModelBookId",
                table: "BookCheckedOutModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibrarianModelLibrarianId",
                table: "BookCheckedOutModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserModelUserId",
                table: "BookCheckedOutModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookCheckedOutModel_BookModelBookId",
                table: "BookCheckedOutModel",
                column: "BookModelBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCheckedOutModel_LibrarianModelLibrarianId",
                table: "BookCheckedOutModel",
                column: "LibrarianModelLibrarianId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCheckedOutModel_UserModelUserId",
                table: "BookCheckedOutModel",
                column: "UserModelUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCheckedOutModel_BookModel_BookModelBookId",
                table: "BookCheckedOutModel",
                column: "BookModelBookId",
                principalTable: "BookModel",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCheckedOutModel_LibrarianModel_LibrarianModelLibrarianId",
                table: "BookCheckedOutModel",
                column: "LibrarianModelLibrarianId",
                principalTable: "LibrarianModel",
                principalColumn: "LibrarianId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCheckedOutModel_UserModel_UserModelUserId",
                table: "BookCheckedOutModel",
                column: "UserModelUserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCheckedOutModel_BookModel_BookModelBookId",
                table: "BookCheckedOutModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCheckedOutModel_LibrarianModel_LibrarianModelLibrarianId",
                table: "BookCheckedOutModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCheckedOutModel_UserModel_UserModelUserId",
                table: "BookCheckedOutModel");

            migrationBuilder.DropIndex(
                name: "IX_BookCheckedOutModel_BookModelBookId",
                table: "BookCheckedOutModel");

            migrationBuilder.DropIndex(
                name: "IX_BookCheckedOutModel_LibrarianModelLibrarianId",
                table: "BookCheckedOutModel");

            migrationBuilder.DropIndex(
                name: "IX_BookCheckedOutModel_UserModelUserId",
                table: "BookCheckedOutModel");

            migrationBuilder.DropColumn(
                name: "BookModelBookId",
                table: "BookCheckedOutModel");

            migrationBuilder.DropColumn(
                name: "LibrarianModelLibrarianId",
                table: "BookCheckedOutModel");

            migrationBuilder.DropColumn(
                name: "UserModelUserId",
                table: "BookCheckedOutModel");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BookCheckedOutModel",
                newName: "BookYear");

            migrationBuilder.RenameColumn(
                name: "ReturnDate",
                table: "BookCheckedOutModel",
                newName: "BookToBeReturned");

            migrationBuilder.RenameColumn(
                name: "LibrarianId",
                table: "BookCheckedOutModel",
                newName: "BookCheckedOutByLibrarian");

            migrationBuilder.RenameColumn(
                name: "IssueDate",
                table: "BookCheckedOutModel",
                newName: "BookCheckedOut");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookCheckedOutModel",
                newName: "BookBorrowedByUser");

            migrationBuilder.RenameColumn(
                name: "CopyId",
                table: "BookCheckedOutModel",
                newName: "BookCheckedOutId");

            migrationBuilder.AlterColumn<int>(
                name: "UserDOB",
                table: "UserModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "BookAuthor",
                table: "BookCheckedOutModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookTitle",
                table: "BookCheckedOutModel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
