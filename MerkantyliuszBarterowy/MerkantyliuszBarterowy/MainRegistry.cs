using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap.Configuration.DSL;
using MerkantyliuszBarterowy.ViewModel;
using MerkantyliuszBarterowy.View;

namespace MerkantyliuszBarterowy
{
    class MainRegistry : Registry
    {
        public MainRegistry()
        {
            For<IMainWindow>().Use<MainWindow>();
            For<IMainWindowViewModel>().Use<MainWindowViewModel>();
            For<IBarterViewModel>().Use<BarterViewModel>();
            For<IVoyageViewModel>().Use<VoyageViewModel>();
        }
    }
}
