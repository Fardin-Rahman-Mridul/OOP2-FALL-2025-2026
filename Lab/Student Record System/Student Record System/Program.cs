using System;

interface IStudent
{
    void Display();
}

class Student : IStudent
{
    private string name;
    private int[] marks = new int[3];

    public Student(string name)
    {
        this.name = name;
    }

    public int this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + " Marks: " + marks[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Student st = new Student("Rahim");

        st[0] = 75;
        st[1] = 82;
        st[2] = 90;

        st.Display();
    }
}
