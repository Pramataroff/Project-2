using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace Project_2
{
    internal class Program
    {
        static List<CarDealer> cars = new List<CarDealer>();

        static void Main(string[] args)
        {
            Console.Write("Enter how many cars: ");
            int n = int.Parse(Console.ReadLine());
            List<CarDealer> cars = new List<CarDealer>();
            for (int i = 0; i < n; i++)
            {
                CarDealer current = new CarDealer();
                Console.Write("Enter registrational number: ");
                current.regnomer = Console.ReadLine();
                Console.Write("Enter engine number: ");
                current.enginenum = Console.ReadLine();
                Console.Write("Enter car brand: ");
                current.carBrand = Console.ReadLine();
                Console.Write("Enter car model: ");
                current.carModel = Console.ReadLine();
                Console.Write("Enter car's price: ");
                current.Price = int.Parse(Console.ReadLine());
                Console.Write("Enter car's year of release: ");
                current.Yearofrelease = int.Parse(Console.ReadLine());
                Console.WriteLine();
                cars.Add(current);
            }
            CarDealer.Printcars(cars);


            Client current1 = new Client();

            Console.Write("Enter client's number: ");
            current1.ClientNum = int.Parse(Console.ReadLine());
            Console.Write("Enter client's name: ");
            current1.clientName = Console.ReadLine();
            Console.Write("Enter client's born year: ");
            current1.Bornyear = int.Parse(Console.ReadLine());
            Console.Write("Enter client's budget: ");
            current1.Budget = int.Parse(Console.ReadLine());


            Sort(cars);
            CarDealer.SpecificCarBrand(cars);
            CarDealer.Actualisation(cars);
            Delete(cars);
            Sum(cars);
            MostExpensive(cars);
            NewestCar(cars);
            Clientsafford(cars, current1);



        }
        static void Delete(List<CarDealer> list)
        {
            Console.Write("Do you want to delete car: Y/N: ");
            char YorN = char.Parse(Console.ReadLine());
            if (YorN == 'Y')
            {
                Console.Write("Enter car's brand to delete: ");
                string brand = Console.ReadLine();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].carBrand == brand)
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }
        static void Sum(List<CarDealer> list)
        {
            double sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i].Yearofrelease;
            }
            sum = sum / list.Count;
            Console.WriteLine($"Cars average year of release {sum}");
        }
        static void Sort(List<CarDealer> list)
        {
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < list.Count - 1; j++)
                    {
                        if (list[j].Price > list[j + 1].Price)
                        {
                            CarDealer swap = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = swap;
                        }
                    }
                }
            }
        }
        static void MostExpensive(List<CarDealer> list)
        {
            list[list.Count - 1].Printcar();
        }
        static void NewestCar(List<CarDealer> list)
        {
            int max = 0;
            for (int j = 0; j < list.Count; j++)
            {
                if (max < list[j].Yearofrelease)
                {
                    max = list[j].Yearofrelease;
                }
            }
            Console.WriteLine($"The newest car is year: {max}");
        }

        static void Clientsafford(List<CarDealer> list, Client current)
        {
            Console.WriteLine("Client can afford: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Price <= current.Budget)
                {
                    list[i].Printcar();
                }
            }
        }
    }
}
