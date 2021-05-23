using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using biletix3.Models;

namespace biletix3.Services
{
    class DBFirebase
    {
        FirebaseClient client;

        public DBFirebase()
        {
            client = new FirebaseClient("https://biletix-b9b59-default-rtdb.firebaseio.com/");
        }
        public ObservableCollection<Student> getStudent()
        {
            var studentData = client
                .Child("Tickets")
                .AsObservable<Student>()
                .AsObservableCollection();
            return studentData;

        }

        public async Task AddStudent(string first, string last, string ev)
        {
            Student s = new Student() { FirstName = first, LastName = last, EventName = ev };
            await client
                .Child("Tickets")
                .PostAsync(s);
        }
    }
}
