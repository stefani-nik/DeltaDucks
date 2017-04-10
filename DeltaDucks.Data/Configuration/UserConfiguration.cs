namespace DeltaDucks.Data.Configuration
{

    using System.Data.Entity.ModelConfiguration;
    using Models;

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");
            Property(u => u.Name).IsRequired().HasMaxLength(20);
        }
    }
}
