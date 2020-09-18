using System;

namespace Department {
    class Program {
        static void Main(string[] args) {
            Employee emp = new Employee("васиЛий", "пУпкИн", "петровиЧ", DateTime.Parse("29.12.1986"));

            //emp.Name = "вася";
            //emp.Family = "пупкин";
            //emp.Sirname = "петрович";
            //emp.BirthDate = new DateTime(1986, 12, 30);


            Console.WriteLine(emp.returnEmployeeInfo());
        }
    }
}
