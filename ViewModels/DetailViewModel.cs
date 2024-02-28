using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLesson.ViewModels;
using ShellLessonStep2.Models;
using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.ViewModels
{
    [QueryProperty(nameof(SelectedAnimal), "selectedAnimal")]

    public class DetailViewModel : ViewModelBase
    {
        private Animal selectedAnimal;
        public Animal SelectedAnimal
        {
            get
            {
                return this.selectedAnimal;
            }
            set
            {
                this.selectedAnimal = value;
                OnPropertyChanged();
            }
        }
    }
}
