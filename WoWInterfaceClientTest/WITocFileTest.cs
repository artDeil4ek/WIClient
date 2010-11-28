using System;
using  vcWoWInterfaceClient;
using NUnit.Framework;

namespace WoWInterfaceClientTest
{
	[TestFixture]
	public class WITocFileTest
	{
		[Test]
		public void TocFileTest()
		{
			WITocFile tocFile = new WITocFile("C:\\Users\\olik\\Documents\\Projects\\WoWInterfaceClient\\TestWoWData\\Interface\\AddOns\\Recount");
			Assert.AreEqual(true, tocFile.IsValidAddon());
			Assert.AreEqual("C:\\Users\\olik\\Documents\\Projects\\WoWInterfaceClient\\TestWoWData\\Interface\\AddOns\\Recount", tocFile.AddonPath);
			Assert.AreEqual("Recount", tocFile.AddonTitle);
			Assert.AreEqual("Cryect, ported to 2.4 by Elsia", tocFile.AddonAuthor);
			Assert.AreEqual("v4.0.1d release", tocFile.AddonVersion);
		}
	}
}

