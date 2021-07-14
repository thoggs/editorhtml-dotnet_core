using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.SetCursorPosition(6, 1);
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.SetCursorPosition(6, 2);
            Console.WriteLine("---------------");
            Console.Write("\n");
            Replace(text);
            Console.ReadKey();
            Menu.Show();
        }

        private static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            foreach (var t in words)
            {
                if (strong.IsMatch(t))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(t.Substring(
                        t.IndexOf('>') + 1, 
                        t.LastIndexOf('<') - 1 - t.IndexOf('>')));
                    Console.Write("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(t);
                    Console.Write(" ");
                }
            }
        }
    }
}