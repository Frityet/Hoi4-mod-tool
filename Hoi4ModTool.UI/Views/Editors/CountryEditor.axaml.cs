using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaColorPicker;

namespace Hoi4ModTool.UI.Controls
{

    public class CountryEditor : UserControl
    {

        public CountryEditor()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            var controls = new Controls
            {
                CountryName = this.Find<TextBox>("CountryName"),
                CountryTag = this.Find<TextBox>("CountryTag"),
                CountryColour = this.Find<ColorPicker>("CountryColour"),
                
                LeaderName = this.Find<TextBox>("LeaderName"),
                LeaderIdeology = this.Find<ComboBox>("LeaderIdeology"),
                
                FascismPopularity = this.Find<NumericUpDown>("FascismPopularity"),
                CommunismPopularity = this.Find<NumericUpDown>("CommunismPopularity"),
                DemocracyPopularity = this.Find<NumericUpDown>("DemocracyPopularity"),
                NonAlignedPopularity = this.Find<NumericUpDown>("NonAlignedPopularity"),
                RulingParty = this.Find<ComboBox>("RulingParty"),
                
                ResearchSlots = this.Find<NumericUpDown>("ResearchSlots"),
                WarSupport = this.Find<NumericUpDown>("WarSupport"),
                Stability = this.Find<NumericUpDown>("Stability"),
                
                CapitalStateID = this.Find<NumericUpDown>("CapitalStateID")
            };
        }
        
        private struct Controls
        {
            public TextBox      CountryName     { get; init; }
            public TextBox      CountryTag      { get; init; }
            public ColorPicker  CountryColour   { get; init; }
            
            public TextBox      LeaderName      { get; init; }
            public ComboBox     LeaderIdeology  { get; init; }
            
            public NumericUpDown    FascismPopularity       { get; init; }
            public NumericUpDown    CommunismPopularity     { get; init; }
            public NumericUpDown    DemocracyPopularity     { get; init; }
            public NumericUpDown    NonAlignedPopularity    { get; init; }
            public ComboBox         RulingParty             { get; init; }
            
            public NumericUpDown    ResearchSlots   { get; init; }
            public NumericUpDown    WarSupport      { get; init; }
            public NumericUpDown    Stability       { get; init; }

            public NumericUpDown    CapitalStateID  { get; init; }

            
        }
    }
}