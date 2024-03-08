using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSample.ViewModels;

public partial class ControlViewModel: ObservableObject
{
    [ObservableProperty]
    private ushort _multiColumnWidth;

    public ControlViewModel()
    {
        CalcSizes();
    }
    
    private void CalcSizes()
    {
#if MACCATALYST
        MultiColumnWidth = 400;
#else
        var width = DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density;
        MultiColumnWidth = (ushort)(width / 3);
#endif
    }
}