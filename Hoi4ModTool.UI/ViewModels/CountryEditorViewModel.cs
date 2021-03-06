using System.Drawing;
using System.Linq;
using Hoi4ModTool.Core;

namespace Hoi4ModTool.UI.ViewModels
{
    public class CountryEditorViewModel : ViewModelBase
    {
        public string[] IdeologyNames => Ideologies.IDEOLOGY_NAMES.Values.ToArray();
        public string[] PartyNames => Ideologies.PARTY_NAMES.Values.ToArray();

        public Country Country { get; set; }

        public CountryEditorViewModel()
        {
            Country = new Country();
        }

    }
}