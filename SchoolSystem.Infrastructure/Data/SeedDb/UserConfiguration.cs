﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolSystem.Infrastructure.Data.SeedDb
{
    internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var data = new SeedData();

            builder.HasData(new IdentityUser[]
            {
                      data.UserRadostinaMekova,
                      data.UserValentinaStoeva,
                      data.UserYulianaPetkova,
                      data.UserTatyanaGerganova,
                      data.UserBilyanaLozanova,
                      data.UserKrasimiraKutin,
                      data.UserTeodorHristov,
                      data.UserSilviyaGancheva,
                      data.UserCvetomirAmbursa,
                      data.UserMitkoMitkov,
                      data.UserEmilStoyanov,
                      data.UserBorislavaBangeeva,
                      data.UserMariaIvanova,
                      data.UserKrumIvanov,
                      data.UserVeronikaPetrova,
                      data.UserPlamenDimitrov,
                      data.UserZlatinaGeorgieva,
                      data.UserRadoslavTodorov ,
                      data.UserAdrianaIvanova ,
                      data.UserBozhidarKolev ,
                      data.UserEvelinaVasileva ,
                      data.UserStoyanPetrov ,
                      data.UserTsvetelinaStoyanova ,
                      data.UserLyubenMarinov ,
                      data.UserRositsaPetrova,
                      data.UserKaloyanIvanov ,
                      data.UserEkaterinaGeorgieva ,
                      data.UserHristoDimitrov ,
                      data.UserDobrinkaIvanova ,
                      data.UserBlagoyGeorgiev ,
                      data.UserIskraKoleva ,
                      data.UserKrasimirTodorov,
                      data.UserGerganaIvanova ,
                      data.UserVasilPetrov ,
                      data.UserNadezhdaDimitrova,
                      data.UserTodorGeorgiev,
                      data.UserRadkaIvanova ,
                      data.UserHristinaStefanova,
                      data.UserYavorKolev ,
                      data.UserKameliaPetrova  ,
                      data.UserEmilIvanov ,
                      data.UserDilyanaAleksandrova,
                      data.UserTsvetanGeorgiev,
                      data.UserZhivkaIvanova ,
                      data.UserIvoDimitrov ,
                      data.UserAdriyanaStoyanova,
                      data.UserKamenPetrov,
                      data.UserKristinaKoleva ,
                      data.UserYankoIvanov ,
                      data.UserPolinaGeorgieva ,
                      data.UserVeselinVasilev ,
                      data.UserAntoniyaPetrova ,
                      data.UserLyubomirDimitrov,
                      data.UserZornitsaTodorova,
                      data.UserStefanIvanov ,
                      data.UserYoanaGeorgieva ,
                      data.UserKrasimiraPetrova,
                      data.UserIvayloKolev ,
                      data.UserMargaritaGeorgieva ,
                      data.UserRumenIvanov ,
                      data.UserMilenaDimitrova  ,
                      data.UserYordanTodorov ,
                      data.UserSilviyaPetrova ,
                      data.UserBogdanIvanov ,
                      data.UserPetyaKoleva ,
                      data.UserAsenMarinov ,
                      data.UserRalitsaIvanova,
                      data.UserVelkoVasilev ,
                      data.UserGalyaDimitrova,
                      data.UserDimiturIvanov ,
                      data.UserNadiaKoleva  ,
                      data.UserYulianPetrov ,
                      data.UserRadostinaGeorgieva,
                      data.UserKrasimIvanov,
                      data.UserTeodoraTodorova ,
                      data.UserKalinPetrov  ,
                      data.UserSvetlaDimitrova ,
                      data.UserVentsislavGeorgiev ,
                      data.UserVasilenaIvanova ,
                      data.UserMartinPetrov ,
                      data.UserRalitsaKoleva ,
                      data.UserStefanDimitrov ,
                      data.UserSnezhanaGeorgieva ,
                      data.UserIvayloIvanov ,
                      data.UserMarianaPetrova ,
                      data.UserRosenKolev ,
                      data.UserTanyaStoyanova,
                      data.UserDimitarIvanov,
                      data.UserElenaPetrova ,
                      data.UserStefchoDimitrov ,
                      data.UserMilenaGeorgieva ,
                      data.UserAleksandarTodorov,
                      data.UserViktoriaIvanova ,
                      data.UserNikolayKolev ,
                      data.UserMariaVasileva ,
                      data.UserIvayloPetrov ,
                      data.UserGabrielaStoyanova,
                      data.UserGeorgiMarinov ,
                      data.UserKristinaPetrova ,
                      data.UserRumchoIvanov ,
                      data.UserEmiliaGeorgieva ,
                      data.UserKrasimirDimitrov ,
                      data.UserSilviyaIvanova  ,
                      data.UserAsenGeorgiev ,
                      data.UserElenaKoleva ,
                      data.UserStanimirTodorov ,
                      data.UserMagdalenaIvanova ,
                      data.UserHristoPetrov ,
                      data.UserKalinaDimitrova  ,
                      data.UserTsvetanchoGeorgiev,
                      data.UserNadezhdaIvanova  ,
                      data.UserBorisStefanov  ,
                      data.UserAneliyaKoleva ,
                      data.UserRosenPetrov ,
                      data.UserRadostinaIvanova ,
                      data.UserVasilAleksandrov ,
                      data.UserRositsaGeorgieva ,
                      data.UserPlamenIvanov  ,
                      data.UserValentinaDimitrova,
                      data.UserIvoStoyanov ,
                      data.UserStefaniyaPetrova ,
                      data.UserMartinKolev  ,
                      data.UserSonyaIvanova  ,
                      data.UserLyubomirGeorgiev ,
                      data.UserNataliyaVasileva ,
                      data.UserPetarPetrov  ,
                      data.UserGerganaDimitrova ,
                      data.UserLyubomiraTodorova ,
                      data.UserAntonIvanov ,
                      data.UserTanyaGeorgieva ,
                      data.UserKamenchoPetrov ,
                      data.UserVanyaKoleva ,
                      data.UserRadoslavGeorgiev ,
                      data.UserVasilenkaIvanova ,
                      data.UserKirilDimitrov  ,
                      data.UserKameliyaTodorova ,
                      data.UserIliyaPetrov ,
                      data.UserDilyanaIvanova ,
                      data.UserBogdanKolev ,
                      data.UserDanielaMarinova  ,
                      data.UserHristiyanIvanov ,
                      data.UserTeodoraVasileva ,
                      data.UserDesislavDimitrov ,
                      data.UserGalyaIvanova ,
                      data.UserIvanKolev ,
                      data.UserMariyaPetrova ,
                      data.UserSimeonGeorgiev ,
                      data.UserMagdalinaIvanova ,
                      data.UserEmilTodorov ,
                      data.UserKalinchoPetrov ,
                      data.UserRalitsaDimitrova ,
                      data.UserYordanGeorgiev ,
                      data.UserRadinkaIvanova ,
                      data.UserVentsislavPetrov ,
                      data.UserDarinaKoleva ,
                      data.UserBozhidarDimitrov ,
                      data.UserNeliGeorgieva ,
                      data.UserYavorIvanov ,
                      data.UserMilitsaPetrova ,
                      data.UserZdravkoKolev ,
                      data.UserElenaStoyanova
            });
        }
    }
}