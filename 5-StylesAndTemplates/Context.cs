using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace StylesAndTemplates
{
    public class Context
    {
        ObservableCollection<Item> _items;

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public Context()
        {
            var items = new Item[]
            {
                new Item { IsChecked = false, Name="Name1"},
                new Item { IsChecked = true, Name="Name2"},
                new Item { IsChecked = false, Name="Name3"},
                new Item { IsChecked = false, Name="Name4"}
            };
            _items = new ObservableCollection<Item>(items);
        }
    }
}
