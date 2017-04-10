using System.Data.Entity.ModelConfiguration;
using DeltaDucks.Models;

namespace DeltaDucks.Data.Configuration
{
    public class LandmarkConfiguration : EntityTypeConfiguration<Landmark>
    {

        public LandmarkConfiguration()
        {
            ToTable("Landmarks");
            Property(l => l.Name).IsRequired().HasMaxLength(100);
        }
    }
}
