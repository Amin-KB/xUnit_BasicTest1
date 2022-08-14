using System;

namespace TaschenrechnerApp
{
    public class Taschenrechner
    {
        public void AddierenNichtGutTestbar()
        {
            int ergebnis;

            Console.WriteLine("Bitte zwei Zahlen eingeben:");

            Console.Write("Zahl 1:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Zahl 2:");
            int b = int.Parse(Console.ReadLine());

            ergebnis = a + b;

            Console.WriteLine(ergebnis);
        }

        //Diese Methode isoliert die eigentliche Logik
        //Sie beschäftigt sich weder mit Eingabe noch Ausgabe
        public int Addieren(int a, int b)
        {
            int ergebnis;

            ergebnis = a + b;

            return ergebnis;
        }
    }
}
