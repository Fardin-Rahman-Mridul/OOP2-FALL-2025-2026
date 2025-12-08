using System;

public class A
{
    internal int i = 10;
}

public class B : A
{
    protected internal int j = 20;
}

class PrintA
{
    public PrintA(ref int r)
    {
        r = 60;
    }
    internal int printA;
}

class PrintB
{
    public PrintB(out string o)
    {
        o = "Try harder!";
    }
    protected internal int printB = 5;
}

public class Alpha
{
    protected static string? s = "This is a string";

    protected Alpha()
    {
        s = s + "alpha ";
    }
}

public class SubAlpha : Alpha
{
    public SubAlpha()
    {
        s = s + "sub ";
    }
}

public class SubSubAlpha : SubAlpha
{
    public SubSubAlpha()
    {
        s = s + "subsub ";
    }

    public static void print1(A a1)
    {
        Console.WriteLine(a1.i);
    }

    public static void print3(B b1)
    {
        Console.WriteLine(b1.j);
    }

    public static void Main(String[] args)
    {
        A a = new A();
        a.i = 21;
        B b = new B();
        b.i = 25;

        print1(a);
        print1(b);
        print3(b);

        Console.WriteLine(s);
        Console.WriteLine("Find the output");

        s = null;
        new SubSubAlpha();
        Console.WriteLine(s);

        PrintA pa = new PrintA(ref a.i);
        PrintB pb = new PrintB(out s);

        Console.WriteLine("Out output = " + s);
        Console.WriteLine("printA = " + pa.printA);
        Console.WriteLine("Ref output = " + a.i);
        Console.WriteLine("printB = " + pb.printB);
    }
}