using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;


namespace Part1
{
    internal class Welcome
    {
        internal static void DrawBorder(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(FiggleFonts.Standard.Render(new string('=', 3)));
            Console.WriteLine(title);
            //Console.WriteLine(FiggleFonts.Standard.Render(new string($"= {title.PadRight(2),5} =")));
            Console.WriteLine(FiggleFonts.Standard.Render(new string('=', 3)));
            Console.ResetColor();
        }

        internal static void DrawBorder2(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('=', 25));
            Console.WriteLine(new string($"= {title.PadRight(20)} ="));
            Console.WriteLine(new string('=', 25));
            Console.ResetColor();
        }
        internal static void ErrorDraw(string title)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('=', 25));
            Console.WriteLine(new string($"= {title.PadRight(20)} ="));
            Console.WriteLine(new string('=', 25));
            Console.ResetColor();
        }
        internal static void ChatBotDraw(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(title);
            Console.ResetColor();
        }



        internal static void ShowWelcomeScreen()
        {
            Console.Clear();
            DrawBorder("   +--------------+\r\n   |.------------.|\r\n   ||            ||\r\n   ||            ||\r\n   ||            ||\r\n   ||            ||\r\n   |+------------+|\r\n   +-..--------..-+\r\n   .--------------.\r\n  / /============\\ \\\r\n / /==============\\ \\\r\n/____________________\\\r\n\\____________________/");
            Console.ResetColor();
        }
    }
}
