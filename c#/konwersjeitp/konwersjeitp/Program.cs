using System;

namespace konwersjeitp
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 4.5;
            int y = (int)x;
            double z = (double)y;
            Console.WriteLine("x = " + x) ; 
            Console.WriteLine("y = " + y) ; 
            Console.WriteLine("z = " + z) ;
            Console.WriteLine("");







            // Deklaracja zmiennej typu Int32 (to samo co int)
            System.Int32 liczba = 100;

            // Rzutowanie long na int (może spowodować utratę danych)
            long longNbr = 12354146;
            int intNbr = (int)longNbr;
            Console.WriteLine(intNbr);


            // Rzutowanie int na long (bezpieczne, bez utraty danych)
            int intNumber = 23152;
            long longNubmer = intNumber;
            Console.WriteLine(intNumber); 


            // Konwersja liczby całkowitej na string i wypisanie jej dwukrotnie
            string str = liczba.ToString();
            Console.WriteLine(str + str);


            // Parsowanie tekstu w notacji naukowej na typ float NIE DZIALA
            /*string text = "9.11E-31";
            float kgElectomass = float.Parse(text);
            Console.WriteLine(kgElectomass); */

            Console.Write("Podaj liczbe: ");
            string input = Console.ReadLine();

            if (Int32.TryParse(input,out int result))
            {
                Console.WriteLine($"Konwesja udana. liczba to: {result}");
            }
            else
            {
                Console.WriteLine("Nie udalo sie przekonwetoac\n\n\n\n");
            }


            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();

            if (imie=="" || imie==" "|| int.TryParse(imie, out _))
            {
                Console.WriteLine("Czesc nikt");
            }
            else
            {
                Console.WriteLine($"Czesc {imie}");
            }

            Console.Write("Podaj gdzie jestes: ");
            string lok = Console.ReadLine();

            if (lok == "" || lok == " ")
            {
                Console.WriteLine("jestes w pizdize");
            }
            else
            {
                Console.WriteLine($"jestes w {lok}");
            }



        }
    }
}
