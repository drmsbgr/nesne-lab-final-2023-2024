using Microsoft.EntityFrameworkCore;
using MYAZ203.Models;

namespace MYAZ203.Repositories;

public class RepositoryContext : DbContext
{
    public DbSet<Student>? Students { get; set; }
    public DbSet<Course>? Courses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source = app.db");
    }
}