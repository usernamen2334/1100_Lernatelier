using System.ComponentModel;
using System.Globalization;

namespace Zufallsgenerator_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                int versuche = 1;
                string Restart = "Ja";
                while (Restart == "Ja")
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("                                                   The Numberguesser");
                        double ZufalsZahl = Convert.ToDouble(new Random().Next(1, 100));
                        Console.WriteLine("Geben sie eine zufällige Zahl zwischen 1 und 100 ein");
                        double eingabe = Convert.ToDouble(Console.ReadLine());
                        while (eingabe != ZufalsZahl)
                        {

                            if (eingabe > ZufalsZahl)
                            {
                                Console.WriteLine("Die Zufalszahl ist kleiner als ihre eingabe");
                            }
                            else
                            {
                                Console.WriteLine("Die Zufallszahl ist grösser als ihre eingabe");
                            }
                            Console.WriteLine("Geben sie eine neue Zahl ein");
                            eingabe = Convert.ToDouble(Console.ReadLine());
                            versuche++;
                        }


                        Console.WriteLine("Du hast die Zahl erratten");
                        Console.WriteLine("Versuche gebraucht um die Zahl zu eratten" +
                            "" +
                            "" +
                            ": " + versuche);

                        Console.WriteLine("Willst du nochmals Spielen?(Ja/Nein)");
                        Restart = Console.ReadLine();

                        if (Restart == "Ja")
                        {
                            Console.WriteLine("Geben sie eine neue Zahl ein");
                        }

                        if (Restart == "Nein")
                        {
                            Console.WriteLine("Schade!");
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Deine Eigabe ist ungültig");
                        Console.WriteLine("Willst du nochmals spielen?(Ja/Nein)");
                        Restart = Console.ReadLine();
                        if (Restart == "Ja")
                        {
                            Console.WriteLine("Geben sie eine neue Zahl ein");
                        }

                        if (Restart == "Nein")
                        {
                            Console.WriteLine("Schade!");
                        }

                    }

                }

            }
        }
    }






}
