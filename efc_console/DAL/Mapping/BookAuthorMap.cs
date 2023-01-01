﻿using efc_console.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efc_console.DAL.Mapping {
    public class BookAuthorMap : IEntityTypeConfiguration<BookAuthor> {
        public void Configure(EntityTypeBuilder<BookAuthor> builder) {

            builder.HasKey(ba => ba.BookAuthorId);

            builder
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookId);

            builder
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);
        }
    }
}
