using System;

namespace Department {
    class Program {
        static void Main(string[] args) {
            Employee emp = new Employee("васиЛий", "пУпкИн", "петровиЧ", DateTime.Parse("29.12.1986"));

            Console.WriteLine(emp.returnEmployeeInfo());
            Console.WriteLine();

            Project pr = new Project("Проект раз", DateTime.Now, new DateTime(2021, 01, 01), "Подробное описание проекта раз");

            Console.WriteLine(pr.returnProjectInfo());

        }
    }
}
