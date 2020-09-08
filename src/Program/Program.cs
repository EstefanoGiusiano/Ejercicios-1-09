using System;
using Tablero;
using TextFileReader;
namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileReader reader= new TextFileReader("../../assets/board.txt");
            Tablero board=new Tablero(reader.ReadTextFile());
            Console.WriteLine(board);
        }
    }
}
