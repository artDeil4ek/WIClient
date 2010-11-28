using System;

namespace WowInterfaceClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			WIAddonsDirectory addonsDirectory = new WIAddonsDirectory("C:\\Users\\olik\\Documents\\Projects\\WoWInterfaceClient\\TestWoWData");
			WIAddonsArray addonsArray = (WIAddonsArray)addonsDirectory;
			Console.WriteLine(addonsArray);
			Console.ReadLine();
		}
	}
}
