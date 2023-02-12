namespace MyDecorators
{
    public class ClaseDecorators
    {
        public void Displaylogo(bool animation, int vel = 75)
        {                
            string[] logo = {
            "███████████████████████████████████████████████████████████████████████████████",
            "",
            "███████╗███████╗ ██████╗██╗   ██╗██████╗ ███████╗██╗  ██╗███████╗██╗   ██╗",
            "██╔════╝██╔════╝██╔════╝██║   ██║██╔══██╗██╔════╝██║ ██╔╝██╔════╝╚██╗ ██╔╝",
            "███████╗█████╗  ██║     ██║   ██║██████╔╝█████╗  █████╔╝ █████╗   ╚████╔╝ ",
            "╚════██║██╔══╝  ██║     ██║   ██║██╔══██╗██╔══╝  ██╔═██╗ ██╔══╝    ╚██╔╝  ",
            "███████║███████╗╚██████╗╚██████╔╝██║  ██║███████╗██║  ██╗███████╗   ██║   ",
            "╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ",
            "    ████████                    ",
            "  ██        ██                  ",
            "██            ██████████████████",
            "██  ████                      ██",
            "██  ████      ░░░░██░░██░░██░░██",
            "██░░        ░░████  ██  ██  ██  ",
            "  ██░░░░░░░░██                  ",
            "    ████████                    ",
            "",
            "███████████████████████████████████████████████████████████████████████████████",
            "",
            "Script creado por Tomas Armando Campos",
            ""
            };

            string[] logo_alt = {
            "   _______________  _____  ______ ________  __",
            "  / __/ __/ ___/ / / / _ \\/ __/ //_/ __/\\ \\/ /",
            " _\\ \\/ _// /__/ /_/ / , _/ _// ,< / _/   \\  / ",
            "/___/___/\\___/\\____/_/|_/___/_/|_/___/   /_/  ",
            "",
            "Script creado por Tomas Armando Campos",
            ""
            };
            Console.Write("\x1b[1m");
            if (Console.WindowWidth >= 80 && Console.WindowHeight >= 26 ){
                for (int i = 0; i < logo.Length; i++)
                    {
                    int x = (Console.WindowWidth - logo[i].Length) / 2;
                    int y = Console.WindowHeight / Console.WindowWidth + i;

                    Console.SetCursorPosition(x, y);
                    if (animation == true){
                        Thread.Sleep(vel);
                    }
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine(logo[i]);
                    Console.ResetColor();
                    }
            }
            else if (Console.WindowWidth >= 45 && Console.WindowHeight >= 15 )
            {
                for (int i = 0; i < logo_alt.Length; i++)
                    {
                    int x = (Console.WindowWidth - logo_alt[i].Length) / 2;
                    int y = Console.WindowHeight / Console.WindowWidth + i;

                    Console.SetCursorPosition(x, y);
                    if (animation == true){
                        Thread.Sleep(vel);
                    }
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine(logo_alt[i]);
                    Console.ResetColor();
                    }
            }
            Console.Write("\x1b[0m");
        }

        public void Displaycredits(bool animation, int vel = 75)
        {                
            string[] logo = {
            " ___________________________________",
            "/ Programa hecho por:               \\",
            "\\ - Tomas Armando Campos Lopez      /",
            " -----------------------------------",
            "        \\    ^__^             ",
            "         \\   (oo)\\_______     ",
            "             (__)\\       )\\/\\ ",
            "                 ||----w |    ",
            "                 ||     ||    ",
            ""
            };
            Console.Write("\x1b[1m");
            for (int i = 0; i < logo.Length; i++)
                {
                    if (animation == true)
                    {
                        Thread.Sleep(vel);
                    }
                    //Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine(logo[i]);
                    Console.ResetColor();
                }
            Console.Write("\x1b[0m");
            }

        public void Separator(int linesQty)
        {
            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', linesQty));
            Console.ResetColor();
        }
    }
}