using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoColumnsListBoxWP8.Common;

namespace TwoColumnsListBoxWP8.Models
{
   public class Person: BindableBase
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private int _Score;
        public int Score
        {
            get { return _Score; }
            set { SetProperty(ref _Score, value); }
        }
    }
}
