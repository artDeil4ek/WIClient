using System;
using System.IO;

namespace WowInterfaceClient
{
	public class WITocFile : WIAddonInfo
	{
		public WITocFile(string _addonPath) : base(_addonPath)
		{
			ReadTocFile(_addonPath);
		}
		
		// Read *.toc file
		private void ReadTocFile(string _addonPath)
		{
			string tocFilePath = FindTocFile(_addonPath);
			if (tocFilePath.Length == 0) return;
			
			if (File.Exists(tocFilePath))
			{
				StreamReader file = null;
				try
				{
					file = new StreamReader(tocFilePath);
					string line = "";
					while ((line = file.ReadLine()) != null)
					{
						AnalyzeTocFileLine(line);
					}
				}
				finally
				{
					if (file != null) file.Close();
				}
			}
		}
		
		// Find *.toc file
		private string FindTocFile(string _addonPath)
		{
			string[] tocFiles = null;
			try
			{
				tocFiles = Directory.GetFiles(AddonPath, "*.toc");
			}
			catch
			{
				return "";
			}
			if (tocFiles.Length == 1) return tocFiles[0];
			return "";
		}
		
		static string Title = "## Title: ";
		static string Author = "## Author: ";
		static string Version = "## Version: ";
		
		// Analyze toc file line
		private void AnalyzeTocFileLine(string tocLine)
		{
			if (tocLine.StartsWith(Title)) base.AddonTitle = tocLine.Substring(Title.Length);
			if (tocLine.StartsWith(Author)) base.AddonAuthor = tocLine.Substring(Author.Length);
			if (tocLine.StartsWith(Version)) base.AddonVersion = tocLine.Substring(Version.Length);
		}
		
	}
}

