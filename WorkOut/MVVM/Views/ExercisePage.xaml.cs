using WorkOut.MVVM.ViewModels;

namespace WorkOut.MVVM.Views;

public partial class ExercisePage : ContentPage
{
    MainPageViewModel MainPageVM = new MainPageViewModel();
    public ExercisePage()
    {
        InitializeComponent();
        BindingContext = MainPageVM;
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        MainPageVM.FindPendingExercise();
    }
};