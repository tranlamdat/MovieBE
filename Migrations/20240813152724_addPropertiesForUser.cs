using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class addPropertiesForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(1948), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(3323), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(4722), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(7216), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(8353), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(9670), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(3055), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(6911), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7633), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7849), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8061), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8286), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(8953), new DateTime(2024, 8, 7, 20, 7, 6, 491, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(1558), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(1828), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(2607), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(3122), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(3637), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(3897), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(8390), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(8918), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(9439), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(9697), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(205), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(464), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(721), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(1492), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(1749), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(2511), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(2767), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(3024), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(4446), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(4953), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5287), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5620), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(5954), new DateTime(2024, 8, 7, 20, 7, 6, 493, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(4278), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(4546), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(4815), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(5196), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(6713), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(6974), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(7497), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(8018), new DateTime(2024, 8, 7, 20, 7, 6, 492, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(1599), new DateTime(2024, 8, 7, 20, 7, 6, 490, DateTimeKind.Local).AddTicks(1725), "AQAAAAEAACcQAAAAELdGQqVyvb3J9xiEQQ6tqWdBbLF8gX1FoQarO6cjEu9O7noO5dx/LJLXbxch3w/xOw==" });
        }
    }
}
