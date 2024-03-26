using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Infrastructure.Data.Models;

namespace SchoolSystem.Infrastructure.Data.SeedDb
{
    internal class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {

            builder
                .HasOne(p => p.Child)
                .WithMany()
                .HasForeignKey(p => p.ChildId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new Parent[] {
                   data.KrumIvanov, data.VeronikaPetrova, data.PlamenDimitrov, data.ZlatinaGeorgieva, data.RadoslavTodorov,
                   data.AdrianaIvanova, data.BozhidarKolev, data.EvelinaVasileva,data.StoyanPetrov, data.TsvetelinaStoyanova,
                   data.LyubenMarinov,data.RositsaPetrova, data.KaloyanIvanov, data.EkaterinaGeorgieva,
                   data.HristoDimitrov, data.DobrinkaIvanova,data.BlagoyGeorgiev, data.IskraKoleva, data.KrasimirTodorov,
                   data.GerganaIvanova, data.VasilPetrov, data.NadezhdaDimitrova,data.TodorGeorgiev, data.RadkaIvanova,
                   data.HristinaStefanova, data.YavorKolev, data.KameliaPetrova, data.EmilIvanov, data.DilyanaAleksandrova,
                   data.TsvetanGeorgiev, data.ZhivkaIvanova, data.IvoDimitrov, data.AdriyanaStoyanova, data.KamenPetrov,
                   data.KristinaKoleva, data.YankoIvanov, data.PolinaGeorgieva, data.VeselinVasilev, data.AntoniyaPetrova,
                   data.LyubomirDimitrov, data.ZornitsaTodorova, data.StefanIvanov, data.YoanaGeorgieva, data.KrasimiraPetrova,
                   data.IvayloKolev, data.MargaritaGeorgieva, data.RumenIvanov, data.MilenaDimitrova, data.YordanTodorov,
                   data.SilviyaPetrova, data.BogdanIvanov, data.PetyaKoleva, data.AsenMarinov, data.RalitsaIvanova,
                   data.VelkoVasilev, data.GalyaDimitrova, data.DimiturIvanov, data.NadiaKoleva, data.YulianPetrov,
                   data.RadostinaGeorgieva, data.KrasimIvanov, data.TeodoraTodorova, data.KalinPetrov, data.SvetlaDimitrova,
                   data.VentsislavGeorgiev, data.VasilenaIvanova, data.MartinPetrov, data.RalitsaKoleva, data.StefanDimitrov,
                   data.SnezhanaGeorgieva, data.IvayloIvanov, data.MarianaPetrova, data.RosenKolev, data.TanyaStoyanova});
        }
    }
}
