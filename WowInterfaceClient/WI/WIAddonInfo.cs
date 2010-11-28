/*
 * Class holds information about current addon 
*/
using System;

namespace WowInterfaceClient
{
	public class WIAddonInfo
	{
		public WIAddonInfo()
		{
			addonPath = "";
			addonTitle = "";
			addonAuthor = "";
			addonVersion = "";
		}
		public WIAddonInfo(string _addonPath)
		{
			addonPath = _addonPath;
			addonTitle = "";
			addonAuthor = "";
			addonVersion = "";
		}
		
		// Is addon found and addon information successfully readed
		public bool IsValidAddon()
		{
			return ( (AddonPath.Length != 0) && (AddonTitle.Length != 0) );
		}
		
		// To String method
		public override string ToString()
		{
			return String.Format("Addon: {0} | {1} | {2}", AddonTitle, AddonAuthor, AddonVersion);
		}
		
		// Addon path
		private readonly string addonPath;
		public string AddonPath
		{
			get
			{
				return addonPath;
			}
		}
		
		// Addon Information
		// Addon name
		private string addonTitle;
		public string AddonTitle
		{
			get
			{
				return addonTitle;
			}
			set
			{
				addonTitle = value;
			}
		}
		//
		// Addon author
		private string addonAuthor;
		public string AddonAuthor
		{
			get
			{
				return addonAuthor;
			}
			set
			{
				addonAuthor = value;
			}
		}
		// Addon version
		private string addonVersion;
		public string AddonVersion
		{
			get
			{
				return addonVersion;
			}
			set
			{
				addonVersion = value;
			}
		}
	}
}

