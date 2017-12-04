using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingLists
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        //public static Employee GetEmployee()
        //{
        //    var emp = new Employee();

        //    emp.Name = "John";
        //    emp.Title = "Developer";

        //    return emp;
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() {Name = "John", Title = "Dev"});
            employees.Add(new Employee() { Name = "Jane", Title = "Artist" });
            employees.Add(new Employee() { Name = "Dave", Title = "CEO" });
            employees.Add(new Employee() { Name = "Darius", Title = "Waiter" });
            employees.Add(new Employee() { Name = "Sofia", Title = "Bartender" });
            return employees;
        }
    }
}
