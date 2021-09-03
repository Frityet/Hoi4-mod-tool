using System;
using System.Drawing;

namespace Hoi4ModTool.Core
{
    public class Country
    {
        public string Name                      { get; set; }

        public string Tag                       { get; set; }

        public Color Colour                     { get; set; }

        public Ideologies.Parties RulingParty   { get; set; }

        public PartySupport PartySupport        { get; set; }

        public int StateId                      { get; set; }

        public int ResearchSlots                { get; set; }

        public int Stability                    { get; set; }
        
        public int WarSupport                   { get; set; }
    }

    public class PartySupport
    {
        public int Democracy    { get; set; }
        public int Communism    { get; set; }
        public int Fascism      { get; set; }
        public int NonAligned   { get; set; }
    }
}