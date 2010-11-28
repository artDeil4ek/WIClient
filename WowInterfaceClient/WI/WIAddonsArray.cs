using System;
using System.Collections;

namespace WowInterfaceClient
{
	public class WIAddonsArray
	{
		public WIAddonsArray()
		{
			addonArray = new ArrayList();
		}
		public WIAddonsArray(string _addonsPath)
		{
			addonArray = new ArrayList();
		}
		
		// Array of all correct addons in wow folder
		private ArrayList addonArray = null;
		
		// Add new addon info to array
		public void AddAddon(WIAddonInfo addonInfo)
		{
			addonArray.Add(addonInfo);
		}
		
		// Get addon count
		public int GetCount()
		{
			return addonArray.Count;
		}
		
		// To string method
		public override string ToString()
		{
			string addonArrayString = "";
			for (int addonIndex = 0; addonIndex < addonArray.Count; addonIndex++)
			{
				addonArrayString += addonArray[addonIndex];
				addonArrayString += "\r\n";
			}
			return addonArrayString;
		}
	}
}

