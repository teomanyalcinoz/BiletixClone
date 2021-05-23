using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using biletix3.Services;
using MvvmHelpers.Commands;
using System.Collections.ObjectModel;
using biletix3.Models;
using System.Threading.Tasks;

namespace biletix3.ViewModels
{
    class StudentsViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EventName { get; set; }

        private DBFirebase services;

        public Command AddStudentCommand { get; }

        private ObservableCollection<Student> _students = new ObservableCollection<Student>();
        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                OnPropertyChanged();
            }
        }

        public StudentsViewModel()
        {
            services = new DBFirebase();
            Students = services.getStudent();
            AddStudentCommand = new Command(async () => await addStudentAsync(FirstName, LastName, EventName));
        }

        public async Task addStudentAsync(string firstName, string lastName, string ev)
        {
            await services.AddStudent(firstName, lastName, ev);
        }
    }
}
