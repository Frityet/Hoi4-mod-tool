using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

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
        }
    }
}