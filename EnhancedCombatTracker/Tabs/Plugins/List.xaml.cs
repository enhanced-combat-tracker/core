using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace EnhancedCombatTracker.Tabs.Plugins
{
    public class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}