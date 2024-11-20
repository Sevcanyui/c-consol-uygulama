using System;

public class soru2
{
    public static void Main(string[] args)
    {
        //öğrenci bilgilerini konsolla aldım
        Console.WriteLine("öğrenci adı");
        string name = Console.ReadLine();

        Console.WriteLine("öğrenci soyadı");
        string surname = Console.ReadLine();

        Console.WriteLine("öğrenci telefon numarası");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("öğrenci numarası");
        string studentID = Console.ReadLine ();

        Console.WriteLine("öğrenci yaşı");
        int studentAge = Convert.ToInt32(Console.ReadLine());

        //kullanıcının verilerini konsolda ekrana yazdırdım
        Console.WriteLine("Ögrenci adı:" + name + "\n Öğrencinin soyadı:" + surname + "\nöğrencinin telefon numarası:" + phoneNumber  + "\nöğrenci numarası:"studentID + "\nöğrenci yaşı:"+ studentAge);

    }
}