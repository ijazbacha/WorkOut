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
		else if(ExViewModel.Exercise == null)
		{
            DisplayAlert("Input Warning", "Exercise Field is Empty", "ok");
        }
		else
		{
			DisplayAlert("Category Warning", "Please Select Category", "ok");
		}
	}

	private async void Button_Clicked_1(object sender, EventArgs e)
	{
		var modelView = BindingContext as AddExerciseViewModel;
		var categoryTitle = await DisplayPromptAsync("Add New Category",
			"Category Name", maxLength:50, keyboard: Keyboard.Text);
		modelView.Categories.Add(new Category
		{
			Id = modelView.Categories.Count() + 1,
			Title = categoryTitle
		}) ;
	}
}