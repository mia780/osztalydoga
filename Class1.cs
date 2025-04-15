using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Auto
    {
        string marka { get; set; }
        string tipus { get; set; }
        int gyartasiev { get; set; }
        double fogyasztas { get; set; }
        int km { get; set; }

        public Auto(string marka, string tipus, int gyartasiev, double fogyasztas, int km)
        {
            this.marka = marka;
            this.tipus = tipus;
            this.gyartasiev = gyartasiev;
            this.fogyasztas = fogyasztas;
            this.km = km;
        }

        public int eletkor()
        {
            return DateTime.Now.Year - gyartasiev;
        }

        public double uzemanyag_felhasznalas()
        {
            return km / 100.0 * fogyasztas;
        }

        public double atlagfogyasztas_kmre()
        {
            return fogyasztas / 100.0;
        }

        public void adatkiiras()
        {
            Console.WriteLine("Az autó adatai:");
            Console.WriteLine($"Márka: {marka}");
            Console.WriteLine($"Típus: {tipus}");
            Console.WriteLine($"Gyártási év: {gyartasiev}");
            Console.WriteLine($"Életkor: {eletkor()}");
            Console.WriteLine($"Fogyasztás: {fogyasztas}");
            Console.WriteLine($"Megtett km: {km}");
            Console.WriteLine($"Összesen felhasznált üzemanyag: {uzemanyag_felhasznalas()} liter");
            Console.WriteLine($"Átlagos fogyasztás 1 km-re: {atlagfogyasztas_kmre()} liter/km");
        }
    }
    }
