using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace BackProjectCurs.Entity
{
    public class Context : DbContext
    {
        public virtual DbSet<User> Users { get; set; }//обновляет бд по подобию юзерс
        public virtual DbSet<Task> Tasks { get; set; }//Задачи

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ToDoListSUSU;Username=postgres;Password=postgres");
        }



    }
}
