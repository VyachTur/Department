using System;

namespace Department {
    class Program {
        static void Main(string[] args) {
            Employee emp = new Employee("васиЛий", "пУпкИн", "петровиЧ", DateTime.Parse("29.12.1986"));

            Console.WriteLine(emp.returnEmployeeInfo());
        }
    }
}
