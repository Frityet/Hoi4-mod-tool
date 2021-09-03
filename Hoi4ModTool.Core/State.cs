namespace Hoi4ModTool.Core
{
    public class State
    {
        public string StateName { get; set; }

        public Country StateOwner { get; set; }

        public int StatePopulation { get; set; }

        public string StateAirZoneName { get; set;}

        public string StateSupplyAreaName { get; set; }

        public int StateSupply { get; set; }

        public int[] StateProvinces { get; set; }

        public StateBuildings[] Bulidings { get; set; }

        public enum StateBuildings
        {
            Airports,

            CivilianFactory,

            MilltaryFactory,

            Dockyard,

        }
    }


}