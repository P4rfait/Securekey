using MyDecorators;
using CheckWinSize;
using MethodSelecctionScreen;
using Config;

namespace FirstMethodScreen
{
	public class ClaseFirstMethodScreen
	{
		public void MethodMenu()
		{
			ClaseDecorators Decorador = new ClaseDecorators();
			ClaseCheckWinSize CheckWinSize = new ClaseCheckWinSize();
			ClaseMethodSelecctionScreen MethodSelecctionScreen = new ClaseMethodSelecctionScreen();
			ClaseConfig Config = new ClaseConfig();

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
				Config.GetConfigFileData();


				//Imprimir cantidad de caracteres
				Console.Write("Cantidad de caracteres [");
				Console.Write("\x1b[1m");
				Console.Write(Config.length);
				Console.Write("\x1b[0m");
				Console.WriteLine("]");
				
				

				//Imprimir estado de mayusculas
				Console.Write("Mayúsculas [");
				Console.ForegroundColor = Config.capital ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed;
				Console.Write("\x1b[1m");
				Console.Write(Config.capital? "Si":"No");
				Console.Write("\x1b[0m");
				Console.ResetColor();
				Console.WriteLine("]");
				
				//Imprimir estado de Minusculas
				Console.Write("Minúsculas [");
				Console.ForegroundColor = Config.lowercase ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed;
				Console.Write("\x1b[1m");
				Console.Write(Config.lowercase? "Si":"No");
				Console.Write("\x1b[0m");
				Console.ResetColor();
				Console.WriteLine("]");

				//Imprimir estado de Numeros
				Console.Write("Números [");
				Console.ForegroundColor = Config.numbers ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed;
				Console.Write("\x1b[1m");
				Console.Write(Config.numbers? "Si":"No");
				Console.Write("\x1b[0m");
				Console.ResetColor();
				Console.WriteLine("]");

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
							Console.WriteLine("Has seleccionado Generar");
							Console.ReadKey();
							break;
						case 2:
							CheckWinSize.checkwinsize();
							isValidInput = true;
							Console.WriteLine("Has seleccionado configurar");
							Console.ReadKey();
							break;
						case 3:
							CheckWinSize.checkwinsize();
							isValidInput = true;
							MethodSelecctionScreen.MethodMenu();
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