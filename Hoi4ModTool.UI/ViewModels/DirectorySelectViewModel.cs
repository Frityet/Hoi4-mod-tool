using System.IO;

namespace Hoi4ModTool.UI.ViewModels
{
    public class DirectorySelectViewModel : ViewModelBase
    {
        public DirectoryInfo? ModDir { get; set; }
                
        public string SelectedModDir => $"Selected Mod: {(ModDir is null ? "" : ModDir.FullName)}";
    }
}