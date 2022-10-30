using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Model
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }


        public User()
        {
            ID = int.MinValue;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Salary = decimal.MinValue;
        }

        public User(int id,string firstName, string middleName, string lastName, DateTime dateOfBirth,
            decimal salary)
        {
            ID = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Salary = salary;
        }


        public override string ToString() => $"ID: {ID}\n"+$"ФИО: {FirstName} {MiddleName} {LastName}\n" +
            $"Дата рождения: {DateOfBirth:MM/dd/yyyy}\n" + $"Зарплата: {Salary} "+" рублей";
    }
}
