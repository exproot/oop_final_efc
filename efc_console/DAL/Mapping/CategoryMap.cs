using efc_console.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efc_console.DAL.Mapping {
    public class CategoryMap : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {

            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.CategoryDesc)
                .HasDefaultValue("Empty");

            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Fantastic" },
                new Category { CategoryId = 2, CategoryName = "Science" },
                new Category { CategoryId = 3, CategoryName = "Novel" }
            );
        }
    }
}
