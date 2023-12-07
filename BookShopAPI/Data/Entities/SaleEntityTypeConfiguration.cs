using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Data.Entities
{
    public class SaleEntityTypeConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("sales");

            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("VARCHAR")
                .HasMaxLength(36);

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
                .HasOne<Employee>(s => s.Employee)
                .WithMany(e => e.Sales)
                .HasForeignKey(s => s.EmployeeId);

            builder
                .HasOne<Customer>(s => s.Customer)
                .WithMany(e => e.Sales)
                .HasForeignKey(s => s.CustomerId);  
        }
    }
}