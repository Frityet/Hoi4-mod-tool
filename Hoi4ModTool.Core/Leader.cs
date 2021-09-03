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
            Dictator,
            
            WarriorCode,

            UnderageMonarch,

            LegitimateHeir,

            CollaboratorKing,

            ImperialSanction,

            EmperorShowa,

            WW1Trauma,

            StoutDefender,

            Warmonger,

            InexperiencedImperialist,

            AutocraticImperialist,
            
        }

    }

}