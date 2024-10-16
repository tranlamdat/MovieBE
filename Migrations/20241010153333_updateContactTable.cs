using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class updateContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(627), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(668), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(674), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(675), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(678), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(679), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(681), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(683), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(701), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(704), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(706), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(709), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(710), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(711), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(947), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(949), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(951), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(952), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(953), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(955), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(957), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(960), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(962), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(964), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(965), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(966), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(969), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(971), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(973), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(974), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(976), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(978), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(979), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(982), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(983), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(984), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(735), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(742), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(744), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(746), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(748), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(751), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(525), new DateTime(2024, 10, 10, 22, 33, 32, 439, DateTimeKind.Local).AddTicks(541), "AQAAAAEAACcQAAAAEI/AfDOYzZKYXt46Wj+8JLgCmK9IQ5YliPl/P6eYTS88nD5AykUBR2kE1M0n92PbqA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Contacts");

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
    }
}
