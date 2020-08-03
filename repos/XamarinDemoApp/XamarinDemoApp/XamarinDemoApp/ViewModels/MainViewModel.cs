using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XamarinDemoApp.Models;
using XamarinDemoApp.Services;

namespace XamarinDemoApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Employee> _employeesList;

        public List<Employee> EmployeesList 
        { 
            get => _employeesList;
            set {
                    _employeesList = value;
                    OnPropertyChanged();
                } 
        }

        public MainViewModel()
        {
            InitializeDateAsync();
        }
        private async void InitializeDateAsync()
        {
            var employeeServices = new EmployeeServices();

            EmployeesList = await employeeServices.GetEmployeesAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
