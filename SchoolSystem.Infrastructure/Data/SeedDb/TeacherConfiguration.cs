using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Infrastructure.Data.Models;

namespace SchoolSystem.Infrastructure.Data.SeedDb
{
    internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            var data = new SeedData();

            builder.HasData(new Teacher[] {
                 data.TatyanaGerganova,
                 data.BilyanaLozanova,
                 data.KrasimiraKutin,
                 data.TeodorHristov,
                 data.SilviyaGancheva,
                 data.CvetomirAmbursa,
                 data.MitkoMitkov,
                 data.EmilStoyanov,
                 data.BorislavaBangeeva,
                 data.MariaIvanova
            }); 
        }
    }
}
