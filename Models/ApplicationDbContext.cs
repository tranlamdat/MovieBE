using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Sever.Constraints;

namespace Sever.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            try
            {
                if (Database.GetService<IDatabaseCreator>() is RelationalDatabaseCreator databaseCreator)
                {
                    if (!databaseCreator.CanConnect())
                    {
                        databaseCreator.Create();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieMedia> MoviesMedias { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Roles
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, Name = ERole.Admin.ToString() },
                new Role { RoleId = 2, Name = ERole.Member.ToString() },
                new Role { RoleId = 5, Name = ERole.Guest.ToString() }
            );

            // Seed Users
            string adminPassword = "Admin@2024";
            PasswordHasher<string> passwordHasher = new();
            string password = passwordHasher.HashPassword(null, adminPassword);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Email = "admin@gmail.com",
                    Password = password,
                    FirstName = "Admin",
                    LastName = "First",
                    RoleId = 1
                }
            );

            // Seed Actor
            modelBuilder.Entity<Actor>().HasData(
                new Actor { ActorId = 1, Name = "Robert Downey Jr.", DoB = new DateTime(1965, 04, 04), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 2, Name = "Scarlett Johansson", DoB = new DateTime(1984, 11, 22), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 3, Name = "Leonardo DiCaprio", DoB = new DateTime(1974, 11, 11), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 4, Name = "Jennifer Lawrence", DoB = new DateTime(1990, 08, 15), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 5, Name = "Denzel Washington", DoB = new DateTime(1954, 12, 28), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 6, Name = "Natalie Portman", DoB = new DateTime(1981, 06, 09), Nationality = "Israeli-American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 7, Name = "Tom Hanks", DoB = new DateTime(1956, 07, 09), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 8, Name = "Emma Watson", DoB = new DateTime(1990, 04, 15), Nationality = "British", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 9, Name = "Brad Pitt", DoB = new DateTime(1963, 12, 18), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" },
                new Actor { ActorId = 10, Name = "Gal Gadot", DoB = new DateTime(1985, 04, 30), Nationality = "Israeli", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286489/ACTOR/g4mdoefbqdrczrod7uwf.jpg", PublicId = "ACTOR/g4mdoefbqdrczrod7uwf" }
            );

            // Seed Director
            modelBuilder.Entity<Director>().HasData(
                new Director { DirectorId = 1, Name = "Steven Spielberg", DoB = new DateTime(1946, 12, 18), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 2, Name = "Christopher Nolan", DoB = new DateTime(1970, 07, 30), Nationality = "British", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 3, Name = "Martin Scorsese", DoB = new DateTime(1942, 11, 17), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 4, Name = "Quentin Tarantino", DoB = new DateTime(1963, 03, 27), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 5, Name = "James Cameron", DoB = new DateTime(1954, 08, 16), Nationality = "Canadian", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 6, Name = "Kathryn Bigelow", DoB = new DateTime(1951, 11, 27), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 7, Name = "Ridley Scott", DoB = new DateTime(1937, 11, 30), Nationality = "British", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 8, Name = "Peter Jackson", DoB = new DateTime(1961, 10, 31), Nationality = "New Zealander", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 9, Name = "Guillermo del Toro", DoB = new DateTime(1964, 10, 09), Nationality = "Mexican", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" },
                new Director { DirectorId = 10, Name = "Greta Gerwig", DoB = new DateTime(1983, 08, 04), Nationality = "American", AvatarUrl = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1720286507/DIRECTOR/os4brhm9sriu8nw09apr.webp", PublicId = "DIRECTOR/os4brhm9sriu8nw09apr" }
            );

            // Seed Genre
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Action" },
                new Genre { GenreId = 2, Name = "Comedy" },
                new Genre { GenreId = 3, Name = "Drama" },
                new Genre { GenreId = 4, Name = "Horror" },
                new Genre { GenreId = 5, Name = "Science-Fiction" },
                new Genre { GenreId = 6, Name = "Romance" },
                new Genre { GenreId = 7, Name = "Thriller" },
                new Genre { GenreId = 8, Name = "Fantasy" },
                new Genre { GenreId = 9, Name = "Animation" },
                new Genre { GenreId = 10, Name = "Documentary" }
            );

            // Seed Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Inception", ReleaseDate = new DateTime(2010, 07, 16), Description = "Inception is a mind-bending thriller where dream invasion is possible. Dom Cobb, a skilled thief, extracts secrets from deep within the subconscious during dreams. Cobb is an international fugitive seeking redemption through one last job: to plant an idea instead of stealing it. Success could be the perfect crime.", Duration = 148, National = "USA", NumberOfView = 10, GenreId = 5, DirectorId = 2 },
                new Movie { MovieId = 2, Title = "Titanic", ReleaseDate = new DateTime(1997, 12, 19), Description = "Titanic is a love story that unfolds on the ill-fated ship. Seventeen-year-old Rose boards with her aristocratic family, feeling suffocated by societal constraints and an impending arranged marriage. She meets Jack, a third-class passenger, and they fall in love amid the ship's grandeur and tragedy.", Duration = 195, National = "USA", NumberOfView = 8, GenreId = 6, DirectorId = 5 },
                new Movie { MovieId = 3, Title = "Pulp Fiction", ReleaseDate = new DateTime(1994, 10, 14), Description = "Pulp Fiction intertwines the lives of Los Angeles criminals, including hitmen, a boxer, and a mob boss, in a series of interconnected stories blending violence and redemption.", Duration = 154, National = "USA", NumberOfView = 18, GenreId = 7, DirectorId = 4 },
                new Movie { MovieId = 4, Title = "The Dark Knight", ReleaseDate = new DateTime(2008, 07, 18), Description = "The Dark Knight follows Batman as he confronts the Joker, a psychopathic criminal wreaking havoc on Gotham City. The conflict forces Batman to confront his own ideals and methods in combating crime.", Duration = 152, National = "USA", NumberOfView = 2, GenreId = 1, DirectorId = 2 },
                new Movie { MovieId = 5, Title = "Avatar", ReleaseDate = new DateTime(2009, 12, 18), Description = "Avatar follows Jake Sully, a paraplegic Marine, who becomes part of the Avatar Program on Pandora, where he integrates with the Na'vi to infiltrate the indigenous species for a corporate mission. However, his experiences lead him to question his allegiances and fight for Pandora's survival.", Duration = 162, National = "USA", NumberOfView = 10, GenreId = 5, DirectorId = 5 },
                new Movie { MovieId = 6, Title = "The Matrix", ReleaseDate = new DateTime(1999, 03, 31), Description = "The Matrix centers on Neo, a computer hacker who discovers that reality is a simulated world created by sentient machines to subdue humanity. Neo joins a group of rebels to overthrow the machines and free humanity from their control.", Duration = 136, National = "USA", NumberOfView = 20, GenreId = 5, DirectorId = 7 },
                new Movie { MovieId = 7, Title = "La La Land", ReleaseDate = new DateTime(2016, 12, 09), Description = "La La Land tells the story of Mia, an aspiring actress, and Sebastian, a jazz musician, who meet and fall in love in Los Angeles while pursuing their dreams. Their relationship faces challenges as they navigate the competitive and demanding entertainment industry.", Duration = 128, National = "USA", NumberOfView = 7, GenreId = 6, DirectorId = 10 },
                new Movie { MovieId = 8, Title = "The Lord of the Rings: The Return of the King", ReleaseDate = new DateTime(2003, 12, 17), Description = "The Lord of the Rings: The Return of the King depicts the final battle for Middle-earth as Aragorn, Frodo, and their allies confront Sauron's forces in an epic conclusion to the trilogy.", Duration = 201, National = "New Zealand", NumberOfView = 80, GenreId = 8, DirectorId = 8 },
                new Movie { MovieId = 9, Title = "Pan's Labyrinth", ReleaseDate = new DateTime(2006, 10, 20), Description = "Pan's Labyrinth follows Ofelia, a young girl in post-Civil War Spain, who discovers a mysterious labyrinth and encounters magical creatures. Amid her harsh reality, Ofelia navigates a world of fantasy to fulfill a daunting task.", Duration = 118, National = "Mexico", NumberOfView = 1, GenreId = 4, DirectorId = 9 },
                new Movie { MovieId = 10, Title = "Wonder Woman", ReleaseDate = new DateTime(2017, 06, 02), Description = "Wonder Woman chronicles Diana, an Amazonian warrior princess, who leaves her home to fight alongside humans in World War I. As she discovers her powers and true destiny, she becomes a symbol of hope and inspiration.", Duration = 141, National = "USA", NumberOfView = 64, GenreId = 1, DirectorId = 9 }
            );

            // Seed movie actor
            modelBuilder.Entity<MovieActor>().HasData(
                new MovieActor { MovieActorId = 1, MovieId = 1, ActorId = 1, CharacterName = "Cobb" },
                new MovieActor { MovieActorId = 2, MovieId = 1, ActorId = 2, CharacterName = "Ariadne" },
                new MovieActor { MovieActorId = 3, MovieId = 1, ActorId = 3, CharacterName = "Arthur" },
                new MovieActor { MovieActorId = 4, MovieId = 2, ActorId = 3, CharacterName = "Jack Dawson" },
                new MovieActor { MovieActorId = 5, MovieId = 2, ActorId = 4, CharacterName = "Rose DeWitt Bukater" },
                new MovieActor { MovieActorId = 6, MovieId = 2, ActorId = 5, CharacterName = "Cal Hockley" },
                new MovieActor { MovieActorId = 7, MovieId = 3, ActorId = 5, CharacterName = "Vincent Vega" },
                new MovieActor { MovieActorId = 8, MovieId = 3, ActorId = 6, CharacterName = "Mia Wallace" },
                new MovieActor { MovieActorId = 9, MovieId = 3, ActorId = 7, CharacterName = "Jules Winnfield" },
                new MovieActor { MovieActorId = 10, MovieId = 4, ActorId = 1, CharacterName = "Bruce Wayne/Batman" },
                new MovieActor { MovieActorId = 11, MovieId = 4, ActorId = 8, CharacterName = "Joker" },
                new MovieActor { MovieActorId = 12, MovieId = 4, ActorId = 9, CharacterName = "Harvey Dent" },
                new MovieActor { MovieActorId = 13, MovieId = 5, ActorId = 2, CharacterName = "Jake Sully" },
                new MovieActor { MovieActorId = 14, MovieId = 5, ActorId = 10, CharacterName = "Neytiri" },
                new MovieActor { MovieActorId = 15, MovieId = 5, ActorId = 3, CharacterName = "Colonel Miles Quaritch" },
                new MovieActor { MovieActorId = 16, MovieId = 6, ActorId = 1, CharacterName = "Neo" },
                new MovieActor { MovieActorId = 17, MovieId = 6, ActorId = 5, CharacterName = "Morpheus" },
                new MovieActor { MovieActorId = 18, MovieId = 6, ActorId = 7, CharacterName = "Trinity" },
                new MovieActor { MovieActorId = 19, MovieId = 7, ActorId = 6, CharacterName = "Sebastian" },
                new MovieActor { MovieActorId = 20, MovieId = 7, ActorId = 7, CharacterName = "Mia" },
                new MovieActor { MovieActorId = 21, MovieId = 7, ActorId = 8, CharacterName = "Keith" },
                new MovieActor { MovieActorId = 22, MovieId = 8, ActorId = 8, CharacterName = "Frodo Baggins" },
                new MovieActor { MovieActorId = 23, MovieId = 8, ActorId = 9, CharacterName = "Aragorn" },
                new MovieActor { MovieActorId = 24, MovieId = 8, ActorId = 10, CharacterName = "Gandalf" },
                new MovieActor { MovieActorId = 25, MovieId = 9, ActorId = 10, CharacterName = "Ofelia" },
                new MovieActor { MovieActorId = 26, MovieId = 9, ActorId = 6, CharacterName = "Carmen" },
                new MovieActor { MovieActorId = 27, MovieId = 9, ActorId = 7, CharacterName = "Captain Vidal" },
                new MovieActor { MovieActorId = 28, MovieId = 10, ActorId = 2, CharacterName = "Diana Prince/Wonder Woman" },
                new MovieActor { MovieActorId = 29, MovieId = 10, ActorId = 4, CharacterName = "Steve Trevor" },
                new MovieActor { MovieActorId = 30, MovieId = 10, ActorId = 3, CharacterName = "Antiope" }
            );

            // Seed Movie Media
            modelBuilder.Entity<MovieMedia>().HasData(
                new MovieMedia { MovieMediaId = 1, Name = "Inception Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 1 },
                new MovieMedia { MovieMediaId = 2, Name = "Inception Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 1 },
                new MovieMedia { MovieMediaId = 3, Name = "Inception Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 1 },
                new MovieMedia { MovieMediaId = 4, Name = "Inception Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 1 },
                new MovieMedia { MovieMediaId = 5, Name = "Titanic Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 2 },
                new MovieMedia { MovieMediaId = 6, Name = "Titanic Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 2 },
                new MovieMedia { MovieMediaId = 7, Name = "Titanic Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 2 },
                new MovieMedia { MovieMediaId = 8, Name = "Titanic Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 2 },
                new MovieMedia { MovieMediaId = 9, Name = "Pulp Fiction Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 3 },
                new MovieMedia { MovieMediaId = 10, Name = "Pulp Fiction Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 3 },
                new MovieMedia { MovieMediaId = 11, Name = "Pulp Fiction Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 3 },
                new MovieMedia { MovieMediaId = 12, Name = "Pulp Fiction Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 3 },
                new MovieMedia { MovieMediaId = 13, Name = "The Dark Knight Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 4 },
                new MovieMedia { MovieMediaId = 14, Name = "The Dark Knight Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 4 },
                new MovieMedia { MovieMediaId = 15, Name = "The Dark Knight Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 4 },
                new MovieMedia { MovieMediaId = 16, Name = "The Dark Knight Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 4 },
                new MovieMedia { MovieMediaId = 17, Name = "Avatar Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 5 },
                new MovieMedia { MovieMediaId = 18, Name = "Avatar Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 5 },
                new MovieMedia { MovieMediaId = 19, Name = "Avatar Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 5 },
                new MovieMedia { MovieMediaId = 20, Name = "Avatar Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 5 },
                new MovieMedia { MovieMediaId = 21, Name = "The Matrix Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 6 },
                new MovieMedia { MovieMediaId = 22, Name = "The Matrix Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 6 },
                new MovieMedia { MovieMediaId = 23, Name = "The Matrix Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 6 },
                new MovieMedia { MovieMediaId = 24, Name = "The Matrix Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 6 },
                new MovieMedia { MovieMediaId = 25, Name = "La La Land Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 7 },
                new MovieMedia { MovieMediaId = 26, Name = "La La Land Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 7 },
                new MovieMedia { MovieMediaId = 27, Name = "La La Land Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 7 },
                new MovieMedia { MovieMediaId = 28, Name = "La La Land Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 7 },
                new MovieMedia { MovieMediaId = 29, Name = "The Lord of the Rings: The Return of the King Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 8 },
                new MovieMedia { MovieMediaId = 30, Name = "The Lord of the Rings: The Return of the King Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 8 },
                new MovieMedia { MovieMediaId = 31, Name = "The Lord of the Rings: The Return of the King Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 8 },
                new MovieMedia { MovieMediaId = 32, Name = "The Lord of the Rings: The Return of the King Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 8 },
                new MovieMedia { MovieMediaId = 33, Name = "Pan's Labyrinth Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 9 },
                new MovieMedia { MovieMediaId = 34, Name = "Pan's Labyrinth Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 9 },
                new MovieMedia { MovieMediaId = 35, Name = "Pan's Labyrinth Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 9 },
                new MovieMedia { MovieMediaId = 36, Name = "Pan's Labyrinth Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 9 },
                new MovieMedia { MovieMediaId = 37, Name = "Wonder Woman Poster", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1722168426/POSTER/p6ixrrzrgzoywdhmbarj.jpg", PublicId = "POSTER/xhprcuwrw5rewdojm9ke", Type = EFileType.POSTER, MovieId = 10 },
                new MovieMedia { MovieMediaId = 38, Name = "Wonder Woman Banner", Url = "https://res.cloudinary.com/dl3zwdtki/image/upload/v1719774957/BANNER/g5dqzcs4zwgxvvw3lsma.jpg", PublicId = "BANNER/g5dqzcs4zwgxvvw3lsma", Type = EFileType.BANNER, MovieId = 10 },
                new MovieMedia { MovieMediaId = 39, Name = "Wonder Woman Trailer", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775117/TRAILER/kou9a1hm4axazrmvxfgh.mp4", PublicId = "TRAILER/kou9a1hm4axazrmvxfgh", Type = EFileType.TRAILER, MovieId = 10 },
                new MovieMedia { MovieMediaId = 40, Name = "Wonder Woman Video", Url = "https://res.cloudinary.com/dl3zwdtki/video/upload/v1719775341/VIDEO/fnoqi8bubpp3zk2l44y5.mp4", PublicId = "VIDEO/fnoqi8bubpp3zk2l44y5", Type = EFileType.VIDEO, MovieId = 10 }
            );
        }
    }
}
