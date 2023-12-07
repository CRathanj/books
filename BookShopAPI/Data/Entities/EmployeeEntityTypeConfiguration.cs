using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Data.Entities;

public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("employees");

        builder.HasKey(x => x.Id);
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
            .Property(x => x.Gender)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnName("gender")
            .HasColumnType("VARCHAR");

        builder
            .Property(x => x.Position)
            .IsRequired()
            .HasMaxLength(60)
            .HasColumnName("position")
            .HasColumnType("VARCHAR");

        builder
            .Property(x => x.Salary)
            .IsRequired()
            .HasColumnName("salary")
            .HasColumnType("DECIMAL(15,3)");

        builder
            .Property(x => x.Contact)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("contact")
            .HasColumnType("VARCHAR");

        builder
            .Property(x => x.Address)
            .IsRequired()
            .HasMaxLength(150)
            .HasColumnName("address")
            .HasColumnType("VARCHAR");

        builder
           .Property(x => x.HireDate)
           .HasColumnName("hire_date")
           .HasColumnType("TIMESTAMP")
           .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder
            .Property(x => x.StopDate)
            .HasColumnName("stop_date")
            .HasColumnType("TIMESTAMP")
            .HasDefaultValueSql("NULL ON UPDATE CURRENT_TIMESTAMP");

        builder
            .Property(x => x.Active)
            .IsRequired()
            .HasColumnName("active")
            .HasColumnType("bit");
    }
}
