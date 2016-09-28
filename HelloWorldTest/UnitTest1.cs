using HelloWorld;
using NUnit.Framework;

namespace HelloWorldTest
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void TestMethod1()
		{
			Hello hello = new Hello();
			var expected = "bladiebla!";

			Assert.AreEqual(expected, hello.Dummy());
		}
	}
}
