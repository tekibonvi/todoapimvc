using Microsoft.EntityFrameworkCore;
using todoapimvc.Models;

namespace todoapimvc.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id_user = 3, Name = "Ezequias", Address = "Balcarce 16", Email = "ezequiasbonvi@utn.com" },
                new User { Id_user = 5, Name = "Herman", Address = "Av Alberdi 16", Email = "hermankuka@utn.com" },
                new User { Id_user = 9, Name = "Juan", Address = "Rio de Janeiro 300", Email = "juanperez@utn.com" },
                new User { Id_user = 15, Name = "Marcelo", Address = "Hermano Indio 24", Email = "marcefrac@utn.com" });
        }
    }
}

