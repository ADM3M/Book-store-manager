using Microsoft.EntityFrameworkCore;
using Jul.Entities;

namespace Jul.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Books> Books { get; set; }

        public DbSet<Genres> Genres { get; set; }

        public DbSet<Publishers> Publishers { get; set; }

        public DbSet<Authors> Authors { get; set; }

        public DbSet<Receipts> Receipts { get; set; }

        public DbSet<Countries> Countries { get; set; }

        public DbSet<Cities> Cities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Database=LibraryDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>()
                .HasOne(c => c.Genres)
                .WithMany(c => c.Books)
                .HasForeignKey(c => c.GenreId);
            modelBuilder.Entity<Books>()
                .HasOne(c => c.Author)
                .WithMany(c => c.AuthorBooks)
                .HasForeignKey(c => c.AuthorId);
            modelBuilder.Entity<Books>()
                .HasOne(c => c.Publisher)
                .WithMany(c => c.PublisherBooks)
                .HasForeignKey(c => c.PublisherId);
        }
    }
}
