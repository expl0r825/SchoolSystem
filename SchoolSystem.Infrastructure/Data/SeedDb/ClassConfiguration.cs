using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Infrastructure.Data.Models;

namespace SchoolSystem.Infrastructure.Data.SeedDb
{
    internal class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            var data = new SeedData();

            builder.HasData(new Class[] { data.Eight, data.Ninth, data.Tenth, data.Eleventh, data.Twelfth});
        }
    }
}
