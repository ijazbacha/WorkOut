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
                new Exercise{Name="Plank", CategoryId=1, IsCompleted=false},
                new Exercise{Name="Plank", CategoryId=2, IsCompleted=false},
                new Exercise{Name="Bicycle Crunch", CategoryId=1, IsCompleted=false},
                new Exercise{Name="Bicycle Crunch", CategoryId=3, IsCompleted=false},
                new Exercise{Name="Pushups", CategoryId=7, IsCompleted=false},
                new Exercise{Name="Pushups", CategoryId=5, IsCompleted=false},
                new Exercise{Name="Running", CategoryId=8, IsCompleted=false},
                new Exercise{Name="Burpee", CategoryId=9, IsCompleted=false},
                new Exercise{Name="Dips", CategoryId=6, IsCompleted=false},
            };
        }
    }
}
