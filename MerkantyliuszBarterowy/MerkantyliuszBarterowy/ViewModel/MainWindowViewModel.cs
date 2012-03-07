using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Windows;

namespace MerkantyliuszBarterowy.ViewModel
{
    class MainWindowViewModel : IMainWindowViewModel
    {
        public MainWindowViewModel()
        {
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

        private void ShowBarterView()
        {
            //TODO:
            throw new NotImplementedException();
        }

        private void ShowVoyageView()
        {
            //TODO:
            throw new NotImplementedException();
        }

        private bool CanShowBarterView()
        {
            //TODO:
            return false;
        }

        private bool CanShowVoyageView()
        {
            //TODO:
            return false;
        }

        private readonly DelegateCommand _showBarterViewCommand;
        private readonly DelegateCommand _showVoyageViewCommand;
    }
}
