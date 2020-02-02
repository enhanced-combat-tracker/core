using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using EnhancedCombatTracker.ViewModels;

namespace EnhancedCombatTracker
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(/*this.Get<TabControl>("Tabs")*/);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void AddTab(string Plugin, string Header, UserControl Panel)
        {
            ((MainWindowViewModel)DataContext).AddTab(Plugin, Header, Panel);
        }
    }
}