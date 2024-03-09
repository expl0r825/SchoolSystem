using SchoolSystem.Infrastructure.Data.Models;
using System.Net.Http.Headers;

namespace SchoolSystem.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        //Subjects

        public Subject Bulgarian { get; set; }
        public Subject Mathematics { get; set; }
        public Subject English { get; set; }
        public Subject SoftwareDesign { get; set; }
        public Subject ComputerScience { get; set; }
        public Subject Business { get; set; }
        public Subject Physics { get; set; }
        public Subject Programming { get; set; }
        public Subject Engineering { get; set; }
        public Subject History { get; set; }


        //Teachers

        public Teacher TatyanaGerganova { get; set; }
        public Teacher BilyanaLozanova { get; set; }
        public Teacher KrasimiraKutin { get; set; }
        public Teacher TeodorHristov { get; set; }
        public Teacher SilviyaGancheva { get; set; }
        public Teacher CvetomirAmbursa { get; set; }
        public Teacher MitkoMitkov { get; set; }
        public Teacher EmilStoyanov { get; set; }
        public Teacher BorislavaBangeeva { get; set; }
        public Teacher MariaIvanova { get; set; }


        //Classes

        public Class Eight { get; set; }
        public Class Ninth { get; set; }
        public Class Tenth { get; set; }
        public Class Eleventh { get; set; }
        public Class Twelfth { get; set; }


        //Principals

        public Principal RadostinaMekova { get; set; }
        public Principal ValentinaStoeva { get; set; }
        public Principal YulianaPetkova { get; set; }


        //Parents

        public Parent KrumIvanov { get; set; }
        public Parent VeronikaPetrova { get; set; }
        public Parent PlamenDimitrov { get; set; }
        public Parent ZlatinaGeorgieva { get; set; }
        public Parent RadoslavTodorov { get; set; }
        public Parent AdrianaIvanova { get; set; }
        public Parent BozhidarKolev { get; set; }
        public Parent EvelinaVasileva { get; set; }
        public Parent StoyanPetrov { get; set; }
        public Parent TsvetelinaStoyanova { get; set; }
        public Parent LyubenMarinov { get; set; }
        public Parent RositsaPetrova { get; set; }
        public Parent KaloyanIvanov { get; set; }
        public Parent EkaterinaGeorgieva { get; set; }
        public Parent HristoDimitrov { get; set; }
        public Parent DobrinkaIvanova { get; set; }
        public Parent BlagoyGeorgiev { get; set; }
        public Parent IskraKoleva { get; set; }
        public Parent KrasimirTodorov { get; set; }
        public Parent GerganaIvanova { get; set; }
        public Parent VasilPetrov { get; set; }
        public Parent NadezhdaDimitrova { get; set; }
        public Parent TodorGeorgiev { get; set; }
        public Parent RadkaIvanova { get; set; }
        public Parent HristinaStefanova { get; set; }
        public Parent YavorKolev { get; set; }
        public Parent KameliaPetrova { get; set; }
        public Parent EmilIvanov { get; set; }
        public Parent DilyanaAleksandrova { get; set; }
        public Parent TsvetanGeorgiev { get; set; }
        public Parent ZhivkaIvanova { get; set; }
        public Parent IvoDimitrov { get; set; }
        public Parent AdriyanaStoyanova { get; set; }
        public Parent KamenPetrov { get; set; }
        public Parent KristinaKoleva { get; set; }
        public Parent YankoIvanov { get; set; }
        public Parent PolinaGeorgieva { get; set; }
        public Parent VeselinVasilev { get; set; }
        public Parent AntoniyaPetrova { get; set; }
        public Parent LyubomirDimitrov { get; set; }
        public Parent ZornitsaTodorova { get; set; }
        public Parent StefanIvanov { get; set; }
        public Parent YoanaGeorgieva { get; set; }
        public Parent KrasimiraPetrova { get; set; }
        public Parent IvayloKolev { get; set; }
        public Parent MargaritaGeorgieva { get; set; }
        public Parent RumenIvanov { get; set; }
        public Parent MilenaDimitrova { get; set; }
        public Parent YordanTodorov { get; set; }
        public Parent SilviyaPetrova { get; set; }
        public Parent BogdanIvanov { get; set; }
        public Parent PetyaKoleva { get; set; }
        public Parent AsenMarinov { get; set; }
        public Parent RalitsaIvanova { get; set; }
        public Parent VelkoVasilev { get; set; }
        public Parent GalyaDimitrova { get; set; }
        public Parent DimiturIvanov { get; set; }
        public Parent NadiaKoleva { get; set; }
        public Parent YulianPetrov { get; set; }
        public Parent RadostinaGeorgieva { get; set; }
        public Parent KrasimIvanov { get; set; }
        public Parent TeodoraTodorova { get; set; }
        public Parent KalinPetrov { get; set; }
        public Parent SvetlaDimitrova { get; set; }
        public Parent VentsislavGeorgiev { get; set; }
        public Parent VasilenaIvanova { get; set; }
        public Parent MartinPetrov { get; set; }
        public Parent RalitsaKoleva { get; set; }
        public Parent StefanDimitrov { get; set; }
        public Parent SnezhanaGeorgieva { get; set; }
        public Parent IvayloIvanov { get; set; }
        public Parent MarianaPetrova { get; set; }
        public Parent RosenKolev { get; set; }
        public Parent TanyaStoyanova { get; set; }


        //Students

        public Student DimitarIvanov { get; set; }
        public Student ElenaPetrova { get; set; }
        public Student StefchoDimitrov { get; set; }
        public Student MilenaGeorgieva { get; set; }
        public Student AleksandarTodorov { get; set; }
        public Student ViktoriaIvanova { get; set; }
        public Student NikolayKolev { get; set; }
        public Student MariaVasileva { get; set; }
        public Student IvayloPetrov { get; set; }
        public Student GabrielaStoyanova { get; set; }
        public Student GeorgiMarinov { get; set; }
        public Student KristinaPetrova { get; set; }
        public Student RumchoIvanov { get; set; }
        public Student EmiliaGeorgieva { get; set; }
        public Student KrasimirDimitrov { get; set; }
        public Student SilviyaIvanova { get; set; }
        public Student AsenGeorgiev { get; set; }
        public Student ElenaKoleva { get; set; }
        public Student StanimirTodorov { get; set; }
        public Student MagdalenaIvanova { get; set; }
        public Student HristoPetrov { get; set; }
        public Student KalinaDimitrova { get; set; }
        public Student TsvetanchoGeorgiev { get; set; }
        public Student NadezhdaIvanova { get; set; }
        public Student BorisStefanov { get; set; }
        public Student AneliyaKoleva { get; set; }
        public Student RosenPetrov { get; set; }
        public Student RadostinaIvanova { get; set; }
        public Student VasilAleksandrov { get; set; }
        public Student RositsaGeorgieva { get; set; }
        public Student PlamenIvanov { get; set; }
        public Student ValentinaDimitrova { get; set; }
        public Student IvoStoyanov { get; set; }
        public Student StefaniyaPetrova { get; set; }
        public Student MartinKolev { get; set; }
        public Student SonyaIvanova { get; set; }
        public Student LyubomirGeorgiev { get; set; }
        public Student NataliyaVasileva { get; set; }
        public Student PetarPetrov { get; set; }
        public Student GerganaDimitrova { get; set; }
        public Student LyubomiraTodorova { get; set; }
        public Student AntonIvanov { get; set; }
        public Student TanyaGeorgieva { get; set; }
        public Student KamenchoPetrov { get; set; }
        public Student VanyaKoleva { get; set; }
        public Student RadoslavGeorgiev { get; set; }
        public Student VasilenkaIvanova { get; set; }
        public Student KirilDimitrov { get; set; }
        public Student KameliyaTodorova { get; set; }
        public Student IliyaPetrov { get; set; }
        public Student DilyanaIvanova { get; set; }
        public Student BogdanKolev { get; set; }
        public Student DanielaMarinova { get; set; }
        public Student HristiyanIvanov { get; set; }
        public Student TeodoraVasileva { get; set; }
        public Student DesislavDimitrov { get; set; }
        public Student GalyaIvanova { get; set; }
        public Student IvanKolev { get; set; }
        public Student MariyaPetrova { get; set; }
        public Student SimeonGeorgiev { get; set; }
        public Student MagdalinaIvanova { get; set; }
        public Student EmilTodorov { get; set; }
        public Student KalinchoPetrov { get; set; }
        public Student RalitsaDimitrova { get; set; }
        public Student YordanGeorgiev { get; set; }
        public Student RadinkaIvanova { get; set; }
        public Student VentsislavPetrov { get; set; }
        public Student DarinaKoleva { get; set; }
        public Student BozhidarDimitrov { get; set; }
        public Student NeliGeorgieva { get; set; }
        public Student YavorIvanov { get; set; }
        public Student MilitsaPetrova { get; set; }
        public Student ZdravkoKolev { get; set; }
        public Student ElenaStoyanova { get; set; }


        //StudentSubjectGrades

        //1
        public StudentSubjectGrade OneOne { get; set; }
        public StudentSubjectGrade OneTwo { get; set; }
        public StudentSubjectGrade OneThree { get; set; }
        public StudentSubjectGrade OneFour { get; set; }
        public StudentSubjectGrade OneFive { get; set; }
        public StudentSubjectGrade OneSix { get; set; }
        public StudentSubjectGrade OneSeven { get; set; }
        public StudentSubjectGrade OneEight { get; set; }
        public StudentSubjectGrade OneNine { get; set; }
        public StudentSubjectGrade OneTen { get; set; }

        //2
        public StudentSubjectGrade TwoOne { get; set; }
        public StudentSubjectGrade TwoTwo { get; set; }
        public StudentSubjectGrade TwoThree { get; set; }
        public StudentSubjectGrade TwoFour { get; set; }
        public StudentSubjectGrade TwoFive { get; set; }
        public StudentSubjectGrade TwoSix { get; set; }
        public StudentSubjectGrade TwoSeven { get; set; }
        public StudentSubjectGrade TwoEight { get; set; }
        public StudentSubjectGrade TwoNine { get; set; }
        public StudentSubjectGrade TwoTen { get; set; }

        //3
        public StudentSubjectGrade ThreeOne { get; set; }
        public StudentSubjectGrade ThreeTwo { get; set; }
        public StudentSubjectGrade ThreeThree { get; set; }
        public StudentSubjectGrade ThreeFour { get; set; }
        public StudentSubjectGrade ThreeFive { get; set; }
        public StudentSubjectGrade ThreeSix { get; set; }
        public StudentSubjectGrade ThreeSeven { get; set; }
        public StudentSubjectGrade ThreeEight { get; set; }
        public StudentSubjectGrade ThreeNine { get; set; }
        public StudentSubjectGrade ThreeTen { get; set; }

        //4
        public StudentSubjectGrade FourOne { get; set; }
        public StudentSubjectGrade FourTwo { get; set; }
        public StudentSubjectGrade FourThree { get; set; }
        public StudentSubjectGrade FourFour { get; set; }
        public StudentSubjectGrade FourFive { get; set; }
        public StudentSubjectGrade FourSix { get; set; }
        public StudentSubjectGrade FourSeven { get; set; }
        public StudentSubjectGrade FourEight { get; set; }
        public StudentSubjectGrade FourNine { get; set; }
        public StudentSubjectGrade FourTen { get; set; }

        //5
        public StudentSubjectGrade FiveOne { get; set; }
        public StudentSubjectGrade FiveTwo { get; set; }
        public StudentSubjectGrade FiveThree { get; set; }
        public StudentSubjectGrade FiveFour { get; set; }
        public StudentSubjectGrade FiveFive { get; set; }
        public StudentSubjectGrade FiveSix { get; set; }
        public StudentSubjectGrade FiveSeven { get; set; }
        public StudentSubjectGrade FiveEight { get; set; }
        public StudentSubjectGrade FiveNine { get; set; }
        public StudentSubjectGrade FiveTen { get; set; }

        //6
        public StudentSubjectGrade SixOne { get; set; }
        public StudentSubjectGrade SixTwo { get; set; }
        public StudentSubjectGrade SixThree { get; set; }
        public StudentSubjectGrade SixFour { get; set; }
        public StudentSubjectGrade SixFive { get; set; }
        public StudentSubjectGrade SixSix { get; set; }
        public StudentSubjectGrade SixSeven { get; set; }
        public StudentSubjectGrade SixEight { get; set; }
        public StudentSubjectGrade SixNine { get; set; }
        public StudentSubjectGrade SixTen { get; set; }

        //7
        public StudentSubjectGrade SevenOne { get; set; }
        public StudentSubjectGrade SevenTwo { get; set; }
        public StudentSubjectGrade SevenThree { get; set; }
        public StudentSubjectGrade SevenFour { get; set; }
        public StudentSubjectGrade SevenFive { get; set; }
        public StudentSubjectGrade SevenSix { get; set; }
        public StudentSubjectGrade SevenSeven { get; set; }
        public StudentSubjectGrade SevenEight { get; set; }
        public StudentSubjectGrade SevenNine { get; set; }
        public StudentSubjectGrade SevenTen { get; set; }

        //8
        public StudentSubjectGrade EightOne { get; set; }
        public StudentSubjectGrade EightTwo { get; set; }
        public StudentSubjectGrade EightThree { get; set; }
        public StudentSubjectGrade EightFour { get; set; }
        public StudentSubjectGrade EightFive { get; set; }
        public StudentSubjectGrade EightSix { get; set; }
        public StudentSubjectGrade EightSeven { get; set; }
        public StudentSubjectGrade EightEight { get; set; }
        public StudentSubjectGrade EightNine { get; set; }
        public StudentSubjectGrade EightTen { get; set; }

        //9
        public StudentSubjectGrade NineOne { get; set; }
        public StudentSubjectGrade NineTwo { get; set; }
        public StudentSubjectGrade NineThree { get; set; }
        public StudentSubjectGrade NineFour { get; set; }
        public StudentSubjectGrade NineFive { get; set; }
        public StudentSubjectGrade NineSix { get; set; }
        public StudentSubjectGrade NineSeven { get; set; }
        public StudentSubjectGrade NineEight { get; set; }
        public StudentSubjectGrade NineNine { get; set; }
        public StudentSubjectGrade NineTen { get; set; }

        //10
        public StudentSubjectGrade TenOne { get; set; }
        public StudentSubjectGrade TenTwo { get; set; }
        public StudentSubjectGrade TenThree { get; set; }
        public StudentSubjectGrade TenFour { get; set; }
        public StudentSubjectGrade TenFive { get; set; }
        public StudentSubjectGrade TenSix { get; set; }
        public StudentSubjectGrade TenSeven { get; set; }
        public StudentSubjectGrade TenEight { get; set; }
        public StudentSubjectGrade TenNine { get; set; }
        public StudentSubjectGrade TenTen { get; set; }

        //11
        public StudentSubjectGrade ElevenOne { get; set; }
        public StudentSubjectGrade ElevenTwo { get; set; }
        public StudentSubjectGrade ElevenThree { get; set; }
        public StudentSubjectGrade ElevenFour { get; set; }
        public StudentSubjectGrade ElevenFive { get; set; }
        public StudentSubjectGrade ElevenSix { get; set; }
        public StudentSubjectGrade ElevenSeven { get; set; }
        public StudentSubjectGrade ElevenEight { get; set; }
        public StudentSubjectGrade ElevenNine { get; set; }
        public StudentSubjectGrade ElevenTen { get; set; }

        //12
        public StudentSubjectGrade TwelveOne { get; set; }
        public StudentSubjectGrade TwelveTwo { get; set; }
        public StudentSubjectGrade TwelveThree { get; set; }
        public StudentSubjectGrade TwelveFour { get; set; }
        public StudentSubjectGrade TwelveFive { get; set; }
        public StudentSubjectGrade TwelveSix { get; set; }
        public StudentSubjectGrade TwelveSeven { get; set; }
        public StudentSubjectGrade TwelveEight { get; set; }
        public StudentSubjectGrade TwelveNine { get; set; }
        public StudentSubjectGrade TwelveTen { get; set; }

        //13
        public StudentSubjectGrade ThirteenOne { get; set; }
        public StudentSubjectGrade ThirteenTwo { get; set; }
        public StudentSubjectGrade ThirteenThree { get; set; }
        public StudentSubjectGrade ThirteenFour { get; set; }
        public StudentSubjectGrade ThirteenFive { get; set; }
        public StudentSubjectGrade ThirteenSix { get; set; }
        public StudentSubjectGrade ThirteenSeven { get; set; }
        public StudentSubjectGrade ThirteenEight { get; set; }
        public StudentSubjectGrade ThirteenNine { get; set; }
        public StudentSubjectGrade ThirteenTen { get; set; }

        //14
        public StudentSubjectGrade FourteenOne { get; set; }
        public StudentSubjectGrade FourteenTwo { get; set; }
        public StudentSubjectGrade FourteenThree { get; set; }
        public StudentSubjectGrade FourteenFour { get; set; }
        public StudentSubjectGrade FourteenFive { get; set; }
        public StudentSubjectGrade FourteenSix { get; set; }
        public StudentSubjectGrade FourteenSeven { get; set; }
        public StudentSubjectGrade FourteenEight { get; set; }
        public StudentSubjectGrade FourteenNine { get; set; }
        public StudentSubjectGrade FourteenTen { get; set; }

        //15
        public StudentSubjectGrade FifteenOne { get; set; }
        public StudentSubjectGrade FifteenTwo { get; set; }
        public StudentSubjectGrade FifteenThree { get; set; }
        public StudentSubjectGrade FifteenFour { get; set; }
        public StudentSubjectGrade FifteenFive { get; set; }
        public StudentSubjectGrade FifteenSix { get; set; }
        public StudentSubjectGrade FifteenSeven { get; set; }
        public StudentSubjectGrade FifteenEight { get; set; }
        public StudentSubjectGrade FifteenNine { get; set; }
        public StudentSubjectGrade FifteenTen { get; set; }

        //16
        public StudentSubjectGrade SixteenOne { get; set; }
        public StudentSubjectGrade SixteenTwo { get; set; }
        public StudentSubjectGrade SixteenThree { get; set; }
        public StudentSubjectGrade SixteenFour { get; set; }
        public StudentSubjectGrade SixteenFive { get; set; }
        public StudentSubjectGrade SixteenSix { get; set; }
        public StudentSubjectGrade SixteenSeven { get; set; }
        public StudentSubjectGrade SixteenEight { get; set; }
        public StudentSubjectGrade SixteenNine { get; set; }
        public StudentSubjectGrade SixteenTen { get; set; }

        //17
        public StudentSubjectGrade SeventeenOne { get; set; }
        public StudentSubjectGrade SeventeenTwo { get; set; }
        public StudentSubjectGrade SeventeenThree { get; set; }
        public StudentSubjectGrade SeventeenFour { get; set; }
        public StudentSubjectGrade SeventeenFive { get; set; }
        public StudentSubjectGrade SeventeenSix { get; set; }
        public StudentSubjectGrade SeventeenSeven { get; set; }
        public StudentSubjectGrade SeventeenEight { get; set; }
        public StudentSubjectGrade SeventeenNine { get; set; }
        public StudentSubjectGrade SeventeenTen { get; set; }

        //18
        public StudentSubjectGrade EighteenOne { get; set; }
        public StudentSubjectGrade EighteenTwo { get; set; }
        public StudentSubjectGrade EighteenThree { get; set; }
        public StudentSubjectGrade EighteenFour { get; set; }
        public StudentSubjectGrade EighteenFive { get; set; }
        public StudentSubjectGrade EighteenSix { get; set; }
        public StudentSubjectGrade EighteenSeven { get; set; }
        public StudentSubjectGrade EighteenEight { get; set; }
        public StudentSubjectGrade EighteenNine { get; set; }
        public StudentSubjectGrade EighteenTen { get; set; }

        //19
        public StudentSubjectGrade NineteenOne { get; set; }
        public StudentSubjectGrade NineteenTwo { get; set; }
        public StudentSubjectGrade NineteenThree { get; set; }
        public StudentSubjectGrade NineteenFour { get; set; }
        public StudentSubjectGrade NineteenFive { get; set; }
        public StudentSubjectGrade NineteenSix { get; set; }
        public StudentSubjectGrade NineteenSeven { get; set; }
        public StudentSubjectGrade NineteenEight { get; set; }
        public StudentSubjectGrade NineteenNine { get; set; }
        public StudentSubjectGrade NineteenTen { get; set; }

        //20
        public StudentSubjectGrade TwentyOne { get; set; }
        public StudentSubjectGrade TwentyTwo { get; set; }
        public StudentSubjectGrade TwentyThree { get; set; }
        public StudentSubjectGrade TwentyFour { get; set; }
        public StudentSubjectGrade TwentyFive { get; set; }
        public StudentSubjectGrade TwentySix { get; set; }
        public StudentSubjectGrade TwentySeven { get; set; }
        public StudentSubjectGrade TwentyEight { get; set; }
        public StudentSubjectGrade TwentyNine { get; set; }
        public StudentSubjectGrade TwentyTen { get; set; }

        //21
        public StudentSubjectGrade TwentyOneOne { get; set; }
        public StudentSubjectGrade TwentyOneTwo { get; set; }
        public StudentSubjectGrade TwentyOneThree { get; set; }
        public StudentSubjectGrade TwentyOneFour { get; set; }
        public StudentSubjectGrade TwentyOneFive { get; set; }
        public StudentSubjectGrade TwentyOneSix { get; set; }
        public StudentSubjectGrade TwentyOneSeven { get; set; }
        public StudentSubjectGrade TwentyOneEight { get; set; }
        public StudentSubjectGrade TwentyOneNine { get; set; }
        public StudentSubjectGrade TwentyOneTen { get; set; }

        //22
        public StudentSubjectGrade TwentyTwoOne { get; set; }
        public StudentSubjectGrade TwentyTwoTwo { get; set; }
        public StudentSubjectGrade TwentyTwoThree { get; set; }
        public StudentSubjectGrade TwentyTwoFour { get; set; }
        public StudentSubjectGrade TwentyTwoFive { get; set; }
        public StudentSubjectGrade TwentyTwoSix { get; set; }
        public StudentSubjectGrade TwentyTwoSeven { get; set; }
        public StudentSubjectGrade TwentyTwoEight { get; set; }
        public StudentSubjectGrade TwentyTwoNine { get; set; }
        public StudentSubjectGrade TwentyTwoTen { get; set; }

        //23
        public StudentSubjectGrade TwentyThreeOne { get; set; }
        public StudentSubjectGrade TwentyThreeTwo { get; set; }
        public StudentSubjectGrade TwentyThreeThree { get; set; }
        public StudentSubjectGrade TwentyThreeFour { get; set; }
        public StudentSubjectGrade TwentyThreeFive { get; set; }
        public StudentSubjectGrade TwentyThreeSix { get; set; }
        public StudentSubjectGrade TwentyThreeSeven { get; set; }
        public StudentSubjectGrade TwentyThreeEight { get; set; }
        public StudentSubjectGrade TwentyThreeNine { get; set; }
        public StudentSubjectGrade TwentyThreeTen { get; set; }

        //24
        public StudentSubjectGrade TwentyFourOne { get; set; }
        public StudentSubjectGrade TwentyFourTwo { get; set; }
        public StudentSubjectGrade TwentyFourThree { get; set; }
        public StudentSubjectGrade TwentyFourFour { get; set; }
        public StudentSubjectGrade TwentyFourFive { get; set; }
        public StudentSubjectGrade TwentyFourSix { get; set; }
        public StudentSubjectGrade TwentyFourSeven { get; set; }
        public StudentSubjectGrade TwentyFourEight { get; set; }
        public StudentSubjectGrade TwentyFourNine { get; set; }
        public StudentSubjectGrade TwentyFourTen { get; set; }

        //25
        public StudentSubjectGrade TwentyFiveOne { get; set; }
        public StudentSubjectGrade TwentyFiveTwo { get; set; }
        public StudentSubjectGrade TwentyFiveThree { get; set; }
        public StudentSubjectGrade TwentyFiveFour { get; set; }
        public StudentSubjectGrade TwentyFiveFive { get; set; }
        public StudentSubjectGrade TwentyFiveSix { get; set; }
        public StudentSubjectGrade TwentyFiveSeven { get; set; }
        public StudentSubjectGrade TwentyFiveEight { get; set; }
        public StudentSubjectGrade TwentyFiveNine { get; set; }
        public StudentSubjectGrade TwentyFiveTen { get; set; }

        //26
        public StudentSubjectGrade TwentySixOne { get; set; }
        public StudentSubjectGrade TwentySixTwo { get; set; }
        public StudentSubjectGrade TwentySixThree { get; set; }
        public StudentSubjectGrade TwentySixFour { get; set; }
        public StudentSubjectGrade TwentySixFive { get; set; }
        public StudentSubjectGrade TwentySixSix { get; set; }
        public StudentSubjectGrade TwentySixSeven { get; set; }
        public StudentSubjectGrade TwentySixEight { get; set; }
        public StudentSubjectGrade TwentySixNine { get; set; }
        public StudentSubjectGrade TwentySixTen { get; set; }

        //27
        public StudentSubjectGrade TwentySevenOne { get; set; }
        public StudentSubjectGrade TwentySevenTwo { get; set; }
        public StudentSubjectGrade TwentySevenThree { get; set; }
        public StudentSubjectGrade TwentySevenFour { get; set; }
        public StudentSubjectGrade TwentySevenFive { get; set; }
        public StudentSubjectGrade TwentySevenSix { get; set; }
        public StudentSubjectGrade TwentySevenSeven { get; set; }
        public StudentSubjectGrade TwentySevenEight { get; set; }
        public StudentSubjectGrade TwentySevenNine { get; set; }
        public StudentSubjectGrade TwentySevenTen { get; set; }

        //28
        public StudentSubjectGrade TwentyEightOne { get; set; }
        public StudentSubjectGrade TwentyEightTwo { get; set; }
        public StudentSubjectGrade TwentyEightThree { get; set; }
        public StudentSubjectGrade TwentyEightFour { get; set; }
        public StudentSubjectGrade TwentyEightFive { get; set; }
        public StudentSubjectGrade TwentyEightSix { get; set; }
        public StudentSubjectGrade TwentyEightSeven { get; set; }
        public StudentSubjectGrade TwentyEightEight { get; set; }
        public StudentSubjectGrade TwentyEightNine { get; set; }
        public StudentSubjectGrade TwentyEightTen { get; set; }

        //29
        public StudentSubjectGrade TwentyNineOne { get; set; }
        public StudentSubjectGrade TwentyNineTwo { get; set; }
        public StudentSubjectGrade TwentyNineThree { get; set; }
        public StudentSubjectGrade TwentyNineFour { get; set; }
        public StudentSubjectGrade TwentyNineFive { get; set; }
        public StudentSubjectGrade TwentyNineSix { get; set; }
        public StudentSubjectGrade TwentyNineSeven { get; set; }
        public StudentSubjectGrade TwentyNineEight { get; set; }
        public StudentSubjectGrade TwentyNineNine { get; set; }
        public StudentSubjectGrade TwentyNineTen { get; set; }

        //30
        public StudentSubjectGrade ThirtyOne { get; set; }
        public StudentSubjectGrade ThirtyTwo { get; set; }
        public StudentSubjectGrade ThirtyThree { get; set; }
        public StudentSubjectGrade ThirtyFour { get; set; }
        public StudentSubjectGrade ThirtyFive { get; set; }
        public StudentSubjectGrade ThirtySix { get; set; }
        public StudentSubjectGrade ThirtySeven { get; set; }
        public StudentSubjectGrade ThirtyEight { get; set; }
        public StudentSubjectGrade ThirtyNine { get; set; }
        public StudentSubjectGrade ThirtyTen { get; set; }

        //31
        public StudentSubjectGrade ThirtyOneOne { get; set; }
        public StudentSubjectGrade ThirtyOneTwo { get; set; }
        public StudentSubjectGrade ThirtyOneThree { get; set; }
        public StudentSubjectGrade ThirtyOneFour { get; set; }
        public StudentSubjectGrade ThirtyOneFive { get; set; }
        public StudentSubjectGrade ThirtyOneSix { get; set; }
        public StudentSubjectGrade ThirtyOneSeven { get; set; }
        public StudentSubjectGrade ThirtyOneEight { get; set; }
        public StudentSubjectGrade ThirtyOneNine { get; set; }
        public StudentSubjectGrade ThirtyOneTen { get; set; }

        //32
        public StudentSubjectGrade ThirtyTwoOne { get; set; }
        public StudentSubjectGrade ThirtyTwoTwo { get; set; }
        public StudentSubjectGrade ThirtyTwoThree { get; set; }
        public StudentSubjectGrade ThirtyTwoFour { get; set; }
        public StudentSubjectGrade ThirtyTwoFive { get; set; }
        public StudentSubjectGrade ThirtyTwoSix { get; set; }
        public StudentSubjectGrade ThirtyTwoSeven { get; set; }
        public StudentSubjectGrade ThirtyTwoEight { get; set; }
        public StudentSubjectGrade ThirtyTwoNine { get; set; }
        public StudentSubjectGrade ThirtyTwoTen { get; set; }

        //33
        public StudentSubjectGrade ThirtyThreeOne { get; set; }
        public StudentSubjectGrade ThirtyThreeTwo { get; set; }
        public StudentSubjectGrade ThirtyThreeThree { get; set; }
        public StudentSubjectGrade ThirtyThreeFour { get; set; }
        public StudentSubjectGrade ThirtyThreeFive { get; set; }
        public StudentSubjectGrade ThirtyThreeSix { get; set; }
        public StudentSubjectGrade ThirtyThreeSeven { get; set; }
        public StudentSubjectGrade ThirtyThreeEight { get; set; }
        public StudentSubjectGrade ThirtyThreeNine { get; set; }
        public StudentSubjectGrade ThirtyThreeTen { get; set; }

        //34
        public StudentSubjectGrade ThirtyFourOne { get; set; }
        public StudentSubjectGrade ThirtyFourTwo { get; set; }
        public StudentSubjectGrade ThirtyFourThree { get; set; }
        public StudentSubjectGrade ThirtyFourFour { get; set; }
        public StudentSubjectGrade ThirtyFourFive { get; set; }
        public StudentSubjectGrade ThirtyFourSix { get; set; }
        public StudentSubjectGrade ThirtyFourSeven { get; set; }
        public StudentSubjectGrade ThirtyFourEight { get; set; }
        public StudentSubjectGrade ThirtyFourNine { get; set; }
        public StudentSubjectGrade ThirtyFourTen { get; set; }

        //35
        public StudentSubjectGrade ThirtyFiveOne { get; set; }
        public StudentSubjectGrade ThirtyFiveTwo { get; set; }
        public StudentSubjectGrade ThirtyFiveThree { get; set; }
        public StudentSubjectGrade ThirtyFiveFour { get; set; }
        public StudentSubjectGrade ThirtyFiveFive { get; set; }
        public StudentSubjectGrade ThirtyFiveSix { get; set; }
        public StudentSubjectGrade ThirtyFiveSeven { get; set; }
        public StudentSubjectGrade ThirtyFiveEight { get; set; }
        public StudentSubjectGrade ThirtyFiveNine { get; set; }
        public StudentSubjectGrade ThirtyFiveTen { get; set; }

        //36
        public StudentSubjectGrade ThirtySixOne { get; set; }
        public StudentSubjectGrade ThirtySixTwo { get; set; }
        public StudentSubjectGrade ThirtySixThree { get; set; }
        public StudentSubjectGrade ThirtySixFour { get; set; }
        public StudentSubjectGrade ThirtySixFive { get; set; }
        public StudentSubjectGrade ThirtySixSix { get; set; }
        public StudentSubjectGrade ThirtySixSeven { get; set; }
        public StudentSubjectGrade ThirtySixEight { get; set; }
        public StudentSubjectGrade ThirtySixNine { get; set; }
        public StudentSubjectGrade ThirtySixTen { get; set; }

        //37
        public StudentSubjectGrade ThirtySevenOne { get; set; }
        public StudentSubjectGrade ThirtySevenTwo { get; set; }
        public StudentSubjectGrade ThirtySevenThree { get; set; }
        public StudentSubjectGrade ThirtySevenFour { get; set; }
        public StudentSubjectGrade ThirtySevenFive { get; set; }
        public StudentSubjectGrade ThirtySevenSix { get; set; }
        public StudentSubjectGrade ThirtySevenSeven { get; set; }
        public StudentSubjectGrade ThirtySevenEight { get; set; }
        public StudentSubjectGrade ThirtySevenNine { get; set; }
        public StudentSubjectGrade ThirtySevenTen { get; set; }

        //38
        public StudentSubjectGrade ThirtyEightOne { get; set; }
        public StudentSubjectGrade ThirtyEightTwo { get; set; }
        public StudentSubjectGrade ThirtyEightThree { get; set; }
        public StudentSubjectGrade ThirtyEightFour { get; set; }
        public StudentSubjectGrade ThirtyEightFive { get; set; }
        public StudentSubjectGrade ThirtyEightSix { get; set; }
        public StudentSubjectGrade ThirtyEightSeven { get; set; }
        public StudentSubjectGrade ThirtyEightEight { get; set; }
        public StudentSubjectGrade ThirtyEightNine { get; set; }
        public StudentSubjectGrade ThirtyEightTen { get; set; }

        //39
        public StudentSubjectGrade ThirtyNineOne { get; set; }
        public StudentSubjectGrade ThirtyNineTwo { get; set; }
        public StudentSubjectGrade ThirtyNineThree { get; set; }
        public StudentSubjectGrade ThirtyNineFour { get; set; }
        public StudentSubjectGrade ThirtyNineFive { get; set; }
        public StudentSubjectGrade ThirtyNineSix { get; set; }
        public StudentSubjectGrade ThirtyNineSeven { get; set; }
        public StudentSubjectGrade ThirtyNineEight { get; set; }
        public StudentSubjectGrade ThirtyNineNine { get; set; }
        public StudentSubjectGrade ThirtyNineTen { get; set; }

        //40
        public StudentSubjectGrade FortyOne { get; set; }
        public StudentSubjectGrade FortyTwo { get; set; }
        public StudentSubjectGrade FortyThree { get; set; }
        public StudentSubjectGrade FortyFour { get; set; }
        public StudentSubjectGrade FortyFive { get; set; }
        public StudentSubjectGrade FortySix { get; set; }
        public StudentSubjectGrade FortySeven { get; set; }
        public StudentSubjectGrade FortyEight { get; set; }
        public StudentSubjectGrade FortyNine { get; set; }
        public StudentSubjectGrade FortyTen { get; set; }

        //41
        public StudentSubjectGrade FortyOneOne { get; set; }
        public StudentSubjectGrade FortyOneTwo { get; set; }
        public StudentSubjectGrade FortyOneThree { get; set; }
        public StudentSubjectGrade FortyOneFour { get; set; }
        public StudentSubjectGrade FortyOneFive { get; set; }
        public StudentSubjectGrade FortyOneSix { get; set; }
        public StudentSubjectGrade FortyOneSeven { get; set; }
        public StudentSubjectGrade FortyOneEight { get; set; }
        public StudentSubjectGrade FortyOneNine { get; set; }
        public StudentSubjectGrade FortyOneTen { get; set; }

        //42
        public StudentSubjectGrade FortyTwoOne { get; set; }
        public StudentSubjectGrade FortyTwoTwo { get; set; }
        public StudentSubjectGrade FortyTwoThree { get; set; }
        public StudentSubjectGrade FortyTwoFour { get; set; }
        public StudentSubjectGrade FortyTwoFive { get; set; }
        public StudentSubjectGrade FortyTwoSix { get; set; }
        public StudentSubjectGrade FortyTwoSeven { get; set; }
        public StudentSubjectGrade FortyTwoEight { get; set; }
        public StudentSubjectGrade FortyTwoNine { get; set; }
        public StudentSubjectGrade FortyTwoTen { get; set; }

        //43
        public StudentSubjectGrade FortyThreeOne { get; set; }
        public StudentSubjectGrade FortyThreeTwo { get; set; }
        public StudentSubjectGrade FortyThreeThree { get; set; }
        public StudentSubjectGrade FortyThreeFour { get; set; }
        public StudentSubjectGrade FortyThreeFive { get; set; }
        public StudentSubjectGrade FortyThreeSix { get; set; }
        public StudentSubjectGrade FortyThreeSeven { get; set; }
        public StudentSubjectGrade FortyThreeEight { get; set; }
        public StudentSubjectGrade FortyThreeNine { get; set; }
        public StudentSubjectGrade FortyThreeTen { get; set; }

        //44
        public StudentSubjectGrade FortyFourOne { get; set; }
        public StudentSubjectGrade FortyFourTwo { get; set; }
        public StudentSubjectGrade FortyFourThree { get; set; }
        public StudentSubjectGrade FortyFourFour { get; set; }
        public StudentSubjectGrade FortyFourFive { get; set; }
        public StudentSubjectGrade FortyFourSix { get; set; }
        public StudentSubjectGrade FortyFourSeven { get; set; }
        public StudentSubjectGrade FortyFourEight { get; set; }
        public StudentSubjectGrade FortyFourNine { get; set; }
        public StudentSubjectGrade FortyFourTen { get; set; }

        //45
        public StudentSubjectGrade FortyFiveOne { get; set; }
        public StudentSubjectGrade FortyFiveTwo { get; set; }
        public StudentSubjectGrade FortyFiveThree { get; set; }
        public StudentSubjectGrade FortyFiveFour { get; set; }
        public StudentSubjectGrade FortyFiveFive { get; set; }
        public StudentSubjectGrade FortyFiveSix { get; set; }
        public StudentSubjectGrade FortyFiveSeven { get; set; }
        public StudentSubjectGrade FortyFiveEight { get; set; }
        public StudentSubjectGrade FortyFiveNine { get; set; }
        public StudentSubjectGrade FortyFiveTen { get; set; }

        //46
        public StudentSubjectGrade FortySixOne { get; set; }
        public StudentSubjectGrade FortySixTwo { get; set; }
        public StudentSubjectGrade FortySixThree { get; set; }
        public StudentSubjectGrade FortySixFour { get; set; }
        public StudentSubjectGrade FortySixFive { get; set; }
        public StudentSubjectGrade FortySixSix { get; set; }
        public StudentSubjectGrade FortySixSeven { get; set; }
        public StudentSubjectGrade FortySixEight { get; set; }
        public StudentSubjectGrade FortySixNine { get; set; }
        public StudentSubjectGrade FortySixTen { get; set; }

        //47
        public StudentSubjectGrade FortySevenOne { get; set; }
        public StudentSubjectGrade FortySevenTwo { get; set; }
        public StudentSubjectGrade FortySevenThree { get; set; }
        public StudentSubjectGrade FortySevenFour { get; set; }
        public StudentSubjectGrade FortySevenFive { get; set; }
        public StudentSubjectGrade FortySevenSix { get; set; }
        public StudentSubjectGrade FortySevenSeven { get; set; }
        public StudentSubjectGrade FortySevenEight { get; set; }
        public StudentSubjectGrade FortySevenNine { get; set; }
        public StudentSubjectGrade FortySevenTen { get; set; }

        //48
        public StudentSubjectGrade FortyEightOne { get; set; }
        public StudentSubjectGrade FortyEightTwo { get; set; }
        public StudentSubjectGrade FortyEightThree { get; set; }
        public StudentSubjectGrade FortyEightFour { get; set; }
        public StudentSubjectGrade FortyEightFive { get; set; }
        public StudentSubjectGrade FortyEightSix { get; set; }
        public StudentSubjectGrade FortyEightSeven { get; set; }
        public StudentSubjectGrade FortyEightEight { get; set; }
        public StudentSubjectGrade FortyEightNine { get; set; }
        public StudentSubjectGrade FortyEightTen { get; set; }

        //49
        public StudentSubjectGrade FortyNineOne { get; set; }
        public StudentSubjectGrade FortyNineTwo { get; set; }
        public StudentSubjectGrade FortyNineThree { get; set; }
        public StudentSubjectGrade FortyNineFour { get; set; }
        public StudentSubjectGrade FortyNineFive { get; set; }
        public StudentSubjectGrade FortyNineSix { get; set; }
        public StudentSubjectGrade FortyNineSeven { get; set; }
        public StudentSubjectGrade FortyNineEight { get; set; }
        public StudentSubjectGrade FortyNineNine { get; set; }
        public StudentSubjectGrade FortyNineTen { get; set; }

        //50
        public StudentSubjectGrade FiftyOne { get; set; }
        public StudentSubjectGrade FiftyTwo { get; set; }
        public StudentSubjectGrade FiftyThree { get; set; }
        public StudentSubjectGrade FiftyFour { get; set; }
        public StudentSubjectGrade FiftyFive { get; set; }
        public StudentSubjectGrade FiftySix { get; set; }
        public StudentSubjectGrade FiftySeven { get; set; }
        public StudentSubjectGrade FiftyEight { get; set; }
        public StudentSubjectGrade FiftyNine { get; set; }
        public StudentSubjectGrade FiftyTen { get; set; }

        //51
        public StudentSubjectGrade FiftyOneOne { get; set; }
        public StudentSubjectGrade FiftyOneTwo { get; set; }
        public StudentSubjectGrade FiftyOneThree { get; set; }
        public StudentSubjectGrade FiftyOneFour { get; set; }
        public StudentSubjectGrade FiftyOneFive { get; set; }
        public StudentSubjectGrade FiftyOneSix { get; set; }
        public StudentSubjectGrade FiftyOneSeven { get; set; }
        public StudentSubjectGrade FiftyOneEight { get; set; }
        public StudentSubjectGrade FiftyOneNine { get; set; }
        public StudentSubjectGrade FiftyOneTen { get; set; }

        //52
        public StudentSubjectGrade FiftyTwoOne { get; set; }
        public StudentSubjectGrade FiftyTwoTwo { get; set; }
        public StudentSubjectGrade FiftyTwoThree { get; set; }
        public StudentSubjectGrade FiftyTwoFour { get; set; }
        public StudentSubjectGrade FiftyTwoFive { get; set; }
        public StudentSubjectGrade FiftyTwoSix { get; set; }
        public StudentSubjectGrade FiftyTwoSeven { get; set; }
        public StudentSubjectGrade FiftyTwoEight { get; set; }
        public StudentSubjectGrade FiftyTwoNine { get; set; }
        public StudentSubjectGrade FiftyTwoTen { get; set; }

        //53
        public StudentSubjectGrade FiftyThreeOne { get; set; }
        public StudentSubjectGrade FiftyThreeTwo { get; set; }
        public StudentSubjectGrade FiftyThreeThree { get; set; }
        public StudentSubjectGrade FiftyThreeFour { get; set; }
        public StudentSubjectGrade FiftyThreeFive { get; set; }
        public StudentSubjectGrade FiftyThreeSix { get; set; }
        public StudentSubjectGrade FiftyThreeSeven { get; set; }
        public StudentSubjectGrade FiftyThreeEight { get; set; }
        public StudentSubjectGrade FiftyThreeNine { get; set; }
        public StudentSubjectGrade FiftyThreeTen { get; set; }

        //54
        public StudentSubjectGrade FiftyFourOne { get; set; }
        public StudentSubjectGrade FiftyFourTwo { get; set; }
        public StudentSubjectGrade FiftyFourThree { get; set; }
        public StudentSubjectGrade FiftyFourFour { get; set; }
        public StudentSubjectGrade FiftyFourFive { get; set; }
        public StudentSubjectGrade FiftyFourSix { get; set; }
        public StudentSubjectGrade FiftyFourSeven { get; set; }
        public StudentSubjectGrade FiftyFourEight { get; set; }
        public StudentSubjectGrade FiftyFourNine { get; set; }
        public StudentSubjectGrade FiftyFourTen { get; set; }

        //55
        public StudentSubjectGrade FiftyFiveOne { get; set; }
        public StudentSubjectGrade FiftyFiveTwo { get; set; }
        public StudentSubjectGrade FiftyFiveThree { get; set; }
        public StudentSubjectGrade FiftyFiveFour { get; set; }
        public StudentSubjectGrade FiftyFiveFive { get; set; }
        public StudentSubjectGrade FiftyFiveSix { get; set; }
        public StudentSubjectGrade FiftyFiveSeven { get; set; }
        public StudentSubjectGrade FiftyFiveEight { get; set; }
        public StudentSubjectGrade FiftyFiveNine { get; set; }
        public StudentSubjectGrade FiftyFiveTen { get; set; }

        //56
        public StudentSubjectGrade FiftySixOne { get; set; }
        public StudentSubjectGrade FiftySixTwo { get; set; }
        public StudentSubjectGrade FiftySixThree { get; set; }
        public StudentSubjectGrade FiftySixFour { get; set; }
        public StudentSubjectGrade FiftySixFive { get; set; }
        public StudentSubjectGrade FiftySixSix { get; set; }
        public StudentSubjectGrade FiftySixSeven { get; set; }
        public StudentSubjectGrade FiftySixEight { get; set; }
        public StudentSubjectGrade FiftySixNine { get; set; }
        public StudentSubjectGrade FiftySixTen { get; set; }

        //57
        public StudentSubjectGrade FiftySevenOne { get; set; }
        public StudentSubjectGrade FiftySevenTwo { get; set; }
        public StudentSubjectGrade FiftySevenThree { get; set; }
        public StudentSubjectGrade FiftySevenFour { get; set; }
        public StudentSubjectGrade FiftySevenFive { get; set; }
        public StudentSubjectGrade FiftySevenSix { get; set; }
        public StudentSubjectGrade FiftySevenSeven { get; set; }
        public StudentSubjectGrade FiftySevenEight { get; set; }
        public StudentSubjectGrade FiftySevenNine { get; set; }
        public StudentSubjectGrade FiftySevenTen { get; set; }

        //58
        public StudentSubjectGrade FiftyEightOne { get; set; }
        public StudentSubjectGrade FiftyEightTwo { get; set; }
        public StudentSubjectGrade FiftyEightThree { get; set; }
        public StudentSubjectGrade FiftyEightFour { get; set; }
        public StudentSubjectGrade FiftyEightFive { get; set; }
        public StudentSubjectGrade FiftyEightSix { get; set; }
        public StudentSubjectGrade FiftyEightSeven { get; set; }
        public StudentSubjectGrade FiftyEightEight { get; set; }
        public StudentSubjectGrade FiftyEightNine { get; set; }
        public StudentSubjectGrade FiftyEightTen { get; set; }

        //59
        public StudentSubjectGrade FiftyNineOne { get; set; }
        public StudentSubjectGrade FiftyNineTwo { get; set; }
        public StudentSubjectGrade FiftyNineThree { get; set; }
        public StudentSubjectGrade FiftyNineFour { get; set; }
        public StudentSubjectGrade FiftyNineFive { get; set; }
        public StudentSubjectGrade FiftyNineSix { get; set; }
        public StudentSubjectGrade FiftyNineSeven { get; set; }
        public StudentSubjectGrade FiftyNineEight { get; set; }
        public StudentSubjectGrade FiftyNineNine { get; set; }
        public StudentSubjectGrade FiftyNineTen { get; set; }

        //60
        public StudentSubjectGrade SixtyOne { get; set; }
        public StudentSubjectGrade SixtyTwo { get; set; }
        public StudentSubjectGrade SixtyThree { get; set; }
        public StudentSubjectGrade SixtyFour { get; set; }
        public StudentSubjectGrade SixtyFive { get; set; }
        public StudentSubjectGrade SixtySix { get; set; }
        public StudentSubjectGrade SixtySeven { get; set; }
        public StudentSubjectGrade SixtyEight { get; set; }
        public StudentSubjectGrade SixtyNine { get; set; }
        public StudentSubjectGrade SixtyTen { get; set; }

        //61
        public StudentSubjectGrade SixtyOneOne { get; set; }
        public StudentSubjectGrade SixtyOneTwo { get; set; }
        public StudentSubjectGrade SixtyOneThree { get; set; }
        public StudentSubjectGrade SixtyOneFour { get; set; }
        public StudentSubjectGrade SixtyOneFive { get; set; }
        public StudentSubjectGrade SixtyOneSix { get; set; }
        public StudentSubjectGrade SixtyOneSeven { get; set; }
        public StudentSubjectGrade SixtyOneEight { get; set; }
        public StudentSubjectGrade SixtyOneNine { get; set; }
        public StudentSubjectGrade SixtyOneTen { get; set; }

        //62
        public StudentSubjectGrade SixtyTwoOne { get; set; }
        public StudentSubjectGrade SixtyTwoTwo { get; set; }
        public StudentSubjectGrade SixtyTwoThree { get; set; }
        public StudentSubjectGrade SixtyTwoFour { get; set; }
        public StudentSubjectGrade SixtyTwoFive { get; set; }
        public StudentSubjectGrade SixtyTwoSix { get; set; }
        public StudentSubjectGrade SixtyTwoSeven { get; set; }
        public StudentSubjectGrade SixtyTwoEight { get; set; }
        public StudentSubjectGrade SixtyTwoNine { get; set; }
        public StudentSubjectGrade SixtyTwoTen { get; set; }

        //63
        public StudentSubjectGrade SixtyThreeOne { get; set; }
        public StudentSubjectGrade SixtyThreeTwo { get; set; }
        public StudentSubjectGrade SixtyThreeThree { get; set; }
        public StudentSubjectGrade SixtyThreeFour { get; set; }
        public StudentSubjectGrade SixtyThreeFive { get; set; }
        public StudentSubjectGrade SixtyThreeSix { get; set; }
        public StudentSubjectGrade SixtyThreeSeven { get; set; }
        public StudentSubjectGrade SixtyThreeEight { get; set; }
        public StudentSubjectGrade SixtyThreeNine { get; set; }
        public StudentSubjectGrade SixtyThreeTen { get; set; }

        //64
        public StudentSubjectGrade SixtyFourOne { get; set; }
        public StudentSubjectGrade SixtyFourTwo { get; set; }
        public StudentSubjectGrade SixtyFourThree { get; set; }
        public StudentSubjectGrade SixtyFourFour { get; set; }
        public StudentSubjectGrade SixtyFourFive { get; set; }
        public StudentSubjectGrade SixtyFourSix { get; set; }
        public StudentSubjectGrade SixtyFourSeven { get; set; }
        public StudentSubjectGrade SixtyFourEight { get; set; }
        public StudentSubjectGrade SixtyFourNine { get; set; }
        public StudentSubjectGrade SixtyFourTen { get; set; }

        //65
        public StudentSubjectGrade SixtyFiveOne { get; set; }
        public StudentSubjectGrade SixtyFiveTwo { get; set; }
        public StudentSubjectGrade SixtyFiveThree { get; set; }
        public StudentSubjectGrade SixtyFiveFour { get; set; }
        public StudentSubjectGrade SixtyFiveFive { get; set; }
        public StudentSubjectGrade SixtyFiveSix { get; set; }
        public StudentSubjectGrade SixtyFiveSeven { get; set; }
        public StudentSubjectGrade SixtyFiveEight { get; set; }
        public StudentSubjectGrade SixtyFiveNine { get; set; }
        public StudentSubjectGrade SixtyFiveTen { get; set; }

        //66
        public StudentSubjectGrade SixtySixOne { get; set; }
        public StudentSubjectGrade SixtySixTwo { get; set; }
        public StudentSubjectGrade SixtySixThree { get; set; }
        public StudentSubjectGrade SixtySixFour { get; set; }
        public StudentSubjectGrade SixtySixFive { get; set; }
        public StudentSubjectGrade SixtySixSix { get; set; }
        public StudentSubjectGrade SixtySixSeven { get; set; }
        public StudentSubjectGrade SixtySixEight { get; set; }
        public StudentSubjectGrade SixtySixNine { get; set; }
        public StudentSubjectGrade SixtySixTen { get; set; }

        //67
        public StudentSubjectGrade SixtySevenOne { get; set; }
        public StudentSubjectGrade SixtySevenTwo { get; set; }
        public StudentSubjectGrade SixtySevenThree { get; set; }
        public StudentSubjectGrade SixtySevenFour { get; set; }
        public StudentSubjectGrade SixtySevenFive { get; set; }
        public StudentSubjectGrade SixtySevenSix { get; set; }
        public StudentSubjectGrade SixtySevenSeven { get; set; }
        public StudentSubjectGrade SixtySevenEight { get; set; }
        public StudentSubjectGrade SixtySevenNine { get; set; }
        public StudentSubjectGrade SixtySevenTen { get; set; }

        //68
        public StudentSubjectGrade SixtyEightOne { get; set; }
        public StudentSubjectGrade SixtyEightTwo { get; set; }
        public StudentSubjectGrade SixtyEightThree { get; set; }
        public StudentSubjectGrade SixtyEightFour { get; set; }
        public StudentSubjectGrade SixtyEightFive { get; set; }
        public StudentSubjectGrade SixtyEightSix { get; set; }
        public StudentSubjectGrade SixtyEightSeven { get; set; }
        public StudentSubjectGrade SixtyEightEight { get; set; }
        public StudentSubjectGrade SixtyEightNine { get; set; }
        public StudentSubjectGrade SixtyEightTen { get; set; }

        //69
        public StudentSubjectGrade SixtyNineOne { get; set; }
        public StudentSubjectGrade SixtyNineTwo { get; set; }
        public StudentSubjectGrade SixtyNineThree { get; set; }
        public StudentSubjectGrade SixtyNineFour { get; set; }
        public StudentSubjectGrade SixtyNineFive { get; set; }
        public StudentSubjectGrade SixtyNineSix { get; set; }
        public StudentSubjectGrade SixtyNineSeven { get; set; }
        public StudentSubjectGrade SixtyNineEight { get; set; }
        public StudentSubjectGrade SixtyNineNine { get; set; }
        public StudentSubjectGrade SixtyNineTen { get; set; }

        //70
        public StudentSubjectGrade SeventyOne { get; set; }
        public StudentSubjectGrade SeventyTwo { get; set; }
        public StudentSubjectGrade SeventyThree { get; set; }
        public StudentSubjectGrade SeventyFour { get; set; }
        public StudentSubjectGrade SeventyFive { get; set; }
        public StudentSubjectGrade SeventySix { get; set; }
        public StudentSubjectGrade SeventySeven { get; set; }
        public StudentSubjectGrade SeventyEight { get; set; }
        public StudentSubjectGrade SeventyNine { get; set; }
        public StudentSubjectGrade SeventyTen { get; set; }

        //71
        public StudentSubjectGrade SeventyOneOne { get; set; }
        public StudentSubjectGrade SeventyOneTwo { get; set; }
        public StudentSubjectGrade SeventyOneThree { get; set; }
        public StudentSubjectGrade SeventyOneFour { get; set; }
        public StudentSubjectGrade SeventyOneFive { get; set; }
        public StudentSubjectGrade SeventyOneSix { get; set; }
        public StudentSubjectGrade SeventyOneSeven { get; set; }
        public StudentSubjectGrade SeventyOneEight { get; set; }
        public StudentSubjectGrade SeventyOneNine { get; set; }
        public StudentSubjectGrade SeventyOneTen { get; set; }

        //72
        public StudentSubjectGrade SeventyTwoOne { get; set; }
        public StudentSubjectGrade SeventyTwoTwo { get; set; }
        public StudentSubjectGrade SeventyTwoThree { get; set; }
        public StudentSubjectGrade SeventyTwoFour { get; set; }
        public StudentSubjectGrade SeventyTwoFive { get; set; }
        public StudentSubjectGrade SeventyTwoSix { get; set; }
        public StudentSubjectGrade SeventyTwoSeven { get; set; }
        public StudentSubjectGrade SeventyTwoEight { get; set; }
        public StudentSubjectGrade SeventyTwoNine { get; set; }
        public StudentSubjectGrade SeventyTwoTen { get; set; }

        //73
        public StudentSubjectGrade SeventyThreeOne { get; set; }
        public StudentSubjectGrade SeventyThreeTwo { get; set; }
        public StudentSubjectGrade SeventyThreeThree { get; set; }
        public StudentSubjectGrade SeventyThreeFour { get; set; }
        public StudentSubjectGrade SeventyThreeFive { get; set; }
        public StudentSubjectGrade SeventyThreeSix { get; set; }
        public StudentSubjectGrade SeventyThreeSeven { get; set; }
        public StudentSubjectGrade SeventyThreeEight { get; set; }
        public StudentSubjectGrade SeventyThreeNine { get; set; }
        public StudentSubjectGrade SeventyThreeTen { get; set; }

        //74
        public StudentSubjectGrade SeventyFourOne { get; set; }
        public StudentSubjectGrade SeventyFourTwo { get; set; }
        public StudentSubjectGrade SeventyFourThree { get; set; }
        public StudentSubjectGrade SeventyFourFour { get; set; }
        public StudentSubjectGrade SeventyFourFive { get; set; }
        public StudentSubjectGrade SeventyFourSix { get; set; }
        public StudentSubjectGrade SeventyFourSeven { get; set; }
        public StudentSubjectGrade SeventyFourEight { get; set; }
        public StudentSubjectGrade SeventyFourNine { get; set; }
        public StudentSubjectGrade SeventyFourTen { get; set; }

        public SeedData()
        {
            SeedSubjects();
            SeedClasses();
            SeedPrincipals();
            SeedParents();
            SeedStudents();
            SeedTeachers();
            SeedStudentSubjectGrades();
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
                ClassId = Tenth.Id,
                UserId = ""
            };
            BilyanaLozanova = new Teacher()
            {
                Id = 2,
                FullName = "Bilyana Lozanova",
                IsClassTeacher = true,
                Email = "b.lozanova@myschool.com",
                PhoneNumber = "5738291467",
                ClassId = Ninth.Id,
                UserId = ""
            };
            KrasimiraKutin = new Teacher()
            {
                Id = 3,
                FullName = "Krasimira Kutin",
                IsClassTeacher = false,
                Email = "k.kutin@myschool.com",
                PhoneNumber = "6248371095",
                ClassId = null,
                UserId = ""
            };
            TeodorHristov = new Teacher()
            {
                Id = 4,
                FullName = "Teodor Hristov",
                IsClassTeacher = false,
                Email = "t.hristov@myschool.com",
                PhoneNumber = "8902145673",
                ClassId = null,
                UserId = ""
            };
            SilviyaGancheva = new Teacher()
            {
                Id = 5,
                FullName = "Silviya Gancheva",
                IsClassTeacher = false,
                Email = "s.gancheva@myschool.com",
                PhoneNumber = "4512067839",
                ClassId = null,
                UserId = ""
            };
            CvetomirAmbursa = new Teacher()
            {
                Id = 6,
                FullName = "Cvetomir Ambursa",
                IsClassTeacher = true,
                Email = "c.ambursa@myschool.com",
                PhoneNumber = "7263489510",
                ClassId = Eleventh.Id,
                UserId = ""
            };
            MitkoMitkov = new Teacher()
            {
                Id = 7,
                FullName = "Mitko Mitkov",
                IsClassTeacher = false,
                Email = "m.mitkov@myschool.com",
                PhoneNumber = "5031982467",
                ClassId = null,
                UserId = ""
            };
            EmilStoyanov = new Teacher()
            {
                Id = 8,
                FullName = "Emil Stoyanov",
                IsClassTeacher = true,
                Email = "e.stoyanov@myschool.com",
                PhoneNumber = "3156924708",
                ClassId = Eight.Id,
                UserId = ""
            };
            BorislavaBangeeva = new Teacher()
            {
                Id = 9,
                FullName = "Borislava Bangeeva",
                IsClassTeacher = false,
                Email = "b.bangeeva@myschool.com",
                PhoneNumber = "9785402163",
                ClassId = null,
                UserId = ""
            };
            MariaIvanova = new Teacher()
            {
                Id = 10,
                FullName = "Maria Ivanova",
                IsClassTeacher = true,
                Email = "m.ivanova@myschool.com",
                PhoneNumber = "2047856931",
                ClassId = Twelfth.Id,
                UserId = ""
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
                UserId = ""

            };
            ValentinaStoeva = new Principal()
            {
                Id = 2,
                FullName = "Valentina Stoeva",
                Email = "v.stoeva@myschool.com",
                PhoneNumber = "8742035918",
                UserId = ""
            };
            YulianaPetkova = new Principal()
            {
                Id = 3,
                FullName = "Yuliana Petkova",
                Email = "y.petkova@myschool.com",
                PhoneNumber = "5268793407",
                UserId = ""
            };
        }
        private void SeedParents()
        {
            KrumIvanov = new Parent()
            {
                Id = 1,
                FullName = "Krum Ivanov",
                ChildId = 1,
                UserId = ""
            };
            VeronikaPetrova = new Parent()
            {
                Id = 2,
                FullName = "Veronika Petrova",
                ChildId = 2,
                UserId = ""
            };
            PlamenDimitrov = new Parent()
            {
                Id = 3,
                FullName = "Plamen Dimitrov",
                ChildId = 3,
                UserId = ""
            };
            ZlatinaGeorgieva = new Parent()
            {
                Id = 4,
                FullName = "Zlatina Georgieva",
                ChildId = 4,
                UserId = ""
            };
            RadoslavTodorov = new Parent()
            {
                Id = 5,
                FullName = "Radoslav Todorov",
                ChildId = 5,
                UserId = ""
            };
            AdrianaIvanova = new Parent()
            {
                Id = 6,
                FullName = "Adriana Ivanova",
                ChildId = 6,
                UserId = ""
            };
            BozhidarKolev = new Parent()
            {
                Id = 7,
                FullName = "Bozhidar Kolev",
                ChildId = 7,
                UserId = ""
            };
            EvelinaVasileva = new Parent()
            {
                Id = 8,
                FullName = "Evelina Vasileva",
                ChildId = 8,
                UserId = ""
            };
            StoyanPetrov = new Parent()
            {
                Id = 9,
                FullName = "Stoyan Petrov",
                ChildId = 9,
                UserId = ""
            };
            TsvetelinaStoyanova = new Parent()
            {
                Id = 10,
                FullName = "Tsvetelina Stoyanova",
                ChildId = 10,
                UserId = ""
            };
            LyubenMarinov = new Parent()
            {
                Id = 11,
                FullName = "Lyuben Marinov",
                ChildId = 11,
                UserId = ""
            };
            RositsaPetrova = new Parent()
            {
                Id = 12,
                FullName = "Rositsa Petrova",
                ChildId = 12,
                UserId = ""
            };
            KaloyanIvanov = new Parent()
            {
                Id = 13,
                FullName = "Kaloyan Ivanov",
                ChildId = 13,
                UserId = ""
            };
            EkaterinaGeorgieva = new Parent()
            {
                Id = 14,
                FullName = "Ekaterina Georgieva",
                ChildId = 14,
                UserId = ""
            };
            HristoDimitrov = new Parent()
            {
                Id = 15,
                FullName = "Hristo Dimitrov",
                ChildId = 15,
                UserId = ""
            };
            DobrinkaIvanova = new Parent()
            {
                Id = 16,
                FullName = "Dobrinka Ivanova",
                ChildId = 16,
                UserId = ""
            };
            BlagoyGeorgiev = new Parent()
            {
                Id = 17,
                FullName = "Blagoy Georgiev",
                ChildId = 17,
                UserId = ""
            };
            IskraKoleva = new Parent()
            {
                Id = 18,
                FullName = "Iskra Koleva",
                ChildId = 18,
                UserId = ""
            };
            KrasimirTodorov = new Parent()
            {
                Id = 19,
                FullName = "Krasimir Todorov",
                ChildId = 19,
                UserId = ""
            };
            GerganaIvanova = new Parent()
            {
                Id = 20,
                FullName = "Gergana Ivanova",
                ChildId = 20,
                UserId = ""
            };
            VasilPetrov = new Parent()
            {
                Id = 21,
                FullName = "Vasil Petrov",
                ChildId = 21,
                UserId = ""
            };
            NadezhdaDimitrova = new Parent()
            {
                Id = 22,
                FullName = "Nadezhda Dimitrova",
                ChildId = 22,
                UserId = ""
            };
            TodorGeorgiev = new Parent()
            {
                Id = 23,
                FullName = "Todor Georgiev",
                ChildId = 23,
                UserId = ""
            };
            RadkaIvanova = new Parent()
            {
                Id = 24,
                FullName = "Radka Ivanova",
                ChildId = 24,
                UserId = ""
            };
            HristinaStefanova = new Parent()
            {
                Id = 25,
                FullName = "Hristina Stefanova",
                ChildId = 25,
                UserId = ""
            };
            YavorKolev = new Parent()
            {
                Id = 26,
                FullName = "Yavor Kolev",
                ChildId = 26,
                UserId = ""
            };
            KameliaPetrova = new Parent()
            {
                Id = 27,
                FullName = "Kamelia Petrova",
                ChildId = 27,
                UserId = ""
            };
            EmilIvanov = new Parent()
            {
                Id = 28,
                FullName = "Emil Ivanov",
                ChildId = 28,
                UserId = ""
            };
            DilyanaAleksandrova = new Parent()
            {
                Id = 29,
                FullName = "Dilyana Aleksandrova",
                ChildId = 29,
                UserId = ""
            };
            TsvetanGeorgiev = new Parent()
            {
                Id = 30,
                FullName = "Tsvetan Georgiev",
                ChildId = 30,
                UserId = ""
            };
            ZhivkaIvanova = new Parent()
            {
                Id = 31,
                FullName = "Zhivka Ivanova",
                ChildId = 31,
                UserId = ""
            };
            IvoDimitrov = new Parent()
            {
                Id = 32,
                FullName = "Ivo Dimitrov",
                ChildId = 32,
                UserId = ""
            };
            AdriyanaStoyanova = new Parent()
            {
                Id = 33,
                FullName = "Adriyana Stoyanova",
                ChildId = 33,
                UserId = ""
            };
            KamenPetrov = new Parent()
            {
                Id = 34,
                FullName = "Kamen Petrov",
                ChildId = 34,
                UserId = ""
            };
            KristinaKoleva = new Parent()
            {
                Id = 35,
                FullName = "Kristina Koleva",
                ChildId = 35,
                UserId = ""
            };
            YankoIvanov = new Parent()
            {
                Id = 36,
                FullName = "Yanko Ivanov",
                ChildId = 36,
                UserId = ""
            };
            PolinaGeorgieva = new Parent()
            {
                Id = 37,
                FullName = "Polina Georgieva",
                ChildId = 37,
                UserId = ""
            };
            VeselinVasilev = new Parent()
            {
                Id = 38,
                FullName = "Veselin Vasilev",
                ChildId = 38,
                UserId = ""
            };
            AntoniyaPetrova = new Parent()
            {
                Id = 39,
                FullName = "Antoniya Petrova",
                ChildId = 39,
                UserId = ""
            };
            LyubomirDimitrov = new Parent()
            {
                Id = 40,
                FullName = "Lyubomir Dimitrov",
                ChildId = 40,
                UserId = ""
            };
            ZornitsaTodorova = new Parent()
            {
                Id = 41,
                FullName = "Zornitsa Todorova",
                ChildId = 41,
                UserId = ""
            };
            StefanIvanov = new Parent()
            {
                Id = 42,
                FullName = "Stefan Ivanov",
                ChildId = 42,
                UserId = ""
            };
            YoanaGeorgieva = new Parent()
            {
                Id = 43,
                FullName = "Yoana Georgieva",
                ChildId = 43,
                UserId = ""
            };
            KrasimiraPetrova = new Parent()
            {
                Id = 44,
                FullName = "Krasimira Petrova",
                ChildId = 44,
                UserId = ""
            };
            IvayloKolev = new Parent()
            {
                Id = 45,
                FullName = "Ivaylo Kolev",
                ChildId = 45,
                UserId = ""
            };
            MargaritaGeorgieva = new Parent()
            {
                Id = 46,
                FullName = "Margarita Georgieva",
                ChildId = 46,
                UserId = ""
            };
            RumenIvanov = new Parent()
            {
                Id = 47,
                FullName = "Rumen Ivanov",
                ChildId = 47,
                UserId = ""
            };
            MilenaDimitrova = new Parent()
            {
                Id = 48,
                FullName = "Milena Dimitrova",
                ChildId = 48,
                UserId = ""
            };
            YordanTodorov = new Parent()
            {
                Id = 49,
                FullName = "Yordan Todorov",
                ChildId = 49,
                UserId = ""
            };
            SilviyaPetrova = new Parent()
            {
                Id = 50,
                FullName = "Silviya Petrova",
                ChildId = 50,
                UserId = ""
            };
            BogdanIvanov = new Parent()
            {
                Id = 51,
                FullName = "Bogdan Ivanov",
                ChildId = 51,
                UserId = ""
            };
            PetyaKoleva = new Parent()
            {
                Id = 52,
                FullName = "Petya Koleva",
                ChildId = 52,
                UserId = ""
            };
            AsenMarinov = new Parent()
            {
                Id = 53,
                FullName = "Asen Marinov",
                ChildId = 53,
                UserId = ""
            };
            RalitsaIvanova = new Parent()
            {
                Id = 54,
                FullName = "Ralitsa Ivanova",
                ChildId = 54,
                UserId = ""
            };
            VelkoVasilev = new Parent()
            {
                Id = 55,
                FullName = "Velko Vasilev",
                ChildId = 55,
                UserId = ""
            };
            GalyaDimitrova = new Parent()
            {
                Id = 56,
                FullName = "Galya Dimitrova",
                ChildId = 56,
                UserId = ""
            };
            DimiturIvanov = new Parent()
            {
                Id = 57,
                FullName = "Dimitur Ivanov",
                ChildId = 57,
                UserId = ""
            };
            NadiaKoleva = new Parent()
            {
                Id = 58,
                FullName = "Nadia Koleva",
                ChildId = 58,
                UserId = ""
            };
            YulianPetrov = new Parent()
            {
                Id = 59,
                FullName = "Yulian Petrov",
                ChildId = 59,
                UserId = ""
            };
            RadostinaGeorgieva = new Parent()
            {
                Id = 60,
                FullName = "Radostina Georgieva",
                ChildId = 60,
                UserId = ""
            };
            KrasimIvanov = new Parent()
            {
                Id = 61,
                FullName = "Krasim Ivanov",
                ChildId = 61,
                UserId = ""
            };
            TeodoraTodorova = new Parent()
            {
                Id = 62,
                FullName = "Teodora Todorova",
                ChildId = 62,
                UserId = ""
            };
            KalinPetrov = new Parent()
            {
                Id = 63,
                FullName = "Kalin Petrov",
                ChildId = 63,
                UserId = ""
            };
            SvetlaDimitrova = new Parent()
            {
                Id = 64,
                FullName = "Svetla Dimitrova",
                ChildId = 64,
                UserId = ""
            };
            VentsislavGeorgiev = new Parent()
            {
                Id = 65,
                FullName = "Ventsislav Georgiev",
                ChildId = 65,
                UserId = ""
            };
            VasilenaIvanova = new Parent()
            {
                Id = 66,
                FullName = "Vasilena Ivanova",
                ChildId = 66,
                UserId = ""
            };
            MartinPetrov = new Parent()
            {
                Id = 67,
                FullName = "Martin Petrov",
                ChildId = 67,
                UserId = ""
            };
            RalitsaKoleva = new Parent()
            {
                Id = 68,
                FullName = "Ralitsa Koleva",
                ChildId = 68,
                UserId = ""
            };
            StefanDimitrov = new Parent()
            {
                Id = 69,
                FullName = "Stefan Dimitrov",
                ChildId = 69,
                UserId = ""
            };
            SnezhanaGeorgieva = new Parent()
            {
                Id = 70,
                FullName = "Snezhana Georgieva",
                ChildId = 70,
                UserId = ""
            };
            IvayloIvanov = new Parent()
            {
                Id = 71,
                FullName = "Ivaylo Ivanov",
                ChildId = 71,
                UserId = ""
            };
            MarianaPetrova = new Parent()
            {
                Id = 72,
                FullName = "Mariana Petrova",
                ChildId = 72,
                UserId = ""
            };
            RosenKolev = new Parent()
            {
                Id = 73,
                FullName = "Rosen Kolev",
                ChildId = 73,
                UserId = ""
            };
            TanyaStoyanova = new Parent()
            {
                Id = 74,
                FullName = "Tanya Stoyanova",
                ChildId = 74,
                UserId = ""
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
                ParentId = 1,
                UserId = ""
            };
            ElenaPetrova = new Student()
            {
                Id = 2,
                FirstName = "Elena",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 2,
                UserId = ""
            };
            StefchoDimitrov = new Student()
            {
                Id = 3,
                FirstName = "Stefcho",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 3,
                UserId = ""
            };
            MilenaGeorgieva = new Student()
            {
                Id = 4,
                FirstName = "Milena",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 4,
                UserId = ""
            };
            AleksandarTodorov = new Student()
            {
                Id = 5,
                FirstName = "Aleksandar",
                LastName = "Todorov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 5,
                UserId = ""
            };
            ViktoriaIvanova = new Student()
            {
                Id = 6,
                FirstName = "Viktoria",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 6,
                UserId = ""
            };
            NikolayKolev = new Student()
            {
                Id = 7,
                FirstName = "Nikolay",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 7,
                UserId = ""
            };
            MariaVasileva = new Student()
            {
                Id = 8,
                FirstName = "Maria",
                LastName = "Vasileva",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 8,
                UserId = ""
            };
            IvayloPetrov = new Student()
            {
                Id = 9,
                FirstName = "Ivaylo",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 9,
                UserId = ""
            };
            GabrielaStoyanova = new Student()
            {
                Id = 10,
                FirstName = "Gabriela",
                LastName = "Stoyanova",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 10,
                UserId = ""
            };
            GeorgiMarinov = new Student()
            {
                Id = 11,
                FirstName = "Georgi",
                LastName = "Marinov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 11,
                UserId = ""
            };
            KristinaPetrova = new Student()
            {
                Id = 12,
                FirstName = "Kristina",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 12,
                UserId = ""
            };
            RumchoIvanov = new Student()
            {
                Id = 13,
                FirstName = "Rumcho",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 13,
                UserId = ""
            };
            EmiliaGeorgieva = new Student()
            {
                Id = 14,
                FirstName = "Emilia",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Eight.Id,
                ClassTeacherId = Eight.TeacherId,
                ParentId = 14,
                UserId = ""
            };


            KrasimirDimitrov = new Student()
            {
                Id = 15,
                FirstName = "Krasimir",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 15,
                UserId = ""
            };
            SilviyaIvanova = new Student()
            {
                Id = 16,
                FirstName = "Silviya",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 16,
                UserId = ""
            };
            AsenGeorgiev = new Student()
            {
                Id = 17,
                FirstName = "Asen",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 17,
                UserId = ""
            };
            ElenaKoleva = new Student()
            {
                Id = 18,
                FirstName = "Elena",
                LastName = "Koleva",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 18,
                UserId = ""
            };
            StanimirTodorov = new Student()
            {
                Id = 19,
                FirstName = "Stanimir",
                LastName = "Todorov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 19,
                UserId = ""
            };
            MagdalenaIvanova = new Student()
            {
                Id = 20,
                FirstName = "Magdalena",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 20,
                UserId = ""
            };
            HristoPetrov = new Student()
            {
                Id = 21,
                FirstName = "Hristo",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 21,
                UserId = ""
            };
            KalinaDimitrova = new Student()
            {
                Id = 22,
                FirstName = "Kalina",
                LastName = "Dimitrova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 22,
                UserId = ""
            };
            TsvetanchoGeorgiev = new Student()
            {
                Id = 23,
                FirstName = "Tsvetancho",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 23,
                UserId = ""
            };
            NadezhdaIvanova = new Student()
            {
                Id = 24,
                FirstName = "Nadezhda",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 24,
                UserId = ""
            };
            BorisStefanov = new Student()
            {
                Id = 25,
                FirstName = "Boris",
                LastName = "Stefanov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 25,
                UserId = ""
            };
            AneliyaKoleva = new Student()
            {
                Id = 26,
                FirstName = "Aneliya",
                LastName = "Koleva",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 26,
                UserId = ""
            };
            RosenPetrov = new Student()
            {
                Id = 27,
                FirstName = "Rosen",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 27,
                UserId = ""
            };
            RadostinaIvanova = new Student()
            {
                Id = 28,
                FirstName = "Radostina",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 28,
                UserId = ""
            };
            VasilAleksandrov = new Student()
            {
                Id = 29,
                FirstName = "Vasil",
                LastName = "Aleksandrov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 29,
                UserId = ""
            };
            RositsaGeorgieva = new Student()
            {
                Id = 30,
                FirstName = "Rositsa",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 30,
                UserId = ""
            };
            PlamenIvanov = new Student()
            {
                Id = 31,
                FirstName = "Plamen",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Ninth.Id,
                ClassTeacherId = Ninth.TeacherId,
                ParentId = 31,
                UserId = ""
            };


            ValentinaDimitrova = new Student()
            {
                Id = 32,
                FirstName = "Valentina",
                LastName = "Dimitrova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 32,
                UserId = ""
            };
            IvoStoyanov = new Student()
            {
                Id = 33,
                FirstName = "Ivo",
                LastName = "Stoyanov",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 33,
                UserId = ""
            };
            StefaniyaPetrova = new Student()
            {
                Id = 34,
                FirstName = "Stefaniya",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 34,
                UserId = ""
            };
            MartinKolev = new Student()
            {
                Id = 35,
                FirstName = "Martin",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 35,
                UserId = ""
            };
            SonyaIvanova = new Student()
            {
                Id = 36,
                FirstName = "Sonya",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 36,
                UserId = ""
            };
            LyubomirGeorgiev = new Student()
            {
                Id = 37,
                FirstName = "Lyubomir",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 37,
                UserId = ""
            };
            NataliyaVasileva = new Student()
            {
                Id = 38,
                FirstName = "Nataliya",
                LastName = "Vasileva",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 38,
                UserId = ""
            };
            PetarPetrov = new Student()
            {
                Id = 39,
                FirstName = "Petar",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 39,
                UserId = ""
            };
            GerganaDimitrova = new Student()
            {
                Id = 40,
                FirstName = "Gergana",
                LastName = "Dimitrova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 40,
                UserId = ""
            };
            LyubomiraTodorova = new Student()
            {
                Id = 41,
                FirstName = "Lyubomira",
                LastName = "Todorova",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 41,
                UserId = ""
            };
            AntonIvanov = new Student()
            {
                Id = 42,
                FirstName = "Anton",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 42,
                UserId = ""
            };
            TanyaGeorgieva = new Student()
            {
                Id = 43,
                FirstName = "Tanya",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Tenth.Id,
                ClassTeacherId = Tenth.TeacherId,
                ParentId = 43,
                UserId = ""
            };


            KamenchoPetrov = new Student()
            {
                Id = 44,
                FirstName = "Kamencho",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 44,
                UserId = ""
            };
            VanyaKoleva = new Student()
            {
                Id = 45,
                FirstName = "Vanya",
                LastName = "Koleva",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 45,
                UserId = ""
            };
            RadoslavGeorgiev = new Student()
            {
                Id = 46,
                FirstName = "Radoslav",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 46,
                UserId = ""
            };
            VasilenkaIvanova = new Student()
            {
                Id = 47,
                FirstName = "Vasilenka",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 47,
                UserId = ""
            };
            KirilDimitrov = new Student()
            {
                Id = 48,
                FirstName = "Kiril",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 48,
                UserId = ""
            };
            KameliyaTodorova = new Student()
            {
                Id = 49,
                FirstName = "Kameliya",
                LastName = "Todorova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 49,
                UserId = ""
            };
            IliyaPetrov = new Student()
            {
                Id = 50,
                FirstName = "Iliya",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 50,
                UserId = ""
            };
            DilyanaIvanova = new Student()
            {
                Id = 51,
                FirstName = "Dilyana",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 51,
                UserId = ""
            };
            BogdanKolev = new Student()
            {
                Id = 52,
                FirstName = "Bogdan",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 52,
                UserId = ""
            };
            DanielaMarinova = new Student()
            {
                Id = 53,
                FirstName = "Daniela",
                LastName = "Marinova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 53,
                UserId = ""
            };
            HristiyanIvanov = new Student()
            {
                Id = 54,
                FirstName = "Hristiyan",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 54,
                UserId = ""
            };
            TeodoraVasileva = new Student()
            {
                Id = 55,
                FirstName = "Teodora",
                LastName = "Vasileva",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 55,
                UserId = ""
            };
            DesislavDimitrov = new Student()
            {
                Id = 56,
                FirstName = "Desislav",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 56,
                UserId = ""
            };
            GalyaIvanova = new Student()
            {
                Id = 57,
                FirstName = "Galya",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 57,
                UserId = ""
            };
            IvanKolev = new Student()
            {
                Id = 58,
                FirstName = "Ivan",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 58,
                UserId = ""
            };
            MariyaPetrova = new Student()
            {
                Id = 59,
                FirstName = "Mariya",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Eleventh.Id,
                ClassTeacherId = Eleventh.TeacherId,
                ParentId = 59,
                UserId = ""
            };


            SimeonGeorgiev = new Student()
            {
                Id = 60,
                FirstName = "Simeon",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 60,
                UserId = ""
            };
            MagdalinaIvanova = new Student()
            {
                Id = 61,
                FirstName = "Magdalina",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 61,
                UserId = ""
            };
            EmilTodorov = new Student()
            {
                Id = 62,
                FirstName = "Emil",
                LastName = "Todorov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 62,
                UserId = ""
            };
            KalinchoPetrov = new Student()
            {
                Id = 63,
                FirstName = "Kalincho",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 63,
                UserId = ""
            };
            RalitsaDimitrova = new Student()
            {
                Id = 64,
                FirstName = "Ralitsa",
                LastName = "Dimitrova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 64,
                UserId = ""
            };
            YordanGeorgiev = new Student()
            {
                Id = 65,
                FirstName = "Yordan",
                LastName = "Georgiev",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 65,
                UserId = ""
            };
            RadinkaIvanova = new Student()
            {
                Id = 66,
                FirstName = "Radinka",
                LastName = "Ivanova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 66,
                UserId = ""
            };
            VentsislavPetrov = new Student()
            {
                Id = 67,
                FirstName = "Ventsislav",
                LastName = "Petrov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 67,
                UserId = ""
            };
            DarinaKoleva = new Student()
            {
                Id = 68,
                FirstName = "Darina",
                LastName = "Koleva",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 68,
                UserId = ""
            };
            BozhidarDimitrov = new Student()
            {
                Id = 69,
                FirstName = "Bozhidar",
                LastName = "Dimitrov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 69,
                UserId = ""
            };
            NeliGeorgieva = new Student()
            {
                Id = 70,
                FirstName = "Neli",
                LastName = "Georgieva",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 70,
                UserId = ""
            };
            YavorIvanov = new Student()
            {
                Id = 71,
                FirstName = "Yavor",
                LastName = "Ivanov",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 71,
                UserId = ""
            };
            MilitsaPetrova = new Student()
            {
                Id = 72,
                FirstName = "Militsa",
                LastName = "Petrova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 72,
                UserId = ""
            };
            ZdravkoKolev = new Student()
            {
                Id = 73,
                FirstName = "Zdravko",
                LastName = "Kolev",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 73,
                UserId = ""
            };
            ElenaStoyanova = new Student()
            {
                Id = 74,
                FirstName = "Elena",
                LastName = "Stoyanova",
                AverageScore = 0,
                ClassId = Twelfth.Id,
                ClassTeacherId = Twelfth.TeacherId,
                ParentId = 74,
                UserId = ""
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