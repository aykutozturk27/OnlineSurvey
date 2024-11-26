using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework.Mappings
{
    public class OptionMap : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            builder.ToTable(@"Option", @"dbo");

            builder.HasKey(u => u.Id);

            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.OptionText).HasColumnName("option_text").HasColumnType("nvarchar(100)");
            builder.Property(a => a.VoteCount).HasColumnName("vote_count").HasColumnType("nvarchar(100)");
            builder.Property(a => a.PollId).HasColumnName("poll_id");

            builder.HasOne(a => a.Poll).WithMany(a => a.Options).HasForeignKey(a => a.PollId);
        }
    }
}
