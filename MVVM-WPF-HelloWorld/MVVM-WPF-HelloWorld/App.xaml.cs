using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MVVM_WPF_HelloWorld.ViewModel;

namespace MVVM_WPF_HelloWorld
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow();

            var viewModel = new MainWindowsViewModel();
            window.DataContext = viewModel;

            window.Show();
        }
    }
}
