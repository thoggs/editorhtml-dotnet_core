using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            DrawScreen();
            WriteOptions();
            
            int option = int.Parse(Console.ReadLine()!);
        }

        private static void DrawScreen()
        {
            UpperLine();
            CenterLine();
            DrawLine();
        }

        private static void WriteOptions()
        {
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 => Novo arquivo");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 => Abrir");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("0 => Sair");
            Console.SetCursorPosition(2, 9);
            Console.Write("Opção: ");
        }

        private static void UpperLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        private static void CenterLine()
        {
            for (int lines = 0; lines <= 15; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        private static void DrawLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
    } 
}