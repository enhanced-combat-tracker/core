using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using EnhancedCombatTracker.Tabs.Plugins.Models;
using ReactiveUI;

namespace EnhancedCombatTracker.Tabs.Plugins.ViewModels
{
    public class PluginsListViewModel : ReactiveObject
    {
        public PluginsListViewModel(IEnumerable<ListItem> items)
        {
            Items = new ObservableCollection<ListItem>(items);
        }

        public ObservableCollection<ListItem> Items { get; }

        private ListItem selectedItem;

        public ListItem SelectedItem {get => selectedItem;set => this.RaiseAndSetIfChanged(ref selectedItem, value);}

    }
}