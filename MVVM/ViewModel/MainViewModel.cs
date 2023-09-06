using PracticeApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCmd { get; set; }

        public RelayCommand DiscoveryViewCmd { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object currentView;

        public object CurrentView
        {
            get { return this.currentView; }
            set 
            {
                this.currentView = value;
                OnPropertyChanged();
            }
        }
        
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            
            this.currentView = HomeVM;

            HomeViewCmd = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCmd = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });
        }
    }
}
