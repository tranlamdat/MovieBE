using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class updateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors");

            migrationBuilder.AddColumn<int>(
                name: "WatchListId",
                table: "WatchLists",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MovieActorId",
                table: "MovieActors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists",
                column: "WatchListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors",
                column: "MovieActorId");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3326), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3330), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3331), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3332), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3333), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3336), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3531), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3549), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3550), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3572), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3573), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3574), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3577), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3580), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3597), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3603), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 6, 30, 0, 24, 27, 129, DateTimeKind.Local).AddTicks(3276), "AQAAAAEAACcQAAAAEECsrYgr46/fnkWrUxraj5At9gzrCrWGUHqHHvo7FsC73wxOI9dRITXGZnIJ9mMX1A==" });

            migrationBuilder.CreateIndex(
                name: "IX_WatchLists_MovieId",
                table: "WatchLists",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_MovieId",
                table: "MovieActors",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists");

            migrationBuilder.DropIndex(
                name: "IX_WatchLists_MovieId",
                table: "WatchLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors");

            migrationBuilder.DropIndex(
                name: "IX_MovieActors_MovieId",
                table: "MovieActors");

            migrationBuilder.DropColumn(
                name: "WatchListId",
                table: "WatchLists");

            migrationBuilder.DropColumn(
                name: "MovieActorId",
                table: "MovieActors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists",
                columns: new[] { "MovieId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors",
                columns: new[] { "MovieId", "ActorId" });

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

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2553), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2556), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2558), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2559), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2563), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2567), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2568), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2373), new DateTime(2024, 6, 27, 1, 39, 9, 513, DateTimeKind.Local).AddTicks(2385), "AQAAAAEAACcQAAAAEPV79hd6mLIcRRkv7PQDk4NDIKztcoEw8Mx4YLIotGRRiMjTSb1yE77G4wCCIuGCow==" });
        }
    }
}
