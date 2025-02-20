using CODEFIRT.Models.DataModels;
using Microsoft.EntityFrameworkCore;

public class BookManagementContext : DbContext
{
    public BookManagementContext(DbContextOptions<BookManagementContext> options)
        : base(options)
    {
    }

    // Khai báo các thuộc tính biểu diễn các tập thực thể
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
}
