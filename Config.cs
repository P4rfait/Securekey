using MyDecorators;

namespace Config
{
	
	public class ClaseConfig
	{
		string fileName = "config";
		
		short def_length = 16;
		bool def_capital = true;
		bool def_lowercase = true;
		bool def_numbers = true;
		public short length;
		public bool numbers;
		public bool lowercase;
		public bool capital;
		public void MakeConfigFile()
		{
			if (!File.Exists(fileName))
				{
					using (StreamWriter writer = new StreamWriter(fileName))
					{
						writer.WriteLine($"length: {def_length}");
						writer.WriteLine($"capital: {def_capital}");
						writer.WriteLine($"lowercase: {def_lowercase}");
						writer.WriteLine($"numbers: {def_numbers}");
					}
				}
		}
		public void GetConfigFileData()
		{
			ClaseDecorators Decorador = new ClaseDecorators();
			bool ErrorToParse = false;
			string[] lines = File.ReadAllLines(fileName);
			foreach(string line in lines)
			{
				string[] parts = line.Split(":");
				string name = parts[0].Trim();
				string value = parts[1].Trim();
				switch(name)
				{
					case "length":
						if (Int16.TryParse(value, out length)){}
						else
						{
							length = def_length;
							ErrorToParse = true;
						}
						break;
					case "numbers":
						if (bool.TryParse(value, out numbers)){}
						else
						{
							numbers = def_numbers;
							ErrorToParse = true;
						}
						break;
					case "lowercase":
						if (bool.TryParse(value, out lowercase)){}
						else{
							lowercase = def_lowercase;
							ErrorToParse = true;
						}
						break;						
					case "capital":
						if(bool.TryParse(value, out capital)){}
						else{
							capital = def_capital;
							ErrorToParse = true;
						}
						break;	
				}
			}
			if (ErrorToParse == true)
			{
				Decorador.Separator2(5);
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("A ocurrido un error con al menos un valor, se a definido su valor por defecto, y restaurado la integridad de los archivos");
				Decorador.Separator2(5);
				Console.ResetColor();
				using (StreamWriter writer = new StreamWriter(fileName))
				{
					writer.WriteLine($"length: {def_length}");
					writer.WriteLine($"capital: {def_capital}");
					writer.WriteLine($"lowercase: {def_lowercase}");
					writer.WriteLine($"numbers: {def_numbers}");
				}
			}
		}
	}
}