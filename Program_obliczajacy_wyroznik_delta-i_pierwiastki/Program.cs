using System;

class Program
{
    static void Main()
    {
        // Wprowadzenie współczynników a, b, i c
        Console.Write("Podaj współczynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współczynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współczynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Sprawdzenie, czy a nie jest zerem
        if (a == 0)
        {
            Console.WriteLine("To nie jest równanie kwadratowe (a nie może być zerem).");
            return;
        }

        // Obliczenie delty
        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Delta: {delta}");

        // Rozwiązanie równania kwadratowego na podstawie delty
        if (delta > 0)
        {
            // Dwa różne pierwiastki rzeczywiste
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Równanie ma dwa różne pierwiastki rzeczywiste:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (delta == 0)
        {
            // Jeden podwójny pierwiastek rzeczywisty
            double x = -b / (2 * a);
            Console.WriteLine("Równanie ma jeden podwójny pierwiastek rzeczywisty:");
            Console.WriteLine($"x = {x}");
        }
        else
        {
            // Brak pierwiastków rzeczywistych
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
    }
}
