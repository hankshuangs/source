using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
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
            var employeeServices = new EmployeeServices();

            EmployeesList = employeeServices.GetEmployees();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
