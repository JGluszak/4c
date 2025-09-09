using System;

namespace wejsciewyjscie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź z klaw atury jeden znak: ");
            int kodZnaku = Console.Read();
            Console.WriteLine($"Kod odczytanego znaku to {kodZnaku}");


            Console.WriteLine(" Proszę nacisnąć klawisz Q. ");
            ConsoleKeyInfo keylnfo = Console.ReadKey();
            while (keylnfo.Key != ConsoleKey.Q)
            {
                Console.WriteLine(
                "\nTo nie jest klawisz Q. Proszę nacisnąć klawi sz Q. ");
                keylnfo = Console.ReadKey();
            }
            Console.WriteLine("\nDziękuję za naciśnięcie klawisza Q. ");
            Console.Read();



            Console.Write("Proszę naciskać dowol ne klawisze. ");
            Console.WriteLine("Klawisz Esc kończy działanie programu .");
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                String str = keyInfo.Key.ToString();
                if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                {
                    str += "[ALT]";
                }
                if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                {
                    str += "[CTRL]";
                }
                if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    str += "[SHIFT]";
                }
                Console.Write(" Zastosowano kombinację " + str);
                Console.WriteLine(", czyl i znak " + keyInfo.KeyChar);

            } while (keyInfo.Key != ConsoleKey.Escape);



        }
    }
}

