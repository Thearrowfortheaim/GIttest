// Aufgabe 1 Seite 158 (Eigene Version)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Balkendiagramm_erweitert_Galileo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm - Balkendiagramm - Erweiterung");
            char myCharakter = GetCharakter();
            int[] myNumbers = GetNumbers();
            PrintDiagramm(myCharakter, myNumbers);
           
          
            Console.WriteLine("Ende des Programms");
        }
        static char GetCharakter()
        {
            Console.WriteLine("Setze ein Zeichen für dein Diagramm ein:\n");
            string line = Console.ReadLine();
            char c = line[0];
            return c;
        }
        static int[] GetNumbers()
        {
            Console.WriteLine("Gib die Diagrammwerte ein:\n");
            string line = Console.ReadLine();
            char[] splitSymbols = new char[] { ' ', ',', ';' };
            string[] singleNumbers = line.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);
            int[] MyNumbers = new int[singleNumbers.Length];
            for (int i = 0; i < MyNumbers.Length; i++)
                MyNumbers[i] = int.Parse(singleNumbers[i]);
            return MyNumbers;
        }
        static void PrintDiagramm(char charakter, int[] numbers) {
        int LineZahl = numbers.Length;
            for (int row = 0; row < numbers.Length; row++)
            {
                int ZeicheninLine = numbers[row];
                for (int Zeichen = 0; Zeichen < ZeicheninLine; Zeichen++)
                {
                    Console.Write(charakter);
                }
                Console.WriteLine();
            }
            // Fortsetzung des Programs mit einem Menu für den User
            Console.WriteLine("Wenn Sie ein neues Diagramm bauen wollen, Drücken Sie 'Y', ansonsten drücken Sie 'N'..");
            string line = Console.ReadLine();
            char a = line[0];
            if (a == 'Y') { 
                PrintDiagramm(GetCharakter(), GetNumbers());
                Console.WriteLine();
            }
            else 
            Console.WriteLine("Sie haben das Programm absolwiert!!!\n");
        }
        
    }
    
}
