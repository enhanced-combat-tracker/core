using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Avalonia.Controls;
using ReactiveUI;

namespace EnhancedCombatTracker.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private List<TabItem> items = new List<TabItem>();

        public MainWindowViewModel(/*TabControl Tabs*/)
        {/*
            rightTabs = new List<TabItem>{
                Tabs.Get<TabItem>("Plugins"),
                Tabs.Get<TabItem>("Settings")
            };*/
        }

        public List<TabItem> Items { get => items; set => this.RaiseAndSetIfChanged(ref items, value); }

        private SortedDictionary<string, TabItem> leftTabs = new SortedDictionary<string, TabItem>();

        private List<TabItem> rightTabs = new List<TabItem>();

        internal void AddTab(string Plugin, string Header, UserControl Panel)
        {
            TabItem item = new TabItem();
            item.Header = Header;
            item.Content = Panel;
            
            leftTabs.Add(Plugin+Header,item);

            List<TabItem> newItems = new List<TabItem>();
            newItems.AddRange(leftTabs.Values);
            newItems.AddRange(rightTabs);
        }
    }
}