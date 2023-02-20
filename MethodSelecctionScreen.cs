using MyDecorators;
using CheckWinSize;
using TitleScreen;
using FirstMethodScreen;

namespace MethodSelecctionScreen
{
	public class ClaseMethodSelecctionScreen{
		public void MethodMenu()
		{
			ClaseDecorators Decorador = new ClaseDecorators();
			ClaseCheckWinSize CheckWinSize = new ClaseCheckWinSize();
			ClaseTitleMenu TitleMenu = new ClaseTitleMenu();
			ClaseFirstMethodScreen FirstMethodScreen = new ClaseFirstMethodScreen();

			Console.Clear();
			bool isValidInput = false;
			while (!isValidInput)
			{
				CheckWinSize.checkwinsize();
				Console.Clear();
				Decorador.Separator(5);
				Console.Write("\x1b[1m");
				Console.ForegroundColor=ConsoleColor.DarkGreen;
				Console.WriteLine("Que metodo de generacion deceas utilizar?:");
				Console.Write("\x1b[0m");
				Console.ForegroundColor=ConsoleColor.White;
				Decorador.Separator(5);
				Console.WriteLine("(1) Generacion basada en parametros personalizables");
				Console.WriteLine("(2) Generacion basa en ingreso de palabra clave");
				Decorador.Separator(5);
				Console.WriteLine("(3) Regresar");
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine("(4) Salir");
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
							FirstMethodScreen.MethodMenu();
							Console.ReadKey();
							break;
						case 2:
							CheckWinSize.checkwinsize();
							isValidInput = true;
							Console.WriteLine("Has seleccionada la generacion basada en texto");
							Console.ReadKey();
							break;
						case 3:
							CheckWinSize.checkwinsize();
							isValidInput = true;
							TitleMenu.TitleMenu();
							Console.ReadKey();
							break;
						case 4:
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