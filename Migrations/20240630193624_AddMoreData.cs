using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class AddMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3292), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3296), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3298), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3299), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3303), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3305), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3356), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3393), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3397), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3399), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3402), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3571), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3573), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3575), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3583), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3585), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "MovieActorId", "ActorId", "CharacterName", "DateCreated", "DateUpdated", "MovieId" },
                values: new object[,]
                {
                    { 1, 1, "Cobb", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3691), 1 },
                    { 2, 2, "Ariadne", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3694), 1 },
                    { 3, 3, "Arthur", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3695), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3696), 1 },
                    { 4, 3, "Jack Dawson", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3697), 2 },
                    { 5, 4, "Rose DeWitt Bukater", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3699), 2 },
                    { 6, 5, "Cal Hockley", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3701), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3701), 2 },
                    { 7, 5, "Vincent Vega", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3703), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3703), 3 },
                    { 8, 6, "Mia Wallace", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3706), 3 },
                    { 9, 7, "Jules Winnfield", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3707), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3708), 3 },
                    { 10, 1, "Bruce Wayne/Batman", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3709), 4 },
                    { 11, 8, "Joker", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3711), 4 },
                    { 12, 9, "Harvey Dent", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3715), 4 }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "MovieActorId", "ActorId", "CharacterName", "DateCreated", "DateUpdated", "MovieId" },
                values: new object[,]
                {
                    { 13, 2, "Jake Sully", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3716), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3716), 5 },
                    { 14, 10, "Neytiri", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3718), 5 },
                    { 15, 3, "Colonel Miles Quaritch", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3720), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3720), 5 },
                    { 16, 1, "Neo", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3722), 6 },
                    { 17, 5, "Morpheus", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3723), 6 },
                    { 18, 7, "Trinity", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3725), 6 },
                    { 19, 6, "Sebastian", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3726), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3726), 7 },
                    { 20, 7, "Mia", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3728), 7 },
                    { 21, 8, "Keith", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3729), 7 },
                    { 22, 8, "Frodo Baggins", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3731), 8 },
                    { 23, 9, "Aragorn", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3733), 8 },
                    { 24, 10, "Gandalf", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3734), 8 },
                    { 25, 10, "Ofelia", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3735), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3736), 9 },
                    { 26, 6, "Carmen", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3737), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3737), 9 },
                    { 27, 7, "Captain Vidal", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3738), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3739), 9 },
                    { 28, 2, "Diana Prince/Wonder Woman", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3740), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3740), 10 },
                    { 29, 4, "Steve Trevor", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3741), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3742), 10 },
                    { 30, 3, "Antiope", new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3743), 10 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3622), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3627), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3630), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3633), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3635), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3640), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3645), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3649), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.InsertData(
                table: "MoviesMedias",
                columns: new[] { "MovieMediaId", "MovieId", "Name", "PublicId", "Type", "Url" },
                values: new object[,]
                {
                    { 1, 1, "Inception Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 2, 1, "Inception Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 3, 1, "Inception Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 4, 1, "Inception Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 5, 2, "Titanic Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 6, 2, "Titanic Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 7, 2, "Titanic Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 8, 2, "Titanic Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 9, 3, "Pulp Fiction Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 10, 3, "Pulp Fiction Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 11, 3, "Pulp Fiction Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 12, 3, "Pulp Fiction Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 13, 4, "The Dark Knight Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 14, 4, "The Dark Knight Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" }
                });

            migrationBuilder.InsertData(
                table: "MoviesMedias",
                columns: new[] { "MovieMediaId", "MovieId", "Name", "PublicId", "Type", "Url" },
                values: new object[,]
                {
                    { 15, 4, "The Dark Knight Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 16, 4, "The Dark Knight Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 17, 5, "Avatar Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 18, 5, "Avatar Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 19, 5, "Avatar Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 20, 5, "Avatar Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 21, 6, "The Matrix Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 22, 6, "The Matrix Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 23, 6, "The Matrix Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 24, 6, "The Matrix Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 25, 7, "La La Land Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 26, 7, "La La Land Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 27, 7, "La La Land Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 28, 7, "La La Land Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 29, 8, "The Lord of the Rings: The Return of the King Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 30, 8, "The Lord of the Rings: The Return of the King Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 31, 8, "The Lord of the Rings: The Return of the King Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 32, 8, "The Lord of the Rings: The Return of the King Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 33, 9, "Pan's Labyrinth Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 34, 9, "Pan's Labyrinth Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 35, 9, "Pan's Labyrinth Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 36, 9, "Pan's Labyrinth Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" },
                    { 37, 10, "Wonder Woman Poster", "POSTER/xhprcuwrw5rewdojm9ke", 0, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774876/POSTER/xhprcuwrw5rewdojm9ke.jpg" },
                    { 38, 10, "Wonder Woman Banner", "BANNER/g5dqzcs4zwgxvvw3lsma", 1, "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg" },
                    { 39, 10, "Wonder Woman Trailer", "TRAILER/kou9a1hm4axazrmvxfgh", 2, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4" },
                    { 40, 10, "Wonder Woman Video", "VIDEO/fnoqi8bubpp3zk2l44y5", 4, "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3184), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3202), "AQAAAAEAACcQAAAAEOzkrOsvR/BKG4OYWa+dUSciOZcLSSe7LPsosaKzlXnvjyCbirugd9Ba4pLsP1dqGw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 40);

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
        }
    }
}
