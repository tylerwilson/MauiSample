using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiSample.ViewModels;

namespace MauiSample.Views;

public partial class ControlView : ContentView
{
    public static readonly BindableProperty ViewModelProperty =
        BindableProperty.Create(nameof(ViewModel), typeof(ControlViewModel), typeof(ControlView), null, propertyChanged: SetViewModelProperty);

    public ControlViewModel ViewModel
    {
        get => (ControlViewModel)GetValue(ViewModelProperty);
        set => SetValue(ViewModelProperty, value);
    }

    private static void SetViewModelProperty(BindableObject bindable, object oldValue, object newValue)
    {
        //(bindable as ControlView)?.UpdateContext();
    }

    public ControlView()
    {
        InitializeComponent();

        ViewModel = new ControlViewModel();

        BindingContext = ViewModel;
    }

    // public ControlView(ControlViewModel vm)
    // {
    //     InitializeComponent();
    // }
}