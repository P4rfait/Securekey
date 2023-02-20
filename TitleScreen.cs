using MyDecorators;
using Credits;
using CheckWinSize;
using MethodSelecctionScreen;

namespace TitleScreen
{
	public class ClaseTitleMenu
	{
		public void TitleMenu()
		{
			ClaseDecorators Decorador = new ClaseDecorators();
			ClaseCredits Creditos = new ClaseCredits();
			ClaseCheckWinSize CheckWinSize = new ClaseCheckWinSize();
			ClaseMethodSelecctionScreen GenerationMenu = new ClaseMethodSelecctionScreen();

			Console.Clear();
			Console.CursorVisible = false;
			Decorador.Displaylogo(true);
			Console.CursorVisible = true;
			bool isValidInput = false;
			while (!isValidInput)
			{
				CheckWinSize.checkwinsize();
				Console.Clear();
				Decorador.Displaylogo(false);
				Decorador.Separator(5);
				Console.Write("\x1b[1m");
				Console.ForegroundColor=ConsoleColor.DarkGreen;
				Console.WriteLine("Que accion desea realizar?:");
				Console.Write("\x1b[0m");
				Console.ForegroundColor=ConsoleColor.White;
				Decorador.Separator(5);
				Console.WriteLine("(1) Menu de generacion de contraseña");
				Console.WriteLine("(2) Acerca de & Créditos");
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine("(3) Salir");
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
							GenerationMenu.MethodMenu();
							Console.ReadKey();
							break;
						case 2:
						CheckWinSize.checkwinsize();
							isValidInput = true;
							Creditos.PrintCredits();
							Console.ReadKey();
							break;
						case 3:
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