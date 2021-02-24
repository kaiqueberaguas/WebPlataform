using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Infra.Dbcontexts
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(c => c.Name).HasMaxLength(25).IsRequired();
            builder.Property(e => e.IsActive);
            builder.Property(e => e.LastUpdate);
            builder.Property(e => e.InclusionDate);
        }
    }
}
