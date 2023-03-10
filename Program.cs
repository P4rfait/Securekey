using System;
using System.Threading;

using TitleScreen;
using Config;

namespace Program;

public class MainClass
{
  public static void Main(string[] args)
  {
    ClaseTitleMenu TitleMenu = new ClaseTitleMenu();
    ClaseConfig Config = new ClaseConfig();
    if (Console.WindowWidth < 45 || Console.WindowHeight < 15)
    {
      Console.Write("\x1b[1m");
      Console.ForegroundColor=ConsoleColor.DarkRed;
      Console.WriteLine("\nLa ventana es demasiado chica para ejecutar el programa\n");
      Console.Write("\x1b[0m");
      return;
    };
    
    Config.MakeConfigFile();
    TitleMenu.TitleMenu();
  }
}