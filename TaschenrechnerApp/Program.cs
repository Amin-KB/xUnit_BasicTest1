using System;

namespace TaschenrechnerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var tr = new Taschenrechner();

            //tr.AddierenNichtGutTestbar();

            Console.WriteLine("Bitte zwei Zahlen eingeben:");

            Console.Write("Zahl 1:");
            int z1 = int.Parse(Console.ReadLine());

            Console.Write("Zahl 2:");
            int z2 = int.Parse(Console.ReadLine());

            int e = tr.Addieren(z1, z2); //Isolierte Logik, die Methode ist leicht Testbar

            Console.WriteLine(e);

            //Hinzufügen eines Testprojekts:
            //Neues Projekt der Projektmappe hinzufügen
            //Auf "Test" filtern im rechten Dropdown
            //xUnit Testprojekt auswählen
            //Einen schönen Namen vergeben
        }
    }
}
