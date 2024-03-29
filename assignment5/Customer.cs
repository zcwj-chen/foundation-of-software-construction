using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class Customer
    {
        private string name;
        private string id;
        private int age;
        private string gender;

        public Customer() { }
        public Customer(string name, string id, int age, string gender)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.gender = gender;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"【客户】姓名：{name}\t年龄：{age}\t账号：{id}\t性别：{gender}\n";
        }

        public override bool Equals(object obj)
        {
            var other = obj as Customer;
            if(other == null && this == null) return true;
            bool nameEqual = (Name == null && other.Name == null)
                        || Name.Equals(other.Name);
            bool IdEqual = (Id == null && other.Id == null)
                        || Id.Equals(other.Id);
            bool genderEqual = (Gender == null && other.Gender == null)
                        || Gender.Equals(other.Gender);
            return other != null
                && nameEqual
                && IdEqual
                && Age == other.Age
                && genderEqual;
        }
    }
}
