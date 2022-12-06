using WorkOut.MVVM.Views;

namespace WorkOut;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ExercisePage();
	}
}
