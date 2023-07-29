using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace FMB.Services.Posts.Models
{
    public class PostsContext : DbContext
    {
        public PostsContext() // �� ��������� DI ���� �� ������� �������
        {
            Database.EnsureCreated();
        }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // �� �������, ���� �� ������� �� �������
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=PostsDB;User Id=postgres;Password=qwerty;");
        }
    }

}