using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WydawanieReszty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nominaly = { 200, 100, 50, 20, 10 }; //tablica jednowymiarowa; zawiera nominały, które są dostępne

            Console.WriteLine("Podaj kwotę do wydania");
            int kwota = int.Parse(Console.ReadLine()); //zmiana danych wprowadzonych przez użytkownika na wartość liczbową
            Console.WriteLine("Wydane nominały");

            //sprawdzenie czy kwota podana przez użytkownika może być wydana za pomocą dostepnych nominałów:

            if ((kwota % nominaly[nominaly.Length - 1]) == 0) //sprawdzenie czy reszta z dzielenia kwoty użytkownika przez ostatni nominał dostępny w tablicy równa się 0
            {
                while (kwota > 0) //dzięki zastosowaniu pętli for możemy iterować po wszystkich dostępnych wartościach nominałów
                {
                    for (int i = 0; i < nominaly.Length; i++)
                    {
                        if (kwota >= nominaly[i])
                        {
                            Console.WriteLine(nominaly[i]);
                            kwota = kwota - nominaly[i];
                            break;
                        }
                    }
                }
            }
            else Console.WriteLine("Kwota nie może być wydana za pomocą dostępnych nominałów");

            Console.WriteLine("Naciśnij ENTER");
            Console.ReadLine();
        }
    }
}
