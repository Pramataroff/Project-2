using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class CarDealer
    {
        public string regnomer;
        public string enginenum;
        public string carBrand;
        public string carModel;
        private double price;
        private int yearofrelease;

        public double Price { get { return price; } set { price = value; } }
        public int Yearofrelease { get { return yearofrelease; } set { yearofrelease = value; } }


        static public void Printcars(List<CarDealer> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Reg number: {item.regnomer}; Engine number {item.enginenum}; Car brand: {item.carBrand}; Car model {item.carModel};");
            }
        }
        public void Printcar()
        {
            Console.WriteLine($"Reg number: {this.regnomer}; Engine number {this.enginenum}; Car brand: {this.carBrand}; Car model {this.carModel}; Car price {this.Price}");
        }

        static public void SpecificCarBrand(List<CarDealer> list)
        {
            Console.Write("Enter on which car brand do you want table: ");
            string brand = Console.ReadLine();
            for (int i = 0; list.Count > i; i++)
            {
                if (list[i].carBrand == brand)
                {
                    list[i].Printcar();
                }
            }
        }
        static public void Actualisation(List<CarDealer> list)
        {

            Console.WriteLine("Do you want to actualisate car's details: Y/N");
            char YorN = char.Parse(Console.ReadLine());
            if (YorN == 'Y')
            {
                Console.Write("Enter which car brand do you want to change: ");

                string brand = Console.ReadLine();
                for (int i = 0; list.Count > i; i++)
                {
                    Console.Write("Enter car's new registrational number: ");
                    list[i].regnomer = Console.ReadLine();
                    Console.Write("Enter car's new engine number: ");
                    list[i].enginenum = Console.ReadLine();
                    Console.Write("Enter car's new model: ");
                    list[i].carModel = Console.ReadLine();
                    Console.Write("Enter car's new price: ");
                    list[i].Price = double.Parse(Console.ReadLine());
                    Console.Write("Enter car's new year of release: ");
                    list[i].yearofrelease = int.Parse(Console.ReadLine());
                }
            }


        }
        
    }
}
