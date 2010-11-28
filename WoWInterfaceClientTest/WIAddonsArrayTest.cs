using System;
using WowInterfaceClient;
using NUnit.Framework;

namespace WoWInterfaceClientTest
{
	[TestFixture]
	public class WIAddonsArrayTest
	{
		[Test]
		public void AddAddonTest()
		{
			WIAddonsArray addonArray;
			Assert.AreEqual(0, addonArray.GetCount());
			WIAddonInfoTest addonInfo;
			addonInfo.Add(addonInfo);
			Assert.AreEqual(1, GetCount());
		}
	}
}

