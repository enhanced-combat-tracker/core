using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace EnhancedCombatTracker.Tabs.Settings
{
    public class TreeView : UserControl
    {
        public TreeView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}