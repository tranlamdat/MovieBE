using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class addContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2212), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2217), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2219), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2222), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2226), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2227), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2229), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2274), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2276), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2278), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2281), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2287), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2290), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2311), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2312), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2315), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2316), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2317), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2319), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2320), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2321), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2382), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2383), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2385), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2386), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2387), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2388), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2389), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2390), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2391), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2392), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2393), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2394), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2396), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2397), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2399), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2400), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2401), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2404), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2405), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2504), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2507), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2509), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2510), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2511), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2514), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2515), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2346), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2349), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2351), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2352), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2354), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2355), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2360), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2362), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2363), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2083), new DateTime(2024, 10, 10, 22, 9, 1, 230, DateTimeKind.Local).AddTicks(2098), "AQAAAAEAACcQAAAAEFkTCiQcsfaKMd6vgwwGvpTA8LNlYRvD7xjayXwenOzUW9EhsvKmavS3x6gt9xhK3g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8461), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8810), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8979), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9316), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9486), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9654), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9822), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(231), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(748), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(915), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1252), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1591), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1758), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(2638), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(2805), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(2973), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3141), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3829), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4173), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6592), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6939), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7111), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7457), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7630), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7803), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8147), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8319), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8491), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8835), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9007), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9353), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9525), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9871), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(43), new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(216), new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(387), new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(558), new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(730), new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(902), new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(1075), new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(1247), new DateTime(2024, 8, 13, 22, 27, 21, 996, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4414), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5126), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5476), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5651), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5826), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 8, 13, 22, 27, 21, 995, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8169), new DateTime(2024, 8, 13, 22, 27, 21, 994, DateTimeKind.Local).AddTicks(8288), "AQAAAAEAACcQAAAAEKekhgyUiPCU6WBLrLx6dj7yxhGFQ7xP8gkDkPCD+QKDGBSIplPR0KI5qZ8lG1yNUQ==" });
        }
    }
}
