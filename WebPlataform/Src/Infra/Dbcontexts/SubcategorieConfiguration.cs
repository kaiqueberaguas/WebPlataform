using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Infra.Dbcontexts
{
    public class SubcategorieConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(s => s.Name).HasMaxLength(25).IsRequired();
            builder.Property(e => e.IsActive);
            builder.Property(e => e.LastUpdate);
            builder.Property(e => e.InclusionDate);
        }
    }
}
