using System;
using System.Text;
using static System.ConsoleKey;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.SetCursorPosition(6, 1);
            Console.WriteLine("MODO EDITOR");
            Console.SetCursorPosition(4, 2);
            Console.WriteLine("---------------");
            Start();
        }

        private static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != Escape);
            
            Console.WriteLine("---------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            
        }
    }
}