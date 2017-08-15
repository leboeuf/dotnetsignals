using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Stories.Data.Entities.Mappings
{
    public class CommentScoreMap : IEntityTypeConfiguration<CommentScore>
    {
        public void Configure(EntityTypeBuilder<CommentScore> builder)
        {
            builder.HasKey(cs => cs.Id);
            builder.Property(cs => cs.CommentId).IsRequired();
            builder.Property(cs => cs.Value).IsRequired();

        }
    }
}
