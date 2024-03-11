using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Infrastructure.Data.Models;

namespace SchoolSystem.Infrastructure.Data.SeedDb
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder
               .HasOne(s => s.Class)
               .WithMany(c => c.Students)
               .HasForeignKey(s => s.ClassId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.ClassTeacher)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassTeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.Parent)
                .WithMany()
                .HasForeignKey(s => s.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new Student[]
            {
               data.DimitarIvanov,
               data.ElenaPetrova,
               data.StefchoDimitrov,
               data.MilenaGeorgieva,
               data.AleksandarTodorov,
               data.ViktoriaIvanova,
               data.NikolayKolev,
               data.MariaVasileva,
               data.IvayloPetrov,
               data.GabrielaStoyanova,
               data.GeorgiMarinov,
               data.KristinaPetrova,
               data.RumchoIvanov,
               data.EmiliaGeorgieva,
               data.KrasimirDimitrov,
               data.SilviyaIvanova,
               data.AsenGeorgiev,
               data.ElenaKoleva,
               data.StanimirTodorov,
               data.MagdalenaIvanova,
               data.HristoPetrov,
               data.KalinaDimitrova,
               data.TsvetanchoGeorgiev,
               data.NadezhdaIvanova,
               data.BorisStefanov,
               data.AneliyaKoleva,
               data.RosenPetrov,
               data.RadostinaIvanova,
               data.VasilAleksandrov,
               data.RositsaGeorgieva,
               data.PlamenIvanov,
               data.ValentinaDimitrova,
               data.IvoStoyanov,
               data.StefaniyaPetrova,
               data.MartinKolev,
               data.SonyaIvanova,
               data.LyubomirGeorgiev,
               data.NataliyaVasileva,
               data.PetarPetrov,
               data.GerganaDimitrova,
               data.LyubomiraTodorova,
               data.AntonIvanov,
               data.TanyaGeorgieva,
               data.KamenchoPetrov,
               data.VanyaKoleva,
               data.RadoslavGeorgiev,
               data.VasilenkaIvanova,
               data.KirilDimitrov,
               data.KameliyaTodorova,
               data.IliyaPetrov,
               data.DilyanaIvanova,
               data.BogdanKolev,
               data.DanielaMarinova,
               data.HristiyanIvanov,
               data.TeodoraVasileva,
               data.DesislavDimitrov,
               data.GalyaIvanova,
               data.IvanKolev,
               data.MariyaPetrova,
               data.SimeonGeorgiev,
               data.MagdalinaIvanova,
               data.EmilTodorov,
               data.KalinchoPetrov,
               data.RalitsaDimitrova,
               data.YordanGeorgiev,
               data.RadinkaIvanova,
               data.VentsislavPetrov,
               data.DarinaKoleva,
               data.BozhidarDimitrov,
               data.NeliGeorgieva,
               data.YavorIvanov,
               data.MilitsaPetrova,
               data.ZdravkoKolev,
               data.ElenaStoyanova
            });

        }
    }
}
