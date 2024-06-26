using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class addSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "DateCreated", "DateUpdated", "DoB", "Name", "Nationality" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7212), new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert Downey Jr.", "American" },
                    { 2, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7218), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scarlett Johansson", "American" },
                    { 3, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7219), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7219), new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo DiCaprio", "American" },
                    { 4, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7220), new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jennifer Lawrence", "American" },
                    { 5, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7221), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7221), new DateTime(1954, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denzel Washington", "American" },
                    { 6, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7222), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7222), new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalie Portman", "Israeli-American" },
                    { 7, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7223), new DateTime(1956, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Hanks", "American" },
                    { 8, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7224), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7224), new DateTime(1990, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma Watson", "British" },
                    { 9, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7226), new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brad Pitt", "American" },
                    { 10, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7227), new DateTime(1985, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gal Gadot", "Israeli" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "DirectorId", "DateCreated", "DateUpdated", "DoB", "Name", "Nationality" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7257), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven Spielberg", "American" },
                    { 2, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7259), new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher Nolan", "British" },
                    { 3, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7260), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7261), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin Scorsese", "American" },
                    { 4, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7282), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7294), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quentin Tarantino", "American" },
                    { 5, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7306), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Cameron", "Canadian" },
                    { 6, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7307), new DateTime(1951, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kathryn Bigelow", "American" },
                    { 7, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7308), new DateTime(1937, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ridley Scott", "British" },
                    { 8, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7309), new DateTime(1961, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Jackson", "New Zealander" },
                    { 9, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7310), new DateTime(1964, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guillermo del Toro", "Mexican" },
                    { 10, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7311), new DateTime(1983, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greta Gerwig", "American" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7329), "Action" },
                    { 2, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7330), "Comedy" },
                    { 3, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7331), "Drama" },
                    { 4, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7332), "Horror" },
                    { 5, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7333), "Science-Fiction" },
                    { 6, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7334), "Romance" },
                    { 7, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7334), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7335), "Thriller" },
                    { 8, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7335), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7335), "Fantasy" },
                    { 9, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7336), "Animation" },
                    { 10, new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7337), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7337), "Documentary" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7146), "AQAAAAEAACcQAAAAEAvp6On5wZGXpk//ZUI74iSE11QbTsY9Y0NveGJPVP7+AzOmiausxSFHzTF/+cWoeA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "MovieUrl",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEOZQXMnWlCDt9psk3Pq4/yt0JCwV0TvNxy48wmARbp7dQkQmEVKEnOwezq/HY+sfOw==" });
        }
    }
}
