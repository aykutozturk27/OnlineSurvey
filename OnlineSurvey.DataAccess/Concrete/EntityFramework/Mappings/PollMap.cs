using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework.Mappings
{
    public class PollMap : IEntityTypeConfiguration<Poll>
    {
        public void Configure(EntityTypeBuilder<Poll> builder)
        {
            builder.ToTable(@"Poll", @"dbo");

            builder.HasKey(u => u.Id);

            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.Title).HasColumnName("title").HasColumnType("nvarchar(100)");
            builder.Property(a => a.UserId).HasColumnName("user_id");

            builder.HasOne(x => x.User).WithMany(x => x.Polls).HasForeignKey(x => x.UserId);
        }
    }
}
