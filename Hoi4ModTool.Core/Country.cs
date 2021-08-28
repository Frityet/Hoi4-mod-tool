namespace Hoi4ModTool.Core

using Ideologies.Parties;
{
    public class Country
    {
        public string CountryName { get; set; }

        public string CountryTag { get; set; }
        
        public Ideologies.Parties CountryRulingParty { get; set; }

        public enum CountryCulture
        {
            
        }


        public int CapitalStateId { get; set;}

        public int ResearchSlots { get; set;}


        public int CountryColor { get; set; }
    }
}