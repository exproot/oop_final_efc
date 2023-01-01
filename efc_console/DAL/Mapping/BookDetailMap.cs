using efc_console.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace efc_console.DAL.Mapping {
    public class BookDetailMap : IEntityTypeConfiguration<BookDetail> {
        public void Configure(EntityTypeBuilder<BookDetail> builder) {

            builder.HasKey(bd => bd.BookDetailId);

            builder.Property(bd => bd.Year)
                .HasDefaultValue(DateTime.Now.Year);

            builder.HasOne(bd => bd.Book)
                .WithOne(bd => bd.BookDetail)
                .HasForeignKey<BookDetail>(bd => bd.BookId)
                .OnDelete(DeleteBehavior.Cascade);
            
        }
    }

}
