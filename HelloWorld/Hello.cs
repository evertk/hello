﻿// <copyright file="Hello.cs" company="Delta Instruments">Copyright © Delta Instruments B.V.</copyright>


namespace HelloWorld
{
	class Hello
	{
		public Hello()
		{

		}

		public string Hotfix_1_5_2()
		{
			return FreerksText() + " " + Text();
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
	}
}
