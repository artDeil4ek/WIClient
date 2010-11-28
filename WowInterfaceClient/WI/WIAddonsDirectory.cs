using System;
using System.IO;

namespace WowInterfaceClient
{
	public class WIAddonsDirectory : WIAddonsArray
	{
		public WIAddonsDirectory(string _addonsPath) : base(_addonsPath)
		{
			FindAddonsDirectories(_addonsPath);
		}
		
		// Find all addons directories
		private void FindAddonsDirectories(string _addonsPath)
		{
			string[] addonsDirectories = null;
			try
			{
				addonsDirectories = Directory.GetDirectories(_addonsPath);
			}
			catch
			{
				return;
			}
		}
		
		// Analyze addons directories
		private void AnalyzeAddonsDirectories(string [] _addonsDirectories)
		{
			foreach(string addonPath in _addonsDirectories)
			{
				WITocFile addonInfo = new WITocFile(addonPath);
				if (addonInfo.IsValidAddon()) base.AddAddon(addonInfo);
			}
		}
	}
}

