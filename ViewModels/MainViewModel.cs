using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSample.ViewModels;

public partial class MainViewModel: ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<string> _items = [];
    
    public MainViewModel()
    {
        Items =
        [
            "Item 1",
            // "Item 2",
            // "Item 3"
        ];
    }
}