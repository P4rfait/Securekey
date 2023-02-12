using CheckWinSize;
using MyDecorators;
using Program;

namespace Credits{
	public class ClaseCredits
	{
		public void PrintCredits()
		{
		ClaseDecorators Decorador = new ClaseDecorators();
		ClaseCheckWinSize CheckWinSize = new ClaseCheckWinSize();
    	ClaseMainMenu mainMenu = new ClaseMainMenu();


		Console.Clear();
		Console.CursorVisible = false;
		Console.ForegroundColor=ConsoleColor.Cyan;
		Console.WriteLine("Acerca de & Créditos");
		Decorador.Separator(5);
		Decorador.Displaycredits(true);
		Console.CursorVisible = true;
		bool isValidInput = false;
		while (!isValidInput)
		{
			CheckWinSize.checkwinsize();
			Console.Clear();
			Console.ForegroundColor=ConsoleColor.Cyan;
			Console.WriteLine("Acerca de & Créditos");
			Decorador.Separator(5);
			Decorador.Displaycredits(false);
			Decorador.Separator(5);
			Console.Write("\x1b[1m");
			Console.ForegroundColor=ConsoleColor.DarkGreen;
			Console.WriteLine("Que accion desea realizar?:");
			Console.Write("\x1b[0m");
			Console.ForegroundColor=ConsoleColor.White;
			Decorador.Separator(5);
			Console.WriteLine("(1) Regresar");
			Console.ForegroundColor=ConsoleColor.Red;
			Console.WriteLine("(2) Salir");
			Console.ResetColor();
			Decorador.Separator(5);
			Console.Write("> ");
			Console.ResetColor();
			Console.CursorVisible = true;
			
			string? input = Console.ReadLine();
			if (Int16.TryParse(input, out short result))
			{
			short selecton = result;
			switch (selecton)
			{
				case 1:
					CheckWinSize.checkwinsize();
					isValidInput = true;
					mainMenu.MainMenu();
					Console.ReadKey();
					break;
				case 2:
					Console.WriteLine("Saliendo del programa");
					Console.Clear();
					Environment.Exit(0);
					return;
				default:
					Console.CursorVisible = false;
					Console.Write("\x1b[1m");
					Console.ForegroundColor=ConsoleColor.DarkRed;
					Console.WriteLine("\nEl número ingresado no corresponde a ninguna opción.\n");
					Console.ForegroundColor=ConsoleColor.White;
					Console.WriteLine("Pulsa la tecla [Enter] para continuar...");
					Console.Write("\x1b[0m");
					while (Console.ReadKey().Key != ConsoleKey.Enter) {}
					break;
			}
			}
			else
			{
			Console.CursorVisible = false;
			Console.Write("\x1b[1m");
			Console.ForegroundColor=ConsoleColor.DarkRed;
			Console.WriteLine("\nLa entrada no es un valor numérico válido.\n");
			Console.ForegroundColor=ConsoleColor.White;
			Console.WriteLine("Pulsa la tecla [Enter] para continuar...");
			Console.Write("\x1b[0m");
			while (Console.ReadKey().Key != ConsoleKey.Enter) {}
			}
		}
		}
	}
}