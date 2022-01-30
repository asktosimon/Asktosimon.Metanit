using System.Collections.ObjectModel;
using System.Collections.Specialized;

var people = new ObservableCollection<string>();

NotifyCollectionChangedEventHandler handler = (sender, e) =>
{
    var a = e.Action switch
    {
        NotifyCollectionChangedAction.Add => "sdsdsd",
        _ => "sdsdsd"
    };

    Console.WriteLine(a);
};

people.CollectionChanged += handler;

people.Add("BOB");