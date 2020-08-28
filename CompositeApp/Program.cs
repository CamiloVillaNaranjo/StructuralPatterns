using CompositeApp.Component.Composite;
using CompositeApp.Component.Leaf;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ram = new SimpleProduct("Memoria RAM GigaBit Módulo de 16GB", 150000);
            var processor = new SimpleProduct("Intel Core i7", 750000);
            var videoCard = new SimpleProduct("nVidia GTX 1050", 1500000);
            var keyBoard = new SimpleProduct("Keyboard generic 101 keys - Intel", 20000);
            var mouse = new SimpleProduct("Mouse generic 3 buttons - Intel", 20000);

            var computerGeneric = new CompositeProduct("Computer Gamer Generic");
            computerGeneric.Add(ram);
            computerGeneric.Add(processor);
            computerGeneric.Add(videoCard);
            computerGeneric.Add(keyBoard);
            computerGeneric.Add(mouse);

            Console.WriteLine($"Precio de {ram.Name} es: ${ram.GetPrice().ToString("N2")}");
            Console.WriteLine($"Precio de {computerGeneric.Name} es: ${computerGeneric.GetPrice().ToString("N2")}");

            Console.ReadLine();
        }
    }
}


namespace Coding.Exercise
{
    public abstract class Employee
    {
        protected Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }
        public int Salary { get; private set; }

        public abstract void Add(Employee employee);
        public abstract void Remove(Employee employee);

        public abstract int GetCost();
    }

    public class TeamMember: Employee
    {
        public TeamMember(string name, int salary): base(name,salary){}

        public override void Add(Employee employee)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }
        public override int GetCost()
        {
            return Salary;
        }
    }

    public class TeamLead: Employee
    {
        List<Employee> employees = new List<Employee>();
        public TeamLead(string name):base(name, 0){}

        public override void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public override void Remove(Employee employee)
        {
            employees.Remove(employee);
        }
        public override int GetCost()
        {
            return employees.Sum(employee => employee.Salary);
        }
    }
}