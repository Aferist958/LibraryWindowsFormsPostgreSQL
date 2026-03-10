using dotenv.net;
using Microsoft.EntityFrameworkCore;
using Library.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("DB_CONNECTION"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("gen_random_uuid()")
                .HasComment("Индефикатор для книг");
            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(255)
                .HasComment("Название книг");
            builder.Property(b => b.YearOfPublication)
                .HasComment("Год издания");
            builder.Property(b => b.Quantity)
                .IsRequired()
                .HasComment("Количество книг");
            builder.HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .UsingEntity(t => t.ToTable("Book_Author"));
        }
    }

    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("gen_random_uuid()")
                .HasComment("Индефикатор для авторов");
            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasComment("Имя автора или его псевдоним");
            builder.Property(a => a.Description)
                .HasComment("Описание автора");
        }
    }
}
