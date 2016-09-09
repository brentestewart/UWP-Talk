using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HeroFinder.Annotations;
using HeroFinder.Models;
using HeroFinder.Repositories;

namespace HeroFinder.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Hero currentHero;
        private bool showInfo = true;
        public List<Hero> Heroes { get; set; }

        public bool ShowInfo
        {
            get { return showInfo; }
            set
            {
                showInfo = value;
                RaisePropertyChanged();
            }
        }

        public Hero CurrentHero
        {
            get { return currentHero; }
            set
            {
                currentHero = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            Heroes = HeroesRepository.GetAllHeroes();
            CurrentHero = Heroes.FirstOrDefault();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
