using Microsoft.AspNetCore.Identity;
using SchoolSystem.Infrastructure.Data.Models;

namespace SchoolSystem.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        //Subjects

        public Subject Bulgarian { get; set; } = new Subject();
        public Subject Mathematics { get; set; } = new Subject();
        public Subject English { get; set; } = new Subject();
        public Subject SoftwareDesign { get; set; } = new Subject();
        public Subject ComputerScience { get; set; } = new Subject();
        public Subject Business { get; set; } = new Subject();
        public Subject Physics { get; set; } = new Subject();
        public Subject Programming { get; set; } = new Subject();
        public Subject Engineering { get; set; } = new Subject();
        public Subject History { get; set; } = new Subject();


        //Teachers

        public Teacher TatyanaGerganova { get; set; } = new Teacher();
        public IdentityUser UserTatyanaGerganova { get; set; } = new IdentityUser();

        public Teacher BilyanaLozanova { get; set; } = new Teacher();
        public IdentityUser UserBilyanaLozanova { get; set; } = new IdentityUser();

        public Teacher KrasimiraKutin { get; set; } = new Teacher();
        public IdentityUser UserKrasimiraKutin { get; set; } = new IdentityUser();

        public Teacher TeodorHristov { get; set; } = new Teacher();
        public IdentityUser UserTeodorHristov { get; set; } = new IdentityUser();

        public Teacher SilviyaGancheva { get; set; } = new Teacher();
        public IdentityUser UserSilviyaGancheva { get; set; } = new IdentityUser();

        public Teacher CvetomirAmbursa { get; set; } = new Teacher();
        public IdentityUser UserCvetomirAmbursa { get; set; } = new IdentityUser();

        public Teacher MitkoMitkov { get; set; } = new Teacher();
        public IdentityUser UserMitkoMitkov { get; set; } = new IdentityUser();

        public Teacher EmilStoyanov { get; set; } = new Teacher();
        public IdentityUser UserEmilStoyanov { get; set; } = new IdentityUser();

        public Teacher BorislavaBangeeva { get; set; } = new Teacher();
        public IdentityUser UserBorislavaBangeeva { get; set; } = new IdentityUser();

        public Teacher MariaIvanova { get; set; } = new Teacher();
        public IdentityUser UserMariaIvanova { get; set; } = new IdentityUser();


        //Classes

        public Class Eight { get; set; } = new Class();
        public Class Ninth { get; set; } = new Class();
        public Class Tenth { get; set; } = new Class();
        public Class Eleventh { get; set; } = new Class();
        public Class Twelfth { get; set; } = new Class();


        //Principals

        public Principal RadostinaMekova { get; set; } = new Principal();
        public IdentityUser UserRadostinaMekova { get; set; } = new IdentityUser();

        public Principal ValentinaStoeva { get; set; } = new Principal();
        public IdentityUser UserValentinaStoeva { get; set; } = new IdentityUser();

        public Principal YulianaPetkova { get; set; } = new Principal();
        public IdentityUser UserYulianaPetkova { get; set; } = new IdentityUser();


        //Parents

        public Parent KrumIvanov { get; set; } = new Parent();
        public IdentityUser UserKrumIvanov { get; set; } = new IdentityUser();

        public Parent VeronikaPetrova { get; set; } = new Parent();
        public IdentityUser UserVeronikaPetrova { get; set; } = new IdentityUser();

        public Parent PlamenDimitrov { get; set; } = new Parent();
        public IdentityUser UserPlamenDimitrov { get; set; } = new IdentityUser();

        public Parent ZlatinaGeorgieva { get; set; } = new Parent();
        public IdentityUser UserZlatinaGeorgieva { get; set; } = new IdentityUser();

        public Parent RadoslavTodorov { get; set; } = new Parent();
        public IdentityUser UserRadoslavTodorov { get; set; } = new IdentityUser();

        public Parent AdrianaIvanova { get; set; } = new Parent();
        public IdentityUser UserAdrianaIvanova { get; set; } = new IdentityUser();

        public Parent BozhidarKolev { get; set; } = new Parent();
        public IdentityUser UserBozhidarKolev { get; set; } = new IdentityUser();

        public Parent EvelinaVasileva { get; set; } = new Parent();
        public IdentityUser UserEvelinaVasileva { get; set; } = new IdentityUser();

        public Parent StoyanPetrov { get; set; } = new Parent();
        public IdentityUser UserStoyanPetrov { get; set; } = new IdentityUser();

        public Parent TsvetelinaStoyanova { get; set; } = new Parent();
        public IdentityUser UserTsvetelinaStoyanova { get; set; } = new IdentityUser();

        public Parent LyubenMarinov { get; set; } = new Parent();
        public IdentityUser UserLyubenMarinov { get; set; } = new IdentityUser();

        public Parent RositsaPetrova { get; set; } = new Parent();
        public IdentityUser UserRositsaPetrova { get; set; } = new IdentityUser();

        public Parent KaloyanIvanov { get; set; } = new Parent();
        public IdentityUser UserKaloyanIvanov { get; set; } = new IdentityUser();

        public Parent EkaterinaGeorgieva { get; set; } = new Parent();
        public IdentityUser UserEkaterinaGeorgieva { get; set; } = new IdentityUser();

        public Parent HristoDimitrov { get; set; } = new Parent();
        public IdentityUser UserHristoDimitrov { get; set; } = new IdentityUser();

        public Parent DobrinkaIvanova { get; set; } = new Parent();
        public IdentityUser UserDobrinkaIvanova { get; set; } = new IdentityUser();

        public Parent BlagoyGeorgiev { get; set; } = new Parent();
        public IdentityUser UserBlagoyGeorgiev { get; set; } = new IdentityUser();

        public Parent IskraKoleva { get; set; } = new Parent();
        public IdentityUser UserIskraKoleva { get; set; } = new IdentityUser();

        public Parent KrasimirTodorov { get; set; } = new Parent();
        public IdentityUser UserKrasimirTodorov { get; set; } = new IdentityUser();

        public Parent GerganaIvanova { get; set; } = new Parent();
        public IdentityUser UserGerganaIvanova { get; set; } = new IdentityUser();

        public Parent VasilPetrov { get; set; } = new Parent();
        public IdentityUser UserVasilPetrov { get; set; } = new IdentityUser();

        public Parent NadezhdaDimitrova { get; set; } = new Parent();
        public IdentityUser UserNadezhdaDimitrova { get; set; } = new IdentityUser();

        public Parent TodorGeorgiev { get; set; } = new Parent();
        public IdentityUser UserTodorGeorgiev { get; set; } = new IdentityUser();

        public Parent RadkaIvanova { get; set; } = new Parent();
        public IdentityUser UserRadkaIvanova { get; set; } = new IdentityUser();

        public Parent HristinaStefanova { get; set; } = new Parent();
        public IdentityUser UserHristinaStefanova { get; set; } = new IdentityUser();

        public Parent YavorKolev { get; set; } = new Parent();
        public IdentityUser UserYavorKolev { get; set; } = new IdentityUser();

        public Parent KameliaPetrova { get; set; } = new Parent();
        public IdentityUser UserKameliaPetrova { get; set; } = new IdentityUser();

        public Parent EmilIvanov { get; set; } = new Parent();
        public IdentityUser UserEmilIvanov { get; set; } = new IdentityUser();

        public Parent DilyanaAleksandrova { get; set; } = new Parent();
        public IdentityUser UserDilyanaAleksandrova { get; set; } = new IdentityUser();

        public Parent TsvetanGeorgiev { get; set; } = new Parent();
        public IdentityUser UserTsvetanGeorgiev { get; set; } = new IdentityUser();

        public Parent ZhivkaIvanova { get; set; } = new Parent();
        public IdentityUser UserZhivkaIvanova { get; set; } = new IdentityUser();

        public Parent IvoDimitrov { get; set; } = new Parent();
        public IdentityUser UserIvoDimitrov { get; set; } = new IdentityUser();

        public Parent AdriyanaStoyanova { get; set; } = new Parent();
        public IdentityUser UserAdriyanaStoyanova { get; set; } = new IdentityUser();

        public Parent KamenPetrov { get; set; } = new Parent();
        public IdentityUser UserKamenPetrov { get; set; } = new IdentityUser();

        public Parent KristinaKoleva { get; set; } = new Parent();
        public IdentityUser UserKristinaKoleva { get; set; } = new IdentityUser();

        public Parent YankoIvanov { get; set; } = new Parent();
        public IdentityUser UserYankoIvanov { get; set; } = new IdentityUser();

        public Parent PolinaGeorgieva { get; set; } = new Parent();
        public IdentityUser UserPolinaGeorgieva { get; set; } = new IdentityUser();

        public Parent VeselinVasilev { get; set; } = new Parent();
        public IdentityUser UserVeselinVasilev { get; set; } = new IdentityUser();

        public Parent AntoniyaPetrova { get; set; } = new Parent();
        public IdentityUser UserAntoniyaPetrova { get; set; } = new IdentityUser();

        public Parent LyubomirDimitrov { get; set; } = new Parent();
        public IdentityUser UserLyubomirDimitrov { get; set; } = new IdentityUser();

        public Parent ZornitsaTodorova { get; set; } = new Parent();
        public IdentityUser UserZornitsaTodorova { get; set; } = new IdentityUser();

        public Parent StefanIvanov { get; set; } = new Parent();
        public IdentityUser UserStefanIvanov { get; set; } = new IdentityUser();

        public Parent YoanaGeorgieva { get; set; } = new Parent();
        public IdentityUser UserYoanaGeorgieva { get; set; } = new IdentityUser();

        public Parent KrasimiraPetrova { get; set; } = new Parent();
        public IdentityUser UserKrasimiraPetrova { get; set; } = new IdentityUser();

        public Parent IvayloKolev { get; set; } = new Parent();
        public IdentityUser UserIvayloKolev { get; set; } = new IdentityUser();

        public Parent MargaritaGeorgieva { get; set; } = new Parent();
        public IdentityUser UserMargaritaGeorgieva { get; set; } = new IdentityUser();

        public Parent RumenIvanov { get; set; } = new Parent();
        public IdentityUser UserRumenIvanov { get; set; } = new IdentityUser();

        public Parent MilenaDimitrova { get; set; } = new Parent();
        public IdentityUser UserMilenaDimitrova { get; set; } = new IdentityUser();

        public Parent YordanTodorov { get; set; } = new Parent();
        public IdentityUser UserYordanTodorov { get; set; } = new IdentityUser();

        public Parent SilviyaPetrova { get; set; } = new Parent();
        public IdentityUser UserSilviyaPetrova { get; set; } = new IdentityUser();

        public Parent BogdanIvanov { get; set; } = new Parent();
        public IdentityUser UserBogdanIvanov { get; set; } = new IdentityUser();

        public Parent PetyaKoleva { get; set; } = new Parent();
        public IdentityUser UserPetyaKoleva { get; set; } = new IdentityUser();

        public Parent AsenMarinov { get; set; } = new Parent();
        public IdentityUser UserAsenMarinov { get; set; } = new IdentityUser();

        public Parent RalitsaIvanova { get; set; } = new Parent();
        public IdentityUser UserRalitsaIvanova { get; set; } = new IdentityUser();

        public Parent VelkoVasilev { get; set; } = new Parent();
        public IdentityUser UserVelkoVasilev { get; set; } = new IdentityUser();

        public Parent GalyaDimitrova { get; set; } = new Parent();
        public IdentityUser UserGalyaDimitrova { get; set; } = new IdentityUser();

        public Parent DimiturIvanov { get; set; } = new Parent();
        public IdentityUser UserDimiturIvanov { get; set; } = new IdentityUser();

        public Parent NadiaKoleva { get; set; } = new Parent();
        public IdentityUser UserNadiaKoleva { get; set; } = new IdentityUser();

        public Parent YulianPetrov { get; set; } = new Parent();
        public IdentityUser UserYulianPetrov { get; set; } = new IdentityUser();

        public Parent RadostinaGeorgieva { get; set; } = new Parent();
        public IdentityUser UserRadostinaGeorgieva { get; set; } = new IdentityUser();

        public Parent KrasimIvanov { get; set; } = new Parent();
        public IdentityUser UserKrasimIvanov { get; set; } = new IdentityUser();

        public Parent TeodoraTodorova { get; set; } = new Parent();
        public IdentityUser UserTeodoraTodorova { get; set; } = new IdentityUser();

        public Parent KalinPetrov { get; set; } = new Parent();
        public IdentityUser UserKalinPetrov { get; set; } = new IdentityUser();

        public Parent SvetlaDimitrova { get; set; } = new Parent();
        public IdentityUser UserSvetlaDimitrova { get; set; } = new IdentityUser();

        public Parent VentsislavGeorgiev { get; set; } = new Parent();
        public IdentityUser UserVentsislavGeorgiev { get; set; } = new IdentityUser();

        public Parent VasilenaIvanova { get; set; } = new Parent();
        public IdentityUser UserVasilenaIvanova { get; set; } = new IdentityUser();

        public Parent MartinPetrov { get; set; } = new Parent();
        public IdentityUser UserMartinPetrov { get; set; } = new IdentityUser();

        public Parent RalitsaKoleva { get; set; } = new Parent();
        public IdentityUser UserRalitsaKoleva { get; set; } = new IdentityUser();

        public Parent StefanDimitrov { get; set; } = new Parent();
        public IdentityUser UserStefanDimitrov { get; set; } = new IdentityUser();

        public Parent SnezhanaGeorgieva { get; set; } = new Parent();
        public IdentityUser UserSnezhanaGeorgieva { get; set; } = new IdentityUser();

        public Parent IvayloIvanov { get; set; } = new Parent();
        public IdentityUser UserIvayloIvanov { get; set; } = new IdentityUser();

        public Parent MarianaPetrova { get; set; } = new Parent();
        public IdentityUser UserMarianaPetrova { get; set; } = new IdentityUser();

        public Parent RosenKolev { get; set; } = new Parent();
        public IdentityUser UserRosenKolev { get; set; } = new IdentityUser();

        public Parent TanyaStoyanova { get; set; } = new Parent();
        public IdentityUser UserTanyaStoyanova { get; set; } = new IdentityUser();



        //Students

        public Student DimitarIvanov { get; set; } = new Student();
        public IdentityUser UserDimitarIvanov { get; set; } = new IdentityUser();

        public Student ElenaPetrova { get; set; } = new Student();
        public IdentityUser UserElenaPetrova { get; set; } = new IdentityUser();

        public Student StefchoDimitrov { get; set; } = new Student();
        public IdentityUser UserStefchoDimitrov { get; set; } = new IdentityUser();

        public Student MilenaGeorgieva { get; set; } = new Student();
        public IdentityUser UserMilenaGeorgieva { get; set; } = new IdentityUser();

        public Student AleksandarTodorov { get; set; } = new Student();
        public IdentityUser UserAleksandarTodorov { get; set; } = new IdentityUser();

        public Student ViktoriaIvanova { get; set; } = new Student();
        public IdentityUser UserViktoriaIvanova { get; set; } = new IdentityUser();

        public Student NikolayKolev { get; set; } = new Student();
        public IdentityUser UserNikolayKolev { get; set; } = new IdentityUser();

        public Student MariaVasileva { get; set; } = new Student();
        public IdentityUser UserMariaVasileva { get; set; } = new IdentityUser();

        public Student IvayloPetrov { get; set; } = new Student();
        public IdentityUser UserIvayloPetrov { get; set; } = new IdentityUser();

        public Student GabrielaStoyanova { get; set; } = new Student();
        public IdentityUser UserGabrielaStoyanova { get; set; } = new IdentityUser();

        public Student GeorgiMarinov { get; set; } = new Student();
        public IdentityUser UserGeorgiMarinov { get; set; } = new IdentityUser();

        public Student KristinaPetrova { get; set; } = new Student();
        public IdentityUser UserKristinaPetrova { get; set; } = new IdentityUser();

        public Student RumchoIvanov { get; set; } = new Student();
        public IdentityUser UserRumchoIvanov { get; set; } = new IdentityUser();

        public Student EmiliaGeorgieva { get; set; } = new Student();
        public IdentityUser UserEmiliaGeorgieva { get; set; } = new IdentityUser();

        public Student KrasimirDimitrov { get; set; } = new Student();
        public IdentityUser UserKrasimirDimitrov { get; set; } = new IdentityUser();

        public Student SilviyaIvanova { get; set; } = new Student();
        public IdentityUser UserSilviyaIvanova { get; set; } = new IdentityUser();

        public Student AsenGeorgiev { get; set; } = new Student();
        public IdentityUser UserAsenGeorgiev { get; set; } = new IdentityUser();

        public Student ElenaKoleva { get; set; } = new Student();
        public IdentityUser UserElenaKoleva { get; set; } = new IdentityUser();

        public Student StanimirTodorov { get; set; } = new Student();
        public IdentityUser UserStanimirTodorov { get; set; } = new IdentityUser();

        public Student MagdalenaIvanova { get; set; } = new Student();
        public IdentityUser UserMagdalenaIvanova { get; set; } = new IdentityUser();

        public Student HristoPetrov { get; set; } = new Student();
        public IdentityUser UserHristoPetrov { get; set; } = new IdentityUser();

        public Student KalinaDimitrova { get; set; } = new Student();
        public IdentityUser UserKalinaDimitrova { get; set; } = new IdentityUser();

        public Student TsvetanchoGeorgiev { get; set; } = new Student();
        public IdentityUser UserTsvetanchoGeorgiev { get; set; } = new IdentityUser();

        public Student NadezhdaIvanova { get; set; } = new Student();
        public IdentityUser UserNadezhdaIvanova { get; set; } = new IdentityUser();

        public Student BorisStefanov { get; set; } = new Student();
        public IdentityUser UserBorisStefanov { get; set; } = new IdentityUser();

        public Student AneliyaKoleva { get; set; } = new Student();
        public IdentityUser UserAneliyaKoleva { get; set; } = new IdentityUser();

        public Student RosenPetrov { get; set; } = new Student();
        public IdentityUser UserRosenPetrov { get; set; } = new IdentityUser();

        public Student RadostinaIvanova { get; set; } = new Student();
        public IdentityUser UserRadostinaIvanova { get; set; } = new IdentityUser();

        public Student VasilAleksandrov { get; set; } = new Student();
        public IdentityUser UserVasilAleksandrov { get; set; } = new IdentityUser();

        public Student RositsaGeorgieva { get; set; } = new Student();
        public IdentityUser UserRositsaGeorgieva { get; set; } = new IdentityUser();

        public Student PlamenIvanov { get; set; } = new Student();
        public IdentityUser UserPlamenIvanov { get; set; } = new IdentityUser();

        public Student ValentinaDimitrova { get; set; } = new Student();
        public IdentityUser UserValentinaDimitrova { get; set; } = new IdentityUser();

        public Student IvoStoyanov { get; set; } = new Student();
        public IdentityUser UserIvoStoyanov { get; set; } = new IdentityUser();

        public Student StefaniyaPetrova { get; set; } = new Student();
        public IdentityUser UserStefaniyaPetrova { get; set; } = new IdentityUser();

        public Student MartinKolev { get; set; } = new Student();
        public IdentityUser UserMartinKolev { get; set; } = new IdentityUser();

        public Student SonyaIvanova { get; set; } = new Student();
        public IdentityUser UserSonyaIvanova { get; set; } = new IdentityUser();

        public Student LyubomirGeorgiev { get; set; } = new Student();
        public IdentityUser UserLyubomirGeorgiev { get; set; } = new IdentityUser();

        public Student NataliyaVasileva { get; set; } = new Student();
        public IdentityUser UserNataliyaVasileva { get; set; } = new IdentityUser();

        public Student PetarPetrov { get; set; } = new Student();
        public IdentityUser UserPetarPetrov { get; set; } = new IdentityUser();

        public Student GerganaDimitrova { get; set; } = new Student();
        public IdentityUser UserGerganaDimitrova { get; set; } = new IdentityUser();

        public Student LyubomiraTodorova { get; set; } = new Student();
        public IdentityUser UserLyubomiraTodorova { get; set; } = new IdentityUser();

        public Student AntonIvanov { get; set; } = new Student();
        public IdentityUser UserAntonIvanov { get; set; } = new IdentityUser();

        public Student TanyaGeorgieva { get; set; } = new Student();
        public IdentityUser UserTanyaGeorgieva { get; set; } = new IdentityUser();

        public Student KamenchoPetrov { get; set; } = new Student();
        public IdentityUser UserKamenchoPetrov { get; set; } = new IdentityUser();

        public Student VanyaKoleva { get; set; } = new Student();
        public IdentityUser UserVanyaKoleva { get; set; } = new IdentityUser();

        public Student RadoslavGeorgiev { get; set; } = new Student();
        public IdentityUser UserRadoslavGeorgiev { get; set; } = new IdentityUser();

        public Student VasilenkaIvanova { get; set; } = new Student();
        public IdentityUser UserVasilenkaIvanova { get; set; } = new IdentityUser();

        public Student KirilDimitrov { get; set; } = new Student();
        public IdentityUser UserKirilDimitrov { get; set; } = new IdentityUser();

        public Student KameliyaTodorova { get; set; } = new Student();
        public IdentityUser UserKameliyaTodorova { get; set; } = new IdentityUser();

        public Student IliyaPetrov { get; set; } = new Student();
        public IdentityUser UserIliyaPetrov { get; set; } = new IdentityUser();

        public Student DilyanaIvanova { get; set; } = new Student();
        public IdentityUser UserDilyanaIvanova { get; set; } = new IdentityUser();

        public Student BogdanKolev { get; set; } = new Student();
        public IdentityUser UserBogdanKolev { get; set; } = new IdentityUser();

        public Student DanielaMarinova { get; set; } = new Student();
        public IdentityUser UserDanielaMarinova { get; set; } = new IdentityUser();

        public Student HristiyanIvanov { get; set; } = new Student();
        public IdentityUser UserHristiyanIvanov { get; set; } = new IdentityUser();

        public Student TeodoraVasileva { get; set; } = new Student();
        public IdentityUser UserTeodoraVasileva { get; set; } = new IdentityUser();

        public Student DesislavDimitrov { get; set; } = new Student();
        public IdentityUser UserDesislavDimitrov { get; set; } = new IdentityUser();

        public Student GalyaIvanova { get; set; } = new Student();
        public IdentityUser UserGalyaIvanova { get; set; } = new IdentityUser();

        public Student IvanKolev { get; set; } = new Student();
        public IdentityUser UserIvanKolev { get; set; } = new IdentityUser();

        public Student MariyaPetrova { get; set; } = new Student();
        public IdentityUser UserMariyaPetrova { get; set; } = new IdentityUser();

        public Student SimeonGeorgiev { get; set; } = new Student();
        public IdentityUser UserSimeonGeorgiev { get; set; } = new IdentityUser();

        public Student MagdalinaIvanova { get; set; } = new Student();
        public IdentityUser UserMagdalinaIvanova { get; set; } = new IdentityUser();

        public Student EmilTodorov { get; set; } = new Student();
        public IdentityUser UserEmilTodorov { get; set; } = new IdentityUser();

        public Student KalinchoPetrov { get; set; } = new Student();
        public IdentityUser UserKalinchoPetrov { get; set; } = new IdentityUser();

        public Student RalitsaDimitrova { get; set; } = new Student();
        public IdentityUser UserRalitsaDimitrova { get; set; } = new IdentityUser();

        public Student YordanGeorgiev { get; set; } = new Student();
        public IdentityUser UserYordanGeorgiev { get; set; } = new IdentityUser();

        public Student RadinkaIvanova { get; set; } = new Student();
        public IdentityUser UserRadinkaIvanova { get; set; } = new IdentityUser();

        public Student VentsislavPetrov { get; set; } = new Student();
        public IdentityUser UserVentsislavPetrov { get; set; } = new IdentityUser();

        public Student DarinaKoleva { get; set; } = new Student();
        public IdentityUser UserDarinaKoleva { get; set; } = new IdentityUser();

        public Student BozhidarDimitrov { get; set; } = new Student();
        public IdentityUser UserBozhidarDimitrov { get; set; } = new IdentityUser();

        public Student NeliGeorgieva { get; set; } = new Student();
        public IdentityUser UserNeliGeorgieva { get; set; } = new IdentityUser();

        public Student YavorIvanov { get; set; } = new Student();
        public IdentityUser UserYavorIvanov { get; set; } = new IdentityUser();

        public Student MilitsaPetrova { get; set; } = new Student();
        public IdentityUser UserMilitsaPetrova { get; set; } = new IdentityUser();

        public Student ZdravkoKolev { get; set; } = new Student();
        public IdentityUser UserZdravkoKolev { get; set; } = new IdentityUser();

        public Student ElenaStoyanova { get; set; } = new Student();
        public IdentityUser UserElenaStoyanova { get; set; } = new IdentityUser();



        //StudentSubjectGrades

        //1
        public StudentSubjectGrade OneOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade OneTen { get; set; } = new StudentSubjectGrade();


        //2
        public StudentSubjectGrade TwoOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwoTen { get; set; } = new StudentSubjectGrade();

        //3
        public StudentSubjectGrade ThreeOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThreeTen { get; set; } = new StudentSubjectGrade();

        //4
        public StudentSubjectGrade FourOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourTen { get; set; } = new StudentSubjectGrade();

        //5
        public StudentSubjectGrade FiveOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiveTen { get; set; } = new StudentSubjectGrade();

        //6
        public StudentSubjectGrade SixOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixTen { get; set; } = new StudentSubjectGrade();

        //7
        public StudentSubjectGrade SevenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SevenTen { get; set; } = new StudentSubjectGrade();

        //8
        public StudentSubjectGrade EightOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EightTen { get; set; } = new StudentSubjectGrade();

        //9
        public StudentSubjectGrade NineOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineTen { get; set; } = new StudentSubjectGrade();

        //10
        public StudentSubjectGrade TenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TenTen { get; set; } = new StudentSubjectGrade();

        //11
        public StudentSubjectGrade ElevenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ElevenTen { get; set; } = new StudentSubjectGrade();

        //12
        public StudentSubjectGrade TwelveOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwelveTen { get; set; } = new StudentSubjectGrade();

        //13
        public StudentSubjectGrade ThirteenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirteenTen { get; set; } = new StudentSubjectGrade();

        //14
        public StudentSubjectGrade FourteenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FourteenTen { get; set; } = new StudentSubjectGrade();

        //15
        public StudentSubjectGrade FifteenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FifteenTen { get; set; } = new StudentSubjectGrade();

        //16
        public StudentSubjectGrade SixteenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixteenTen { get; set; } = new StudentSubjectGrade();

        //17
        public StudentSubjectGrade SeventeenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventeenTen { get; set; } = new StudentSubjectGrade();

        //18
        public StudentSubjectGrade EighteenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade EighteenTen { get; set; } = new StudentSubjectGrade();

        //19
        public StudentSubjectGrade NineteenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade NineteenTen { get; set; } = new StudentSubjectGrade();

        //20
        public StudentSubjectGrade TwentyOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTen { get; set; } = new StudentSubjectGrade();

        //21
        public StudentSubjectGrade TwentyOneOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyOneTen { get; set; } = new StudentSubjectGrade();

        //22
        public StudentSubjectGrade TwentyTwoOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyTwoTen { get; set; } = new StudentSubjectGrade();

        //23
        public StudentSubjectGrade TwentyThreeOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyThreeTen { get; set; } = new StudentSubjectGrade();

        //24
        public StudentSubjectGrade TwentyFourOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFourTen { get; set; } = new StudentSubjectGrade();

        //25
        public StudentSubjectGrade TwentyFiveOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyFiveTen { get; set; } = new StudentSubjectGrade();

        //26
        public StudentSubjectGrade TwentySixOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySixTen { get; set; } = new StudentSubjectGrade();

        //27
        public StudentSubjectGrade TwentySevenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentySevenTen { get; set; } = new StudentSubjectGrade();

        //28
        public StudentSubjectGrade TwentyEightOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyEightTen { get; set; } = new StudentSubjectGrade();

        //29
        public StudentSubjectGrade TwentyNineOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade TwentyNineTen { get; set; } = new StudentSubjectGrade();

        //30
        public StudentSubjectGrade ThirtyOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTen { get; set; } = new StudentSubjectGrade();

        //31
        public StudentSubjectGrade ThirtyOneOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyOneTen { get; set; } = new StudentSubjectGrade();

        //32
        public StudentSubjectGrade ThirtyTwoOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyTwoTen { get; set; } = new StudentSubjectGrade();

        //33
        public StudentSubjectGrade ThirtyThreeOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyThreeTen { get; set; } = new StudentSubjectGrade();

        //34
        public StudentSubjectGrade ThirtyFourOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFourTen { get; set; } = new StudentSubjectGrade();

        //35
        public StudentSubjectGrade ThirtyFiveOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyFiveTen { get; set; } = new StudentSubjectGrade();

        //36
        public StudentSubjectGrade ThirtySixOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySixTen { get; set; } = new StudentSubjectGrade();

        //37
        public StudentSubjectGrade ThirtySevenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtySevenTen { get; set; } = new StudentSubjectGrade();

        //38
        public StudentSubjectGrade ThirtyEightOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyEightTen { get; set; } = new StudentSubjectGrade();

        //39
        public StudentSubjectGrade ThirtyNineOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade ThirtyNineTen { get; set; } = new StudentSubjectGrade();

        //40
        public StudentSubjectGrade FortyOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTen { get; set; } = new StudentSubjectGrade();

        //41
        public StudentSubjectGrade FortyOneOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyOneTen { get; set; } = new StudentSubjectGrade();

        //42
        public StudentSubjectGrade FortyTwoOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyTwoTen { get; set; } = new StudentSubjectGrade();

        //43
        public StudentSubjectGrade FortyThreeOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyThreeTen { get; set; } = new StudentSubjectGrade();

        //44
        public StudentSubjectGrade FortyFourOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFourTen { get; set; } = new StudentSubjectGrade();

        //45
        public StudentSubjectGrade FortyFiveOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyFiveTen { get; set; } = new StudentSubjectGrade();

        //46
        public StudentSubjectGrade FortySixOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySixTen { get; set; } = new StudentSubjectGrade();

        //47
        public StudentSubjectGrade FortySevenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortySevenTen { get; set; } = new StudentSubjectGrade();

        //48
        public StudentSubjectGrade FortyEightOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyEightTen { get; set; } = new StudentSubjectGrade();

        //49
        public StudentSubjectGrade FortyNineOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FortyNineTen { get; set; } = new StudentSubjectGrade();

        //50
        public StudentSubjectGrade FiftyOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTen { get; set; } = new StudentSubjectGrade();

        //51
        public StudentSubjectGrade FiftyOneOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyOneTen { get; set; } = new StudentSubjectGrade();

        //52
        public StudentSubjectGrade FiftyTwoOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyTwoTen { get; set; } = new StudentSubjectGrade();

        //53
        public StudentSubjectGrade FiftyThreeOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyThreeTen { get; set; } = new StudentSubjectGrade();

        //54
        public StudentSubjectGrade FiftyFourOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFourTen { get; set; } = new StudentSubjectGrade();

        //55
        public StudentSubjectGrade FiftyFiveOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyFiveTen { get; set; } = new StudentSubjectGrade();

        //56
        public StudentSubjectGrade FiftySixOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySixTen { get; set; } = new StudentSubjectGrade();

        //57
        public StudentSubjectGrade FiftySevenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftySevenTen { get; set; } = new StudentSubjectGrade();

        //58
        public StudentSubjectGrade FiftyEightOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyEightTen { get; set; } = new StudentSubjectGrade();

        //59
        public StudentSubjectGrade FiftyNineOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade FiftyNineTen { get; set; } = new StudentSubjectGrade();

        //60
        public StudentSubjectGrade SixtyOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTen { get; set; } = new StudentSubjectGrade();

        //61
        public StudentSubjectGrade SixtyOneOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyOneTen { get; set; } = new StudentSubjectGrade();

        //62
        public StudentSubjectGrade SixtyTwoOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyTwoTen { get; set; } = new StudentSubjectGrade();

        //63
        public StudentSubjectGrade SixtyThreeOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyThreeTen { get; set; } = new StudentSubjectGrade();

        //64
        public StudentSubjectGrade SixtyFourOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFourTen { get; set; } = new StudentSubjectGrade();

        //65
        public StudentSubjectGrade SixtyFiveOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyFiveTen { get; set; } = new StudentSubjectGrade();

        //66
        public StudentSubjectGrade SixtySixOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySixTen { get; set; } = new StudentSubjectGrade();

        //67
        public StudentSubjectGrade SixtySevenOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtySevenTen { get; set; } = new StudentSubjectGrade();

        //68
        public StudentSubjectGrade SixtyEightOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyEightTen { get; set; } = new StudentSubjectGrade();

        //69
        public StudentSubjectGrade SixtyNineOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SixtyNineTen { get; set; } = new StudentSubjectGrade();

        //70
        public StudentSubjectGrade SeventyOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventySix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventySeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTen { get; set; } = new StudentSubjectGrade();

        //71
        public StudentSubjectGrade SeventyOneOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyOneTen { get; set; } = new StudentSubjectGrade();

        //72
        public StudentSubjectGrade SeventyTwoOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyTwoTen { get; set; } = new StudentSubjectGrade();

        //73
        public StudentSubjectGrade SeventyThreeOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyThreeTen { get; set; } = new StudentSubjectGrade();

        //74
        public StudentSubjectGrade SeventyFourOne { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourTwo { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourThree { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourFour { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourFive { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourSix { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourSeven { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourEight { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourNine { get; set; } = new StudentSubjectGrade();
        public StudentSubjectGrade SeventyFourTen { get; set; } = new StudentSubjectGrade();

        public SeedData()
        {
            SeedPrincipals();
            SeedParents();
            SeedStudents();
            SeedTeachers();
            SeedClasses();
            SeedSubjects();
            SeedStudentSubjectGrades();
            SeedUsers();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();


            //Teachers

            UserTatyanaGerganova = new IdentityUser()
            {
                Id = "bfb57c7b-4d3d-44e5-8e4f-bf68bfdb542d",
                UserName = TatyanaGerganova.Email,
                NormalizedUserName = TatyanaGerganova.Email,
                Email = TatyanaGerganova.Email,
                NormalizedEmail = TatyanaGerganova.Email
            };
            UserTatyanaGerganova.PasswordHash = hasher.HashPassword(UserTatyanaGerganova, "TatyanaGerganova123");

            UserBilyanaLozanova = new IdentityUser()
            {
                Id = "4f2d3e6a-8ef0-4e6b-80c2-9b487bbba2dd",
                UserName = BilyanaLozanova.Email,
                NormalizedUserName = BilyanaLozanova.Email,
                Email = BilyanaLozanova.Email,
                NormalizedEmail = BilyanaLozanova.Email
            };
            UserBilyanaLozanova.PasswordHash = hasher.HashPassword(UserBilyanaLozanova, "BilyanaLozanova123");

            UserKrasimiraKutin = new IdentityUser()
            {
                Id = "f09a28d8-2ad2-465e-8ab6-7b4bd4a82ec6",
                UserName = KrasimiraKutin.Email,
                NormalizedUserName = KrasimiraKutin.Email,
                Email = KrasimiraKutin.Email,
                NormalizedEmail = KrasimiraKutin.Email
            };
            UserKrasimiraKutin.PasswordHash = hasher.HashPassword(UserKrasimiraKutin, "KrasimiraKutin123");

            UserTeodorHristov = new IdentityUser()
            {
                Id = "8a7389a7-17c1-4f0a-96e9-0929cfa1c9b1",
                UserName = TeodorHristov.Email,
                NormalizedUserName = TeodorHristov.Email,
                Email = TeodorHristov.Email,
                NormalizedEmail = TeodorHristov.Email
            };
            UserTeodorHristov.PasswordHash = hasher.HashPassword(UserTeodorHristov, "TeodorHristov123");

            UserSilviyaGancheva = new IdentityUser()
            {
                Id = "7a68960f-439a-42ab-9a4c-10720fd21c95",
                UserName = SilviyaGancheva.Email,
                NormalizedUserName = SilviyaGancheva.Email,
                Email = SilviyaGancheva.Email,
                NormalizedEmail = SilviyaGancheva.Email
            };
            UserSilviyaGancheva.PasswordHash = hasher.HashPassword(UserSilviyaGancheva, "SilviyaGancheva123");

            UserCvetomirAmbursa = new IdentityUser()
            {
                Id = "c3926be0-cc65-4a5d-92c7-4c8917d390bf",
                UserName = CvetomirAmbursa.Email,
                NormalizedUserName = CvetomirAmbursa.Email,
                Email = CvetomirAmbursa.Email,
                NormalizedEmail = CvetomirAmbursa.Email
            };
            UserCvetomirAmbursa.PasswordHash = hasher.HashPassword(UserCvetomirAmbursa, "CvetomirAmbursa123");

            UserMitkoMitkov = new IdentityUser()
            {
                Id = "a15da546-3bc8-4ee7-90cd-172a2180f220",
                UserName = MitkoMitkov.Email,
                NormalizedUserName = MitkoMitkov.Email,
                Email = MitkoMitkov.Email,
                NormalizedEmail = MitkoMitkov.Email
            };
            UserMitkoMitkov.PasswordHash = hasher.HashPassword(UserMitkoMitkov, "MitkoMitkov123");

            UserEmilStoyanov = new IdentityUser()
            {
                Id = "d3a9008b-85c3-4a1a-8f57-36ad03b32a72",
                UserName = EmilStoyanov.Email,
                NormalizedUserName = EmilStoyanov.Email,
                Email = EmilStoyanov.Email,
                NormalizedEmail = EmilStoyanov.Email
            };
            UserEmilStoyanov.PasswordHash = hasher.HashPassword(UserEmilStoyanov, "EmilStoyanov123");

            UserBorislavaBangeeva = new IdentityUser()
            {
                Id = "2db4cc9f-8d87-4e13-97f0-8eb8b7ea00e7",
                UserName = BorislavaBangeeva.Email,
                NormalizedUserName = BorislavaBangeeva.Email,
                Email = BorislavaBangeeva.Email,
                NormalizedEmail = BorislavaBangeeva.Email
            };
            UserBorislavaBangeeva.PasswordHash = hasher.HashPassword(UserBorislavaBangeeva, "BorislavaBangeeva123");

            UserMariaIvanova = new IdentityUser()
            {
                Id = "0c2174fe-5bfc-4842-9cb3-882a35a09902",
                UserName = MariaIvanova.Email,
                NormalizedUserName = MariaIvanova.Email,
                Email = MariaIvanova.Email,
                NormalizedEmail = MariaIvanova.Email
            };
            UserMariaIvanova.PasswordHash = hasher.HashPassword(UserMariaIvanova, "MariaIvanova123");


            //Principals

            UserRadostinaMekova = new IdentityUser()
            {
                Id = "5a11fb1d-76ee-4c9a-8a9e-2534297cf94e",
                UserName = RadostinaMekova.Email,
                NormalizedUserName = RadostinaMekova.Email,
                Email = RadostinaMekova.Email,
                NormalizedEmail = RadostinaMekova.Email
            };
            UserRadostinaMekova.PasswordHash = hasher.HashPassword(UserRadostinaMekova, "RadostinaMekova123");

            UserValentinaStoeva = new IdentityUser()
            {
                Id = "7d4e1b42-7463-4bcf-9d0f-eeb02a87d0c5",
                UserName = ValentinaStoeva.Email,
                NormalizedUserName = ValentinaStoeva.Email,
                Email = ValentinaStoeva.Email,
                NormalizedEmail = ValentinaStoeva.Email
            };
            UserValentinaStoeva.PasswordHash = hasher.HashPassword(UserValentinaStoeva, "ValentinaStoeva123");

            UserYulianaPetkova = new IdentityUser()
            {
                Id = "fbb84d19-1715-4d08-87bb-c87966c442b8",
                UserName = YulianaPetkova.Email,
                NormalizedUserName = YulianaPetkova.Email,
                Email = YulianaPetkova.Email,
                NormalizedEmail = YulianaPetkova.Email
            };
            UserYulianaPetkova.PasswordHash = hasher.HashPassword(UserYulianaPetkova, "YulianaPetkova123");


            //Parents

            UserKrumIvanov = new IdentityUser()
            {
                Id = "b6f0b26e-4baf-4a7c-bb7d-02e5f3a12a6c",
                UserName = "krumivanov",
                NormalizedUserName = "krumivanov",
                Email = "krumivanov@myschool.com",
                NormalizedEmail = "krumivanov@myschool.com"
            };
            UserKrumIvanov.PasswordHash = hasher.HashPassword(UserKrumIvanov, "krumivanov123");

            UserVeronikaPetrova = new IdentityUser()
            {
                Id = "87c52768-9d12-46c1-ae72-0dcf9f415f39",
                UserName = "veronikapetrova",
                NormalizedUserName = "veronikapetrova",
                Email = "veronikapetrova@myschool.com",
                NormalizedEmail = "veronikapetrova@myschool.com"
            };
            UserVeronikaPetrova.PasswordHash = hasher.HashPassword(UserVeronikaPetrova, "veronikapetrova123");

            UserPlamenDimitrov = new IdentityUser()
            {
                Id = "2d8f5db8-876c-4c0a-9c3a-91a4e724cbdd",
                UserName = "plamendimitrov",
                NormalizedUserName = "plamendimitrov",
                Email = "plamendimitrov@myschool.com",
                NormalizedEmail = "plamendimitrov@myschool.com"
            };
            UserPlamenDimitrov.PasswordHash = hasher.HashPassword(UserPlamenDimitrov, "plamendimitrov123");

            UserZlatinaGeorgieva = new IdentityUser()
            {
                Id = "f51a7a24-9aa3-4a93-9dd6-8d8e682ef64d",
                UserName = "zlatinageorieva",
                NormalizedUserName = "zlatinageorieva",
                Email = "zlatinageorieva@myschool.com",
                NormalizedEmail = "zlatinageorieva@myschool.com"
            };
            UserZlatinaGeorgieva.PasswordHash = hasher.HashPassword(UserZlatinaGeorgieva, "zlatinageorgieva123");

            UserRadoslavTodorov = new IdentityUser()
            {
                Id = "c173c3a5-2bf3-40cd-86bb-27b18a2d3b7a",
                UserName = "radoslavtodorov",
                NormalizedUserName = "radoslavtodorov",
                Email = "radoslavtodorov@myschool.com",
                NormalizedEmail = "radoslavtodorov@myschool.com"
            };
            UserRadoslavTodorov.PasswordHash = hasher.HashPassword(UserRadoslavTodorov, "radoslavtodorov123");

            UserAdrianaIvanova = new IdentityUser()
            {
                Id = "6d42e1d8-4e45-48b4-ba42-1a7f9c2a4a5c",
                UserName = "adrianaivanova",
                NormalizedUserName = "adrianaivanova",
                Email = "adrianaivanova@myschool.com",
                NormalizedEmail = "adrianaivanova@myschool.com"
            };
            UserAdrianaIvanova.PasswordHash = hasher.HashPassword(UserAdrianaIvanova, "adrianaivanova123");

            UserBozhidarKolev = new IdentityUser()
            {
                Id = "a8f87e34-d5ae-4c46-aa1d-2f3cc6e11d2a",
                UserName = "bozhidarakolev",
                NormalizedUserName = "bozhidarakolev",
                Email = "bozhidarakolev@myschool.com",
                NormalizedEmail = "bozhidarakolev@myschool.com"
            };
            UserBozhidarKolev.PasswordHash = hasher.HashPassword(UserBozhidarKolev, "bozhidarkolev123");

            UserEvelinaVasileva = new IdentityUser()
            {
                Id = "3f12d8fb-1251-48f5-b566-8f4ef5b2c5d5",
                UserName = "evelinavasileva",
                NormalizedUserName = "evelinavasileva",
                Email = "evelinavasileva@myschool.com",
                NormalizedEmail = "evelinavasileva@myschool.com"
            };
            UserEvelinaVasileva.PasswordHash = hasher.HashPassword(UserEvelinaVasileva, "evelinavasileva123");

            UserStoyanPetrov = new IdentityUser()
            {
                Id = "d7cde10b-1785-4e74-92b3-c18c8f3d9e0a",
                UserName = "stoyanpetrov",
                NormalizedUserName = "stoyanpetrov",
                Email = "stoyanpetrov@myschool.com",
                NormalizedEmail = "stoyanpetrov@myschool.com"
            };
            UserStoyanPetrov.PasswordHash = hasher.HashPassword(UserStoyanPetrov, "stoyanpetrov123");

            UserTsvetelinaStoyanova = new IdentityUser()
            {
                Id = "2f978b4c-4d9c-4ee1-aa1b-bdca0d1f89d6",
                UserName = "tsvetelinastoyanova",
                NormalizedUserName = "tsvetelinastoyanova",
                Email = "tsvetelinastoyanova@myschool.com",
                NormalizedEmail = "tsvetelinastoyanova@myschool.com"
            };
            UserTsvetelinaStoyanova.PasswordHash = hasher.HashPassword(UserTsvetelinaStoyanova, "tsvetelinastoyanova123");

            UserLyubenMarinov = new IdentityUser()
            {
                Id = "8270e9b1-2c24-43e1-9f93-22d9923de12c",
                UserName = "lyubenmarinov",
                NormalizedUserName = "lyubenmarinov",
                Email = "lyubenmarinov@myschool.com",
                NormalizedEmail = "lyubenmarinov@myschool.com"
            };
            UserLyubenMarinov.PasswordHash = hasher.HashPassword(UserLyubenMarinov, "lyubenmarinov123");

            UserRositsaPetrova = new IdentityUser()
            {
                Id = "f05ad822-8530-4f4d-9f43-d8908ee1ad48",
                UserName = "rositsapetrova",
                NormalizedUserName = "rositsapetrova",
                Email = "rositsapetrova@myschool.com",
                NormalizedEmail = "rositsapetrova@myschool.com"
            };
            UserRositsaPetrova.PasswordHash = hasher.HashPassword(UserRositsaPetrova, "rositsapetrova123");

            UserKaloyanIvanov = new IdentityUser()
            {
                Id = "8e9d7e5c-3429-426e-8bf7-256f874a189a",
                UserName = "kaloyanivanov",
                NormalizedUserName = "kaloyanivanov",
                Email = "kaloyanivanov@myschool.com",
                NormalizedEmail = "kaloyanivanov@myschool.com"
            };
            UserKaloyanIvanov.PasswordHash = hasher.HashPassword(UserKaloyanIvanov, "kaloyanivanov123");

            UserEkaterinaGeorgieva = new IdentityUser()
            {
                Id = "85bb508a-2d95-42d9-aa43-0e4fe33497a0",
                UserName = "ekaterinageorgieva",
                NormalizedUserName = "ekaterinageorgieva",
                Email = "ekaterinageorgieva@myschool.com",
                NormalizedEmail = "ekaterinageorgieva@myschool.com"
            };
            UserEkaterinaGeorgieva.PasswordHash = hasher.HashPassword(UserEkaterinaGeorgieva, "ekaterinageorgieva123");

            UserHristoDimitrov = new IdentityUser()
            {
                Id = "b122f303-2d44-4f3d-bdd8-dac3626da548",
                UserName = "hristodimitrov",
                NormalizedUserName = "hristodimitrov",
                Email = "hristodimitrov@myschool.com",
                NormalizedEmail = "hristodimitrov@myschool.com"
            };
            UserHristoDimitrov.PasswordHash = hasher.HashPassword(UserHristoDimitrov, "hristodimitrov123");

            UserDobrinkaIvanova = new IdentityUser()
            {
                Id = "4ce7832b-e2f3-446f-8c63-720db3f89237",
                UserName = "dobrinkaivanova",
                NormalizedUserName = "dobrinkaivanova",
                Email = "dobrinkaivanova@myschool.com",
                NormalizedEmail = "dobrinkaivanova@myschool.com"
            };
            UserDobrinkaIvanova.PasswordHash = hasher.HashPassword(UserDobrinkaIvanova, "dobrinkaivanova123");

            UserBlagoyGeorgiev = new IdentityUser()
            {
                Id = "6b86569b-8f22-4a5c-9511-109f06d214a8",
                UserName = "blagoygeorgiev",
                NormalizedUserName = "blagoygeorgiev",
                Email = "blagoygeorgiev@myschool.com",
                NormalizedEmail = "blagoygeorgiev@myschool.com"
            };
            UserBlagoyGeorgiev.PasswordHash = hasher.HashPassword(UserBlagoyGeorgiev, "blagoygeorgiev123");

            UserIskraKoleva = new IdentityUser()
            {
                Id = "923f8d7d-c02d-4177-a5f8-6b6975a7119b",
                UserName = "iskrakoleva",
                NormalizedUserName = "iskrakoleva",
                Email = "iskrakoleva@myschool.com",
                NormalizedEmail = "iskrakoleva@myschool.com"
            };
            UserIskraKoleva.PasswordHash = hasher.HashPassword(UserIskraKoleva, "iskrakoleva123");

            UserKrasimirTodorov = new IdentityUser()
            {
                Id = "a0e8ee4a-4dbb-4a5e-b97f-e35c542b778e",
                UserName = "krasimirtodorov",
                NormalizedUserName = "krasimirtodorov",
                Email = "krasimirtodorov@myschool.com",
                NormalizedEmail = "krasimirtodorov@myschool.com"
            };
            UserKrasimirTodorov.PasswordHash = hasher.HashPassword(UserKrasimirTodorov, "krasimirtodorov123");

            UserGerganaIvanova = new IdentityUser()
            {
                Id = "0fe8a18a-0f52-4e41-8d44-292001678e5b",
                UserName = "gerganaivanova",
                NormalizedUserName = "gerganaivanova",
                Email = "gerganaivanova@myschool.com",
                NormalizedEmail = "gerganaivanova@myschool.com"
            };
            UserGerganaIvanova.PasswordHash = hasher.HashPassword(UserGerganaIvanova, "gerganaivanova123");

            UserVasilPetrov = new IdentityUser()
            {
                Id = "95226fbf-1ebd-49c2-aaaf-71788a690ac5",
                UserName = "vasilpetrov",
                NormalizedUserName = "vasilpetrov",
                Email = "vasilpetrov@myschool.com",
                NormalizedEmail = "vasilpetrov@myschool.com"
            };
            UserVasilPetrov.PasswordHash = hasher.HashPassword(UserVasilPetrov, "vasilpetrov123");

            UserNadezhdaDimitrova = new IdentityUser()
            {
                Id = "c3d2b72a-bbf1-448f-9d87-ef1dd620e91d",
                UserName = "nadezhdadimitrova",
                NormalizedUserName = "nadezhdadimitrova",
                Email = "nadezhdadimitrova@myschool.com",
                NormalizedEmail = "nadezhdadimitrova@myschool.com"
            };
            UserNadezhdaDimitrova.PasswordHash = hasher.HashPassword(UserNadezhdaDimitrova, "nadezhdadimitrova123");

            UserTodorGeorgiev = new IdentityUser()
            {
                Id = "3670d992-3c68-43a1-9862-1e14d65f8888",
                UserName = "todorgeorgiev",
                NormalizedUserName = "todorgeorgiev",
                Email = "todorgeorgiev@myschool.com",
                NormalizedEmail = "todorgeorgiev@myschool.com"
            };
            UserTodorGeorgiev.PasswordHash = hasher.HashPassword(UserTodorGeorgiev, "todorgeorgiev123");

            UserRadkaIvanova = new IdentityUser()
            {
                Id = "04870e99-9ba7-4640-8ef2-01fc2a1190d7",
                UserName = "radkaivanova",
                NormalizedUserName = "radkaivanova",
                Email = "radkaivanova@myschool.com",
                NormalizedEmail = "radkaivanova@myschool.com"
            };
            UserRadkaIvanova.PasswordHash = hasher.HashPassword(UserRadkaIvanova, "radkaivanova123");

            UserHristinaStefanova = new IdentityUser()
            {
                Id = "c5422b1e-16ed-4d05-8d45-9202c7d85d77",
                UserName = "hristinastefanova",
                NormalizedUserName = "hristinastefanova",
                Email = "hristinastefanova@myschool.com",
                NormalizedEmail = "hristinastefanova@myschool.com"
            };
            UserHristinaStefanova.PasswordHash = hasher.HashPassword(UserHristinaStefanova, "hristinastefanova123");

            UserYavorKolev = new IdentityUser()
            {
                Id = "e06a86ef-9ed7-4852-b9e3-0c0c62b741fe",
                UserName = "yavorkolev",
                NormalizedUserName = "yavorkolev",
                Email = "yavorkolev@myschool.com",
                NormalizedEmail = "yavorkolev@myschool.com"
            };
            UserYavorKolev.PasswordHash = hasher.HashPassword(UserYavorKolev, "yavorkolev123");

            UserKameliaPetrova = new IdentityUser()
            {
                Id = "0dbed053-0ea2-43c1-b4b1-99a1d1197084",
                UserName = "kameliapetrova",
                NormalizedUserName = "kameliapetrova",
                Email = "kameliapetrova@myschool.com",
                NormalizedEmail = "kameliapetrova@myschool.com"
            };
            UserKameliaPetrova.PasswordHash = hasher.HashPassword(UserKameliaPetrova, "kameliapetrova123");

            UserEmilIvanov = new IdentityUser()
            {
                Id = "6e3ac05f-09b1-4e65-9ab5-81a0c787e9e3",
                UserName = "emilivanov",
                NormalizedUserName = "emilivanov",
                Email = "emilivanov@myschool.com",
                NormalizedEmail = "emilivanov@myschool.com"
            };
            UserEmilIvanov.PasswordHash = hasher.HashPassword(UserEmilIvanov, "emilivanov123");

            UserDilyanaAleksandrova = new IdentityUser()
            {
                Id = "a7201fc2-3e05-4ad0-a0f3-1f925f05e0b1",
                UserName = "dilyanaaleksandrova",
                NormalizedUserName = "dilyanaaleksandrova",
                Email = "dilyanaaleksandrova@myschool.com",
                NormalizedEmail = "dilyanaaleksandrova@myschool.com"
            };
            UserDilyanaAleksandrova.PasswordHash = hasher.HashPassword(UserDilyanaAleksandrova, "dilyanaaleksandrova123");

            UserTsvetanGeorgiev = new IdentityUser()
            {
                Id = "57e4c1a5-4c76-4cda-98ce-2e2a0a22c764",
                UserName = "tsvetangeorgiev",
                NormalizedUserName = "tsvetangeorgiev",
                Email = "tsvetangeorgiev@myschool.com",
                NormalizedEmail = "tsvetangeorgiev@myschool.com"
            };
            UserTsvetanGeorgiev.PasswordHash = hasher.HashPassword(UserTsvetanGeorgiev, "tsvetangeorgiev123");

            UserZhivkaIvanova = new IdentityUser()
            {
                Id = "87e879c3-5c01-41d1-9e08-0a667172a0c7",
                UserName = "zhivkaivanova",
                NormalizedUserName = "zhivkaivanova",
                Email = "zhivkaivanova@myschool.com",
                NormalizedEmail = "zhivkaivanova@myschool.com"
            };
            UserZhivkaIvanova.PasswordHash = hasher.HashPassword(UserZhivkaIvanova, "zhivkaivanova123");

            UserIvoDimitrov = new IdentityUser()
            {
                Id = "a7f2842b-bfd9-4e04-994a-c5f16bfefc10",
                UserName = "ivodimitrov",
                NormalizedUserName = "ivodimitrov",
                Email = "ivodimitrov@myschool.com",
                NormalizedEmail = "ivodimitrov@myschool.com"
            };
            UserIvoDimitrov.PasswordHash = hasher.HashPassword(UserIvoDimitrov, "ivodimitrov123");

            UserAdriyanaStoyanova = new IdentityUser()
            {
                Id = "9e8741d5-65d9-4cc0-b7b6-ff1b688c34f1",
                UserName = "adriyanastoyanova",
                NormalizedUserName = "adriyanastoyanova",
                Email = "adriyanastoyanova@myschool.com",
                NormalizedEmail = "adriyanastoyanova@myschool.com"
            };
            UserAdriyanaStoyanova.PasswordHash = hasher.HashPassword(UserAdriyanaStoyanova, "adriyanastoyanova123");

            UserKamenPetrov = new IdentityUser()
            {
                Id = "0f76fe6a-91ed-496d-aa60-ba07cda9c7e1",
                UserName = "kamenpetrov",
                NormalizedUserName = "kamenpetrov",
                Email = "kamenpetrov@myschool.com",
                NormalizedEmail = "kamenpetrov@myschool.com"
            };
            UserKamenPetrov.PasswordHash = hasher.HashPassword(UserKamenPetrov, "kamenpetrov123");

            UserKristinaKoleva = new IdentityUser()
            {
                Id = "2e3c6d85-136f-4878-819b-9f982e6e4ed8",
                UserName = "kristinakoleva",
                NormalizedUserName = "kristinakoleva",
                Email = "kristinakoleva@myschool.com",
                NormalizedEmail = "kristinakoleva@myschool.com"
            };
            UserKristinaKoleva.PasswordHash = hasher.HashPassword(UserKristinaKoleva, "kristinakoleva123");

            UserYankoIvanov = new IdentityUser()
            {
                Id = "65c645b2-cdf7-45d1-89d1-cd881a36ed98",
                UserName = "yankoivanov",
                NormalizedUserName = "yankoivanov",
                Email = "yankoivanov@myschool.com",
                NormalizedEmail = "yankoivanov@myschool.com"
            };
            UserYankoIvanov.PasswordHash = hasher.HashPassword(UserYankoIvanov, "yankoivanov123");

            UserPolinaGeorgieva = new IdentityUser()
            {
                Id = "65aa7d12-2f5a-4381-8c69-9b01523cf5e1",
                UserName = "polinageorgieva",
                NormalizedUserName = "polinageorgieva",
                Email = "polinageorgieva@myschool.com",
                NormalizedEmail = "polinageorgieva@myschool.com"
            };
            UserPolinaGeorgieva.PasswordHash = hasher.HashPassword(UserPolinaGeorgieva, "polinageorgieva123");

            UserVeselinVasilev = new IdentityUser()
            {
                Id = "3f0c19e4-df31-42e7-9421-882128123af3",
                UserName = "veselinvasilev",
                NormalizedUserName = "veselinvasilev",
                Email = "veselinvasilev@myschool.com",
                NormalizedEmail = "veselinvasilev@myschool.com"
            };
            UserVeselinVasilev.PasswordHash = hasher.HashPassword(UserVeselinVasilev, "veselinvasilev123");

            UserAntoniyaPetrova = new IdentityUser()
            {
                Id = "2ef3d2b3-3d7f-4d52-8a04-5433e1f869ec",
                UserName = "antoniyapetrova",
                NormalizedUserName = "antoniyapetrova",
                Email = "antoniyapetrova@myschool.com",
                NormalizedEmail = "antoniyapetrova@myschool.com"
            };
            UserAntoniyaPetrova.PasswordHash = hasher.HashPassword(UserAntoniyaPetrova, "antoniyapetrova123");

            UserLyubomirDimitrov = new IdentityUser()
            {
                Id = "b87b71e9-8db3-4f09-b865-5402a08d0b8b",
                UserName = "lyubomirdimitrov",
                NormalizedUserName = "lyubomirdimitrov",
                Email = "lyubomirdimitrov@myschool.com",
                NormalizedEmail = "lyubomirdimitrov@myschool.com"
            };
            UserLyubomirDimitrov.PasswordHash = hasher.HashPassword(UserLyubomirDimitrov, "lyubomirdimitrov123");

            UserZornitsaTodorova = new IdentityUser()
            {
                Id = "f75d44bf-9f2d-4d0f-a20a-b28d8eac0d7d",
                UserName = "zornitsatodorova",
                NormalizedUserName = "zornitsatodorova",
                Email = "zornitsatodorova@myschool.com",
                NormalizedEmail = "zornitsatodorova@myschool.com"
            };
            UserZornitsaTodorova.PasswordHash = hasher.HashPassword(UserZornitsaTodorova, "zornitsatodorova123");

            UserStefanIvanov = new IdentityUser()
            {
                Id = "1e1b85b7-6c15-4f2c-b1c4-47ad0c8bf5f9",
                UserName = "stefanivanov",
                NormalizedUserName = "stefanivanov",
                Email = "stefanivanov@myschool.com",
                NormalizedEmail = "stefanivanov@myschool.com"
            };
            UserStefanIvanov.PasswordHash = hasher.HashPassword(UserStefanIvanov, "stefanivanov123");

            UserYoanaGeorgieva = new IdentityUser()
            {
                Id = "5a52e138-0a2c-4b1a-8a68-b95de62aa345",
                UserName = "yoanageorgieva",
                NormalizedUserName = "yoanageorgieva",
                Email = "yoanageorgieva@myschool.com",
                NormalizedEmail = "yoanageorgieva@myschool.com"
            };
            UserYoanaGeorgieva.PasswordHash = hasher.HashPassword(UserYoanaGeorgieva, "yoanageorgieva123");

            UserKrasimiraPetrova = new IdentityUser()
            {
                Id = "b2c8a67c-5a1d-4e23-9c85-0c57454de9ee",
                UserName = "krasimirapetrova",
                NormalizedUserName = "krasimirapetrova",
                Email = "krasimirapetrova@myschool.com",
                NormalizedEmail = "krasimirapetrova@myschool.com"
            };
            UserKrasimiraPetrova.PasswordHash = hasher.HashPassword(UserKrasimiraPetrova, "krasimirapetrova123");

            UserIvayloKolev = new IdentityUser()
            {
                Id = "9e3dbbc2-33d7-4c57-a3ee-5b7e19b1c3c2",
                UserName = "ivaylokolev",
                NormalizedUserName = "ivaylokolev",
                Email = "ivaylokolev@myschool.com",
                NormalizedEmail = "ivaylokolev@myschool.com"
            };
            UserIvayloKolev.PasswordHash = hasher.HashPassword(UserIvayloKolev, "ivaylokolev123");

            UserMargaritaGeorgieva = new IdentityUser()
            {
                Id = "9b9474b0-06ab-4953-8f23-cff7e88c7a0b",
                UserName = "margaritageorgeiva",
                NormalizedUserName = "margaritageorgeiva",
                Email = "margaritageorgeiva@myschool.com",
                NormalizedEmail = "margaritageorgeiva@myschool.com"
            };
            UserMargaritaGeorgieva.PasswordHash = hasher.HashPassword(UserMargaritaGeorgieva, "margaritageorgieva123");

            UserRumenIvanov = new IdentityUser()
            {
                Id = "7edf5ac1-2d87-4bf0-b2ed-4d2e4a7b9657",
                UserName = "rumenivanov",
                NormalizedUserName = "rumenivanov",
                Email = "rumenivanov@myschool.com",
                NormalizedEmail = "rumenivanov@myschool.com"
            };
            UserRumenIvanov.PasswordHash = hasher.HashPassword(UserRumenIvanov, "rumenivanov123");

            UserMilenaDimitrova = new IdentityUser()
            {
                Id = "e192e1fe-5680-4ad9-a5e8-4c8328f7840c",
                UserName = "milenadimitrova",
                NormalizedUserName = "milenadimitrova",
                Email = "milenadimitrova@myschool.com",
                NormalizedEmail = "milenadimitrova@myschool.com"
            };
            UserMilenaDimitrova.PasswordHash = hasher.HashPassword(UserMilenaDimitrova, "milenadimitrova123");

            UserYordanTodorov = new IdentityUser()
            {
                Id = "5d5313c0-7da7-4ac6-aa0d-3e6a51fe09b6",
                UserName = "yordantodorov",
                NormalizedUserName = "yordantodorov",
                Email = "yordantodorov@myschool.com",
                NormalizedEmail = "yordantodorov@myschool.com"
            };
            UserYordanTodorov.PasswordHash = hasher.HashPassword(UserYordanTodorov, "yordantodorov123");

            UserSilviyaPetrova = new IdentityUser()
            {
                Id = "31d9f6c5-c9a8-48c8-8b5f-c990d06200ad",
                UserName = "silviyapetrova",
                NormalizedUserName = "silviyapetrova",
                Email = "silviyapetrova@myschool.com",
                NormalizedEmail = "silviyapetrova@myschool.com"
            };
            UserSilviyaPetrova.PasswordHash = hasher.HashPassword(UserSilviyaPetrova, "silviyapetrova123");

            UserBogdanIvanov = new IdentityUser()
            {
                Id = "5e61439f-95d5-4e2b-9b0d-91e7c4472e3e",
                UserName = "bogdanivanov",
                NormalizedUserName = "bogdanivanov",
                Email = "bogdanivanov@myschool.com",
                NormalizedEmail = "bogdanivanov@myschool.com"
            };
            UserBogdanIvanov.PasswordHash = hasher.HashPassword(UserBogdanIvanov, "bogdanivanov123");

            UserPetyaKoleva = new IdentityUser()
            {
                Id = "32d43d0a-632a-48fe-bc8f-68bb3f72f083",
                UserName = "petyakoleva",
                NormalizedUserName = "petyakoleva",
                Email = "petyakoleva@myschool.com",
                NormalizedEmail = "petyakoleva@myschool.com"
            };
            UserPetyaKoleva.PasswordHash = hasher.HashPassword(UserPetyaKoleva, "petyakoleva123");

            UserAsenMarinov = new IdentityUser()
            {
                Id = "e9f13942-e518-46f3-8b3e-d332b26d18fc",
                UserName = "asenmarinov",
                NormalizedUserName = "asenmarinov",
                Email = "asenmarinov@myschool.com",
                NormalizedEmail = "asenmarinov@myschool.com"
            };
            UserAsenMarinov.PasswordHash = hasher.HashPassword(UserAsenMarinov, "asenmarinov123");

            UserRalitsaIvanova = new IdentityUser()
            {
                Id = "5e4bb853-02b0-4e76-b28b-2181be91d1fc",
                UserName = "ralitsaivanova",
                NormalizedUserName = "ralitsaivanova",
                Email = "ralitsaivanova@myschool.com",
                NormalizedEmail = "ralitsaivanova@myschool.com"
            };
            UserRalitsaIvanova.PasswordHash = hasher.HashPassword(UserRalitsaIvanova, "ralitsaivanova123");

            UserVelkoVasilev = new IdentityUser()
            {
                Id = "2b7e8569-4edf-46d1-8b07-d2a09977e361",
                UserName = "velkovasilev",
                NormalizedUserName = "velkovasilev",
                Email = "velkovasilev@myschool.com",
                NormalizedEmail = "velkovasilev@myschool.com"
            };
            UserVelkoVasilev.PasswordHash = hasher.HashPassword(UserVelkoVasilev, "velkovasilev123");

            UserGalyaDimitrova = new IdentityUser()
            {
                Id = "b685f57e-87da-4d6f-8d52-1597c109a1f9",
                UserName = "galyadimitrova",
                NormalizedUserName = "galyadimitrova",
                Email = "galyadimitrova@myschool.com",
                NormalizedEmail = "galyadimitrova@myschool.com"
            };
            UserGalyaDimitrova.PasswordHash = hasher.HashPassword(UserGalyaDimitrova, "galyadimitrova123");

            UserDimiturIvanov = new IdentityUser()
            {
                Id = "d6ab2e2d-bcc6-4e32-82eb-8c77280d482d",
                UserName = "dimiturivanov",
                NormalizedUserName = "dimiturivanov",
                Email = "dimiturivanov@myschool.com",
                NormalizedEmail = "dimiturivanov@myschool.com"
            };
            UserDimiturIvanov.PasswordHash = hasher.HashPassword(UserDimiturIvanov, "dimiturivanov123");

            UserNadiaKoleva = new IdentityUser()
            {
                Id = "30936933-775b-4687-8e1a-5a758bc5ed38",
                UserName = "nadiakoleva",
                NormalizedUserName = "nadiakoleva",
                Email = "nadiakoleva@myschool.com",
                NormalizedEmail = "nadiakoleva@myschool.com"
            };
            UserNadiaKoleva.PasswordHash = hasher.HashPassword(UserNadiaKoleva, "nadiakoleva123");

            UserYulianPetrov = new IdentityUser()
            {
                Id = "8c9965a3-36a4-4a6b-ba5a-7f3a262aa0c3",
                UserName = "yulianpetrov",
                NormalizedUserName = "yulianpetrov",
                Email = "yulianpetrov@myschool.com",
                NormalizedEmail = "yulianpetrov@myschool.com"
            };
            UserYulianPetrov.PasswordHash = hasher.HashPassword(UserYulianPetrov, "yulianpetrov123");

            UserRadostinaGeorgieva = new IdentityUser()
            {
                Id = "5dbfbd88-cb21-4784-b7e8-6b0e618ad92b",
                UserName = "radostinageorgieva",
                NormalizedUserName = "radostinageorgieva",
                Email = "radostinageorgieva@myschool.com",
                NormalizedEmail = "radostinageorgieva@myschool.com"
            };
            UserRadostinaGeorgieva.PasswordHash = hasher.HashPassword(UserRadostinaGeorgieva, "radostinageorgieva123");

            UserKrasimIvanov = new IdentityUser()
            {
                Id = "a4d2bcdc-23da-4395-9b9b-2087cc52bafe",
                UserName = "krasimivanov",
                NormalizedUserName = "krasimivanov",
                Email = "krasimivanov@myschool.com",
                NormalizedEmail = "krasimivanov@myschool.com"
            };
            UserKrasimIvanov.PasswordHash = hasher.HashPassword(UserKrasimIvanov, "krasimivanov123");

            UserTeodoraTodorova = new IdentityUser()
            {
                Id = "23fb4de4-1bf9-4e72-9764-4c2d1f870990",
                UserName = "teodoratodorova",
                NormalizedUserName = "teodoratodorova",
                Email = "teodoratodorova@myschool.com",
                NormalizedEmail = "teodoratodorova@myschool.com"
            };
            UserTeodoraTodorova.PasswordHash = hasher.HashPassword(UserTeodoraTodorova, "teoodratodorova123");

            UserKalinPetrov = new IdentityUser()
            {
                Id = "6a9e1770-798c-43de-aad7-8d8a6ad5eeab",
                UserName = "kalinpetrov",
                NormalizedUserName = "kalinpetrov",
                Email = "kalinpetrov@myschool.com",
                NormalizedEmail = "kalinpetrov@myschool.com"
            };
            UserKalinPetrov.PasswordHash = hasher.HashPassword(UserKalinPetrov, "kalinpetrov123");

            UserSvetlaDimitrova = new IdentityUser()
            {
                Id = "41ac68c1-84c8-4a2a-9f69-8571bb50e80a",
                UserName = "svetladimitrova",
                NormalizedUserName = "svetladimitrova",
                Email = "svetladimitrova@myschool.com",
                NormalizedEmail = "svetladimitrova@myschool.com"
            };
            UserSvetlaDimitrova.PasswordHash = hasher.HashPassword(UserSvetlaDimitrova, "svetladimitrova123");

            UserVentsislavGeorgiev = new IdentityUser()
            {
                Id = "3b3202f3-3f0c-4e15-9eb1-2c49b78aeb3b",
                UserName = "ventsislavgeorgiev",
                NormalizedUserName = "ventsislavgeorgiev",
                Email = "ventsislavgeorgiev@myschool.com",
                NormalizedEmail = "ventsislavgeorgiev@myschool.com"
            };
            UserVentsislavGeorgiev.PasswordHash = hasher.HashPassword(UserVentsislavGeorgiev, "ventsislavgeorgiev123");

            UserVasilenaIvanova = new IdentityUser()
            {
                Id = "35af9309-d2fb-46a4-84b4-d3dfdaa6b7d3",
                UserName = "vasilenaivanova",
                NormalizedUserName = "vasilenaivanova",
                Email = "vasilenaivanova@myschool.com",
                NormalizedEmail = "vasilenaivanova@myschool.com"
            };
            UserVasilenaIvanova.PasswordHash = hasher.HashPassword(UserVasilenaIvanova, "vasilenaivanova123");

            UserMartinPetrov = new IdentityUser()
            {
                Id = "4ec6a858-e99e-44a8-822d-5292c378fbb4",
                UserName = "martinpetrov",
                NormalizedUserName = "martinpetrov",
                Email = "martinpetrov@myschool.com",
                NormalizedEmail = "martinpetrov@myschool.com"
            };
            UserMartinPetrov.PasswordHash = hasher.HashPassword(UserMartinPetrov, "martinpetrov123");

            UserRalitsaKoleva = new IdentityUser()
            {
                Id = "1a36c289-32ed-42d0-8b6b-1f5490ecf0ab",
                UserName = "ralitsakoleva",
                NormalizedUserName = "ralitsakoleva",
                Email = "ralitsakoleva@myschool.com",
                NormalizedEmail = "ralitsakoleva@myschool.com"
            };
            UserRalitsaKoleva.PasswordHash = hasher.HashPassword(UserRalitsaKoleva, "ralitsakoleva123");

            UserStefanDimitrov = new IdentityUser()
            {
                Id = "1b56c7bf-0f4e-4c3d-94db-7e81f4c32ebf",
                UserName = "stefandimitrov",
                NormalizedUserName = "stefandimitrov",
                Email = "stefandimitrov@myschool.com",
                NormalizedEmail = "stefandimitrov@myschool.com"
            };
            UserStefanDimitrov.PasswordHash = hasher.HashPassword(UserStefanDimitrov, "stefandimitrov123");

            UserSnezhanaGeorgieva = new IdentityUser()
            {
                Id = "a22b38b9-85b0-4fe0-9d5c-7e3d9aa55a45",
                UserName = "snezhanageorgieva",
                NormalizedUserName = "snezhanageorgieva",
                Email = "snezhanageorgieva@myschool.com",
                NormalizedEmail = "snezhanageorgieva@myschool.com"
            };
            UserSnezhanaGeorgieva.PasswordHash = hasher.HashPassword(UserSnezhanaGeorgieva, "snezhanageorgieva123");

            UserIvayloIvanov = new IdentityUser()
            {
                Id = "11b2f953-01c9-446a-818f-778ce6a1f1a3",
                UserName = "ivayloivanov",
                NormalizedUserName = "ivayloivanov",
                Email = "ivayloivanov@myschool.com",
                NormalizedEmail = "ivayloivanov@myschool.com"
            };
            UserIvayloIvanov.PasswordHash = hasher.HashPassword(UserIvayloIvanov, "ivayloivanov123");

            UserMarianaPetrova = new IdentityUser()
            {
                Id = "5a119169-b39a-4e4b-8f7f-3ab86a6cebc4",
                UserName = "marianapetrova",
                NormalizedUserName = "marianapetrova",
                Email = "marianapetrova@myschool.com",
                NormalizedEmail = "marianapetrova@myschool.com"
            };
            UserMarianaPetrova.PasswordHash = hasher.HashPassword(UserMarianaPetrova, "marianapetrova123");

            UserRosenKolev = new IdentityUser()
            {
                Id = "2b7c8f64-17f7-42f5-bb92-84b8f4d35f4f",
                UserName = "rosenkolev",
                NormalizedUserName = "rosenkolev",
                Email = "rosenkolev@myschool.com",
                NormalizedEmail = "rosenkolev@myschool.com"
            };
            UserRosenKolev.PasswordHash = hasher.HashPassword(UserRosenKolev, "rosenkolev123");

            UserTanyaStoyanova = new IdentityUser()
            {
                Id = "6b04a713-c12c-4a0f-aa0b-0eafde1543ac",
                UserName = "tanyastoyanova",
                NormalizedUserName = "tanyastoyanova",
                Email = "tanyastoyanova@myschool.com",
                NormalizedEmail = "tanyastoyanova@myschool.com"
            };
            UserTanyaStoyanova.PasswordHash = hasher.HashPassword(UserTanyaStoyanova, "tanyastoyanova123");


            //Students

            UserDimitarIvanov = new IdentityUser()
            {
                Id = "21d56e3d-8c91-431e-a6e2-760848cf2aae",
                UserName = "dimitarivanov",
                NormalizedUserName = "dimitarivanov",
                Email = "dimitarivanov@myschool.com",
                NormalizedEmail = "dimitarivanov@myschool.com"
            };
            UserDimitarIvanov.PasswordHash = hasher.HashPassword(UserDimitarIvanov, "dimitarivanov123");

            UserElenaPetrova = new IdentityUser()
            {
                Id = "d3d28ff2-79fe-4e7a-bf85-8e4fe2e0a097",
                UserName = "elenapetrova",
                NormalizedUserName = "elenapetrova",
                Email = "elenapetrova@myschool.com",
                NormalizedEmail = "elenapetrova@myschool.com"
            };
            UserElenaPetrova.PasswordHash = hasher.HashPassword(UserElenaPetrova, "elenapetrova123");

            UserStefchoDimitrov = new IdentityUser()
            {
                Id = "c6aa9e1c-1894-4ef8-9a29-29c110f31949",
                UserName = "stefchodimitrov",
                NormalizedUserName = "stefchodimitrov",
                Email = "stefchodimitrov@myschool.com",
                NormalizedEmail = "stefchodimitrov@myschool.com"
            };
            UserStefchoDimitrov.PasswordHash = hasher.HashPassword(UserStefchoDimitrov, "stefchodimitrov123");

            UserMilenaGeorgieva = new IdentityUser()
            {
                Id = "109824cc-6b9f-4b1f-af65-87bb5a4ff79b",
                UserName = "milenageorgieva",
                NormalizedUserName = "milenageorgieva",
                Email = "milenageorgieva@myschool.com",
                NormalizedEmail = "milenageorgieva@myschool.com"
            };
            UserMilenaGeorgieva.PasswordHash = hasher.HashPassword(UserMilenaGeorgieva, "milenageorgieva123");

            UserAleksandarTodorov = new IdentityUser()
            {
                Id = "8c0cb95d-0e1a-40c4-9e2f-2542d530dbaa",
                UserName = "aleksandartodorov",
                NormalizedUserName = "aleksandartodorov",
                Email = "aleksandartodorov@myschool.com",
                NormalizedEmail = "aleksandartodorov@myschool.com"
            };
            UserAleksandarTodorov.PasswordHash = hasher.HashPassword(UserAleksandarTodorov, "aleksandartodorov123");

            UserViktoriaIvanova = new IdentityUser()
            {
                Id = "7fc4b81c-0b22-4e35-bc17-c7c3e73d1874",
                UserName = "viktoriaivanova",
                NormalizedUserName = "viktoriaivanova",
                Email = "viktoriaivanova@myschool.com",
                NormalizedEmail = "viktoriaivanova@myschool.com"
            };
            UserViktoriaIvanova.PasswordHash = hasher.HashPassword(UserViktoriaIvanova, "viktoriaivanova123");

            UserNikolayKolev = new IdentityUser()
            {
                Id = "5a7d1e4a-8f4f-4e52-9d14-06f9d3a134b4",
                UserName = "nikolaykolev",
                NormalizedUserName = "nikolaykolev",
                Email = "nikolaykolev@myschool.com",
                NormalizedEmail = "nikolaykolev@myschool.com"
            };
            UserNikolayKolev.PasswordHash = hasher.HashPassword(UserNikolayKolev, "nikolaykolev123");

            UserMariaVasileva = new IdentityUser()
            {
                Id = "93a6ac3b-c8c9-4a24-a00b-4f54e2f4d2d7",
                UserName = "mariavasileva",
                NormalizedUserName = "mariavasileva",
                Email = "mariavasileva@myschool.com",
                NormalizedEmail = "mariavasileva@myschool.com"
            };
            UserMariaVasileva.PasswordHash = hasher.HashPassword(UserMariaVasileva, "mariavasileva123");

            UserIvayloPetrov = new IdentityUser()
            {
                Id = "d071556f-89ee-4819-86b2-7eb3b63f65a2",
                UserName = "ivaylopetrov",
                NormalizedUserName = "ivaylopetrov",
                Email = "ivaylopetrov@myschool.com",
                NormalizedEmail = "ivaylopetrov@myschool.com"
            };
            UserIvayloPetrov.PasswordHash = hasher.HashPassword(UserIvayloPetrov, "ivaylopetrov123");

            UserGabrielaStoyanova = new IdentityUser()
            {
                Id = "c618a246-9af9-4a37-9e0d-257ec4b2b854",
                UserName = "gabrielastoyanova",
                NormalizedUserName = "gabrielastoyanova",
                Email = "gabrielastoyanova@myschool.com",
                NormalizedEmail = "gabrielastoyanova@myschool.com"
            };
            UserGabrielaStoyanova.PasswordHash = hasher.HashPassword(UserGabrielaStoyanova, "gabrielastoyanova123");

            UserGeorgiMarinov = new IdentityUser()
            {
                Id = "172ef32c-2c8e-49f9-8c0f-0d8236a98fc7",
                UserName = "georgimarinov",
                NormalizedUserName = "georgimarinov",
                Email = "georgimarinov@myschool.com",
                NormalizedEmail = "georgimarinov@myschool.com"
            };
            UserGeorgiMarinov.PasswordHash = hasher.HashPassword(UserGeorgiMarinov, "georgimarinov123");

            UserKristinaPetrova = new IdentityUser()
            {
                Id = "1f49e02f-784c-4b51-856b-0fc301da5bf0",
                UserName = "kristinapetrova",
                NormalizedUserName = "kristinapetrova",
                Email = "kristinapetrova@myschool.com",
                NormalizedEmail = "kristinapetrova@myschool.com"
            };
            UserKristinaPetrova.PasswordHash = hasher.HashPassword(UserKristinaPetrova, "kristinapetrova123");

            UserRumchoIvanov = new IdentityUser()
            {
                Id = "f3dd26e0-e2eb-4e1f-9ea2-d260e779a5e3",
                UserName = "rumchoivanov",
                NormalizedUserName = "rumchoivanov",
                Email = "rumchoivanov@myschool.com",
                NormalizedEmail = "rumchoivanov@myschool.com"
            };
            UserRumchoIvanov.PasswordHash = hasher.HashPassword(UserRumchoIvanov, "rumchoivanov123");

            UserEmiliaGeorgieva = new IdentityUser()
            {
                Id = "b4c1c7da-6491-48d6-91d5-3c4f43105fc1",
                UserName = "emiliageorgieva",
                NormalizedUserName = "emiliageorgieva",
                Email = "emiliageorgieva@myschool.com",
                NormalizedEmail = "emiliageorgieva@myschool.com"
            };
            UserEmiliaGeorgieva.PasswordHash = hasher.HashPassword(UserEmiliaGeorgieva, "emiliageorgieva123");

            UserKrasimirDimitrov = new IdentityUser()
            {
                Id = "5038ef42-267f-4a5d-8b92-2d63052265c8",
                UserName = "krasimirivanov",
                NormalizedUserName = "krasimirivanov",
                Email = "krasimirivanov@myschool.com",
                NormalizedEmail = "krasimirivanov@myschool.com"
            };
            UserKrasimirDimitrov.PasswordHash = hasher.HashPassword(UserKrasimirDimitrov, "krasimirivanov123");

            UserSilviyaIvanova = new IdentityUser()
            {
                Id = "9e32eab9-84e3-4b35-bb92-89b3dfb8e98f",
                UserName = "silviyaivanova",
                NormalizedUserName = "silviyaivanova",
                Email = "silviyaivanova@myschool.com",
                NormalizedEmail = "silviyaivanova@myschool.com"
            };
            UserSilviyaIvanova.PasswordHash = hasher.HashPassword(UserSilviyaIvanova, "silviyaivanova123");

            UserAsenGeorgiev = new IdentityUser()
            {
                Id = "84ab245c-804d-4ac7-8f9e-bcda15863c5c",
                UserName = "asengeorgiev",
                NormalizedUserName = "asengeorgiev",
                Email = "asengeorgiev@myschool.com",
                NormalizedEmail = "asengeorgiev@myschool.com"
            };
            UserAsenGeorgiev.PasswordHash = hasher.HashPassword(UserAsenGeorgiev, "asengeorgiev123");

            UserElenaKoleva = new IdentityUser()
            {
                Id = "5a141fd9-2bcf-4dab-8c0a-8c15b7c8dbef",
                UserName = "elenakoleva",
                NormalizedUserName = "elenakoleva",
                Email = "elenakoleva@myschool.com",
                NormalizedEmail = "elenakoleva@myschool.com"
            };
            UserElenaKoleva.PasswordHash = hasher.HashPassword(UserElenaKoleva, "elenakoleva123");

            UserStanimirTodorov = new IdentityUser()
            {
                Id = "31b1f166-5412-40c7-b0cb-38aaec6a5ba6",
                UserName = "stanimirtodorov",
                NormalizedUserName = "stanimirtodorov",
                Email = "stanimirtodorov@myschool.com",
                NormalizedEmail = "stanimirtodorov@myschool.com"
            };
            UserStanimirTodorov.PasswordHash = hasher.HashPassword(UserStanimirTodorov, "stanimirtodorov123");

            UserMagdalenaIvanova = new IdentityUser()
            {
                Id = "1443d844-bfd9-45a1-94a5-83c18f140c0e",
                UserName = "magdalenaivanova",
                NormalizedUserName = "magdalenaivanova",
                Email = "magdalenaivanova@myschool.com",
                NormalizedEmail = "magdalenaivanova@myschool.com"
            };
            UserMagdalenaIvanova.PasswordHash = hasher.HashPassword(UserMagdalenaIvanova, "magdalenaivanova123");

            UserHristoPetrov = new IdentityUser()
            {
                Id = "d0b3c3d4-5803-4f42-9f3f-5879926e2f3f",
                UserName = "hristopetrov",
                NormalizedUserName = "hristopetrov",
                Email = "hristopetrov@myschool.com",
                NormalizedEmail = "hristopetrov@myschool.com"
            };
            UserHristoPetrov.PasswordHash = hasher.HashPassword(UserHristoPetrov, "hristopetrov123");

            UserKalinaDimitrova = new IdentityUser()
            {
                Id = "7b1a2e32-bc36-4bf7-9b65-07fbfa810baa",
                UserName = "kalinadimitrova",
                NormalizedUserName = "kalinadimitrova",
                Email = "kalinadimitrova@myschool.com",
                NormalizedEmail = "kalinadimitrova@myschool.com"
            };
            UserKalinaDimitrova.PasswordHash = hasher.HashPassword(UserKalinaDimitrova, "kalinadimitrova123");

            UserTsvetanchoGeorgiev = new IdentityUser()
            {
                Id = "321efec2-563e-4f66-a158-7c2e4f7db24b",
                UserName = "tsvetanchogeorgiev",
                NormalizedUserName = "tsvetanchogeorgiev",
                Email = "tsvetanchogeorgiev@myschool.com",
                NormalizedEmail = "tsvetanchogeorgiev@myschool.com"
            };
            UserTsvetanchoGeorgiev.PasswordHash = hasher.HashPassword(UserTsvetanchoGeorgiev, "tsvetanchogeorgiev123");

            UserNadezhdaIvanova = new IdentityUser()
            {
                Id = "71c4c53d-0c7e-4d33-b8b3-15b3ff206249",
                UserName = "nadezhdaivanova",
                NormalizedUserName = "nadezhdaivanova",
                Email = "nadezhdaivanova@myschool.com",
                NormalizedEmail = "nadezhdaivanova@myschool.com"
            };
            UserNadezhdaIvanova.PasswordHash = hasher.HashPassword(UserNadezhdaIvanova, "nadezhdaivanova123");

            UserBorisStefanov = new IdentityUser()
            {
                Id = "0e119a09-9c6b-46c2-bb9b-5151d5b8a8d7",
                UserName = "boristefanov",
                NormalizedUserName = "boristefanov",
                Email = "boristefanov@myschool.com",
                NormalizedEmail = "boristefanov@myschool.com"
            };
            UserBorisStefanov.PasswordHash = hasher.HashPassword(UserBorisStefanov, "boristefanov123");

            UserAneliyaKoleva = new IdentityUser()
            {
                Id = "2b765779-8f0d-4d01-b822-41fb42f9d173",
                UserName = "aneliyakoleva",
                NormalizedUserName = "aneliyakoleva",
                Email = "aneliyakoleva@myschool.com",
                NormalizedEmail = "aneliyakoleva@myschool.com"
            };
            UserAneliyaKoleva.PasswordHash = hasher.HashPassword(UserAneliyaKoleva, "aneliyakoleva123");

            UserRosenPetrov = new IdentityUser()
            {
                Id = "e20a8a8b-7038-45c5-b292-91c7b5e196d1",
                UserName = "rosenpetrov",
                NormalizedUserName = "rosenpetrov",
                Email = "rosenpetrov@myschool.com",
                NormalizedEmail = "rosenpetrov@myschool.com"
            };
            UserRosenPetrov.PasswordHash = hasher.HashPassword(UserRosenPetrov, "rosenpetrov123");

            UserRadostinaIvanova = new IdentityUser()
            {
                Id = "39b55a1b-d8b5-4bb2-9e71-cc994a1463d5",
                UserName = "radostinaivanova",
                NormalizedUserName = "radostinaivanova",
                Email = "radostinaivanova@myschool.com",
                NormalizedEmail = "radostinaivanova@myschool.com"
            };
            UserRadostinaIvanova.PasswordHash = hasher.HashPassword(UserRadostinaIvanova, "radostinaivanova123");

            UserVasilAleksandrov = new IdentityUser()
            {
                Id = "57ef3794-e725-4d7c-9d17-7b7ac01081c5",
                UserName = "vasilaleksandrov",
                NormalizedUserName = "vasilaleksandrov",
                Email = "vasilaleksandrov@myschool.com",
                NormalizedEmail = "vasilaleksandrov@myschool.com"
            };
            UserVasilAleksandrov.PasswordHash = hasher.HashPassword(UserVasilAleksandrov, "vasilaleksandrov123");

            UserRositsaGeorgieva = new IdentityUser()
            {
                Id = "d6ddbe61-7627-4b88-bc3c-8c2b3a7e89a4",
                UserName = "rositsageorgieva",
                NormalizedUserName = "rositsageorgieva",
                Email = "rositsageorgieva@myschool.com",
                NormalizedEmail = "rositsageorgieva@myschool.com"
            };
            UserRositsaGeorgieva.PasswordHash = hasher.HashPassword(UserRositsaGeorgieva, "rositsageorgieva123");

            UserPlamenIvanov = new IdentityUser()
            {
                Id = "d1983bf8-cb42-4da2-88d2-5297be88a146",
                UserName = "plamenivanov",
                NormalizedUserName = "plamenivanov",
                Email = "plamenivanov@myschool.com",
                NormalizedEmail = "plamenivanov@myschool.com"
            };
            UserPlamenIvanov.PasswordHash = hasher.HashPassword(UserPlamenIvanov, "plamenivanov123");

            UserValentinaDimitrova = new IdentityUser()
            {
                Id = "162d8979-1a84-4642-9b27-49973518a040",
                UserName = "valentinadimitrova",
                NormalizedUserName = "valentinadimitrova",
                Email = "valentinadimitrova@myschool.com",
                NormalizedEmail = "valentinadimitrova@myschool.com"
            };
            UserValentinaDimitrova.PasswordHash = hasher.HashPassword(UserValentinaDimitrova, "valentinadimitrova123");

            UserIvoStoyanov = new IdentityUser()
            {
                Id = "41c16c1c-6345-487b-9202-18bf7a723b5e",
                UserName = "ivostoyanov",
                NormalizedUserName = "ivostoyanov",
                Email = "ivostoyanov@myschool.com",
                NormalizedEmail = "ivostoyanov@myschool.com"
            };
            UserIvoStoyanov.PasswordHash = hasher.HashPassword(UserIvoStoyanov, "ivostoyanov123");

            UserStefaniyaPetrova = new IdentityUser()
            {
                Id = "a3bd2a1d-5061-439e-aec9-0e54720e3ed5",
                UserName = "stefaniyapetrova",
                NormalizedUserName = "stefaniyapetrova",
                Email = "stefaniyapetrova@myschool.com",
                NormalizedEmail = "stefaniyapetrova@myschool.com"
            };
            UserStefaniyaPetrova.PasswordHash = hasher.HashPassword(UserStefaniyaPetrova, "stefaniyapetrova123");

            UserMartinKolev = new IdentityUser()
            {
                Id = "2c537f9a-c6ef-43d1-98da-e63d947de2bd",
                UserName = "martinkolev",
                NormalizedUserName = "martinkolev",
                Email = "martinkolev@myschool.com",
                NormalizedEmail = "martinkolev@myschool.com"
            };
            UserMartinKolev.PasswordHash = hasher.HashPassword(UserMartinKolev, "martinkolev123");

            UserSonyaIvanova = new IdentityUser()
            {
                Id = "512da3a0-4861-49ac-9142-1536f5ea2cb1",
                UserName = "sonyaivanova",
                NormalizedUserName = "sonyaivanova",
                Email = "sonyaivanova@myschool.com",
                NormalizedEmail = "sonyaivanova@myschool.com"
            };
            UserSonyaIvanova.PasswordHash = hasher.HashPassword(UserSonyaIvanova, "sonyaivanova123");

            UserLyubomirGeorgiev = new IdentityUser()
            {
                Id = "9c1e0838-6a1b-4158-92a2-36c6234e9d41",
                UserName = "lyubomirgeorgiev",
                NormalizedUserName = "lyubomirgeorgiev",
                Email = "lyubomirgeorgiev@myschool.com",
                NormalizedEmail = "lyubomirgeorgiev@myschool.com"
            };
            UserLyubomirGeorgiev.PasswordHash = hasher.HashPassword(UserLyubomirGeorgiev, "lyubomirgeorgiev123");

            UserNataliyaVasileva = new IdentityUser()
            {
                Id = "17b6757b-33e6-4d97-b8f4-22e3ec4e34a3",
                UserName = "nataliyavasileva",
                NormalizedUserName = "nataliyavasileva",
                Email = "nataliyavasileva@myschool.com",
                NormalizedEmail = "nataliyavasileva@myschool.com"
            };
            UserNataliyaVasileva.PasswordHash = hasher.HashPassword(UserNataliyaVasileva, "nataliyavasileva123");

            UserPetarPetrov = new IdentityUser()
            {
                Id = "7d2f14fb-b3b5-4598-8989-ba10d3612c96",
                UserName = "petarpetrov",
                NormalizedUserName = "petarpetrov",
                Email = "petarpetrov@myschool.com",
                NormalizedEmail = "petarpetrov@myschool.com"
            };
            UserPetarPetrov.PasswordHash = hasher.HashPassword(UserPetarPetrov, "petarpetrov123");

            UserGerganaDimitrova = new IdentityUser()
            {
                Id = "3f13969e-28fc-4315-b44d-b0f7b827202a",
                UserName = "gerganadimitrova",
                NormalizedUserName = "gerganadimitrova",
                Email = "gerganadimitrova@myschool.com",
                NormalizedEmail = "gerganadimitrova@myschool.com"
            };
            UserGerganaDimitrova.PasswordHash = hasher.HashPassword(UserGerganaDimitrova, "gerganadimitrova123");

            UserLyubomiraTodorova = new IdentityUser()
            {
                Id = "8a4b8f2d-72e8-46d1-8a9f-2d06b1d9ecf1",
                UserName = "lyubomiratodorova",
                NormalizedUserName = "lyubomiratodorova",
                Email = "lyubomiratodorova@myschool.com",
                NormalizedEmail = "lyubomiratodorova@myschool.com"
            };
            UserLyubomiraTodorova.PasswordHash = hasher.HashPassword(UserLyubomiraTodorova, "lyubomiratodorova123");

            UserAntonIvanov = new IdentityUser()
            {
                Id = "f4ec527a-d87f-4e87-b948-26e7d4c3351f",
                UserName = "antonivanov",
                NormalizedUserName = "antonivanov",
                Email = "antonivanov@myschool.com",
                NormalizedEmail = "antonivanov@myschool.com"
            };
            UserAntonIvanov.PasswordHash = hasher.HashPassword(UserAntonIvanov, "antonivanov123");

            UserTanyaGeorgieva = new IdentityUser()
            {
                Id = "f0578b4d-49cc-4c3c-8b61-62ebc8c196e9",
                UserName = "tanyageorgieva",
                NormalizedUserName = "tanyageorgieva",
                Email = "tanyageorgieva@myschool.com",
                NormalizedEmail = "tanyageorgieva@myschool.com"
            };
            UserTanyaGeorgieva.PasswordHash = hasher.HashPassword(UserTanyaGeorgieva, "tanyageorgieva123");

            UserKamenchoPetrov = new IdentityUser()
            {
                Id = "d68684c7-c3a8-4c21-8042-b76a4f43ff33",
                UserName = "kamenchopetrov",
                NormalizedUserName = "kamenchopetrov",
                Email = "kamenchopetrov@myschool.com",
                NormalizedEmail = "kamenchopetrov@myschool.com"
            };
            UserKamenchoPetrov.PasswordHash = hasher.HashPassword(UserKamenchoPetrov, "kamenchopetrov123");

            UserVanyaKoleva = new IdentityUser()
            {
                Id = "8d0a37e9-91a1-4b3a-86a9-b57595b104ab",
                UserName = "vanyakoleva",
                NormalizedUserName = "vanyakoleva",
                Email = "vanyakoleva@myschool.com",
                NormalizedEmail = "vanyakoleva@myschool.com"
            };
            UserVanyaKoleva.PasswordHash = hasher.HashPassword(UserVanyaKoleva, "vanyakoleva123");

            UserRadoslavGeorgiev = new IdentityUser()
            {
                Id = "23dbfde3-00c5-47d9-b1b4-23f97379881e",
                UserName = "radoslavgeorgiev",
                NormalizedUserName = "radoslavgeorgiev",
                Email = "radoslavgeorgiev@myschool.com",
                NormalizedEmail = "radoslavgeorgiev@myschool.com"
            };
            UserRadoslavGeorgiev.PasswordHash = hasher.HashPassword(UserRadoslavGeorgiev, "radoslavgeorgiev123");

            UserVasilenkaIvanova = new IdentityUser()
            {
                Id = "6a56e5a9-b77d-492e-82c5-eab5c9397756",
                UserName = "vasilenkaivanova",
                NormalizedUserName = "vasilenkaivanova",
                Email = "vasilenkaivanova@myschool.com",
                NormalizedEmail = "vasilenkaivanova@myschool.com"
            };
            UserVasilenkaIvanova.PasswordHash = hasher.HashPassword(UserVasilenkaIvanova, "vasilenkaivanova123");

            UserKirilDimitrov = new IdentityUser()
            {
                Id = "8d9f8a3f-16a2-4fe5-b12a-32c3f3c66fb1",
                UserName = "kirildimitrov",
                NormalizedUserName = "kirildimitrov",
                Email = "kirildimitrov@myschool.com",
                NormalizedEmail = "kirildimitrov@myschool.com"
            };
            UserKirilDimitrov.PasswordHash = hasher.HashPassword(UserKirilDimitrov, "kirildimitrov123");

            UserKameliyaTodorova = new IdentityUser()
            {
                Id = "8b7f9c67-7985-4f3f-a2a1-271189e22a0d",
                UserName = "kameliyatodorova",
                NormalizedUserName = "kameliyatodorova",
                Email = "kameliyatodorova@myschool.com",
                NormalizedEmail = "kameliyatodorova@myschool.com"
            };
            UserKameliyaTodorova.PasswordHash = hasher.HashPassword(UserKameliyaTodorova, "kameliyatodorova123");

            UserIliyaPetrov = new IdentityUser()
            {
                Id = "961b318b-7e65-4ef9-bf8e-3e22f74cdd6d",
                UserName = "iliyapetrov",
                NormalizedUserName = "iliyapetrov",
                Email = "iliyapetrov@myschool.com",
                NormalizedEmail = "iliyapetrov@myschool.com"
            };
            UserIliyaPetrov.PasswordHash = hasher.HashPassword(UserIliyaPetrov, "iliyapetrov123");

            UserDilyanaIvanova = new IdentityUser()
            {
                Id = "d8b46962-25a4-4977-8363-d43e7076c85f",
                UserName = "dilyanaivanova",
                NormalizedUserName = "dilyanaivanova",
                Email = "dilyanaivanova@myschool.com",
                NormalizedEmail = "dilyanaivanova@myschool.com"
            };
            UserDilyanaIvanova.PasswordHash = hasher.HashPassword(UserDilyanaIvanova, "dilyanaivanova123");

            UserBogdanKolev = new IdentityUser()
            {
                Id = "15b7349f-c184-42e7-9a18-0c0dd1a05bea",
                UserName = "bogdankolev",
                NormalizedUserName = "bogdankolev",
                Email = "bogdankolev@myschool.com",
                NormalizedEmail = "bogdankolev@myschool.com"
            };
            UserBogdanKolev.PasswordHash = hasher.HashPassword(UserBogdanKolev, "bogdankolev123");

            UserDanielaMarinova = new IdentityUser()
            {
                Id = "8f35f8dd-b52a-4084-818b-3e1813e42f19",
                UserName = "danielamarinova",
                NormalizedUserName = "danielamarinova",
                Email = "danielamarinova@myschool.com",
                NormalizedEmail = "danielamarinova@myschool.com"
            };
            UserDanielaMarinova.PasswordHash = hasher.HashPassword(UserDanielaMarinova, "danielamarinova123");

            UserHristiyanIvanov = new IdentityUser()
            {
                Id = "e2b8904e-9a9e-471d-af7b-ef17f62f0e35",
                UserName = "hristiyanivanov",
                NormalizedUserName = "hristiyanivanov",
                Email = "hristiyanivanov@myschool.com",
                NormalizedEmail = "hristiyanivanov@myschool.com"
            };
            UserHristiyanIvanov.PasswordHash = hasher.HashPassword(UserHristiyanIvanov, "hristiyanivanov123");

            UserTeodoraVasileva = new IdentityUser()
            {
                Id = "7fbd8c2e-38c6-4a97-aa74-6321ee1f0e2a",
                UserName = "teodoravasileva",
                NormalizedUserName = "teodoravasileva",
                Email = "teodoravasileva@myschool.com",
                NormalizedEmail = "teodoravasileva@myschool.com"
            };
            UserTeodoraVasileva.PasswordHash = hasher.HashPassword(UserTeodoraVasileva, "teodoravasileva123");

            UserDesislavDimitrov = new IdentityUser()
            {
                Id = "3251a6f3-1415-4173-8d95-509d9b57a4bb",
                UserName = "desislavdimitrov",
                NormalizedUserName = "desislavdimitrov",
                Email = "desislavdimitrov@myschool.com",
                NormalizedEmail = "desislavdimitrov@myschool.com"
            };
            UserDesislavDimitrov.PasswordHash = hasher.HashPassword(UserDesislavDimitrov, "desislavdimitrov123");

            UserGalyaIvanova = new IdentityUser()
            {
                Id = "b2f18679-974f-4648-891b-05df89900b85",
                UserName = "galyaivanova",
                NormalizedUserName = "galyaivanova",
                Email = "galyaivanova@myschool.com",
                NormalizedEmail = "galyaivanova@myschool.com"
            };
            UserGalyaIvanova.PasswordHash = hasher.HashPassword(UserGalyaIvanova, "galyaivanova123");

            UserIvanKolev = new IdentityUser()
            {
                Id = "6c704485-8f35-4b5d-aa5b-c971b87cb442",
                UserName = "ivankolev",
                NormalizedUserName = "ivankolev",
                Email = "ivankolev@myschool.com",
                NormalizedEmail = "ivankolev@myschool.com"
            };
            UserIvanKolev.PasswordHash = hasher.HashPassword(UserIvanKolev, "ivankolev123");

            UserMariyaPetrova = new IdentityUser()
            {
                Id = "2e07c9b0-d2a4-41e7-b8d8-0e0384c5e81b",
                UserName = "mariyapetrova",
                NormalizedUserName = "mariyapetrova",
                Email = "mariyapetrova@myschool.com",
                NormalizedEmail = "mariyapetrova@myschool.com"
            };
            UserMariyaPetrova.PasswordHash = hasher.HashPassword(UserMariyaPetrova, "mariyapetrova123");

            UserSimeonGeorgiev = new IdentityUser()
            {
                Id = "b5245ba7-c0e2-4e7d-b144-e9b7d8889e6e",
                UserName = "simeongeorgiev",
                NormalizedUserName = "simeongeorgiev",
                Email = "simeongeorgiev@myschool.com",
                NormalizedEmail = "simeongeorgiev@myschool.com"
            };
            UserSimeonGeorgiev.PasswordHash = hasher.HashPassword(UserSimeonGeorgiev, "simeongeorgiev123");

            UserMagdalinaIvanova = new IdentityUser()
            {
                Id = "10b1bb25-7f3e-4ec5-bb68-9f8282850711",
                UserName = "magdalinaivanova",
                NormalizedUserName = "magdalinaivanova",
                Email = "magdalinaivanova@myschool.com",
                NormalizedEmail = "magdalinaivanova@myschool.com"
            };
            UserMagdalinaIvanova.PasswordHash = hasher.HashPassword(UserMagdalinaIvanova, "magdalinaivanova123");

            UserEmilTodorov = new IdentityUser()
            {
                Id = "b7395fbb-59e7-4687-9b69-0f135abf8e72",
                UserName = "emiltodorov",
                NormalizedUserName = "emiltodorov",
                Email = "emiltodorov@myschool.com",
                NormalizedEmail = "emiltodorov@myschool.com"
            };
            UserEmilTodorov.PasswordHash = hasher.HashPassword(UserEmilTodorov, "emiltodorov123");

            UserKalinchoPetrov = new IdentityUser()
            {
                Id = "6a4e15d5-29ae-4b86-9015-21d61e22e947",
                UserName = "kalinchopetrov",
                NormalizedUserName = "kalinchopetrov",
                Email = "kalinchopetrov@myschool.com",
                NormalizedEmail = "kalinchopetrov@myschool.com"
            };
            UserKalinchoPetrov.PasswordHash = hasher.HashPassword(UserKalinchoPetrov, "kalinchopetrov123");

            UserRalitsaDimitrova = new IdentityUser()
            {
                Id = "cff038d2-716a-4c45-8f21-81b1e7769a74",
                UserName = "ralitsadimitrova",
                NormalizedUserName = "ralitsadimitrova",
                Email = "ralitsadimitrova@myschool.com",
                NormalizedEmail = "ralitsadimitrova@myschool.com"
            };
            UserRalitsaDimitrova.PasswordHash = hasher.HashPassword(UserRalitsaDimitrova, "ralitsadimitrova123");

            UserYordanGeorgiev = new IdentityUser()
            {
                Id = "80f4cb68-199a-4f6d-8b82-6ad3521c0b52",
                UserName = "yordangeorgiev",
                NormalizedUserName = "yordangeorgiev",
                Email = "yordangeorgiev@myschool.com",
                NormalizedEmail = "yordangeorgiev@myschool.com"
            };
            UserYordanGeorgiev.PasswordHash = hasher.HashPassword(UserYordanGeorgiev, "yordangeorgiev123");

            UserRadinkaIvanova = new IdentityUser()
            {
                Id = "1b441729-6f7d-4d13-9f0b-3fe4e76727c3",
                UserName = "radinkaivanova",
                NormalizedUserName = "radinkaivanova",
                Email = "radinkaivanova@myschool.com",
                NormalizedEmail = "radinkaivanova@myschool.com"
            };
            UserRadinkaIvanova.PasswordHash = hasher.HashPassword(UserRadinkaIvanova, "radinkaivanova123");

            UserVentsislavPetrov = new IdentityUser()
            {
                Id = "675b60ea-ee3f-4e58-b8d4-109b9ab54d99",
                UserName = "ventsislavpetrov",
                NormalizedUserName = "ventsislavpetrov",
                Email = "ventsislavpetrov@myschool.com",
                NormalizedEmail = "ventsislavpetrov@myschool.com"
            };
            UserVentsislavPetrov.PasswordHash = hasher.HashPassword(UserVentsislavPetrov, "ventsislavpetrov123");

            UserDarinaKoleva = new IdentityUser()
            {
                Id = "2bd002d3-ff51-4a18-a155-dc76bba5130a",
                UserName = "darinkakoleva",
                NormalizedUserName = "darinkakoleva",
                Email = "darinkakoleva@myschool.com",
                NormalizedEmail = "darinkakoleva@myschool.com"
            };
            UserDarinaKoleva.PasswordHash = hasher.HashPassword(UserDarinaKoleva, "darinkakoleva123");

            UserBozhidarDimitrov = new IdentityUser()
            {
                Id = "98fb09c1-54d0-4d9c-86ee-7f7b510695ef",
                UserName = "bozhidardimitrov",
                NormalizedUserName = "bozhidardimitrov",
                Email = "bozhidardimitrov@myschool.com",
                NormalizedEmail = "bozhidardimitrov@myschool.com"
            };
            UserBozhidarDimitrov.PasswordHash = hasher.HashPassword(UserBozhidarDimitrov, "bozhidardimitrov123");

            UserNeliGeorgieva = new IdentityUser()
            {
                Id = "731e88f2-bb26-46d8-8d53-031af77b5e15",
                UserName = "neligeorgieva",
                NormalizedUserName = "neligeorgieva",
                Email = "neligeorgieva@myschool.com",
                NormalizedEmail = "neligeorgieva@myschool.com"
            };
            UserNeliGeorgieva.PasswordHash = hasher.HashPassword(UserNeliGeorgieva, "neligeorgieva123");

            UserYavorIvanov = new IdentityUser()
            {
                Id = "5b38fb70-63e4-4d02-a14f-3b58ff14bc76",
                UserName = "yavorivanov",
                NormalizedUserName = "yavorivanov",
                Email = "yavorivanov@myschool.com",
                NormalizedEmail = "yavorivanov@myschool.com"
            };
            UserYavorIvanov.PasswordHash = hasher.HashPassword(UserYavorIvanov, "yavorivanov123");

            UserMilitsaPetrova = new IdentityUser()
            {
                Id = "80a73e8d-3a08-44b3-ba99-8a5ea3ebd012",
                UserName = "militsapetrova",
                NormalizedUserName = "militsapetrova",
                Email = "militsapetrova@myschool.com",
                NormalizedEmail = "militsapetrova@myschool.com"
            };
            UserMilitsaPetrova.PasswordHash = hasher.HashPassword(UserMilitsaPetrova, "militsapetrova123");

            UserZdravkoKolev = new IdentityUser()
            {
                Id = "844dd2c8-e20b-4423-827f-349e0bbd2761",
                UserName = "zdravkokolev",
                NormalizedUserName = "zdravkokolev",
                Email = "zdravkokolev@myschool.com",
                NormalizedEmail = "zdravkokolev@myschool.com"
            };
            UserZdravkoKolev.PasswordHash = hasher.HashPassword(UserZdravkoKolev, "zdravkokolev123");

            UserElenaStoyanova = new IdentityUser()
            {
                Id = "61f620da-d214-4e17-852a-c96fddcc682a",
                UserName = "elenastoyanova",
                NormalizedUserName = "elenastoyanova",
                Email = "elenastoyanova@myschool.com",
                NormalizedEmail = "elenastoyanova@myschool.com"
            };
            UserElenaStoyanova.PasswordHash = hasher.HashPassword(UserElenaStoyanova, "elenastoyanova123");
        }
        private void SeedSubjects()
        {
            Bulgarian = new Subject()
            {
                Id = 1,
                Name = "Bulgarian",
                TeacherId = TatyanaGerganova.Id

            };
            Mathematics = new Subject()
            {
                Id = 2,
                Name = "Mathematics",
                TeacherId = BilyanaLozanova.Id

            };
            English = new Subject()
            {
                Id = 3,
                Name = "English",
                TeacherId = KrasimiraKutin.Id
            };
            SoftwareDesign = new Subject()
            {
                Id = 4,
                Name = "SoftwareDesign",
                TeacherId = TeodorHristov.Id
            };
            ComputerScience = new Subject()
            {
                Id = 5,
                Name = "ComputerScience",
                TeacherId = SilviyaGancheva.Id
            };
            Business = new Subject()
            {
                Id = 6,
                Name = "Business",
                TeacherId = CvetomirAmbursa.Id
            };
            Physics = new Subject()
            {
                Id = 7,
                Name = "Physics",
                TeacherId = MitkoMitkov.Id
            };
            Programming = new Subject()
            {
                Id = 8,
                Name = "Programming",
                TeacherId = EmilStoyanov.Id
            };
            Engineering = new Subject()
            {
                Id = 9,
                Name = "Engineering",
                TeacherId = BorislavaBangeeva.Id
            };
            History = new Subject()
            {
                Id = 10,
                Name = "History",
                TeacherId = MariaIvanova.Id
            };

        }
        private void SeedTeachers()
        {
            TatyanaGerganova = new Teacher()
            {
                Id = 1,
                FullName = "Tatyana Gerganova",
                IsClassTeacher = true,
                Email = "t.gerganova@myschool.com",
                PhoneNumber = "1357924680",
                UserId = UserTatyanaGerganova.Id
            };
            BilyanaLozanova = new Teacher()
            {
                Id = 2,
                FullName = "Bilyana Lozanova",
                IsClassTeacher = true,
                Email = "b.lozanova@myschool.com",
                PhoneNumber = "5738291467",
                UserId = UserBilyanaLozanova.Id
            };
            KrasimiraKutin = new Teacher()
            {
                Id = 3,
                FullName = "Krasimira Kutin",
                IsClassTeacher = false,
                Email = "k.kutin@myschool.com",
                PhoneNumber = "6248371095",
                UserId = UserKrasimiraKutin.Id
            };
            TeodorHristov = new Teacher()
            {
                Id = 4,
                FullName = "Teodor Hristov",
                IsClassTeacher = false,
                Email = "t.hristov@myschool.com",
                PhoneNumber = "8902145673",
                UserId = UserTeodorHristov.Id
            };
            SilviyaGancheva = new Teacher()
            {
                Id = 5,
                FullName = "Silviya Gancheva",
                IsClassTeacher = false,
                Email = "s.gancheva@myschool.com",
                PhoneNumber = "4512067839",
                UserId = UserSilviyaGancheva.Id
            };
            CvetomirAmbursa = new Teacher()
            {
                Id = 6,
                FullName = "Cvetomir Ambursa",
                IsClassTeacher = true,
                Email = "c.ambursa@myschool.com",
                PhoneNumber = "7263489510",
                UserId = UserCvetomirAmbursa.Id
            };
            MitkoMitkov = new Teacher()
            {
                Id = 7,
                FullName = "Mitko Mitkov",
                IsClassTeacher = false,
                Email = "m.mitkov@myschool.com",
                PhoneNumber = "5031982467",
                UserId = UserMitkoMitkov.Id
            };
            EmilStoyanov = new Teacher()
            {
                Id = 8,
                FullName = "Emil Stoyanov",
                IsClassTeacher = true,
                Email = "e.stoyanov@myschool.com",
                PhoneNumber = "3156924708",
                UserId = UserEmilStoyanov.Id
            };
            BorislavaBangeeva = new Teacher()
            {
                Id = 9,
                FullName = "Borislava Bangeeva",
                IsClassTeacher = false,
                Email = "b.bangeeva@myschool.com",
                PhoneNumber = "9785402163",
                UserId = UserBorislavaBangeeva.Id
            };
            MariaIvanova = new Teacher()
            {
                Id = 10,
                FullName = "Maria Ivanova",
                IsClassTeacher = true,
                Email = "m.ivanova@myschool.com",
                PhoneNumber = "2047856931",
                UserId = UserMariaIvanova.Id
            };

        }
        private void SeedClasses()
        {
            Eight = new Class()
            {
                Id = 1,
                Name = "8\"g\"",
                AverageScore = 0,
                TeacherId = EmilStoyanov.Id
            };
            Ninth = new Class()
            {
                Id = 2,
                Name = "9\"b\"",
                AverageScore = 0,
                TeacherId = BilyanaLozanova.Id
            };
            Tenth = new Class()
            {
                Id = 3,
                Name = "10\"v\"",
                AverageScore = 0,
                TeacherId = TatyanaGerganova.Id
            };
            Eleventh = new Class()
            {
                Id = 4,
                Name = "11\"e\"",
                AverageScore = 0,
                TeacherId = CvetomirAmbursa.Id
            };
            Twelfth = new Class()
            {
                Id = 5,
                Name = "12\"d\"",
                AverageScore = 0,
                TeacherId = MariaIvanova.Id
            };

        }
        private void SeedPrincipals()
        {
            RadostinaMekova = new Principal()
            {
                Id = 1,
                FullName = "Radostina Mekova",
                Email = "r.mekova@myschool.com",
                PhoneNumber = "8642097531",
                UserId = UserRadostinaMekova.Id

            };
            ValentinaStoeva = new Principal()
            {
                Id = 2,
                FullName = "Valentina Stoeva",
                Email = "v.stoeva@myschool.com",
                PhoneNumber = "8742035918",
                UserId = UserValentinaStoeva.Id
            };
            YulianaPetkova = new Principal()
            {
                Id = 3,
                FullName = "Yuliana Petkova",
                Email = "y.petkova@myschool.com",
                PhoneNumber = "5268793407",
                UserId = UserYulianaPetkova.Id
            };
        }
        private void SeedParents()
        {
            KrumIvanov = new Parent()
            {
                Id = 1,
                FullName = "Krum Ivanov",
                ChildId = 1,
                UserId = UserKrumIvanov.Id
            };
            VeronikaPetrova = new Parent()
            {
                Id = 2,
                FullName = "Veronika Petrova",
                ChildId = 2,
                UserId = UserVeronikaPetrova.Id
            };
            PlamenDimitrov = new Parent()
            {
                Id = 3,
                FullName = "Plamen Dimitrov",
                ChildId = 3,
                UserId = UserPlamenDimitrov.Id
            };
            ZlatinaGeorgieva = new Parent()
            {
                Id = 4,
                FullName = "Zlatina Georgieva",
                ChildId = 4,
                UserId = UserZlatinaGeorgieva.Id
            };
            RadoslavTodorov = new Parent()
            {
                Id = 5,
                FullName = "Radoslav Todorov",
                ChildId = 5,
                UserId = UserRadoslavTodorov.Id
            };
            AdrianaIvanova = new Parent()
            {
                Id = 6,
                FullName = "Adriana Ivanova",
                ChildId = 6,
                UserId = UserAdrianaIvanova.Id
            };
            BozhidarKolev = new Parent()
            {
                Id = 7,
                FullName = "Bozhidar Kolev",
                ChildId = 7,
                UserId = UserBozhidarKolev.Id
            };
            EvelinaVasileva = new Parent()
            {
                Id = 8,
                FullName = "Evelina Vasileva",
                ChildId = 8,
                UserId = UserEvelinaVasileva.Id
            };
            StoyanPetrov = new Parent()
            {
                Id = 9,
                FullName = "Stoyan Petrov",
                ChildId = 9,
                UserId = UserStoyanPetrov.Id
            };
            TsvetelinaStoyanova = new Parent()
            {
                Id = 10,
                FullName = "Tsvetelina Stoyanova",
                ChildId = 10,
                UserId = UserTsvetelinaStoyanova.Id
            };
            LyubenMarinov = new Parent()
            {
                Id = 11,
                FullName = "Lyuben Marinov",
                ChildId = 11,
                UserId = UserLyubenMarinov.Id
            };
            RositsaPetrova = new Parent()
            {
                Id = 12,
                FullName = "Rositsa Petrova",
                ChildId = 12,
                UserId = UserRositsaPetrova.Id
            };
            KaloyanIvanov = new Parent()
            {
                Id = 13,
                FullName = "Kaloyan Ivanov",
                ChildId = 13,
                UserId = UserKaloyanIvanov.Id
            };
            EkaterinaGeorgieva = new Parent()
            {
                Id = 14,
                FullName = "Ekaterina Georgieva",
                ChildId = 14,
                UserId = UserEkaterinaGeorgieva.Id
            };
            HristoDimitrov = new Parent()
            {
                Id = 15,
                FullName = "Hristo Dimitrov",
                ChildId = 15,
                UserId = UserHristoDimitrov.Id
            };
            DobrinkaIvanova = new Parent()
            {
                Id = 16,
                FullName = "Dobrinka Ivanova",
                ChildId = 16,
                UserId = UserDobrinkaIvanova.Id
            };
            BlagoyGeorgiev = new Parent()
            {
                Id = 17,
                FullName = "Blagoy Georgiev",
                ChildId = 17,
                UserId = UserBlagoyGeorgiev.Id
            };
            IskraKoleva = new Parent()
            {
                Id = 18,
                FullName = "Iskra Koleva",
                ChildId = 18,
                UserId = UserIskraKoleva.Id
            };
            KrasimirTodorov = new Parent()
            {
                Id = 19,
                FullName = "Krasimir Todorov",
                ChildId = 19,
                UserId = UserKrasimirTodorov.Id
            };
            GerganaIvanova = new Parent()
            {
                Id = 20,
                FullName = "Gergana Ivanova",
                ChildId = 20,
                UserId = UserGerganaIvanova.Id
            };
            VasilPetrov = new Parent()
            {
                Id = 21,
                FullName = "Vasil Petrov",
                ChildId = 21,
                UserId = UserVasilPetrov.Id
            };
            NadezhdaDimitrova = new Parent()
            {
                Id = 22,
                FullName = "Nadezhda Dimitrova",
                ChildId = 22,
                UserId = UserNadezhdaDimitrova.Id
            };
            TodorGeorgiev = new Parent()
            {
                Id = 23,
                FullName = "Todor Georgiev",
                ChildId = 23,
                UserId = UserTodorGeorgiev.Id
            };
            RadkaIvanova = new Parent()
            {
                Id = 24,
                FullName = "Radka Ivanova",
                ChildId = 24,
                UserId = UserRadkaIvanova.Id
            };
            HristinaStefanova = new Parent()
            {
                Id = 25,
                FullName = "Hristina Stefanova",
                ChildId = 25,
                UserId = UserHristinaStefanova.Id
            };
            YavorKolev = new Parent()
            {
                Id = 26,
                FullName = "Yavor Kolev",
                ChildId = 26,
                UserId = UserYavorKolev.Id
            };
            KameliaPetrova = new Parent()
            {
                Id = 27,
                FullName = "Kamelia Petrova",
                ChildId = 27,
                UserId = UserKameliaPetrova.Id
            };
            EmilIvanov = new Parent()
            {
                Id = 28,
                FullName = "Emil Ivanov",
                ChildId = 28,
                UserId = UserEmilIvanov.Id
            };
            DilyanaAleksandrova = new Parent()
            {
                Id = 29,
                FullName = "Dilyana Aleksandrova",
                ChildId = 29,
                UserId = UserDilyanaAleksandrova.Id
            };
            TsvetanGeorgiev = new Parent()
            {
                Id = 30,
                FullName = "Tsvetan Georgiev",
                ChildId = 30,
                UserId = UserTsvetanGeorgiev.Id
            };
            ZhivkaIvanova = new Parent()
            {
                Id = 31,
                FullName = "Zhivka Ivanova",
                ChildId = 31,
                UserId = UserZhivkaIvanova.Id
            };
            IvoDimitrov = new Parent()
            {
                Id = 32,
                FullName = "Ivo Dimitrov",
                ChildId = 32,
                UserId = UserIvoDimitrov.Id
            };
            AdriyanaStoyanova = new Parent()
            {
                Id = 33,
                FullName = "Adriyana Stoyanova",
                ChildId = 33,
                UserId = UserAdriyanaStoyanova.Id
            };
            KamenPetrov = new Parent()
            {
                Id = 34,
                FullName = "Kamen Petrov",
                ChildId = 34,
                UserId = UserKamenPetrov.Id
            };
            KristinaKoleva = new Parent()
            {
                Id = 35,
                FullName = "Kristina Koleva",
                ChildId = 35,
                UserId = UserKristinaKoleva.Id
            };
            YankoIvanov = new Parent()
            {
                Id = 36,
                FullName = "Yanko Ivanov",
                ChildId = 36,
                UserId = UserYankoIvanov.Id
            };
            PolinaGeorgieva = new Parent()
            {
                Id = 37,
                FullName = "Polina Georgieva",
                ChildId = 37,
                UserId = UserPolinaGeorgieva.Id
            };
            VeselinVasilev = new Parent()
            {
                Id = 38,
                FullName = "Veselin Vasilev",
                ChildId = 38,
                UserId = UserVeselinVasilev.Id
            };
            AntoniyaPetrova = new Parent()
            {
                Id = 39,
                FullName = "Antoniya Petrova",
                ChildId = 39,
                UserId = UserAntoniyaPetrova.Id
            };
            LyubomirDimitrov = new Parent()
            {
                Id = 40,
                FullName = "Lyubomir Dimitrov",
                ChildId = 40,
                UserId = UserLyubomirDimitrov.Id
            };
            ZornitsaTodorova = new Parent()
            {
                Id = 41,
                FullName = "Zornitsa Todorova",
                ChildId = 41,
                UserId = UserZornitsaTodorova.Id
            };
            StefanIvanov = new Parent()
            {
                Id = 42,
                FullName = "Stefan Ivanov",
                ChildId = 42,
                UserId = UserStefanIvanov.Id
            };
            YoanaGeorgieva = new Parent()
            {
                Id = 43,
                FullName = "Yoana Georgieva",
                ChildId = 43,
                UserId = UserYoanaGeorgieva.Id
            };
            KrasimiraPetrova = new Parent()
            {
                Id = 44,
                FullName = "Krasimira Petrova",
                ChildId = 44,
                UserId = UserKrasimiraPetrova.Id
            };
            IvayloKolev = new Parent()
            {
                Id = 45,
                FullName = "Ivaylo Kolev",
                ChildId = 45,
                UserId = UserIvayloKolev.Id
            };
            MargaritaGeorgieva = new Parent()
            {
                Id = 46,
                FullName = "Margarita Georgieva",
                ChildId = 46,
                UserId = UserMargaritaGeorgieva.Id
            };
            RumenIvanov = new Parent()
            {
                Id = 47,
                FullName = "Rumen Ivanov",
                ChildId = 47,
                UserId = UserRumenIvanov.Id
            };
            MilenaDimitrova = new Parent()
            {
                Id = 48,
                FullName = "Milena Dimitrova",
                ChildId = 48,
                UserId = UserMilenaDimitrova.Id
            };
            YordanTodorov = new Parent()
            {
                Id = 49,
                FullName = "Yordan Todorov",
                ChildId = 49,
                UserId = UserYordanTodorov.Id
            };
            SilviyaPetrova = new Parent()
            {
                Id = 50,
                FullName = "Silviya Petrova",
                ChildId = 50,
                UserId = UserSilviyaPetrova.Id
            };
            BogdanIvanov = new Parent()
            {
                Id = 51,
                FullName = "Bogdan Ivanov",
                ChildId = 51,
                UserId = UserBogdanIvanov.Id
            };
            PetyaKoleva = new Parent()
            {
                Id = 52,
                FullName = "Petya Koleva",
                ChildId = 52,
                UserId = UserPetyaKoleva.Id
            };
            AsenMarinov = new Parent()
            {
                Id = 53,
                FullName = "Asen Marinov",
                ChildId = 53,
                UserId = UserAsenMarinov.Id
            };
            RalitsaIvanova = new Parent()
            {
                Id = 54,
                FullName = "Ralitsa Ivanova",
                ChildId = 54,
                UserId = UserRalitsaIvanova.Id
            };
            VelkoVasilev = new Parent()
            {
                Id = 55,
                FullName = "Velko Vasilev",
                ChildId = 55,
                UserId = UserVelkoVasilev.Id
            };
            GalyaDimitrova = new Parent()
            {
                Id = 56,
                FullName = "Galya Dimitrova",
                ChildId = 56,
                UserId = UserGalyaDimitrova.Id
            };
            DimiturIvanov = new Parent()
            {
                Id = 57,
                FullName = "Dimitur Ivanov",
                ChildId = 57,
                UserId = UserDimiturIvanov.Id
            };
            NadiaKoleva = new Parent()
            {
                Id = 58,
                FullName = "Nadia Koleva",
                ChildId = 58,
                UserId = UserNadiaKoleva.Id
            };
            YulianPetrov = new Parent()
            {
                Id = 59,
                FullName = "Yulian Petrov",
                ChildId = 59,
                UserId = UserYulianPetrov.Id
            };
            RadostinaGeorgieva = new Parent()
            {
                Id = 60,
                FullName = "Radostina Georgieva",
                ChildId = 60,
                UserId = UserRadostinaGeorgieva.Id
            };
            KrasimIvanov = new Parent()
            {
                Id = 61,
                FullName = "Krasim Ivanov",
                ChildId = 61,
                UserId = UserKrasimIvanov.Id
            };
            TeodoraTodorova = new Parent()
            {
                Id = 62,
                FullName = "Teodora Todorova",
                ChildId = 62,
                UserId = UserTeodoraTodorova.Id
            };
            KalinPetrov = new Parent()
            {
                Id = 63,
                FullName = "Kalin Petrov",
                ChildId = 63,
                UserId = UserKalinPetrov.Id
            };
            SvetlaDimitrova = new Parent()
            {
                Id = 64,
                FullName = "Svetla Dimitrova",
                ChildId = 64,
                UserId = UserSvetlaDimitrova.Id
            };
            VentsislavGeorgiev = new Parent()
            {
                Id = 65,
                FullName = "Ventsislav Georgiev",
                ChildId = 65,
                UserId = UserVentsislavGeorgiev.Id
            };
            VasilenaIvanova = new Parent()
            {
                Id = 66,
                FullName = "Vasilena Ivanova",
                ChildId = 66,
                UserId = UserVasilenaIvanova.Id
            };
            MartinPetrov = new Parent()
            {
                Id = 67,
                FullName = "Martin Petrov",
                ChildId = 67,
                UserId = UserMartinPetrov.Id
            };
            RalitsaKoleva = new Parent()
            {
                Id = 68,
                FullName = "Ralitsa Koleva",
                ChildId = 68,
                UserId = UserRalitsaKoleva.Id
            };
            StefanDimitrov = new Parent()
            {
                Id = 69,
                FullName = "Stefan Dimitrov",
                ChildId = 69,
                UserId = UserStefanDimitrov.Id
            };
            SnezhanaGeorgieva = new Parent()
            {
                Id = 70,
                FullName = "Snezhana Georgieva",
                ChildId = 70,
                UserId = UserSnezhanaGeorgieva.Id
            };
            IvayloIvanov = new Parent()
            {
                Id = 71,
                FullName = "Ivaylo Ivanov",
                ChildId = 71,
                UserId = UserIvayloIvanov.Id
            };
            MarianaPetrova = new Parent()
            {
                Id = 72,
                FullName = "Mariana Petrova",
                ChildId = 72,
                UserId = UserMarianaPetrova.Id
            };
            RosenKolev = new Parent()
            {
                Id = 73,
                FullName = "Rosen Kolev",
                ChildId = 73,
                UserId = UserRosenKolev.Id
            };
            TanyaStoyanova = new Parent()
            {
                Id = 74,
                FullName = "Tanya Stoyanova",
                ChildId = 74,
                UserId = UserTanyaStoyanova.Id
            };
        }
        private void SeedStudents()
        {
            DimitarIvanov = new Student()
            {
                Id = 1,
                FirstName = "Dimitar",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserDimitarIvanov.Id
            };
            ElenaPetrova = new Student()
            {
                Id = 2,
                FirstName = "Elena",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserElenaPetrova.Id
            };
            StefchoDimitrov = new Student()
            {
                Id = 3,
                FirstName = "Stefcho",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserStefchoDimitrov.Id
            };
            MilenaGeorgieva = new Student()
            {
                Id = 4,
                FirstName = "Milena",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserMilenaGeorgieva.Id
            };
            AleksandarTodorov = new Student()
            {
                Id = 5,
                FirstName = "Aleksandar",
                LastName = "Todorov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserAleksandarTodorov.Id
            };
            ViktoriaIvanova = new Student()
            {
                Id = 6,
                FirstName = "Viktoria",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserViktoriaIvanova.Id
            };
            NikolayKolev = new Student()
            {
                Id = 7,
                FirstName = "Nikolay",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserNikolayKolev.Id
            };
            MariaVasileva = new Student()
            {
                Id = 8,
                FirstName = "Maria",
                LastName = "Vasileva",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserMariaVasileva.Id
            };
            IvayloPetrov = new Student()
            {
                Id = 9,
                FirstName = "Ivaylo",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserIvayloPetrov.Id
            };
            GabrielaStoyanova = new Student()
            {
                Id = 10,
                FirstName = "Gabriela",
                LastName = "Stoyanova",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserGabrielaStoyanova.Id
            };
            GeorgiMarinov = new Student()
            {
                Id = 11,
                FirstName = "Georgi",
                LastName = "Marinov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserGeorgiMarinov.Id
            };
            KristinaPetrova = new Student()
            {
                Id = 12,
                FirstName = "Kristina",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserKristinaPetrova.Id
            };
            RumchoIvanov = new Student()
            {
                Id = 13,
                FirstName = "Rumcho",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserRumchoIvanov.Id
            };
            EmiliaGeorgieva = new Student()
            {
                Id = 14,
                FirstName = "Emilia",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                UserId = UserEmiliaGeorgieva.Id
            };
            KrasimirDimitrov = new Student()
            {
                Id = 15,
                FirstName = "Krasimir",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserKrasimirDimitrov.Id
            };
            SilviyaIvanova = new Student()
            {
                Id = 16,
                FirstName = "Silviya",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserSilviyaIvanova.Id
            };
            AsenGeorgiev = new Student()
            {
                Id = 17,
                FirstName = "Asen",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserAsenGeorgiev.Id
            };
            ElenaKoleva = new Student()
            {
                Id = 18,
                FirstName = "Elena",
                LastName = "Koleva",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserElenaKoleva.Id
            };
            StanimirTodorov = new Student()
            {
                Id = 19,
                FirstName = "Stanimir",
                LastName = "Todorov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserStanimirTodorov.Id
            };
            MagdalenaIvanova = new Student()
            {
                Id = 20,
                FirstName = "Magdalena",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserMagdalenaIvanova.Id
            };
            HristoPetrov = new Student()
            {
                Id = 21,
                FirstName = "Hristo",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserHristoPetrov.Id
            };
            KalinaDimitrova = new Student()
            {
                Id = 22,
                FirstName = "Kalina",
                LastName = "Dimitrova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserKalinaDimitrova.Id
            };
            TsvetanchoGeorgiev = new Student()
            {
                Id = 23,
                FirstName = "Tsvetancho",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserTsvetanchoGeorgiev.Id
            };
            NadezhdaIvanova = new Student()
            {
                Id = 24,
                FirstName = "Nadezhda",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserNadezhdaIvanova.Id
            };
            BorisStefanov = new Student()
            {
                Id = 25,
                FirstName = "Boris",
                LastName = "Stefanov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserBorisStefanov.Id
            };
            AneliyaKoleva = new Student()
            {
                Id = 26,
                FirstName = "Aneliya",
                LastName = "Koleva",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserAneliyaKoleva.Id
            };
            RosenPetrov = new Student()
            {
                Id = 27,
                FirstName = "Rosen",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserRosenPetrov.Id
            };
            RadostinaIvanova = new Student()
            {
                Id = 28,
                FirstName = "Radostina",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserRadostinaIvanova.Id
            };
            VasilAleksandrov = new Student()
            {
                Id = 29,
                FirstName = "Vasil",
                LastName = "Aleksandrov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserVasilAleksandrov.Id
            };
            RositsaGeorgieva = new Student()
            {
                Id = 30,
                FirstName = "Rositsa",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserRositsaGeorgieva.Id
            };
            PlamenIvanov = new Student()
            {
                Id = 31,
                FirstName = "Plamen",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                UserId = UserPlamenIvanov.Id
            };
            ValentinaDimitrova = new Student()
            {
                Id = 32,
                FirstName = "Valentina",
                LastName = "Dimitrova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserValentinaDimitrova.Id
            };
            IvoStoyanov = new Student()
            {
                Id = 33,
                FirstName = "Ivo",
                LastName = "Stoyanov",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserIvoStoyanov.Id
            };
            StefaniyaPetrova = new Student()
            {
                Id = 34,
                FirstName = "Stefaniya",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserStefaniyaPetrova.Id
            };
            MartinKolev = new Student()
            {
                Id = 35,
                FirstName = "Martin",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserMartinKolev.Id
            };
            SonyaIvanova = new Student()
            {
                Id = 36,
                FirstName = "Sonya",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserSonyaIvanova.Id
            };
            LyubomirGeorgiev = new Student()
            {
                Id = 37,
                FirstName = "Lyubomir",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserLyubomirGeorgiev.Id
            };
            NataliyaVasileva = new Student()
            {
                Id = 38,
                FirstName = "Nataliya",
                LastName = "Vasileva",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserNataliyaVasileva.Id
            };
            PetarPetrov = new Student()
            {
                Id = 39,
                FirstName = "Petar",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserPetarPetrov.Id
            };
            GerganaDimitrova = new Student()
            {
                Id = 40,
                FirstName = "Gergana",
                LastName = "Dimitrova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserGerganaDimitrova.Id
            };
            LyubomiraTodorova = new Student()
            {
                Id = 41,
                FirstName = "Lyubomira",
                LastName = "Todorova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserLyubomiraTodorova.Id
            };
            AntonIvanov = new Student()
            {
                Id = 42,
                FirstName = "Anton",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserAntonIvanov.Id
            };
            TanyaGeorgieva = new Student()
            {
                Id = 43,
                FirstName = "Tanya",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                UserId = UserTanyaGeorgieva.Id
            };
            KamenchoPetrov = new Student()
            {
                Id = 44,
                FirstName = "Kamencho",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserKamenchoPetrov.Id
            };
            VanyaKoleva = new Student()
            {
                Id = 45,
                FirstName = "Vanya",
                LastName = "Koleva",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserVanyaKoleva.Id
            };
            RadoslavGeorgiev = new Student()
            {
                Id = 46,
                FirstName = "Radoslav",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserRadoslavGeorgiev.Id
            };
            VasilenkaIvanova = new Student()
            {
                Id = 47,
                FirstName = "Vasilenka",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserVasilenkaIvanova.Id
            };
            KirilDimitrov = new Student()
            {
                Id = 48,
                FirstName = "Kiril",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserKirilDimitrov.Id
            };
            KameliyaTodorova = new Student()
            {
                Id = 49,
                FirstName = "Kameliya",
                LastName = "Todorova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserKameliyaTodorova.Id
            };
            IliyaPetrov = new Student()
            {
                Id = 50,
                FirstName = "Iliya",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserIliyaPetrov.Id
            };
            DilyanaIvanova = new Student()
            {
                Id = 51,
                FirstName = "Dilyana",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserDilyanaIvanova.Id
            };
            BogdanKolev = new Student()
            {
                Id = 52,
                FirstName = "Bogdan",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserBogdanKolev.Id
            };
            DanielaMarinova = new Student()
            {
                Id = 53,
                FirstName = "Daniela",
                LastName = "Marinova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserDanielaMarinova.Id
            };
            HristiyanIvanov = new Student()
            {
                Id = 54,
                FirstName = "Hristiyan",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserHristiyanIvanov.Id
            };
            TeodoraVasileva = new Student()
            {
                Id = 55,
                FirstName = "Teodora",
                LastName = "Vasileva",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserTeodoraVasileva.Id
            };
            DesislavDimitrov = new Student()
            {
                Id = 56,
                FirstName = "Desislav",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserDesislavDimitrov.Id
            };
            GalyaIvanova = new Student()
            {
                Id = 57,
                FirstName = "Galya",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserGalyaIvanova.Id
            };
            IvanKolev = new Student()
            {
                Id = 58,
                FirstName = "Ivan",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserIvanKolev.Id
            };
            MariyaPetrova = new Student()
            {
                Id = 59,
                FirstName = "Mariya",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                UserId = UserMariyaPetrova.Id
            };
            SimeonGeorgiev = new Student()
            {
                Id = 60,
                FirstName = "Simeon",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserSimeonGeorgiev.Id
            };
            MagdalinaIvanova = new Student()
            {
                Id = 61,
                FirstName = "Magdalina",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserMagdalinaIvanova.Id
            };
            EmilTodorov = new Student()
            {
                Id = 62,
                FirstName = "Emil",
                LastName = "Todorov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserEmilTodorov.Id
            };
            KalinchoPetrov = new Student()
            {
                Id = 63,
                FirstName = "Kalincho",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserKalinchoPetrov.Id
            };
            RalitsaDimitrova = new Student()
            {
                Id = 64,
                FirstName = "Ralitsa",
                LastName = "Dimitrova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserRalitsaDimitrova.Id
            };
            YordanGeorgiev = new Student()
            {
                Id = 65,
                FirstName = "Yordan",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserYordanGeorgiev.Id
            };
            RadinkaIvanova = new Student()
            {
                Id = 66,
                FirstName = "Radinka",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserRadinkaIvanova.Id
            };
            VentsislavPetrov = new Student()
            {
                Id = 67,
                FirstName = "Ventsislav",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserVentsislavPetrov.Id
            };
            DarinaKoleva = new Student()
            {
                Id = 68,
                FirstName = "Darina",
                LastName = "Koleva",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserDarinaKoleva.Id
            };
            BozhidarDimitrov = new Student()
            {
                Id = 69,
                FirstName = "Bozhidar",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserBozhidarDimitrov.Id
            };
            NeliGeorgieva = new Student()
            {
                Id = 70,
                FirstName = "Neli",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserNeliGeorgieva.Id
            };
            YavorIvanov = new Student()
            {
                Id = 71,
                FirstName = "Yavor",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserYavorIvanov.Id
            };
            MilitsaPetrova = new Student()
            {
                Id = 72,
                FirstName = "Militsa",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserMilitsaPetrova.Id
            };
            ZdravkoKolev = new Student()
            {
                Id = 73,
                FirstName = "Zdravko",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserZdravkoKolev.Id
            };
            ElenaStoyanova = new Student()
            {
                Id = 74,
                FirstName = "Elena",
                LastName = "Stoyanova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                UserId = UserElenaStoyanova.Id
            };
        }
        private void SeedStudentSubjectGrades()
        {
            //1
            OneOne = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 1,
                Grade = 5.00m
            };

            OneTwo = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 2,
                Grade = 4.00m
            };

            OneThree = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 3,
                Grade = 6.00m
            };

            OneFour = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 4,
                Grade = 6.00m
            };

            OneFive = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 5,
                Grade = 3.00m
            };

            OneSix = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 6,
                Grade = 4.00m
            };

            OneSeven = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 7,
                Grade = 2.00m
            };

            OneEight = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 8,
                Grade = 2.00m
            };

            OneNine = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 9,
                Grade = 6.00m
            };

            OneTen = new StudentSubjectGrade()
            {
                StudentId = 1,
                SubjectId = 10,
                Grade = 5.00m
            };

            //2
            TwoOne = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 1,
                Grade = 6.00m
            };

            TwoTwo = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 2,
                Grade = 6.00m
            };

            TwoThree = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 3,
                Grade = 3.00m
            };

            TwoFour = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 4,
                Grade = 2.00m
            };

            TwoFive = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 5,
                Grade = 2.00m
            };

            TwoSix = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 6,
                Grade = 5.00m
            };

            TwoSeven = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 7,
                Grade = 5.00m
            };

            TwoEight = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 8,
                Grade = 2.00m
            };

            TwoNine = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 9,
                Grade = 6.00m
            };

            TwoTen = new StudentSubjectGrade()
            {
                StudentId = 2,
                SubjectId = 10,
                Grade = 6.00m
            };
            //3
            ThreeOne = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 1,
                Grade = 4.00m
            };

            ThreeTwo = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 2,
                Grade = 2.00m
            };

            ThreeThree = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 3,
                Grade = 2.00m
            };

            ThreeFour = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 4,
                Grade = 3.00m
            };

            ThreeFive = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 5,
                Grade = 5.00m
            };

            ThreeSix = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 6,
                Grade = 5.00m
            };

            ThreeSeven = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 7,
                Grade = 4.00m
            };

            ThreeEight = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 8,
                Grade = 4.00m
            };

            ThreeNine = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 9,
                Grade = 4.00m
            };

            ThreeTen = new StudentSubjectGrade()
            {
                StudentId = 3,
                SubjectId = 10,
                Grade = 3.00m
            };
            //4
            FourOne = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 1,
                Grade = 6.00m
            };

            FourTwo = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 2,
                Grade = 6.00m
            };

            FourThree = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 3,
                Grade = 5.00m
            };

            FourFour = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 4,
                Grade = 4.00m
            };

            FourFive = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 5,
                Grade = 4.00m
            };

            FourSix = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 6,
                Grade = 2.00m
            };

            FourSeven = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 7,
                Grade = 2.00m
            };

            FourEight = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 8,
                Grade = 3.00m
            };

            FourNine = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 9,
                Grade = 3.00m
            };

            FourTen = new StudentSubjectGrade()
            {
                StudentId = 4,
                SubjectId = 10,
                Grade = 3.00m
            };
            //5
            FiveOne = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 1,
                Grade = 5.00m
            };

            FiveTwo = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 2,
                Grade = 5.00m
            };

            FiveThree = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 3,
                Grade = 6.00m
            };

            FiveFour = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 4,
                Grade = 5.00m
            };

            FiveFive = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 5,
                Grade = 4.00m
            };

            FiveSix = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 6,
                Grade = 5.00m
            };

            FiveSeven = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 7,
                Grade = 3.00m
            };

            FiveEight = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 8,
                Grade = 3.00m
            };

            FiveNine = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 9,
                Grade = 5.00m
            };

            FiveTen = new StudentSubjectGrade()
            {
                StudentId = 5,
                SubjectId = 10,
                Grade = 5.00m
            };
            //6
            SixOne = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 1,
                Grade = 6.00m
            };

            SixTwo = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 2,
                Grade = 6.00m
            };

            SixThree = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 3,
                Grade = 6.00m
            };

            SixFour = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 4,
                Grade = 2.00m
            };

            SixFive = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 5,
                Grade = 2.00m
            };

            SixSix = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 6,
                Grade = 3.00m
            };

            SixSeven = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 7,
                Grade = 3.00m
            };

            SixEight = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 8,
                Grade = 4.00m
            };

            SixNine = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 9,
                Grade = 4.00m
            };

            SixTen = new StudentSubjectGrade()
            {
                StudentId = 6,
                SubjectId = 10,
                Grade = 4.00m
            };
            //7
            SevenOne = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 1,
                Grade = 6.00m
            };

            SevenTwo = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 2,
                Grade = 6.00m
            };

            SevenThree = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 3,
                Grade = 5.00m
            };

            SevenFour = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 4,
                Grade = 5.00m
            };

            SevenFive = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 5,
                Grade = 2.00m
            };

            SevenSix = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 6,
                Grade = 4.00m
            };

            SevenSeven = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 7,
                Grade = 5.00m
            };

            SevenEight = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 8,
                Grade = 5.00m
            };

            SevenNine = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 9,
                Grade = 4.00m
            };

            SevenTen = new StudentSubjectGrade()
            {
                StudentId = 7,
                SubjectId = 10,
                Grade = 6.00m
            };
            //8
            EightOne = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 1,
                Grade = 5.00m
            };

            EightTwo = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 2,
                Grade = 4.00m
            };

            EightThree = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 3,
                Grade = 6.00m
            };

            EightFour = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 4,
                Grade = 5.00m
            };

            EightFive = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 5,
                Grade = 3.00m
            };

            EightSix = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 6,
                Grade = 4.00m
            };

            EightSeven = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 7,
                Grade = 2.00m
            };

            EightEight = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 8,
                Grade = 5.00m
            };

            EightNine = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 9,
                Grade = 3.00m
            };

            EightTen = new StudentSubjectGrade()
            {
                StudentId = 8,
                SubjectId = 10,
                Grade = 4.00m
            };
            //9
            NineOne = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 1,
                Grade = 4.00m
            };

            NineTwo = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 2,
                Grade = 5.00m
            };

            NineThree = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 3,
                Grade = 6.00m
            };

            NineFour = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 4,
                Grade = 5.00m
            };

            NineFive = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 5,
                Grade = 3.00m
            };

            NineSix = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 6,
                Grade = 2.00m
            };

            NineSeven = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 7,
                Grade = 5.00m
            };

            NineEight = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 8,
                Grade = 6.00m
            };

            NineNine = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 9,
                Grade = 6.00m
            };

            NineTen = new StudentSubjectGrade()
            {
                StudentId = 9,
                SubjectId = 10,
                Grade = 4.00m
            };
            //10
            TenOne = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 1,
                Grade = 5.00m
            };

            TenTwo = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 2,
                Grade = 5.00m
            };

            TenThree = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 3,
                Grade = 6.00m
            };

            TenFour = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 4,
                Grade = 3.00m
            };

            TenFive = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 5,
                Grade = 4.00m
            };

            TenSix = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 6,
                Grade = 3.00m
            };

            TenSeven = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 7,
                Grade = 3.00m
            };

            TenEight = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 8,
                Grade = 6.00m
            };

            TenNine = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 9,
                Grade = 6.00m
            };

            TenTen = new StudentSubjectGrade()
            {
                StudentId = 10,
                SubjectId = 10,
                Grade = 5.00m
            };
            //11
            ElevenOne = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 1,
                Grade = 4.00m
            };

            ElevenTwo = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 2,
                Grade = 5.00m
            };

            ElevenThree = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 3,
                Grade = 6.00m
            };

            ElevenFour = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 4,
                Grade = 5.00m
            };

            ElevenFive = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 5,
                Grade = 5.00m
            };

            ElevenSix = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 6,
                Grade = 4.00m
            };

            ElevenSeven = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 7,
                Grade = 2.00m
            };

            ElevenEight = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 8,
                Grade = 2.00m
            };

            ElevenNine = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 9,
                Grade = 4.00m
            };

            ElevenTen = new StudentSubjectGrade()
            {
                StudentId = 11,
                SubjectId = 10,
                Grade = 4.00m
            };
            //12
            TwelveOne = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 1,
                Grade = 5.00m
            };

            TwelveTwo = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 2,
                Grade = 3.00m
            };

            TwelveThree = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 3,
                Grade = 3.00m
            };

            TwelveFour = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 4,
                Grade = 6.00m
            };

            TwelveFive = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 5,
                Grade = 5.00m
            };

            TwelveSix = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 6,
                Grade = 4.00m
            };

            TwelveSeven = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 7,
                Grade = 3.00m
            };

            TwelveEight = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 8,
                Grade = 4.00m
            };

            TwelveNine = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 9,
                Grade = 5.00m
            };

            TwelveTen = new StudentSubjectGrade()
            {
                StudentId = 12,
                SubjectId = 10,
                Grade = 6.00m
            };
            //13
            ThirteenOne = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 1,
                Grade = 6.00m
            };

            ThirteenTwo = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 2,
                Grade = 3.00m
            };

            ThirteenThree = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 3,
                Grade = 2.00m
            };

            ThirteenFour = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 4,
                Grade = 2.00m
            };

            ThirteenFive = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 5,
                Grade = 4.00m
            };

            ThirteenSix = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 6,
                Grade = 5.00m
            };

            ThirteenSeven = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 7,
                Grade = 4.00m
            };

            ThirteenEight = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 8,
                Grade = 4.00m
            };

            ThirteenNine = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 9,
                Grade = 6.00m
            };

            ThirteenTen = new StudentSubjectGrade()
            {
                StudentId = 13,
                SubjectId = 10,
                Grade = 6.00m
            };
            //14
            FourteenOne = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 1,
                Grade = 4.00m
            };

            FourteenTwo = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 2,
                Grade = 5.00m
            };

            FourteenThree = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 3,
                Grade = 4.00m
            };

            FourteenFour = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 4,
                Grade = 4.00m
            };

            FourteenFive = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 5,
                Grade = 3.00m
            };

            FourteenSix = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 6,
                Grade = 4.00m
            };

            FourteenSeven = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 7,
                Grade = 4.00m
            };

            FourteenEight = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 8,
                Grade = 5.00m
            };

            FourteenNine = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 9,
                Grade = 5.00m
            };

            FourteenTen = new StudentSubjectGrade()
            {
                StudentId = 14,
                SubjectId = 10,
                Grade = 6.00m
            };

            //15
            FifteenOne = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 1,
                Grade = 6.00m
            };

            FifteenTwo = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 2,
                Grade = 5.00m
            };

            FifteenThree = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 3,
                Grade = 6.00m
            };

            FifteenFour = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 4,
                Grade = 5.00m
            };

            FifteenFive = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 5,
                Grade = 2.00m
            };

            FifteenSix = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 6,
                Grade = 2.00m
            };

            FifteenSeven = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 7,
                Grade = 4.00m
            };

            FifteenEight = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 8,
                Grade = 4.00m
            };

            FifteenNine = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 9,
                Grade = 5.00m
            };

            FifteenTen = new StudentSubjectGrade()
            {
                StudentId = 15,
                SubjectId = 10,
                Grade = 2.00m
            };
            //16
            SixteenOne = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 1,
                Grade = 3.00m
            };

            SixteenTwo = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 2,
                Grade = 3.00m
            };

            SixteenThree = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 3,
                Grade = 6.00m
            };

            SixteenFour = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 4,
                Grade = 5.00m
            };

            SixteenFive = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 5,
                Grade = 6.00m
            };

            SixteenSix = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 6,
                Grade = 4.00m
            };

            SixteenSeven = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 7,
                Grade = 3.00m
            };

            SixteenEight = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 8,
                Grade = 3.00m
            };

            SixteenNine = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 9,
                Grade = 2.00m
            };

            SixteenTen = new StudentSubjectGrade()
            {
                StudentId = 16,
                SubjectId = 10,
                Grade = 5.00m
            };
            //17
            SeventeenOne = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 1,
                Grade = 6.00m
            };

            SeventeenTwo = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 2,
                Grade = 5.00m
            };

            SeventeenThree = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 3,
                Grade = 4.00m
            };

            SeventeenFour = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 4,
                Grade = 5.00m
            };

            SeventeenFive = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 5,
                Grade = 5.00m
            };

            SeventeenSix = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 6,
                Grade = 3.00m
            };

            SeventeenSeven = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 7,
                Grade = 2.00m
            };

            SeventeenEight = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 8,
                Grade = 4.00m
            };

            SeventeenNine = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 9,
                Grade = 4.00m
            };

            SeventeenTen = new StudentSubjectGrade()
            {
                StudentId = 17,
                SubjectId = 10,
                Grade = 6.00m
            };
            //18
            EighteenOne = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 1,
                Grade = 5.00m
            };

            EighteenTwo = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 2,
                Grade = 3.00m
            };

            EighteenThree = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 3,
                Grade = 2.00m
            };

            EighteenFour = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 4,
                Grade = 4.00m
            };

            EighteenFive = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 5,
                Grade = 5.00m
            };

            EighteenSix = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 6,
                Grade = 6.00m
            };

            EighteenSeven = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 7,
                Grade = 6.00m
            };

            EighteenEight = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 8,
                Grade = 4.00m
            };

            EighteenNine = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 9,
                Grade = 4.00m
            };

            EighteenTen = new StudentSubjectGrade()
            {
                StudentId = 18,
                SubjectId = 10,
                Grade = 3.00m
            };
            //19
            NineteenOne = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 1,
                Grade = 3.00m
            };

            NineteenTwo = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 2,
                Grade = 4.00m
            };

            NineteenThree = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 3,
                Grade = 5.00m
            };

            NineteenFour = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 4,
                Grade = 6.00m
            };

            NineteenFive = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 5,
                Grade = 5.00m
            };

            NineteenSix = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 6,
                Grade = 4.00m
            };

            NineteenSeven = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 7,
                Grade = 6.00m
            };

            NineteenEight = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 8,
                Grade = 6.00m
            };

            NineteenNine = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 9,
                Grade = 6.00m
            };

            NineteenTen = new StudentSubjectGrade()
            {
                StudentId = 19,
                SubjectId = 10,
                Grade = 4.00m
            };
            //20
            TwentyOne = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 1,
                Grade = 3.00m
            };
            TwentyTwo = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 2,
                Grade = 2.00m
            };

            TwentyThree = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 3,
                Grade = 4.00m
            };

            TwentyFour = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 4,
                Grade = 5.00m
            };

            TwentyFive = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 5,
                Grade = 6.00m
            };

            TwentySix = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 6,
                Grade = 5.00m
            };

            TwentySeven = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 7,
                Grade = 6.00m
            };

            TwentyEight = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 8,
                Grade = 5.00m
            };

            TwentyNine = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 9,
                Grade = 4.00m
            };
            TwentyTen = new StudentSubjectGrade()
            {
                StudentId = 20,
                SubjectId = 10,
                Grade = 6.00m
            };
            //21
            TwentyOneOne = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 1,
                Grade = 2.00m
            };

            TwentyOneTwo = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 2,
                Grade = 2.00m
            };

            TwentyOneThree = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 3,
                Grade = 4.00m
            };

            TwentyOneFour = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 4,
                Grade = 5.00m
            };

            TwentyOneFive = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 5,
                Grade = 6.00m
            };

            TwentyOneSix = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 6,
                Grade = 5.00m
            };

            TwentyOneSeven = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 7,
                Grade = 4.00m
            };

            TwentyOneEight = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 8,
                Grade = 3.00m
            };

            TwentyOneNine = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 9,
                Grade = 6.00m
            };

            TwentyOneTen = new StudentSubjectGrade()
            {
                StudentId = 21,
                SubjectId = 10,
                Grade = 6.00m
            };
            //22
            TwentyTwoOne = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 1,
                Grade = 5.00m
            };

            TwentyTwoTwo = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 2,
                Grade = 4.00m
            };

            TwentyTwoThree = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 3,
                Grade = 4.00m
            };

            TwentyTwoFour = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 4,
                Grade = 2.00m
            };

            TwentyTwoFive = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 5,
                Grade = 2.00m
            };

            TwentyTwoSix = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 6,
                Grade = 2.00m
            };

            TwentyTwoSeven = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 7,
                Grade = 4.00m
            };

            TwentyTwoEight = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 8,
                Grade = 5.00m
            };

            TwentyTwoNine = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 9,
                Grade = 5.00m
            };

            TwentyTwoTen = new StudentSubjectGrade()
            {
                StudentId = 22,
                SubjectId = 10,
                Grade = 4.00m
            };
            //23
            TwentyThreeOne = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 1,
                Grade = 3.00m
            };
            TwentyThreeTwo = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 2,
                Grade = 2.00m
            };

            TwentyThreeThree = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 3,
                Grade = 3.00m
            };

            TwentyThreeFour = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 4,
                Grade = 4.00m
            };

            TwentyThreeFive = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 5,
                Grade = 5.00m
            };

            TwentyThreeSix = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 6,
                Grade = 5.00m
            };

            TwentyThreeSeven = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 7,
                Grade = 5.00m
            };

            TwentyThreeEight = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 8,
                Grade = 6.00m
            };

            TwentyThreeNine = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 9,
                Grade = 5.00m
            };

            TwentyThreeTen = new StudentSubjectGrade()
            {
                StudentId = 23,
                SubjectId = 10,
                Grade = 6.00m
            };
            //24
            TwentyFourOne = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 1,
                Grade = 6.00m
            };

            TwentyFourTwo = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 2,
                Grade = 5.00m
            };
            TwentyFourThree = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 3,
                Grade = 5.00m
            };

            TwentyFourFour = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 4,
                Grade = 6.00m
            };

            TwentyFourFive = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 5,
                Grade = 4.00m
            };

            TwentyFourSix = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 6,
                Grade = 3.00m
            };

            TwentyFourSeven = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 7,
                Grade = 6.00m
            };

            TwentyFourEight = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 8,
                Grade = 5.00m
            };

            TwentyFourNine = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 9,
                Grade = 5.00m
            };

            TwentyFourTen = new StudentSubjectGrade()
            {
                StudentId = 24,
                SubjectId = 10,
                Grade = 6.00m
            };
            //25
            TwentyFiveOne = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 1,
                Grade = 4.00m
            };

            TwentyFiveTwo = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 2,
                Grade = 3.00m
            };

            TwentyFiveThree = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 3,
                Grade = 5.00m
            };

            TwentyFiveFour = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 4,
                Grade = 4.00m
            };

            TwentyFiveFive = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 5,
                Grade = 3.00m
            };

            TwentyFiveSix = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 6,
                Grade = 6.00m
            };

            TwentyFiveSeven = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 7,
                Grade = 4.00m
            };

            TwentyFiveEight = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 8,
                Grade = 3.00m
            };

            TwentyFiveNine = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 9,
                Grade = 2.00m
            };

            TwentyFiveTen = new StudentSubjectGrade()
            {
                StudentId = 25,
                SubjectId = 10,
                Grade = 2.00m
            };

            //26
            TwentySixOne = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 1,
                Grade = 4.00m
            };

            TwentySixTwo = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 2,
                Grade = 2.00m
            };

            TwentySixThree = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 3,
                Grade = 5.00m
            };

            TwentySixFour = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 4,
                Grade = 2.00m
            };

            TwentySixFive = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 5,
                Grade = 2.00m
            };

            TwentySixSix = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 6,
                Grade = 6.00m
            };

            TwentySixSeven = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 7,
                Grade = 5.00m
            };

            TwentySixEight = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 8,
                Grade = 4.00m
            };

            TwentySixNine = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 9,
                Grade = 4.00m
            };

            TwentySixTen = new StudentSubjectGrade()
            {
                StudentId = 26,
                SubjectId = 10,
                Grade = 6.00m
            };

            //27
            TwentySevenOne = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 1,
                Grade = 6.00m
            };

            TwentySevenTwo = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 2,
                Grade = 5.00m
            };

            TwentySevenThree = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 3,
                Grade = 4.00m
            };

            TwentySevenFour = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 4,
                Grade = 6.00m
            };

            TwentySevenFive = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 5,
                Grade = 6.00m
            };

            TwentySevenSix = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 6,
                Grade = 4.00m
            };

            TwentySevenSeven = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 7,
                Grade = 3.00m
            };

            TwentySevenEight = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 8,
                Grade = 2.00m
            };

            TwentySevenNine = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 9,
                Grade = 5.00m
            };

            TwentySevenTen = new StudentSubjectGrade()
            {
                StudentId = 27,
                SubjectId = 10,
                Grade = 4.00m
            };
            //28
            TwentyEightOne = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 1,
                Grade = 6.00m
            };

            TwentyEightTwo = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 2,
                Grade = 4.00m
            };

            TwentyEightThree = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 3,
                Grade = 3.00m
            };

            TwentyEightFour = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 4,
                Grade = 2.00m
            };

            TwentyEightFive = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 5,
                Grade = 4.00m
            };

            TwentyEightSix = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 6,
                Grade = 5.00m
            };

            TwentyEightSeven = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 7,
                Grade = 6.00m
            };

            TwentyEightEight = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 8,
                Grade = 4.00m
            };

            TwentyEightNine = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 9,
                Grade = 3.00m
            };

            TwentyEightTen = new StudentSubjectGrade()
            {
                StudentId = 28,
                SubjectId = 10,
                Grade = 2.00m
            };
            //29
            TwentyNineOne = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 1,
                Grade = 5.00m
            };

            TwentyNineTwo = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 2,
                Grade = 6.00m
            };

            TwentyNineThree = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 3,
                Grade = 4.00m
            };

            TwentyNineFour = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 4,
                Grade = 5.00m
            };

            TwentyNineFive = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 5,
                Grade = 3.00m
            };

            TwentyNineSix = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 6,
                Grade = 4.00m
            };

            TwentyNineSeven = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 7,
                Grade = 5.00m
            };

            TwentyNineEight = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 8,
                Grade = 6.00m
            };

            TwentyNineNine = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 9,
                Grade = 5.00m
            };

            TwentyNineTen = new StudentSubjectGrade()
            {
                StudentId = 29,
                SubjectId = 10,
                Grade = 4.00m
            };
            //30
            ThirtyOne = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 1,
                Grade = 3.00m
            };

            ThirtyTwo = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 2,
                Grade = 3.00m
            };

            ThirtyThree = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 3,
                Grade = 5.00m
            };

            ThirtyFour = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 4,
                Grade = 4.00m
            };

            ThirtyFive = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 5,
                Grade = 2.00m
            };

            ThirtySix = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 6,
                Grade = 2.00m
            };

            ThirtySeven = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 7,
                Grade = 5.00m
            };

            ThirtyEight = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 8,
                Grade = 6.00m
            };

            ThirtyNine = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 9,
                Grade = 4.00m
            };

            ThirtyTen = new StudentSubjectGrade()
            {
                StudentId = 30,
                SubjectId = 10,
                Grade = 3.00m
            };
            //31
            ThirtyOneOne = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 1,
                Grade = 2.00m
            };

            ThirtyOneTwo = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 2,
                Grade = 2.00m
            };

            ThirtyOneThree = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 3,
                Grade = 4.00m
            };

            ThirtyOneFour = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 4,
                Grade = 5.00m
            };

            ThirtyOneFive = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 5,
                Grade = 6.00m
            };

            ThirtyOneSix = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 6,
                Grade = 5.00m
            };

            ThirtyOneSeven = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 7,
                Grade = 4.00m
            };

            ThirtyOneEight = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 8,
                Grade = 3.00m
            };

            ThirtyOneNine = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 9,
                Grade = 2.00m
            };

            ThirtyOneTen = new StudentSubjectGrade()
            {
                StudentId = 31,
                SubjectId = 10,
                Grade = 3.00m
            };
            //32
            ThirtyTwoOne = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 1,
                Grade = 4.00m
            };
            ThirtyTwoTwo = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 2,
                Grade = 5.00m
            };

            ThirtyTwoThree = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 3,
                Grade = 6.00m
            };

            ThirtyTwoFour = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 4,
                Grade = 6.00m
            };

            ThirtyTwoFive = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 5,
                Grade = 5.00m
            };

            ThirtyTwoSix = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 6,
                Grade = 4.00m
            };

            ThirtyTwoSeven = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 7,
                Grade = 3.00m
            };

            ThirtyTwoEight = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 8,
                Grade = 2.00m
            };

            ThirtyTwoNine = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 9,
                Grade = 4.00m
            };

            ThirtyTwoTen = new StudentSubjectGrade()
            {
                StudentId = 32,
                SubjectId = 10,
                Grade = 5.00m
            };
            //33
            ThirtyThreeOne = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 1,
                Grade = 4.00m
            };

            ThirtyThreeTwo = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 2,
                Grade = 5.00m
            };

            ThirtyThreeThree = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 3,
                Grade = 4.00m
            };

            ThirtyThreeFour = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 4,
                Grade = 3.00m
            };

            ThirtyThreeFive = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 5,
                Grade = 3.00m
            };

            ThirtyThreeSix = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 6,
                Grade = 6.00m
            };

            ThirtyThreeSeven = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 7,
                Grade = 6.00m
            };

            ThirtyThreeEight = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 8,
                Grade = 5.00m
            };

            ThirtyThreeNine = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 9,
                Grade = 2.00m
            };

            ThirtyThreeTen = new StudentSubjectGrade()
            {
                StudentId = 33,
                SubjectId = 10,
                Grade = 2.00m
            };
            //34
            ThirtyFourOne = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 1,
                Grade = 5.00m
            };

            ThirtyFourTwo = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 2,
                Grade = 4.00m
            };

            ThirtyFourThree = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 3,
                Grade = 4.00m
            };

            ThirtyFourFour = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 4,
                Grade = 6.00m
            };

            ThirtyFourFive = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 5,
                Grade = 6.00m
            };

            ThirtyFourSix = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 6,
                Grade = 3.00m
            };

            ThirtyFourSeven = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 7,
                Grade = 3.00m
            };

            ThirtyFourEight = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 8,
                Grade = 3.00m
            };

            ThirtyFourNine = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 9,
                Grade = 5.00m
            };

            ThirtyFourTen = new StudentSubjectGrade()
            {
                StudentId = 34,
                SubjectId = 10,
                Grade = 2.00m
            };

            //35
            ThirtyFiveOne = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 1,
                Grade = 2.00m
            };

            ThirtyFiveTwo = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 2,
                Grade = 2.00m
            };

            ThirtyFiveThree = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 3,
                Grade = 4.00m
            };

            ThirtyFiveFour = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 4,
                Grade = 5.00m
            };

            ThirtyFiveFive = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 5,
                Grade = 6.00m
            };

            ThirtyFiveSix = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 6,
                Grade = 5.00m
            };

            ThirtyFiveSeven = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 7,
                Grade = 4.00m
            };

            ThirtyFiveEight = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 8,
                Grade = 3.00m
            };

            ThirtyFiveNine = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 9,
                Grade = 6.00m
            };

            ThirtyFiveTen = new StudentSubjectGrade()
            {
                StudentId = 35,
                SubjectId = 10,
                Grade = 6.00m
            };
            //36
            ThirtySixOne = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 1,
                Grade = 6.00m
            };

            ThirtySixTwo = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 2,
                Grade = 3.00m
            };

            ThirtySixThree = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 3,
                Grade = 3.00m
            };

            ThirtySixFour = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 4,
                Grade = 5.00m
            };

            ThirtySixFive = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 5,
                Grade = 4.00m
            };

            ThirtySixSix = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 6,
                Grade = 6.00m
            };

            ThirtySixSeven = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 7,
                Grade = 4.00m
            };

            ThirtySixEight = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 8,
                Grade = 3.00m
            };

            ThirtySixNine = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 9,
                Grade = 2.00m
            };

            ThirtySixTen = new StudentSubjectGrade()
            {
                StudentId = 36,
                SubjectId = 10,
                Grade = 5.00m
            };

            //37
            ThirtySevenOne = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 1,
                Grade = 5.00m
            };

            ThirtySevenTwo = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 2,
                Grade = 6.00m
            };

            ThirtySevenThree = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 3,
                Grade = 4.00m
            };

            ThirtySevenFour = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 4,
                Grade = 3.00m
            };

            ThirtySevenFive = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 5,
                Grade = 2.00m
            };

            ThirtySevenSix = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 6,
                Grade = 2.00m
            };

            ThirtySevenSeven = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 7,
                Grade = 4.00m
            };

            ThirtySevenEight = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 8,
                Grade = 5.00m
            };

            ThirtySevenNine = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 9,
                Grade = 3.00m
            };

            ThirtySevenTen = new StudentSubjectGrade()
            {
                StudentId = 37,
                SubjectId = 10,
                Grade = 3.00m
            };
            //38
            ThirtyEightOne = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 1,
                Grade = 3.00m
            };

            ThirtyEightTwo = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 2,
                Grade = 6.00m
            };

            ThirtyEightThree = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 3,
                Grade = 5.00m
            };

            ThirtyEightFour = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 4,
                Grade = 3.00m
            };

            ThirtyEightFive = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 5,
                Grade = 3.00m
            };

            ThirtyEightSix = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 6,
                Grade = 4.00m
            };

            ThirtyEightSeven = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 7,
                Grade = 4.00m
            };

            ThirtyEightEight = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 8,
                Grade = 5.00m
            };

            ThirtyEightNine = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 9,
                Grade = 3.00m
            };

            ThirtyEightTen = new StudentSubjectGrade()
            {
                StudentId = 38,
                SubjectId = 10,
                Grade = 3.00m
            };

            //39
            ThirtyNineOne = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 1,
                Grade = 3.00m
            };

            ThirtyNineTwo = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 2,
                Grade = 5.00m
            };

            ThirtyNineThree = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 3,
                Grade = 6.00m
            };

            ThirtyNineFour = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 4,
                Grade = 2.00m
            };

            ThirtyNineFive = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 5,
                Grade = 2.00m
            };

            ThirtyNineSix = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 6,
                Grade = 2.00m
            };

            ThirtyNineSeven = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 7,
                Grade = 5.00m
            };

            ThirtyNineEight = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 8,
                Grade = 4.00m
            };

            ThirtyNineNine = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 9,
                Grade = 3.00m
            };

            ThirtyNineTen = new StudentSubjectGrade()
            {
                StudentId = 39,
                SubjectId = 10,
                Grade = 4.00m
            };
            //40
            FortyOne = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 1,
                Grade = 5.00m
            };

            FortyTwo = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 2,
                Grade = 6.00m
            };

            FortyThree = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 3,
                Grade = 6.00m
            };

            FortyFour = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 4,
                Grade = 5.00m
            };

            FortyFive = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 5,
                Grade = 4.00m
            };

            FortySix = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 6,
                Grade = 4.00m
            };

            FortySeven = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 7,
                Grade = 5.00m
            };

            FortyEight = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 8,
                Grade = 5.00m
            };

            FortyNine = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 9,
                Grade = 6.00m
            };

            FortyTen = new StudentSubjectGrade()
            {
                StudentId = 40,
                SubjectId = 10,
                Grade = 6.00m
            };
            //41
            FortyOneOne = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 1,
                Grade = 5.00m
            };

            FortyOneTwo = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 2,
                Grade = 4.00m
            };

            FortyOneThree = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 3,
                Grade = 4.00m
            };

            FortyOneFour = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 4,
                Grade = 3.00m
            };

            FortyOneFive = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 5,
                Grade = 4.00m
            };

            FortyOneSix = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 6,
                Grade = 5.00m
            };

            FortyOneSeven = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 7,
                Grade = 6.00m
            };

            FortyOneEight = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 8,
                Grade = 5.00m
            };

            FortyOneNine = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 9,
                Grade = 4.00m
            };

            FortyOneTen = new StudentSubjectGrade()
            {
                StudentId = 41,
                SubjectId = 10,
                Grade = 4.00m
            };
            //42
            FortyTwoOne = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 1,
                Grade = 5.00m
            };

            FortyTwoTwo = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 2,
                Grade = 4.00m
            };

            FortyTwoThree = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 3,
                Grade = 4.00m
            };

            FortyTwoFour = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 4,
                Grade = 3.00m
            };

            FortyTwoFive = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 5,
                Grade = 4.00m
            };

            FortyTwoSix = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 6,
                Grade = 5.00m
            };

            FortyTwoSeven = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 7,
                Grade = 6.00m
            };

            FortyTwoEight = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 8,
                Grade = 5.00m
            };

            FortyTwoNine = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 9,
                Grade = 4.00m
            };

            FortyTwoTen = new StudentSubjectGrade()
            {
                StudentId = 42,
                SubjectId = 10,
                Grade = 4.00m
            };
            //43
            FortyThreeOne = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 1,
                Grade = 5.00m
            };

            FortyThreeTwo = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 2,
                Grade = 4.00m
            };

            FortyThreeThree = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 3,
                Grade = 3.00m
            };

            FortyThreeFour = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 4,
                Grade = 4.00m
            };

            FortyThreeFive = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 5,
                Grade = 5.00m
            };

            FortyThreeSix = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 6,
                Grade = 6.00m
            };

            FortyThreeSeven = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 7,
                Grade = 6.00m
            };

            FortyThreeEight = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 8,
                Grade = 6.00m
            };

            FortyThreeNine = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 9,
                Grade = 5.00m
            };

            FortyThreeTen = new StudentSubjectGrade()
            {
                StudentId = 43,
                SubjectId = 10,
                Grade = 4.00m
            };

            //44
            FortyFourOne = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 1,
                Grade = 2.00m
            };

            FortyFourTwo = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 2,
                Grade = 2.00m
            };

            FortyFourThree = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 3,
                Grade = 2.00m
            };

            FortyFourFour = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 4,
                Grade = 4.00m
            };

            FortyFourFive = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 5,
                Grade = 5.00m
            };

            FortyFourSix = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 6,
                Grade = 6.00m
            };

            FortyFourSeven = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 7,
                Grade = 4.00m
            };

            FortyFourEight = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 8,
                Grade = 3.00m
            };

            FortyFourNine = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 9,
                Grade = 4.00m
            };

            FortyFourTen = new StudentSubjectGrade()
            {
                StudentId = 44,
                SubjectId = 10,
                Grade = 5.00m
            };
            //45
            FortyFiveOne = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 1,
                Grade = 6.00m
            };

            FortyFiveTwo = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 2,
                Grade = 4.00m
            };

            FortyFiveThree = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 3,
                Grade = 4.00m
            };

            FortyFiveFour = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 4,
                Grade = 4.00m
            };

            FortyFiveFive = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 5,
                Grade = 3.00m
            };

            FortyFiveSix = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 6,
                Grade = 3.00m
            };

            FortyFiveSeven = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 7,
                Grade = 5.00m
            };

            FortyFiveEight = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 8,
                Grade = 5.00m
            };

            FortyFiveNine = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 9,
                Grade = 3.00m
            };

            FortyFiveTen = new StudentSubjectGrade()
            {
                StudentId = 45,
                SubjectId = 10,
                Grade = 3.00m
            };

            //46
            FortySixOne = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 1,
                Grade = 3.00m
            };

            FortySixTwo = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 2,
                Grade = 2.00m
            };

            FortySixThree = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 3,
                Grade = 4.00m
            };

            FortySixFour = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 4,
                Grade = 5.00m
            };

            FortySixFive = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 5,
                Grade = 5.00m
            };

            FortySixSix = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 6,
                Grade = 6.00m
            };

            FortySixSeven = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 7,
                Grade = 6.00m
            };

            FortySixEight = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 8,
                Grade = 6.00m
            };

            FortySixNine = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 9,
                Grade = 5.00m
            };

            FortySixTen = new StudentSubjectGrade()
            {
                StudentId = 46,
                SubjectId = 10,
                Grade = 4.00m
            };

            //47
            FortySevenOne = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 1,
                Grade = 3.00m
            };

            FortySevenTwo = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 2,
                Grade = 3.00m
            };

            FortySevenThree = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 3,
                Grade = 6.00m
            };

            FortySevenFour = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 4,
                Grade = 6.00m
            };

            FortySevenFive = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 5,
                Grade = 4.00m
            };

            FortySevenSix = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 6,
                Grade = 4.00m
            };

            FortySevenSeven = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 7,
                Grade = 5.00m
            };

            FortySevenEight = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 8,
                Grade = 5.00m
            };

            FortySevenNine = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 9,
                Grade = 6.00m
            };

            FortySevenTen = new StudentSubjectGrade()
            {
                StudentId = 47,
                SubjectId = 10,
                Grade = 6.00m
            };
            //48
            FortyEightOne = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 1,
                Grade = 3.00m
            };

            FortyEightTwo = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 2,
                Grade = 3.00m
            };

            FortyEightThree = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 3,
                Grade = 2.00m
            };

            FortyEightFour = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 4,
                Grade = 6.00m
            };

            FortyEightFive = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 5,
                Grade = 6.00m
            };

            FortyEightSix = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 6,
                Grade = 6.00m
            };

            FortyEightSeven = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 7,
                Grade = 3.00m
            };

            FortyEightEight = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 8,
                Grade = 3.00m
            };

            FortyEightNine = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 9,
                Grade = 3.00m
            };

            FortyEightTen = new StudentSubjectGrade()
            {
                StudentId = 48,
                SubjectId = 10,
                Grade = 5.00m
            };
            //49
            FortyNineOne = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 1,
                Grade = 5.00m
            };

            FortyNineTwo = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 2,
                Grade = 5.00m
            };

            FortyNineThree = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 3,
                Grade = 4.00m
            };

            FortyNineFour = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 4,
                Grade = 4.00m
            };

            FortyNineFive = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 5,
                Grade = 6.00m
            };

            FortyNineSix = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 6,
                Grade = 6.00m
            };

            FortyNineSeven = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 7,
                Grade = 4.00m
            };

            FortyNineEight = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 8,
                Grade = 6.00m
            };

            FortyNineNine = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 9,
                Grade = 4.00m
            };

            FortyNineTen = new StudentSubjectGrade()
            {
                StudentId = 49,
                SubjectId = 10,
                Grade = 6.00m
            };
            //50
            FiftyOne = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 1,
                Grade = 3.00m
            };

            FiftyTwo = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 2,
                Grade = 3.00m
            };

            FiftyThree = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 3,
                Grade = 2.00m
            };

            FiftyFour = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 4,
                Grade = 4.00m
            };

            FiftyFive = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 5,
                Grade = 5.00m
            };

            FiftySix = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 6,
                Grade = 6.00m
            };

            FiftySeven = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 7,
                Grade = 4.00m
            };

            FiftyEight = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 8,
                Grade = 4.00m
            };

            FiftyNine = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 9,
                Grade = 5.00m
            };

            FiftyTen = new StudentSubjectGrade()
            {
                StudentId = 50,
                SubjectId = 10,
                Grade = 3.00m
            };
            //51
            FiftyOneOne = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 1,
                Grade = 3.00m
            };

            FiftyOneTwo = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 2,
                Grade = 5.00m
            };

            FiftyOneThree = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 3,
                Grade = 3.00m
            };

            FiftyOneFour = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 4,
                Grade = 2.00m
            };

            FiftyOneFive = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 5,
                Grade = 5.00m
            };

            FiftyOneSix = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 6,
                Grade = 3.00m
            };

            FiftyOneSeven = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 7,
                Grade = 4.00m
            };

            FiftyOneEight = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 8,
                Grade = 4.00m
            };

            FiftyOneNine = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 9,
                Grade = 3.00m
            };

            FiftyOneTen = new StudentSubjectGrade()
            {
                StudentId = 51,
                SubjectId = 10,
                Grade = 2.00m
            };
            //52
            FiftyTwoOne = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 1,
                Grade = 3.00m
            };

            FiftyTwoTwo = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 2,
                Grade = 4.00m
            };

            FiftyTwoThree = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 3,
                Grade = 5.00m
            };

            FiftyTwoFour = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 4,
                Grade = 6.00m
            };

            FiftyTwoFive = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 5,
                Grade = 5.00m
            };

            FiftyTwoSix = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 6,
                Grade = 4.00m
            };

            FiftyTwoSeven = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 7,
                Grade = 5.00m
            };

            FiftyTwoEight = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 8,
                Grade = 6.00m
            };

            FiftyTwoNine = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 9,
                Grade = 4.00m
            };

            FiftyTwoTen = new StudentSubjectGrade()
            {
                StudentId = 52,
                SubjectId = 10,
                Grade = 3.00m
            };

            //53
            FiftyThreeOne = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 1,
                Grade = 3.00m
            };

            FiftyThreeTwo = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 2,
                Grade = 5.00m
            };

            FiftyThreeThree = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 3,
                Grade = 3.00m
            };

            FiftyThreeFour = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 4,
                Grade = 2.00m
            };

            FiftyThreeFive = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 5,
                Grade = 5.00m
            };

            FiftyThreeSix = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 6,
                Grade = 3.00m
            };

            FiftyThreeSeven = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 7,
                Grade = 4.00m
            };

            FiftyThreeEight = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 8,
                Grade = 4.00m
            };

            FiftyThreeNine = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 9,
                Grade = 3.00m
            };

            FiftyThreeTen = new StudentSubjectGrade()
            {
                StudentId = 53,
                SubjectId = 10,
                Grade = 2.00m
            };
            //54
            FiftyFourOne = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 1,
                Grade = 6.00m
            };

            FiftyFourTwo = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 2,
                Grade = 6.00m
            };

            FiftyFourThree = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 3,
                Grade = 5.00m
            };

            FiftyFourFour = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 4,
                Grade = 4.00m
            };

            FiftyFourFive = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 5,
                Grade = 5.00m
            };

            FiftyFourSix = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 6,
                Grade = 3.00m
            };

            FiftyFourSeven = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 7,
                Grade = 4.00m
            };

            FiftyFourEight = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 8,
                Grade = 3.00m
            };

            FiftyFourNine = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 9,
                Grade = 2.00m
            };

            FiftyFourTen = new StudentSubjectGrade()
            {
                StudentId = 54,
                SubjectId = 10,
                Grade = 2.00m
            };
            //55
            FiftyFiveOne = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 1,
                Grade = 4.00m
            };

            FiftyFiveTwo = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 2,
                Grade = 5.00m
            };

            FiftyFiveThree = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 3,
                Grade = 3.00m
            };

            FiftyFiveFour = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 4,
                Grade = 4.00m
            };

            FiftyFiveFive = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 5,
                Grade = 3.00m
            };

            FiftyFiveSix = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 6,
                Grade = 2.00m
            };

            FiftyFiveSeven = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 7,
                Grade = 2.00m
            };

            FiftyFiveEight = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 8,
                Grade = 4.00m
            };

            FiftyFiveNine = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 9,
                Grade = 5.00m
            };

            FiftyFiveTen = new StudentSubjectGrade()
            {
                StudentId = 55,
                SubjectId = 10,
                Grade = 4.00m
            };
            //56
            FiftySixOne = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 1,
                Grade = 6.00m
            };

            FiftySixTwo = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 2,
                Grade = 6.00m
            };

            FiftySixThree = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 3,
                Grade = 4.00m
            };

            FiftySixFour = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 4,
                Grade = 5.00m
            };

            FiftySixFive = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 5,
                Grade = 6.00m
            };

            FiftySixSix = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 6,
                Grade = 2.00m
            };

            FiftySixSeven = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 7,
                Grade = 3.00m
            };

            FiftySixEight = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 8,
                Grade = 4.00m
            };

            FiftySixNine = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 9,
                Grade = 5.00m
            };

            FiftySixTen = new StudentSubjectGrade()
            {
                StudentId = 56,
                SubjectId = 10,
                Grade = 4.00m
            };
            //57
            FiftySevenOne = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 1,
                Grade = 3.00m
            };

            FiftySevenTwo = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 2,
                Grade = 4.00m
            };

            FiftySevenThree = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 3,
                Grade = 5.00m
            };

            FiftySevenFour = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 4,
                Grade = 4.00m
            };

            FiftySevenFive = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 5,
                Grade = 3.00m
            };

            FiftySevenSix = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 6,
                Grade = 2.00m
            };

            FiftySevenSeven = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 7,
                Grade = 4.00m
            };

            FiftySevenEight = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 8,
                Grade = 5.00m
            };

            FiftySevenNine = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 9,
                Grade = 4.00m
            };

            FiftySevenTen = new StudentSubjectGrade()
            {
                StudentId = 57,
                SubjectId = 10,
                Grade = 3.00m
            };
            //58
            FiftyEightOne = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 1,
                Grade = 5.00m
            };

            FiftyEightTwo = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 2,
                Grade = 3.00m
            };

            FiftyEightThree = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 3,
                Grade = 4.00m
            };

            FiftyEightFour = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 4,
                Grade = 6.00m
            };

            FiftyEightFive = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 5,
                Grade = 5.00m
            };

            FiftyEightSix = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 6,
                Grade = 4.00m
            };

            FiftyEightSeven = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 7,
                Grade = 2.00m
            };

            FiftyEightEight = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 8,
                Grade = 3.00m
            };

            FiftyEightNine = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 9,
                Grade = 4.00m
            };

            FiftyEightTen = new StudentSubjectGrade()
            {
                StudentId = 58,
                SubjectId = 10,
                Grade = 2.00m
            };
            //59
            FiftyNineOne = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 1,
                Grade = 5.00m
            };

            FiftyNineTwo = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 2,
                Grade = 6.00m
            };

            FiftyNineThree = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 3,
                Grade = 4.00m
            };

            FiftyNineFour = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 4,
                Grade = 3.00m
            };

            FiftyNineFive = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 5,
                Grade = 5.00m
            };

            FiftyNineSix = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 6,
                Grade = 6.00m
            };

            FiftyNineSeven = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 7,
                Grade = 4.00m
            };

            FiftyNineEight = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 8,
                Grade = 3.00m
            };

            FiftyNineNine = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 9,
                Grade = 2.00m
            };

            FiftyNineTen = new StudentSubjectGrade()
            {
                StudentId = 59,
                SubjectId = 10,
                Grade = 4.00m
            };

            //60
            SixtyOne = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 1,
                Grade = 3.00m
            };

            SixtyTwo = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 2,
                Grade = 5.00m
            };

            SixtyThree = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 3,
                Grade = 6.00m
            };

            SixtyFour = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 4,
                Grade = 4.00m
            };

            SixtyFive = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 5,
                Grade = 3.00m
            };

            SixtySix = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 6,
                Grade = 2.00m
            };

            SixtySeven = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 7,
                Grade = 5.00m
            };

            SixtyEight = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 8,
                Grade = 5.00m
            };

            SixtyNine = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 9,
                Grade = 6.00m
            };

            SixtyTen = new StudentSubjectGrade()
            {
                StudentId = 60,
                SubjectId = 10,
                Grade = 4.00m
            };
            //61
            SixtyOneOne = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 1,
                Grade = 3.00m
            };

            SixtyOneTwo = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 2,
                Grade = 6.00m
            };

            SixtyOneThree = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 3,
                Grade = 6.00m
            };

            SixtyOneFour = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 4,
                Grade = 5.00m
            };

            SixtyOneFive = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 5,
                Grade = 4.00m
            };

            SixtyOneSix = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 6,
                Grade = 3.00m
            };

            SixtyOneSeven = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 7,
                Grade = 5.00m
            };

            SixtyOneEight = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 8,
                Grade = 5.00m
            };

            SixtyOneNine = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 9,
                Grade = 6.00m
            };

            SixtyOneTen = new StudentSubjectGrade()
            {
                StudentId = 61,
                SubjectId = 10,
                Grade = 6.00m
            };

            //62
            SixtyTwoOne = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 1,
                Grade = 6.00m
            };

            SixtyTwoTwo = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 2,
                Grade = 4.00m
            };

            SixtyTwoThree = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 3,
                Grade = 6.00m
            };

            SixtyTwoFour = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 4,
                Grade = 6.00m
            };

            SixtyTwoFive = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 5,
                Grade = 5.00m
            };

            SixtyTwoSix = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 6,
                Grade = 4.00m
            };

            SixtyTwoSeven = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 7,
                Grade = 6.00m
            };

            SixtyTwoEight = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 8,
                Grade = 6.00m
            };

            SixtyTwoNine = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 9,
                Grade = 6.00m
            };

            SixtyTwoTen = new StudentSubjectGrade()
            {
                StudentId = 62,
                SubjectId = 10,
                Grade = 4.00m
            };

            //63
            SixtyThreeOne = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 1,
                Grade = 3.00m
            };

            SixtyThreeTwo = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 2,
                Grade = 4.00m
            };

            SixtyThreeThree = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 3,
                Grade = 5.00m
            };

            SixtyThreeFour = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 4,
                Grade = 6.00m
            };

            SixtyThreeFive = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 5,
                Grade = 3.00m
            };

            SixtyThreeSix = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 6,
                Grade = 2.00m
            };

            SixtyThreeSeven = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 7,
                Grade = 2.00m
            };

            SixtyThreeEight = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 8,
                Grade = 4.00m
            };

            SixtyThreeNine = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 9,
                Grade = 5.00m
            };

            SixtyThreeTen = new StudentSubjectGrade()
            {
                StudentId = 63,
                SubjectId = 10,
                Grade = 6.00m
            };
            //64
            SixtyFourOne = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 1,
                Grade = 4.00m
            };

            SixtyFourTwo = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 2,
                Grade = 3.00m
            };

            SixtyFourThree = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 3,
                Grade = 5.00m
            };

            SixtyFourFour = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 4,
                Grade = 6.00m
            };

            SixtyFourFive = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 5,
                Grade = 2.00m
            };

            SixtyFourSix = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 6,
                Grade = 2.00m
            };

            SixtyFourSeven = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 7,
                Grade = 2.00m
            };

            SixtyFourEight = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 8,
                Grade = 4.00m
            };

            SixtyFourNine = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 9,
                Grade = 2.00m
            };

            SixtyFourTen = new StudentSubjectGrade()
            {
                StudentId = 64,
                SubjectId = 10,
                Grade = 3.00m
            };
            //65
            SixtyFiveOne = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 1,
                Grade = 3.00m
            };

            SixtyFiveTwo = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 2,
                Grade = 5.00m
            };

            SixtyFiveThree = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 3,
                Grade = 3.00m
            };

            SixtyFiveFour = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 4,
                Grade = 6.00m
            };

            SixtyFiveFive = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 5,
                Grade = 4.00m
            };

            SixtyFiveSix = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 6,
                Grade = 3.00m
            };

            SixtyFiveSeven = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 7,
                Grade = 2.00m
            };

            SixtyFiveEight = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 8,
                Grade = 5.00m
            };

            SixtyFiveNine = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 9,
                Grade = 3.00m
            };

            SixtyFiveTen = new StudentSubjectGrade()
            {
                StudentId = 65,
                SubjectId = 10,
                Grade = 2.00m
            };
            //66
            SixtySixOne = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 1,
                Grade = 4.00m
            };
            SixtySixTwo = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 2,
                Grade = 5.00m
            };

            SixtySixThree = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 3,
                Grade = 6.00m
            };

            SixtySixFour = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 4,
                Grade = 3.00m
            };

            SixtySixFive = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 5,
                Grade = 6.00m
            };

            SixtySixSix = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 6,
                Grade = 4.00m
            };

            SixtySixSeven = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 7,
                Grade = 3.00m
            };

            SixtySixEight = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 8,
                Grade = 5.00m
            };

            SixtySixNine = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 9,
                Grade = 3.00m
            };

            SixtySixTen = new StudentSubjectGrade()
            {
                StudentId = 66,
                SubjectId = 10,
                Grade = 2.00m
            };
            //67
            SixtySevenOne = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 1,
                Grade = 4.00m
            };

            SixtySevenTwo = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 2,
                Grade = 5.00m
            };

            SixtySevenThree = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 3,
                Grade = 6.00m
            };

            SixtySevenFour = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 4,
                Grade = 3.00m
            };

            SixtySevenFive = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 5,
                Grade = 4.00m
            };

            SixtySevenSix = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 6,
                Grade = 5.00m
            };

            SixtySevenSeven = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 7,
                Grade = 6.00m
            };

            SixtySevenEight = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 8,
                Grade = 3.00m
            };

            SixtySevenNine = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 9,
                Grade = 4.00m
            };

            SixtySevenTen = new StudentSubjectGrade()
            {
                StudentId = 67,
                SubjectId = 10,
                Grade = 5.00m
            };
            //68
            SixtyEightOne = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 1,
                Grade = 2.00m
            };
            SixtyEightTwo = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 2,
                Grade = 3.00m
            };

            SixtyEightThree = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 3,
                Grade = 5.00m
            };

            SixtyEightFour = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 4,
                Grade = 4.00m
            };

            SixtyEightFive = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 5,
                Grade = 6.00m
            };

            SixtyEightSix = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 6,
                Grade = 3.00m
            };

            SixtyEightSeven = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 7,
                Grade = 3.00m
            };

            SixtyEightEight = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 8,
                Grade = 6.00m
            };

            SixtyEightNine = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 9,
                Grade = 6.00m
            };

            SixtyEightTen = new StudentSubjectGrade()
            {
                StudentId = 68,
                SubjectId = 10,
                Grade = 4.00m
            };
            //69
            SixtyNineOne = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 1,
                Grade = 5.00m
            };

            SixtyNineTwo = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 2,
                Grade = 5.00m
            };

            SixtyNineThree = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 3,
                Grade = 6.00m
            };

            SixtyNineFour = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 4,
                Grade = 4.00m
            };

            SixtyNineFive = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 5,
                Grade = 6.00m
            };

            SixtyNineSix = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 6,
                Grade = 6.00m
            };

            SixtyNineSeven = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 7,
                Grade = 5.00m
            };

            SixtyNineEight = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 8,
                Grade = 3.00m
            };

            SixtyNineNine = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 9,
                Grade = 6.00m
            };

            SixtyNineTen = new StudentSubjectGrade()
            {
                StudentId = 69,
                SubjectId = 10,
                Grade = 4.00m
            };
            //70
            SeventyOne = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 1,
                Grade = 5.00m
            };

            SeventyTwo = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 2,
                Grade = 2.00m
            };

            SeventyThree = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 3,
                Grade = 2.00m
            };

            SeventyFour = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 4,
                Grade = 5.00m
            };

            SeventyFive = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 5,
                Grade = 3.00m
            };

            SeventySix = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 6,
                Grade = 4.00m
            };

            SeventySeven = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 7,
                Grade = 2.00m
            };

            SeventyEight = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 8,
                Grade = 2.00m
            };

            SeventyNine = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 9,
                Grade = 4.00m
            };

            SeventyTen = new StudentSubjectGrade()
            {
                StudentId = 70,
                SubjectId = 10,
                Grade = 5.00m
            };
            //71
            SeventyOneOne = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 1,
                Grade = 3.00m
            };

            SeventyOneTwo = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 2,
                Grade = 2.00m
            };

            SeventyOneThree = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 3,
                Grade = 4.00m
            };

            SeventyOneFour = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 4,
                Grade = 5.00m
            };

            SeventyOneFive = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 5,
                Grade = 6.00m
            };

            SeventyOneSix = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 6,
                Grade = 4.00m
            };

            SeventyOneSeven = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 7,
                Grade = 6.00m
            };

            SeventyOneEight = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 8,
                Grade = 6.00m
            };

            SeventyOneNine = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 9,
                Grade = 5.00m
            };

            SeventyOneTen = new StudentSubjectGrade()
            {
                StudentId = 71,
                SubjectId = 10,
                Grade = 6.00m
            };
            //72
            SeventyTwoOne = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 1,
                Grade = 2.00m
            };

            SeventyTwoTwo = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 2,
                Grade = 5.00m
            };

            SeventyTwoThree = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 3,
                Grade = 6.00m
            };

            SeventyTwoFour = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 4,
                Grade = 3.00m
            };

            SeventyTwoFive = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 5,
                Grade = 4.00m
            };

            SeventyTwoSix = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 6,
                Grade = 6.00m
            };

            SeventyTwoSeven = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 7,
                Grade = 4.00m
            };

            SeventyTwoEight = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 8,
                Grade = 3.00m
            };

            SeventyTwoNine = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 9,
                Grade = 5.00m
            };

            SeventyTwoTen = new StudentSubjectGrade()
            {
                StudentId = 72,
                SubjectId = 10,
                Grade = 6.00m
            };
            //73
            SeventyThreeOne = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 1,
                Grade = 4.00m
            };

            SeventyThreeTwo = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 2,
                Grade = 6.00m
            };

            SeventyThreeThree = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 3,
                Grade = 4.00m
            };

            SeventyThreeFour = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 4,
                Grade = 5.00m
            };

            SeventyThreeFive = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 5,
                Grade = 3.00m
            };

            SeventyThreeSix = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 6,
                Grade = 4.00m
            };

            SeventyThreeSeven = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 7,
                Grade = 6.00m
            };

            SeventyThreeEight = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 8,
                Grade = 4.00m
            };

            SeventyThreeNine = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 9,
                Grade = 5.00m
            };

            SeventyThreeTen = new StudentSubjectGrade()
            {
                StudentId = 73,
                SubjectId = 10,
                Grade = 5.00m
            };
            //74
            SeventyFourOne = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 1,
                Grade = 3.00m
            };

            SeventyFourTwo = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 2,
                Grade = 6.00m
            };

            SeventyFourThree = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 3,
                Grade = 4.00m
            };

            SeventyFourFour = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 4,
                Grade = 3.00m
            };

            SeventyFourFive = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 5,
                Grade = 5.00m
            };

            SeventyFourSix = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 6,
                Grade = 6.00m
            };

            SeventyFourSeven = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 7,
                Grade = 6.00m
            };

            SeventyFourEight = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 8,
                Grade = 4.00m
            };

            SeventyFourNine = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 9,
                Grade = 3.00m
            };

            SeventyFourTen = new StudentSubjectGrade()
            {
                StudentId = 74,
                SubjectId = 10,
                Grade = 5.00m
            };
        }
    }
}