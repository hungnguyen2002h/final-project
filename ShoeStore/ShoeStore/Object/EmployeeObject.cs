using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Object
{
    internal class EmployeeObject
    {
        String id, name, user, pass, gender, phoneNumber, address;
        int age;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value; }

        public EmployeeObject() { }
        public EmployeeObject(string id, string name, string user, string pass, string gender, string phoneNumber, string address, int age)
        {
            Id = id;
            Name = name;
            User = user;
            Pass = pass;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Address = address;
            Age = age;
        }
    }
}
