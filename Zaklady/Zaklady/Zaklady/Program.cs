using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaklady
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vypsani textu
            Console.WriteLine("Hello World!");

            // Ceka na zadani neceho a Enter
            Console.ReadLine();

            // Vykresleni obrazku
            // \\ - vypise \
            Console.WriteLine("    /\\ ");
            Console.WriteLine("   /  \\ ");
            Console.WriteLine("  /    \\ ");
            Console.WriteLine(" /      \\ ");
            Console.WriteLine("/________\\ ");
         
            Console.ReadLine();

            // Promenne
            // Primo vypsana
            string JmenoHrdiny = "John";

            // Uvedeni promenne
            int VekHrdiny;
            // Vypsani pozdeji
            VekHrdiny = 35;

            Console.WriteLine("There once was a man named " + JmenoHrdiny);
            Console.WriteLine("He was " + VekHrdiny + " years old");

            // Lze zmenit uprostred programu
            JmenoHrdiny = "Tom";

            Console.WriteLine("He really liked the name " + JmenoHrdiny);
            Console.WriteLine("But he didn't like being " + VekHrdiny);

            Console.ReadLine();

            // Typy dat
            string Fraze = "Text";
            char Charakter = 'A';
            int CeleCislo = 30;
            float MenePresne = 3.2f;
            double VicePresne = 3.21;
            decimal Nejpresnejsi = 3.210m;
            bool PravdaNepravda = true;

            Console.WriteLine("Hello");
            Console.WriteLine(30);

            Console.ReadLine();

            // sequence
            // \n - da na novy radek
            // \" - vypise "
            Console.WriteLine("SPS\nTrutnov");

            string Test = "SPS Trutnov";
            string Test1 = "SPS Trutnov" + " is cool";
            Console.WriteLine(Test);
            Console.WriteLine(Test1);

            Console.WriteLine(Test1.Length);

            // Vse velkymi pismeny
            Console.WriteLine(Test1.ToUpper());

            // Vse malymi pismeny
            Console.WriteLine(Test1.ToLower());

            // Ma v sobe urcitou hodnotu
            Console.WriteLine(Test1.Contains("Trutnov"));

            // Vypsat urcity charakter
            // Prvni charakter je na pozici 0
            Console.WriteLine(Test1[0]);

            // Jestli ma urcitou hodnotu a na jake pozici zacina
            // Pokud tam neni dostaneme -1
            Console.WriteLine(Test1.IndexOf("Trutnov"));

            // Vypise od urciteho charakteru po urcitou delku
            Console.WriteLine(Test1.Substring(4, 7));

            Console.ReadLine();
        }
    }
}
