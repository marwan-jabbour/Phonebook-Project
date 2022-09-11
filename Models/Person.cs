using System;
namespace PhoneBookWebApp.Models
{ 
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }

        public Person()
        {
        }
    }
}

