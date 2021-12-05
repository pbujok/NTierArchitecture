using ItEmperorNTierArchitecture.DalLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItEmperorNTierArchitecture.DalLayer.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Content);

            builder.Property(x => x.AuthorName)
                .HasMaxLength(130);
        }
    }
}