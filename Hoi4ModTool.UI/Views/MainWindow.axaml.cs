using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Hoi4ModTool.Common;

namespace Hoi4ModTool.UI.Views
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            var leaderIdeology = this.Find<ComboBox>("LeaderIdeology");
            leaderIdeology.Items = Ideologies.IDEOLOGY_NAMES.Values;
            leaderIdeology.SelectedIndex = 0;

            var rulingParty = this.Find<ComboBox>("RulingParty");
            rulingParty.Items = Ideologies.PARTY_NAMES.Values;
            leaderIdeology.SelectedIndex = 1;
        }
    }
}