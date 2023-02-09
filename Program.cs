using System;
using System.Threading;
//Importo mi archivo de
using MyDecorators;

namespace passgen;
class Program
{
  static void Main(string[] args)
  {
    if (Console.WindowWidth < 45 || Console.WindowHeight < 15)
    {
      Console.ForegroundColor=ConsoleColor.DarkRed;
      Console.Write("\x1b[1m");
      Console.WriteLine("\nLa ventana es demasiado chica para ejecutar el programa\n");
      Console.Write("\x1b[0m");
      return;
    };
    ClaseDecorators Decorador = new ClaseDecorators();
    Console.Clear();
    Console.CursorVisible = false;
    Decorador.Displaylogo(true);
    Console.CursorVisible = true;
    bool isValidInput = false;
    while (!isValidInput)
    {

      checkwinsize();

      Console.Clear();
      Decorador.Displaylogo(false);
      Decorador.Separator(5);
      Console.Write("\x1b[1m");
      Console.ForegroundColor=ConsoleColor.DarkGreen;
      Console.WriteLine("Que accion desea realizar?:");
      Console.Write("\x1b[0m");
      Console.ForegroundColor=ConsoleColor.White;
      Console.WriteLine("(1) Menu de generacion de contraseña");
      Console.WriteLine("(2) Acerca de & Créditos");
      Console.ResetColor();
      Console.ForegroundColor=ConsoleColor.Red;
      Console.WriteLine("(3) Salir");
      Console.ResetColor();
      Decorador.Separator(5);
      Console.ForegroundColor=ConsoleColor.DarkGreen;
      Console.Write(">");
      Console.ResetColor();
      Console.CursorVisible = true;
      string? input = Console.ReadLine();
      switch (input)
      {
        case "1":
        checkwinsize();
            isValidInput = true;
            Console.WriteLine("Has seleccionado la opción 1");
            Console.ReadKey();
            break;
        case "2":
        checkwinsize();
            isValidInput = true;
            Console.WriteLine("Has seleccionado la opción 2");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("Saliendo del programa");
            Console.ReadKey();
            return;
        default:
            Console.CursorVisible = false;
            Console.Write("\x1b[1m");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("\nOpcion no valida\n");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Pulsa la tecla [Enter] para continuar...");
            Console.Write("\x1b[0m");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {}
            break;
      }
    }
    static void checkwinsize()
    {
      if (Console.WindowWidth < 45 || Console.WindowHeight < 15)
      {
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.Write("\x1b[1m");
        Console.WriteLine("\nLa ventana es demasiado chica para continuar con la correcta ejecucion de el programa !!!\n");
        Console.ForegroundColor=ConsoleColor.White;
        Console.WriteLine("Pulsa la tecla [Enter] para salir ó ajuste el tamaño de la ventana y pulse la tecla [C] para continuar\n");
        Console.Write("\x1b[0m");
        while(true)
        {
          ConsoleKeyInfo keyInfo = Console.ReadKey();
          if (keyInfo.Key == ConsoleKey.C)
          {
              if (Console.WindowWidth < 45 || Console.WindowHeight < 15)
              {
                Console.Clear();
                Console.ForegroundColor=ConsoleColor.DarkYellow;
                Console.Write("\x1b[1m");
                Console.WriteLine("\nEl tamaño de la ventana sigue sin ser sufiente para seguir con la ejecucion de el programa\n");
                Console.ForegroundColor=ConsoleColor.White;
                Console.WriteLine("Pulsa la tecla [Enter] para salir ó ajuste el tamaño de la ventana y pulse la tecla [C] para continuar\n");
                Console.Write("\x1b[0m");
              }
              else{break;}
          }
          else if (keyInfo.Key == ConsoleKey.Enter)
          {
              Environment.Exit(0);
          }
          else{}
        }
      };
    }
  }
}