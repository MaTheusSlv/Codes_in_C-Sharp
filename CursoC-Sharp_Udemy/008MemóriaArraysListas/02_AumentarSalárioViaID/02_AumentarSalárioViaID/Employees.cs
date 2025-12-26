using System;

namespace _02_AumentarSalárioViaID
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; } //só uma operação do employee pode mexer no salario

        //cria o funcionário
        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        //aumenta o salário
        public void increaseSalary(double percentage)
        {
            Salary = Salary + (Salary * (percentage / 100));
        }

        //sobrescrevendo o ToString pra imprimir como queremos
        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}
