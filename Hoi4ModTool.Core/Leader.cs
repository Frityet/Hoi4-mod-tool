using System;
using System.Drawing;

namespace Hoi4ModTool.Core
{
    class Leader
    {
        public string LeaderName { get; set;}


        public string LeaderPicture { get; set; }


        public string LeaderIdeology {get; set; }


        public LeaderTraits[] Traits { get; set; }
// this gonna be a pain in the ass
        public enum LeaderTraits
        {

            AmericanCaesar,

            AnarchistZeal,

            AntiCommunist,

            AntiDemocrat,

            Appeaser,

            AssassinationSurvivor,

            AutocraticImperialist,

            Basileus,

            BritishBulldog,

            CabinetCrisis,

            CamarillaLeader,


            Caudillo1,

            Caudillo2,

            ChampionofPeace1,

            ChampionofPeace2,

            ChampionofPeace3,

            ChampionofPeace4,

            ChampionofPeace5,

            CominternWorkhorse,

            ConservativeGrandee,

            ConservativeNationalist,

            ConservativeNationalist,

            ConstitutionalMonarch,

            ConstitutionalMonarchMinor,

            CorneredFox,
            
            CountofParis,

            CristeroGeneral,

            CrownRegent,

            Dealbroker,

            Defeatist,

            DevotedTrotskyist,


            Dictator,

            DisdainforPoliticians1,

            DisdainforPoliticians2,

            DisgracedMonarch,

            DislikesGermany,






        }

    }

}