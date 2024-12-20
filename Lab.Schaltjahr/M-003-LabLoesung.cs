using System;
using System.Linq;

namespace Schaltjahrrechner_MiniLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Aufgabe: Schaltjahr-Rechner

            //Abfrage der Eingabe
            Console.WriteLine("Gib das Jahr ein:");
            int year = int.Parse(Console.ReadLine());

            //Deklarierung/Initialisierung der bool-Variablen
            bool istSchaltjahr = false;

            //Pr�fung einer Teilbarkeit durch 4
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                //Setzten der Variablen auf true
                istSchaltjahr = true;
            }

            //Ausgabe
            Console.WriteLine($"{year} ist Schaltjahr: {istSchaltjahr}");

            //Alternative (detailiertere) Ausgabe mittels Kurz-Bedingung
            string ausgabe = istSchaltjahr ? $"{year} ist ein Schaltjahr." : $"{year} ist kein Schaltjahr.";
            Console.WriteLine(ausgabe + "\n\n\n");

            #endregion

            #region 2. Aufgabe: Mini-Lotto

            //Deklaration & Initialisierung des Arrays der Gewinnzahlen
            int[] gewinnzahlen = { 3, 16, 45, 79, 99 };

            //Abfrage des User-Tipps
            Console.Write("Bitte gib deinen Tipp ab (Ganzzahl zwischen 0 und 100): ");
            int tipp = int.Parse(Console.ReadLine());

            //Pr�fung des Zahlenbereiches des Tipps
            if (tipp < 0 || tipp > 100)
                Console.WriteLine("Dein Tipp ist au�erhalb des Zahlenbereiches.");
            else
            {
                //Pr�fung, ob Tipp eine Gewinnzahl ist und Ausgabe
                if (gewinnzahlen.Contains(tipp))
                    Console.WriteLine("Gl�ckwunsch!! Du hast eine der f�nf Gewinnzahlen getippt.");
                else
                    Console.WriteLine("Leider daneben. Viel Gl�ck beim n�chsten Mal.");
            }
            #endregion
        }
    }
}
