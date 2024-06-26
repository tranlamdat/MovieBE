using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class addMovieMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieUrl",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "PosterImage",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "MoviesMedias",
                columns: table => new
                {
                    MovieMediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesMedias", x => x.MovieMediaId);
                    table.ForeignKey(
                        name: "FK_MoviesMedias_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2428), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2434), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2436), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2437), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2439), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2443), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2444), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2445), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2447), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2469), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2471), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2474), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2490), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2493), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2495), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2497), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2516), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2519), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2520), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2521), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2523), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2524), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2525), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2526), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateCreated", "DateUpdated", "Description", "DirectorId", "Duration", "GenreId", "National", "NumberOfView", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2553), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2553), "Inception is a mind-bending thriller where dream invasion is possible. Dom Cobb, a skilled thief, extracts secrets from deep within the subconscious during dreams. Cobb is an international fugitive seeking redemption through one last job: to plant an idea instead of stealing it. Success could be the perfect crime.", 2, 148, 5, "USA", 10, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { 2, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2556), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2556), "Titanic is a love story that unfolds on the ill-fated ship. Seventeen-year-old Rose boards with her aristocratic family, feeling suffocated by societal constraints and an impending arranged marriage. She meets Jack, a third-class passenger, and they fall in love amid the ship's grandeur and tragedy.", 5, 195, 6, "USA", 8, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic" },
                    { 3, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2558), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2558), "Pulp Fiction intertwines the lives of Los Angeles criminals, including hitmen, a boxer, and a mob boss, in a series of interconnected stories blending violence and redemption.", 4, 154, 7, "USA", 18, new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { 4, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2559), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2560), "The Dark Knight follows Batman as he confronts the Joker, a psychopathic criminal wreaking havoc on Gotham City. The conflict forces Batman to confront his own ideals and methods in combating crime.", 2, 152, 1, "USA", 2, new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { 5, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2561), "Avatar follows Jake Sully, a paraplegic Marine, who becomes part of the Avatar Program on Pandora, where he integrates with the Na'vi to infiltrate the indigenous species for a corporate mission. However, his experiences lead him to question his allegiances and fight for Pandora's survival.", 5, 162, 5, "USA", 10, new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar" },
                    { 6, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2563), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2563), "The Matrix centers on Neo, a computer hacker who discovers that reality is a simulated world created by sentient machines to subdue humanity. Neo joins a group of rebels to overthrow the machines and free humanity from their control.", 7, 136, 5, "USA", 20, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { 7, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2564), "La La Land tells the story of Mia, an aspiring actress, and Sebastian, a jazz musician, who meet and fall in love in Los Angeles while pursuing their dreams. Their relationship faces challenges as they navigate the competitive and demanding entertainment industry.", 10, 128, 6, "USA", 7, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "La La Land" },
                    { 8, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2566), "The Lord of the Rings: The Return of the King depicts the final battle for Middle-earth as Aragorn, Frodo, and their allies confront Sauron's forces in an epic conclusion to the trilogy.", 8, 201, 8, "New Zealand", 80, new DateTime(2003, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King" },
                    { 9, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2567), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2567), "Pan's Labyrinth follows Ofelia, a young girl in post-Civil War Spain, who discovers a mysterious labyrinth and encounters magical creatures. Amid her harsh reality, Ofelia navigates a world of fantasy to fulfill a daunting task.", 9, 118, 4, "Mexico", 1, new DateTime(2006, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pan's Labyrinth" },
                    { 10, new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2568), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2569), "Wonder Woman chronicles Diana, an Amazonian warrior princess, who leaves her home to fight alongside humans in World War I. As she discovers her powers and true destiny, she becomes a symbol of hope and inspiration.", 9, 141, 1, "USA", 64, new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder Woman" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2373), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2385), "AQAAAAEAACcQAAAAEPV79hd6mLIcRRkv7PQDk4NDIKztcoEw8Mx4YLIotGRRiMjTSb1yE77G4wCCIuGCow==" });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesMedias_MovieId",
                table: "MoviesMedias",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviesMedias");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MovieUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PosterImage",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7219), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7221), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7222), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7224), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7260), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7282), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7334), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7335), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7337), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 6, 27, 0, 6, 17, 890, DateTimeKind.Local).AddTicks(7146), "AQAAAAEAACcQAAAAEAvp6On5wZGXpk//ZUI74iSE11QbTsY9Y0NveGJPVP7+AzOmiausxSFHzTF/+cWoeA==" });
        }
    }
}
