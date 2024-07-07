using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class addNullForAvatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5626), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5633), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5665), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5674), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5676), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5677), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5678), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5679), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5698), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5699), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5700), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5701), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5702), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5703), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5704), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5706), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5707), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5765), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5768), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5769), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5770), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5772), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5885), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5888), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5889), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5891), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5894), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5900), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5901), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5903), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5904), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5905), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5907), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5908), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5910), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5911), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5913), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5914), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5915), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5729), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5731), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5738), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5739), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5741), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5744), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5745), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 7, 7, 15, 40, 57, 350, DateTimeKind.Local).AddTicks(5543), "AQAAAAEAACcQAAAAEPjotz2CWu9T0R0d/I+mpRrieCPAhuXD7XIXvXyui5Q794Y+BogZBrcPkZUpPnWyMg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5055), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5057), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5059), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5061), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5065), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5094), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5100), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5104), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5106), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5109), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5125), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5128), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5130), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5133), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5134), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5136), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5137), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5313), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5315), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5316), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5319), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5320), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5321), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5322), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5327), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5329), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5330), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5332), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5334), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5336), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5340), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5341), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5343), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5345), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5346), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5348), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5151), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5154), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5157), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5160), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5278), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5280), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5283), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5001), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5010), "AQAAAAEAACcQAAAAEG50TbVZBmHCn2hjzFDJXqNcIdt+E4u1MZp1HUIbtvOfCy7xVABbGff7w0RUHKSmMQ==" });
        }
    }
}
