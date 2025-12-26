using System;
using System.Globalization;
using System.Collections.Generic;

namespace _02_AumentarSalárioViaID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede a quantidade de funcionários a serem registrados
            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            //cria a lista de funcionários
            List<Employees> employees = new List<Employees>();

            //para cada, pede as informações e cadastra
            for (int i = 1; i <= n; i++)
            {
                //pede as infos
                Console.WriteLine("\nEmployee #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employees(id, name, salary)); //cadastra o employee
            }

            //pede o funcionário a atualizar
            Console.Write("\nEnter the employee ID that will have the salary increase: ");
            int id_toup = int.Parse(Console.ReadLine());
            
            //busca o funcionário pelo ID na lista
            Employees emplo = employees.Find(x => x.Id == id_toup);

            //verifica se o funcionário buscado existe, se sim, faz o aumento
            if (emplo != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emplo.increaseSalary(percentage); //realiza o aumento
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }

            //mostra cada item da lista atualizada
            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employees emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
