using System.Collections.Generic;
using EnhancedCombatTracker.Tabs.Plugins.Models;

namespace EnhancedCombatTracker.Tabs.Plugins.Services
{
    public class PluginStorage
    {
        public IEnumerable<ListItem> GetItems() => new[]
        {
            new ListItem { 
                Details = "Details 1",
                Enabled = false,
                Information = "Info 1",
                Name = "Plugin 1"
             },
            new ListItem { 
                Details = "Details 2",
                Enabled = true,
                Information = "Info 2",
                Name = "Plugin 2"
             },
            new ListItem { 
                Details = "Details 3",
                Enabled = false,
                Information = "Info 3",
                Name = "Plugin 3"
             }
        };
    }
}