using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoColumnsListBoxWP8.Common;
using TwoColumnsListBoxWP8.Models;

namespace TwoColumnsListBoxWP8.ViewModels
{
    public class MainViewModel: BindableBase
    {
        private ObservableCollection<Person> _PeopleList;
        public ObservableCollection<Person> PeopleList
        {
            get { return _PeopleList; }
            set { SetProperty(ref _PeopleList, value); }
        }

        public MainViewModel()
        {
            PeopleList = new ObservableCollection<Person>();

            PeopleList.Add(new Person() { 
                Name = "Ahmed",
                Score = 100
            });
            PeopleList.Add(new Person()
            {
                Name = "Ali",
                Score = 90
            });
            PeopleList.Add(new Person()
            {
                Name = "Sara",
                Score = 80
            });
            PeopleList.Add(new Person()
            {
                Name = "Hagar",
                Score = 95
            });
            PeopleList.Add(new Person()
            {
                Name = "Mostafa",
                Score = 101
            });
        }
    }
}
