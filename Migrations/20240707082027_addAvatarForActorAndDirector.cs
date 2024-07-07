using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sever.Migrations
{
    public partial class addAvatarForActorAndDirector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MoviesMedias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5051), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5055), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5056), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5057), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5058), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5059), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5059), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5060), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5061), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5062), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5064), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5065), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5066), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5067), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5071), "ACTOR/g4mdoefbqdrczrod7uwf" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5094), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5095), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5097), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5099), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5100), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5101), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5102), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5103), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 7,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5104), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5105), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 8,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5106), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5106), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 9,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5107), "DIRECTOR/os4brhm9sriu8nw09apr" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 10,
                columns: new[] { "AvatarUrl", "DateCreated", "DateUpdated", "PublicId" },
                values: new object[] { "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5109), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5109), "DIRECTOR/os4brhm9sriu8nw09apr" });

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
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 1,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 2,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 3,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 4,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 5,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 6,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 7,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 8,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 9,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 10,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 11,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 12,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 13,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 14,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 15,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 16,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 17,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 18,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 19,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 20,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 21,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 22,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 23,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 24,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 25,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 26,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 27,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 28,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 29,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 30,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 31,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 32,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 33,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 34,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 35,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 36,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 37,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 38,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 39,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 40,
                column: "Type",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5001), new DateTime(2024, 7, 7, 15, 20, 26, 997, DateTimeKind.Local).AddTicks(5010), "AQAAAAEAACcQAAAAEG50TbVZBmHCn2hjzFDJXqNcIdt+E4u1MZp1HUIbtvOfCy7xVABbGff7w0RUHKSmMQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Actors");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MoviesMedias",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3695), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3701), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3703), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3707), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3716), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3720), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3726), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3735), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3737), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3738), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3740), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3741), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumn: "MovieActorId",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3743) });

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

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 1,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 2,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 3,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 4,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 5,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 6,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 7,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 8,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 9,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 10,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 11,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 12,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 13,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 14,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 15,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 16,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 17,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 18,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 19,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 20,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 21,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 22,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 23,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 24,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 25,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 26,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 27,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 28,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 29,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 30,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 31,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 32,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 33,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 34,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 35,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 36,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 37,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 38,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 39,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MoviesMedias",
                keyColumn: "MovieMediaId",
                keyValue: 40,
                column: "Type",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Password" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3184), new DateTime(2024, 7, 1, 2, 36, 23, 944, DateTimeKind.Local).AddTicks(3202), "AQAAAAEAACcQAAAAEOzkrOsvR/BKG4OYWa+dUSciOZcLSSe7LPsosaKzlXnvjyCbirugd9Ba4pLsP1dqGw==" });
        }
    }
}
