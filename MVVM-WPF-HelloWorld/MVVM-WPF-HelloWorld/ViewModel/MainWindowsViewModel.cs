using System.Collections.ObjectModel;
using MVVM_WPF_HelloWorld.DataAccess;

namespace MVVM_WPF_HelloWorld.ViewModel
{
    public class MainWindowsViewModel : ViewModelBase
    {
        readonly EmployeeRepository _employeeRepository;

        ObservableCollection<ViewModelBase> _viewModels;

        public MainWindowsViewModel()
        {
            _employeeRepository = new EmployeeRepository();

            // cream o instanta a ViewModel pe care vrem sa il afisam si o adaugam la colectie;

            EmployeeListViewModel viewModel = new EmployeeListViewModel(_employeeRepository);
            this.ViewModels.Add(viewModel);

        }

        public ObservableCollection<ViewModelBase> ViewModels // Proprietatea la car se face Binding din UI (din XAML)
        {
            get
            {
                if(_viewModels == null)
                {
                    _viewModels = new ObservableCollection<ViewModelBase>();
                }
                return _viewModels;
            }
        }
    }
}
