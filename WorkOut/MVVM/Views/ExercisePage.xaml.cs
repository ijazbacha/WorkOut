using WorkOut.MVVM.ViewModels;

namespace WorkOut.MVVM.Views;

public partial class ExercisePage : ContentPage
{
    public ExercisePage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
};