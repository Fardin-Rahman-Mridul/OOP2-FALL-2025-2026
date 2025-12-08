using System;

abstract class Employee
{
    private double basicSalary; 

    protected Employee(double salary)
    {
        basicSalary = salary;
    }

    protected double GetBasicSalary()    
    {
        return basicSalary;
    }

    public abstract double GetTotalSalary();
}

class Manager : Employee
{
    public Manager(double salary) : base(salary) { }

    public override double GetTotalSalary()
    {
        return GetBasicSalary() + 2000;
    }
}

class Worker : Employee
{
    public Worker(double salary) : base(salary) { }

    public override double GetTotalSalary()
    {
        return GetBasicSalary() + 800;
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Manager(10000);
        Employee e2 = new Worker(10000);

        Console.WriteLine("Manager Total Salary: " + e1.GetTotalSalary());
        Console.WriteLine("Worker Total Salary: " + e2.GetTotalSalary());
    }
}
