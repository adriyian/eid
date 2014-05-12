using System;
using Egelke.Eid.SmartCard;
using NUnit.Framework;

namespace Egelke.Eid.Client.Test.WithCard
{
	[TestFixture]
	public class When_connecting_to_the_reader
	{
		[Test]
		public void the_card_should_become_connected()
		{
			using (var reader = SmartCardReader.GetReader(TestContext.READER_NAME))
			{
				reader.Connect();

				Assert.IsTrue(reader.Connected);
			}
			
		}
	}
}