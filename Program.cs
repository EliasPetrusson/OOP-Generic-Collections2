namespace OOP_Generic_Collections2
{
    namespace OOP_Generic_Collections
    {
        using System;
        using System.Collections.Generic;

        class Employee
        { //Skapa en klass som heter Employee.  Denna klass ska ha flera egenskaper: Id, Name, Gender, Salary.
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public double Salary { get; set; }
        }

        class Program
        {
            static void Main()
            {
                // I Main()-metoden ska du skapa fem objekt av klassen med olika Id, Name, Gender och Salary.
                Employee employee1 = new Employee { Id = 101, Name = "Filip W", Gender = "Male", Salary = 14 };
                Employee employee2 = new Employee { Id = 102, Name = "Felicia", Gender = "Female", Salary = 50000 };
                Employee employee3 = new Employee { Id = 103, Name = "Tristan", Gender = "Male", Salary = 40000 };
                Employee employee4 = new Employee { Id = 104, Name = "Cajsa", Gender = "Female", Salary = 40000 };
                Employee employee5 = new Employee { Id = 105, Name = "Daniel", Gender = "Male", Salary = 20000 };

                // Skapa sedan en Stack och lägg till de fem objekten du skapat med Push().
                Stack<Employee> stackEmployee = new Stack<Employee>();
                stackEmployee.Push(employee1);
                stackEmployee.Push(employee2);
                stackEmployee.Push(employee3);
                stackEmployee.Push(employee4);
                stackEmployee.Push(employee5);

                //Skriv ut alla objekt i stacken. Använd foreach loop. skriv ut hur många objekt som finns kvar i stacken.
                Console.WriteLine("Objects in stack:");
                foreach (Employee employee in stackEmployee)
                {
                    Console.WriteLine($"Items left in the stack: {stackEmployee.Count}");
                    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
                    Console.WriteLine();
                }

                //Hämta alla objekt med Pop-metoden:
                Console.WriteLine("Retrieve using Pop method:");
                while (stackEmployee.Count > 0)
                {
                    Employee popEmployee = stackEmployee.Pop();
                    Console.WriteLine($"Items left in the stack: {stackEmployee.Count}");
                    Console.WriteLine($"Id: {popEmployee.Id}, Name: {popEmployee.Name}, Gender: {popEmployee.Gender}, Salary: {popEmployee.Salary}");
                    Console.WriteLine();
                }

                //Lägg till alla objekt igen genom Push()-metoden
                stackEmployee.Push(employee1);
                stackEmployee.Push(employee2);
                stackEmployee.Push(employee3);
                stackEmployee.Push(employee4);
                stackEmployee.Push(employee5);

                //Hämta objekt med Peek-metoden
                Console.WriteLine("Retrieve using Peek method:");
                for (int i = 0; i < 2; i++)
                {
                    Employee peekEmployee = stackEmployee.Peek();
                    Console.WriteLine($"Items left in the stack: {stackEmployee.Count}");
                    Console.WriteLine($"Id: {peekEmployee.Id}, Name: {peekEmployee.Name}, Gender: {peekEmployee.Gender}, Salary: {peekEmployee.Salary}");
                    Console.WriteLine();
                }

                //Kolla om objekt nummer 3 finns i stacken eller inte och skriv ut resultatet.
                Employee checkEmployee = employee3;
                if (stackEmployee.Contains(checkEmployee))
                {
                    Console.WriteLine($" {checkEmployee.Id} is in stack.");
                }
                else
                {
                    Console.WriteLine($"{checkEmployee.Id} is not in stack.");
                }


                List<Employee> listEmployee = new List<Employee> //Lägg in fem objekt av klassen Employee i din lista
        {
            new Employee { Id = 6, Name = "Sanna", Gender = "Female", Salary = 50000 },
            new Employee { Id = 7, Name = "Jocke", Gender = "Male", Salary = 40000 },
            new Employee { Id = 8, Name = "Julia", Gender = "Female", Salary = 30000 },
            new Employee { Id = 9, Name = "Filip B", Gender = "Male", Salary = 20000 },
            new Employee { Id = 10, Name = "Jennifer", Gender = "Female", Salary = 15000 }
        };

                //Skapa ett villkor med Contains()-metoden för att kolla om ett visst objekt finns i listan
                Employee employeeInList = listEmployee[1];
                if (listEmployee.Contains(employeeInList))
                {
                    Console.WriteLine($"{employeeInList.Name}  object exists in the list.");
                }
                else
                {
                    Console.WriteLine($"{employeeInList.Name} object does not exist in the list.");
                }

                //Använd sedan Find()-metoden för att hitta och skriva ut det första objektet i listan som har Gender = "Male".
                Employee firstMaleEmployee = listEmployee.Find(emp => emp.Gender == "Male")!;
                Console.WriteLine($"First male employee: Id: {firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Salary: {firstMaleEmployee.Salary}");

                //Använd sedan FindAll()-metoden för att hitta och skriva ut alla objekt i listan som har Gender = "Male"
                List<Employee> maleEmployees = listEmployee.FindAll(emp => emp.Gender == "Male");
                Console.WriteLine("All male employees:");
                foreach (Employee emp in maleEmployees)
                {
                    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
                }
            }
        }


    }
}