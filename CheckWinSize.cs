namespace CheckWinSize{
	public class ClaseCheckWinSize
	{
		public void checkwinsize()
		{
			if (Console.WindowWidth < 45 || Console.WindowHeight < 15)
			{
				Console.Clear();
				Console.ForegroundColor=ConsoleColor.DarkRed;
				Console.Write("\x1b[1m");
				Console.WriteLine("La ventana es demasiado chica para continuar con la correcta ejecucion de el programa!!!\n");
				Console.ForegroundColor=ConsoleColor.White;
				Console.WriteLine("Pulsa las teclas [Ctrl + C] para salir ó ajuste el tamaño de la ventana y pulse la tecla [Enter] para continuar\n");
				Console.Write("\x1b[0m");
				while(true)
				{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				if (keyInfo.Key == ConsoleKey.Enter)
				{
					if (Console.WindowWidth < 45 || Console.WindowHeight < 15)
					{
						Console.Clear();
						Console.ForegroundColor=ConsoleColor.DarkYellow;
						Console.Write("\x1b[1m");
						Console.WriteLine("El tamaño de la ventana sigue sin ser sufiente para seguir con la ejecucion de el programa");
						Console.ForegroundColor=ConsoleColor.White;
						Console.WriteLine("\nPulsa las teclas [Ctrl + C] para salir ó ajuste el tamaño de la ventana y pulse la tecla [Enter] para continuar\n");
						Console.Write("\x1b[0m");
					}
					else{break;}
				}
				else{}
				}
			};
		}
	}
}