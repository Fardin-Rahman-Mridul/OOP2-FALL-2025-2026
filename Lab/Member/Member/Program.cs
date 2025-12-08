using System;

abstract class Member
{
    private string name;
    private int memberId;

    public Member(string n, int id)
    {
        name = n;
        memberId = id;
    }

    public abstract double CalculateFee();
}

class StudentMember : Member
{
    public StudentMember(string n, int id) : base(n, id) { }

    public override double CalculateFee()
    {
        return 300;
    }
}

class RegularMember : Member
{
    public RegularMember(string n, int id) : base(n, id) { }

    public override double CalculateFee()
    {
        return 500;
    }
}

class Program
{
    static void Main()
    {
        Member m1 = new StudentMember("Alice", 101);
        Member m2 = new RegularMember("Bob", 102);

        Console.WriteLine("Student Member Fee: " + m1.CalculateFee());
        Console.WriteLine("Regular Member Fee: " + m2.CalculateFee());
    }
}
