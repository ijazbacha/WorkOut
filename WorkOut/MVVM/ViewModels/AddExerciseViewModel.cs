using Kotlin.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOut.MVVM.Models;

namespace WorkOut.MVVM.ViewModels
{
    public class AddExerciseViewModel
    {
        public string Exercise { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Exercise> Exercises { get; set; }
    }
}
