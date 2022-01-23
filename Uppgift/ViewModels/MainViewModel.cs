using CustomersCasesSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private object _currentView;

        public MainViewModel()
        {
            CustomerViewModel = new CustomerViewModel();
            NewCustomerViewModel = new NewCustomerViewModel();
            CreateCaseViewModel = new CreateCaseViewModel();

            CurrentView = CustomerViewModel;

            CustomerViewCommand = new RelayCommand(x => CurrentView = CustomerViewModel);
            NewCustomerViewCommand = new RelayCommand(x => CurrentView = NewCustomerViewModel);
            CreateCaseViewCommand = new RelayCommand(x => CurrentView = CreateCaseViewModel);
        }

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand CustomerViewCommand { get; set; }
        public CustomerViewModel CustomerViewModel { get; set; }

        public RelayCommand NewCustomerViewCommand { get; set; }
        public NewCustomerViewModel NewCustomerViewModel { get; set; }
        public RelayCommand CreateCaseViewCommand { get; set; }
        public CreateCaseViewModel CreateCaseViewModel { get; set; }
    }
}
