using MyDecorators;
using CheckWinSize;
using MethodSelecctionScreen;


namespace FirstMethodScreen
{
	public class ClaseFirstMethodScreen
	{
		public void MethodMenu()
		{
			ClaseDecorators Decorador = new ClaseDecorators();
			ClaseCheckWinSize CheckWinSize = new ClaseCheckWinSize();
			ClaseMethodSelecctionScreen MethodSelecctionScreen = new ClaseMethodSelecctionScreen();

			Console.Clear();
			bool isValidInput = false;
			while (!isValidInput)
			{
				CheckWinSize.checkwinsize();
				Console.Clear();
				Decorador.Separator(10);
				Console.ForegroundColor=ConsoleColor.Cyan;
				Console.WriteLine("Generacion basada en parametros personalizables");
				Console.ResetColor();
				Decorador.Separator(10);
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.ResetColor();
				Console.WriteLine("Cantidad de caracteres []");
				Console.WriteLine("Mayúsculas []");
				Console.WriteLine("Minúsculas []");
				Console.WriteLine("Números []");
				Console.WriteLine("");
				Decorador.Separator(10);
				Console.Write("\x1b[1m");
				Console.ForegroundColor=ConsoleColor.DarkGreen;
				Console.WriteLine("Que accion desea realizar?:");
				Console.Write("\x1b[0m");
				Console.ForegroundColor=ConsoleColor.White;
				Decorador.Separator(10);
				Console.WriteLine("(1) Generar");
				Console.WriteLine("(2) Configurar");
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
							Console.WriteLine("Has seleccionado la Generacion basada en paramentros");
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
							MethodSelecctionScreen.MethodMenu();
							Console.ReadKey();
							break;
						case 4:
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