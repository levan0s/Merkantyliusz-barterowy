using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap.Configuration.DSL;

namespace MerkantyliuszBarterowy
{
    class MainRegistry : Registry
    {
        public MainRegistry()
        {
            For<IMainWindow>().Use<MainWindow>();
            For<IMainWindowViewModel>().Use<MainWindowViewModel>();
        }
    }
}
