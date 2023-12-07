using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Data.Entities;

public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("books");

        builder.HasKey(x => x.Id);
        builder
            .Property(x => x.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("VARCHAR")
            .HasMaxLength(36);

        builder
            .Property(x => x.ISBN)
            .IsRequired()
            .HasColumnName("isbn")
            .HasColumnType("VARCHAR")
            .HasMaxLength(16);

        builder
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(60)
            .HasColumnName("name")
            .HasColumnType("VARCHAR");

        builder
            .Property(x => x.Author)
            .IsRequired()
            .HasMaxLength(60)
            .HasColumnName("author")
            .HasColumnType("VARCHAR");

        builder
            .Property(x => x.Genres)
            .IsRequired()
            .HasMaxLength(11)
            .HasColumnName("genres")
            .HasColumnType("int");

        builder
           .Property(x => x.Price)
           .IsRequired()
           .HasColumnName("price")
           .HasColumnType("DECIMAL(15,3)");

        builder
            .Property(x => x.Description)
            .HasColumnName("description")
            .HasColumnType("TEXT")
            .HasMaxLength(255);
        builder
            .Property(x => x.CreatedOn)
            .HasColumnName("date_created")
            .HasColumnType("TIMESTAMP")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder
            .Property(x => x.LastUpdatedOn)
            .HasColumnName("date_modified")
            .HasColumnType("TIMESTAMP")
            .HasDefaultValueSql("NULL ON UPDATE CURRENT_TIMESTAMP");

        builder
            .Property(x => x.PublishDate)
            .HasColumnName("date_publish")
            .HasColumnType("TIMESTAMP")
            .HasDefaultValueSql("NULL");
    }
}