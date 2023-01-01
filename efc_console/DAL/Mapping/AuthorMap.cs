using efc_console.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efc_console.DAL.Mapping {
    public class AuthorMap : IEntityTypeConfiguration<Author> {
        public void Configure(EntityTypeBuilder<Author> builder) {

            builder.HasKey(a => a.AuthorId);

            builder.Property(a => a.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Ignore(a => a.FullName);

            builder.HasData(

                new Author { AuthorId = 1, FirstName = "Ertan", LastName = "Yagmur" },
                new Author { AuthorId = 2, FirstName = "Yagmur", LastName = "Ertan" },
                new Author { AuthorId = 3, FirstName = "Yagmur", LastName = "Yagmur" }
            );
        }
    }
}
