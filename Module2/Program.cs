using System;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            char blackSquare = 'X';
            char whiteSquare = 'O';
            int rows = 8;
            int columns = 8;
            for (int rowCounter = 0; rowCounter < rows; rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < columns; columnCounter++)
                {
                    if ((rowCounter+columnCounter) % 2 == 0) // will alternate X and O, also with other chessboard sizes
                    {
                        Console.Write(blackSquare);
                    } else
                    {
                        Console.Write(whiteSquare);
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
