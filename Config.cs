using MyDecorators;

namespace Config
{
	
	public class ClaseConfig
	{
		string fileName = "config";
		
		short def_length = 16;
		bool def_upcase = true;
		bool def_lowercase = true;
		bool def_numbers = true;

		public short length;
		public bool numbers;
		public bool lowercase;
		public bool upcase;

		public void MakeConfigFile()
		{
			if (!File.Exists(fileName))
				{
					using (StreamWriter writer = new StreamWriter(fileName))
					{
						writer.WriteLine($"length: {def_length}");
						writer.WriteLine($"upcase: {def_upcase}");
						writer.WriteLine($"lowercase: {def_lowercase}");
						writer.WriteLine($"numbers: {def_numbers}");
					}
				}
		}
		public void GetConfigFileDataAndRepair()
		{
			ClaseDecorators Decorador = new ClaseDecorators();
			bool ErrorInValues = false;
			bool ErrorInVarNames = false;
			bool ErrorInFormat = false;
			string[] lines = File.ReadAllLines(fileName);
			foreach(string line in lines)
			{
				string[] parts = line.Split(":");
				if (parts.Length == 2)
					{		
						string name = parts[0].Trim();
						string value = parts[1].Trim();
						switch(name)
						{
							case "length":
								if (Int16.TryParse(value, out length))
								{
									if (length < 8)
									{
										length =def_length;
										ErrorInValues = true;
									}
								}
								else
								{
									ErrorInValues = true;
								}
								break;
							case "numbers":
								if (bool.TryParse(value, out numbers)){}
								else
								{
									ErrorInValues = true;
								}
								break;
							case "lowercase":
								if (bool.TryParse(value, out lowercase)){}
								else{
									ErrorInValues = true;
								}
								break;						
							case "upcase":
								if(bool.TryParse(value, out upcase)){}
								else{
									ErrorInValues = true;
								}
								break;	
							default:
								ErrorInVarNames = true;
								break;
						}
				}
				else
				{
					ErrorInFormat = true;
				}
			}

							
			if (ErrorInValues == true || ErrorInVarNames == true || ErrorInFormat == true)
			{
				length = def_length;
				numbers = def_numbers;
				lowercase = def_lowercase;
				upcase = def_upcase;

				Decorador.Separator2(5);
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("A ocurrido un error al cargar la configuracion guardada, se a definido su valor por defecto, y restaurado la integridad de los archivos.");
				Decorador.Separator2(5);
				Console.WriteLine();
				Console.ResetColor();
				using (StreamWriter writer = new StreamWriter(fileName))
				{
					writer.WriteLine($"length: {def_length}");
					writer.WriteLine($"upcase: {def_upcase}");
					writer.WriteLine($"lowercase: {def_lowercase}");
					writer.WriteLine($"numbers: {def_numbers}");
				}
			}
		}
	}
}