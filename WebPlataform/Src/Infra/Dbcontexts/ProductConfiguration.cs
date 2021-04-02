using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Infra.Dbcontexts
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Name).HasMaxLength(25).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Information).HasMaxLength(400);
            builder.Property(p => p.Price).HasColumnType("money").HasPrecision(18);
            builder.Property(p => p.Quantity);
            builder.Property(p => p.Image).HasMaxLength(100);
            builder.HasOne(p => p.Subcategory);
            builder.Property(e => e.IsActive);
            builder.Property(e => e.LastUpdate);
            builder.Property(e => e.InclusionDate);
        }
    }
}
