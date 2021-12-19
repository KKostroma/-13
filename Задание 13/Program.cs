using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Улица Ленина,1",2,3,4);
            MultiBuilding multiBuilding = new MultiBuilding("Улица Ленина,1",2,3,4,5);
            multiBuilding.Print();
            Console.ReadKey();
        }
        class Building
        {
            public string Adres { get; set; }
            public double Dlina { get; set; }
            public double Shirina { get; set; }
            public double Visota { get; set; }
            public Building()
            {

            }
            public Building(string adres, double dlina, double shirina, double visota)
            {
                Adres = adres;
                Dlina = dlina;
                Shirina = shirina;
                Visota = visota;
            }
            public virtual void Print()
            {
                Console.WriteLine($"Адрес здания: {Adres}");
                Console.WriteLine($"Длина здания: {Dlina}");
                Console.WriteLine($"Ширина здания: {Shirina}");
                Console.WriteLine($"Высота здания: {Visota}");
            }
        }
        sealed class MultiBuilding : Building
        {
            public int Etajnost { get; set; }
            public MultiBuilding(string adres, double dlina, double shirina, double visota, int etajnost)
            {
                Adres = adres;
                Dlina = dlina;
                Shirina = shirina;
                Visota = visota;
                Etajnost = etajnost;
            }
            public override void Print()
            {
                Console.WriteLine($"Адрес здания: {Adres}");
                Console.WriteLine($"Длина здания: {Dlina}");
                Console.WriteLine($"Ширина здания: {Shirina}");
                Console.WriteLine($"Высота здания: {Visota}");
                Console.WriteLine($"Этажность здания: {Etajnost}");
            }
        }
    }
}
