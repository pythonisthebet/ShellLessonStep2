using ShellLesson.ViewModels;
using ShellLessonStep2.Models;
using ShellLessonStep2.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShellLessonStep2.ViewModels
{
    public class AnimalViewModel : ViewModelBase
    {
        private ObservableCollection<Animal> cats;
        public ObservableCollection<Animal> Cats
        {
            get
            {
                return this.cats;
            }
            set
            {
                this.cats = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Animal> dogs;
        public ObservableCollection<Animal> Dogs
        {
            get
            {
                return this.dogs;
            }
            set
            {
                this.dogs = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Animal> bears;
        public ObservableCollection<Animal> Bears
        {
            get
            {
                return this.bears;
            }
            set
            {
                this.bears = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Animal> monkeys;
        public ObservableCollection<Animal> Monkeys
        {
            get
            {
                return this.monkeys;
            }
            set
            {
                this.monkeys = value;
                OnPropertyChanged();
            }
        }
        
        private ObservableCollection<Animal> elephants;
        public ObservableCollection<Animal> Elephants
        {
            get
            {
                return this.elephants;
            }
            set
            {
                this.elephants = value;
                OnPropertyChanged();
            }
        }        
    

        private AnimalService animalService;
        public AnimalViewModel()
        {
            animalService = new AnimalService();
            List<Animal> list;

            list = animalService.GetCats().ToList();
            this.cats = new ObservableCollection<Animal>(list);


            list = animalService.GetDogs().ToList();
            this.dogs = new ObservableCollection<Animal>(list);


            list = animalService.GetBears().ToList();
            this.bears = new ObservableCollection<Animal>(list);


            list = animalService.GetMonkeys().ToList();
            this.monkeys = new ObservableCollection<Animal>(list);


            list = animalService.GetElephants().ToList();
            this.elephants = new ObservableCollection<Animal>(list);


        }


        private Object selectedAnimal;
        public Object SelectedAnimal
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

        public ICommand SingleSelectCommand => new Command(OnSingleSelectAnimal);

        async void OnSingleSelectAnimal()
        {
            if (SelectedAnimal != null)
            {
                var navParam = new Dictionary<string, object>()
            {
                { "selectedAnimal",SelectedAnimal}
            };
                //Add goto here to show details
                await Shell.Current.GoToAsync("DetailsPage", navParam);

                SelectedAnimal = null;
            }
        }
    }
}
