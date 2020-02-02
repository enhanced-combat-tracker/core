using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using EnhancedCombatTracker.Tabs.Settings.ViewModels;

namespace EnhancedCombatTracker.Tabs
{
    public class SettingsTab : UserControl
    {
        public SettingsTab()
        {
            InitializeComponent();
            DataContext = new SettingsListViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}