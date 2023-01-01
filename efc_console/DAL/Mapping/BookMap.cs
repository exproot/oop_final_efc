using efc_console.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efc_console.DAL.Mapping {
    public class BookMap : IEntityTypeConfiguration<Book> {
        public void Configure(EntityTypeBuilder<Book> builder) {
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.BookTitle)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            builder.HasData(
                 new Book { BookId = 1, BookTitle = "Ertan"},
                 new Book { BookId = 2, BookTitle = "Yagmur" },
                 new Book { BookId = 3, BookTitle = "29 Yirmidokuz" }
                );
        }
    }
}
