using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(@"User", @"dbo");

            builder.HasKey(u => u.Id);

            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.Email).HasColumnName("email").HasColumnType("nvarchar(100)");
            builder.Property(a => a.PasswordHash).HasColumnName("password_hash").HasColumnType("varbinary(500)");
            builder.Property(a => a.PasswordSalt).HasColumnName("password_salt").HasColumnType("varbinary(500)");
        }
    }
}
