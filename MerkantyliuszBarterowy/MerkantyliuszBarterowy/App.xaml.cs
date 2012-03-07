using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using StructureMap;

namespace MerkantyliuszBarterowy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            ConfigureContainer();
        }

        private void ConfigureContainer()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry(new MainRegistry());
            });
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = ObjectFactory.GetInstance<IMainWindow>();
            mainWindow.ShowDialog();
        }
    }
}
