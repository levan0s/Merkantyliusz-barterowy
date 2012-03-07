using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MerkantyliuszBarterowy.ViewModel;

namespace MerkantyliuszBarterowy.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(IMainWindowViewModel mainWindowViewModel) : this()
        {
            _mainWindowViewModel = mainWindowViewModel;
            DataContext = _mainWindowViewModel;
        }

        private IMainWindowViewModel _mainWindowViewModel;
    }
}
