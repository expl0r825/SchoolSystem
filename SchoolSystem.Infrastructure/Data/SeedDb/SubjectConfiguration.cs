using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Infrastructure.Data.Models;

namespace SchoolSystem.Infrastructure.Data.SeedDb
{
    internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            var data = new SeedData();

            builder.HasData(new Subject[] {
              data.Bulgarian,
              data.Mathematics,
              data.English,
              data.SoftwareDesign,
              data.ComputerScience,
              data.Business,
              data.Physics,
              data.Programming,
              data.Engineering,
              data.History
            });
        }
    }
}
