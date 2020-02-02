using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using EnhancedCombatTracker.Tabs.Plugins.Services;
using EnhancedCombatTracker.Tabs.Plugins.ViewModels;

namespace EnhancedCombatTracker.Tabs
{
    public class PluginsTab : UserControl
    {

        public PluginsTab()
        {
            InitializeComponent();
            DataContext = new PluginsListViewModel(new PluginStorage().GetItems());
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}