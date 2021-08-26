using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Hoi4ModTool.UI.Views
{
    public partial class MainWindow : Window
    {
        private static readonly List<string> IDEOLOGIES = new List<string>()
        {
            "democratic-conservatism", 
            "democratic-liberalism", 
            "democratic-socialism", 
            
            "fascism-nazism",
            "fascism-fascism", 
            "fascism-falangism", 
            "fascism-rexism", 
            
            "communism-marxism", 
            "communism-leninism",
            "communism-stalinism", 
            
            "non aligned-despotism", 
            "non aligned-oligarchism", 
            "non aligned-moderatism",
            "non aligned-centrism"
        };
        
        private static readonly List<string> PARTIES = new List<string>()
        {
            "Fascism",
            "Communism",
            "Democracy",
            "Non-Alligned"
        };
        
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
            leaderIdeology.Items = IDEOLOGIES;
            leaderIdeology.SelectedIndex = 0;

            var rulingParty = this.Find<ComboBox>("RulingParty");
            rulingParty.Items = PARTIES;
            leaderIdeology.SelectedIndex = 0;
        }
    }
}