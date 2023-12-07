using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Data.Entities
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers");

            builder.HasKey(c => c.Id);
            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("VARCHAR")
                .HasMaxLength(36);

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("name")
                .HasColumnType("VARCHAR");

            builder
                .Property(x => x.Contact)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("contact")
                .HasColumnType("VARCHAR");

            builder
                .Property(x => x.Address)
                .HasMaxLength(150)
                .HasColumnName("address")
                .HasColumnType("VARCHAR");
        }
    }
}