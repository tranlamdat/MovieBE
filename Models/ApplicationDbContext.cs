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

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
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
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieActor>().HasKey(m => new { m.MovieId, m.ActorId });
            modelBuilder.Entity<WatchList>().HasKey(m => new { m.MovieId, m.UserId });

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
        }
    }
}
