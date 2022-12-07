using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOut.MVVM.Models;

namespace WorkOut.MVVM.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Exercise> Exercises { get; set; }
    
        public MainPageViewModel()
        {
            LoadData();
            FindPendingExercise();
        }

        public void FindPendingExercise()
        {
            foreach (var category in Categories)
            {
                var ExerciseByCategory = Exercises.Where(item => item.CategoryId == category.Id).ToList();
                
                var Pending = ExerciseByCategory.Where(item => item.IsCompleted == false).ToList();
                category.PendingExercises = Pending.Count();

                var Completed = ExerciseByCategory.Where(item => item.IsCompleted == true).ToList();
                category.Percentage = (float)Completed.Count() / (float)ExerciseByCategory.Count();
                
            }
        }

        private void LoadData()
        {
            Categories = new ObservableCollection<Category>()
            {
                new Category{Id=1, Title="Abs"},
                new Category{Id=2, Title="Love Handle"},
                new Category{Id=3, Title="Glutes"},
                new Category{Id=4, Title="Hamstring"},
                new Category{Id=5, Title="Biceps"},
                new Category{Id=6, Title="Triceps"},
                new Category{Id=7, Title="Chest"},
                new Category{Id=8, Title="Cardio"},
                new Category{Id=9, Title="HIIT"},
            };

            Exercises = new ObservableCollection<Exercise>()
            {
                new Exercise{Name="Plank", CategoryId=1, IsCompleted=true},
                new Exercise{Name="Mountain Climb", CategoryId=1, IsCompleted=false},
                new Exercise{Name="Side Bend", CategoryId=2, IsCompleted=false},
                new Exercise{Name="Bicycle Crunch", CategoryId=2, IsCompleted=false},
                new Exercise{Name="Bridge", CategoryId=3, IsCompleted=false},
                new Exercise{Name="Pushups", CategoryId=3, IsCompleted=true},
                new Exercise{Name="Running", CategoryId=4, IsCompleted=true},
                new Exercise{Name="Burpee", CategoryId=5, IsCompleted=false},
                new Exercise{Name="Dips", CategoryId=5, IsCompleted=false},
                new Exercise{Name="Fly Arm", CategoryId=6, IsCompleted=false},
                new Exercise{Name="Tri Dips", CategoryId=7, IsCompleted=false},
                new Exercise{Name="Feet Rise", CategoryId=7, IsCompleted=false},
                new Exercise{Name="T-rotation", CategoryId=8, IsCompleted=false},
                new Exercise{Name="Plank Tap", CategoryId=9, IsCompleted=false},
            };
        }
    }
}
