// <copyright file="Hello.cs" company="Delta Instruments">Copyright © Delta Instruments B.V.</copyright>

using System.Data.SqlTypes;

namespace HelloWorld
{
	class Hello
	{
		public Hello()
		{

		}

		public string Text()
		{
			return "Hello World! Evertk is tha Man!" + Dummy();
		}
		
		public string FreerksText()
		{
			return "Who's the man?";
		}

		public string Dummy()
		{
			return "bladiebla!";
		}

		public void ChangesMadePost_v1_5()
		{
			// nothing to do here.
		}

		public void ChangesMadeFor1_7()
		{
			string test ="changes made in 1.7 feature branch.!!!!@$@@!@@@?@@";
			// Nothing to do here.
		}

		public void Bla()
		{
			// This is FdL code
		}
	}
}
