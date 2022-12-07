using WorkOut.MVVM.Models;
using WorkOut.MVVM.ViewModels;

namespace WorkOut.MVVM.Views;

public partial class AddNewExercise : ContentPage
{
	public AddNewExercise()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		var ExViewModel = BindingContext as AddExerciseViewModel;
		var SelectedCategory = ExViewModel.Categories.Where(item => item.IsSelected == true).FirstOrDefault();
		if(SelectedCategory != null)
		{
			var NewExercise = new Exercise
			{
				Name = ExViewModel.Exercise,
				CategoryId = SelectedCategory.Id,
				IsCompleted = false
			};
			ExViewModel.Exercises.Add(NewExercise);
			Navigation.PopAsync();
		}
	}
}