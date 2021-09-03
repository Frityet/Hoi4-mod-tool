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

        public enum LeaderTraits
        {
            Dictator,
            
            WarriorCode,

            UnderageMonarch,

            LegitimateHeir,

            CollaboratorKing,

        }

    }

}