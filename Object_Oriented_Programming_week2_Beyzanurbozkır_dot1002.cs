using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1: GreetUser
        GreetUser("Freeman");

        // Exercise 2: CalculateArea
        double area = CalculateArea(5);
        Console.WriteLine("Area: " + area);

        // Exercise 3: IsValidPassword
        bool isValid = IsValidPassword("123456");
        Console.WriteLine("Is Password Valid? " + isValid);

        // Exercise 4: CelsiusToFahrenheit
        int celsiusValue = 42;
        double fahrenheit = CelsiusToFahrenheit(celsiusValue);
        Console.WriteLine(celsiusValue + "C is " + fahrenheit + "F");

        // Exercise 5: PrintReport
        PrintReport("---Midterm---", 85, 0, 100, 50);
    }

    // Exercise 1: Kullanıcıyı ismine göre selamlar.
    static void GreetUser(string name)
    {
        Console.WriteLine("Welcome to DOT1002, " + name + "!");
    }

    // Exercise 2: Dairenin alanını hesaplar. Pi değeri varsayılan olarak 3.14'tür.
    static double CalculateArea(double radius, double pi = 3.14)
    {
        return pi * radius * radius;
    }

    // Exercise 3: Şifre uzunluğunun en az 6 karakter olup olmadığını kontrol eder.
    static bool IsValidPassword(string input)
    {
        return input.Length >= 6;
    }

    // Exercise 4: Celsius değerini Fahrenheit'a dönüştürür.
    // Formül: F = (C * 9/5) + 32
    static double CelsiusToFahrenheit(int celsius)
    {
        return (celsius * 9.0 / 5.0) + 32;
    }

    // Exercise 5: Skor raporunu ve hesaplanan ortalamayı yazdırır.
    static void PrintReport(string title, int a1, int a2, int a3, int midterm);
}
//I used artificial intelligence.