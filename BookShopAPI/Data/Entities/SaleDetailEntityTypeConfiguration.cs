using BookShop.Models;
using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Data.Entities;

public class SaleDetailEntityTypeConfiguration : IEntityTypeConfiguration<SaleDetail>
{
    public void Configure(EntityTypeBuilder<SaleDetail> builder)
    {
        builder.ToTable("sale_details");
        builder.HasKey(sd => new { sd.SaleId, sd.BookId });
        builder
            .Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("VARCHAR")
            .HasMaxLength(36);
        builder
            .HasOne<Sale>(ss => ss.Sale)
            .WithMany(s => s.SaleDetails)
            .HasForeignKey(ss => ss.SaleId)
            .HasConstraintName("sale_id");

        builder
            .HasOne<Book>(sb => sb.Book)
            .WithMany(s => s.SaleDetails)
            .HasForeignKey(sb => sb.BookId)
            .HasConstraintName("book_id");

        builder
            .Property(x => x.Quantity)
            .HasColumnName("quantity")
            .HasColumnType("int")
            .HasMaxLength(11);

        builder
           .Property(x => x.Amount)
           .IsRequired()
           .HasColumnName("amount")
           .HasColumnType("DECIMAL(15,3)");
    }
}
