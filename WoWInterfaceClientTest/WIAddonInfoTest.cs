using System;
using WoWInterfaceClient;
using NUnit.Framework;

namespace WoWInterfaceClientTest
{
	[TestFixture]
	public class WIAddonInfoTest
	{
		[Test]
		public void IsValidAddonTest()
		{
			WIAddonInfoTest addonInfo;
			Assert.AreEqual(false, addonInfo.IsValidAddon());
			addonInfo.AddonPath = "C:\\Users\\olik\\Documents\\Projects\\WoWInterfaceClient\\TestWoWData\\Interface\\AddOns\\Recount";
			addonInfo.AddonTitle = "Recount";
			addonInfo.AddonAuthor = "Cryect, ported to 2.4 by Elsia";
			addonInfo.AddonVersion = "v4.0.1d release";
			Assert.AreEqual(true, addonInfo.IsValidAddon());
		}
		[Test]
		public void ToStringTest()
		{
			WIAddonInfoTest addonInfo;
			addonInfo.AddonPath = "C:\\Users\\olik\\Documents\\Projects\\WoWInterfaceClient\\TestWoWData\\Interface\\AddOns\\Recount";
			addonInfo.AddonTitle = "Recount";
			addonInfo.AddonAuthor = "Cryect, ported to 2.4 by Elsia";
			addonInfo.AddonVersion = "v4.0.1d release";
			Assert.AreEqual("Addon: Recount | Cryect, ported to 2.4 by Elsia | v4.0.1d release", addonInfo.ToString());
		}
	}
}

