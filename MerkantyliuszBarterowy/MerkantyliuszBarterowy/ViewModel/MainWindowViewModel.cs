using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Windows;
using System.ComponentModel;

namespace MerkantyliuszBarterowy.ViewModel
{
    class MainWindowViewModel : IMainWindowViewModel, INotifyPropertyChanged
    {
        public MainWindowViewModel(IBarterViewModel barterViewModel, IVoyageViewModel voyageViewModel)
        {
            _barterViewModel = barterViewModel;
            _voyageViewModel = voyageViewModel;
            _currentViewModel = barterViewModel;

            _showBarterViewCommand = new DelegateCommand(ShowBarterView, CanShowBarterView);
            _showVoyageViewCommand = new DelegateCommand(ShowVoyageView, CanShowVoyageView);
        }

        public ICommand ShowBarterViewCommand
        {
            get { return _showBarterViewCommand; }
        }

        public ICommand ShowVoyageViewCommand
        {
            get { return _showVoyageViewCommand; }
        }

        public object CurrentView
        {
            get { return _currentViewModel; }
            private set
            {
                _currentViewModel = value;

                this.OnPropertyChanged("CurrentView");

                _showBarterViewCommand.RaiseCanExecuteChanged();
                _showVoyageViewCommand.RaiseCanExecuteChanged();
            }
        }

        private void ShowBarterView()
        {
            CurrentView = _barterViewModel;
        }

        private void ShowVoyageView()
        {
            CurrentView = _voyageViewModel;
        }

        private bool CanShowBarterView()
        {
            return _currentViewModel != _barterViewModel;
        }

        private bool CanShowVoyageView()
        {
            return _currentViewModel != _voyageViewModel;
        }

        private readonly DelegateCommand _showBarterViewCommand;
        private readonly DelegateCommand _showVoyageViewCommand;
        private IVoyageViewModel _voyageViewModel;
        private IBarterViewModel _barterViewModel;
        private object _currentViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
