using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.BookTitle)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Genre)
                .IsRequired();

            builder.Property(x => x.Publisher)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.ImagePath)
                .IsRequired();

            builder.Property(x => x.Description)
                .IsRequired();

        }
    }
}
