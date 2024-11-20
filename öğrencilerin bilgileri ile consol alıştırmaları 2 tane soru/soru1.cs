
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("geometrik hesaplama için iki sayı giriniz");//kullanıcı ne yapması gerektşğini ekrana yazdırdım

        //kullanıcının girdiği ilk ve ikinci sayıyı değişkene atadım
        int number1 = Convert.ToInt32(Console.ReadLine()); 
        int number2 = Convert.ToInt32(Console.ReadLine()); 

        //girilen sayıların çarpım değerini yeni bir değişkene atadım
        int multiplication = number1 * number2;

        //geometrik ortalama sonucu için karekökünü aldım
        double result = Math.Sqrt(multiplication);

        //sonra sonucu konsolda gösterdim
        Console.WriteLine(result);
    }
}