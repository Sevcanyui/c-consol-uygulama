using System;

class program
{
     static void Main(string[] args)
    {
        Console.WriteLine("üçkenin kenar1 uzunluğınu yazınız");
        int kenar1 = Convert.ToInt32(Console.ReadLine[]);
        Console.WriteLine("üçkenin kenar2 uzunluğınu yazınız");
        int kenar2 = Convert.ToInt32(Console.ReadLine[])
        Console.WriteLine("üçkenin kenar3 uzunluğınu yazınız");
        int kenar3 = Convert.ToInt32(Console.ReadLine[]);

        int çevre = 2*(kenar1+kenar2+kenar3);
        Console.WriteLine(çevre);

    }
}