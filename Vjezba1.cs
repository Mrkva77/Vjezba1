using System;

namespace Vjezva1
{

    public class KlasaC
    {   
        public int Zbroj(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public double Prosjek(int[] numbers)
        {
            int sum = Zbroj(numbers);
            double average = (double)sum / numbers.Length;
            return average;
        }
    }
}
public class Program
{
    public static void Main()
    {
        var objekt = new KlasaC();

        int[] numbers = new int[5];
        Console.WriteLine("Unesi 5 cjela broja:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Broj{i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int zbroj = objekt.Zbroj(numbers);
        double prosjek = objekt.Prosjek(numbers);

        Console.WriteLine($"Suma: {zbroj}");
        Console.WriteLine($"Prosjek: {prosjek}");
    }
}