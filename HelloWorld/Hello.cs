﻿// <copyright file="Hello.cs" company="Delta Instruments">Copyright © Delta Instruments B.V.</copyright>

using System.Data.SqlTypes;

namespace HelloWorld
{
	internal class Hello
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

		public void Dit_is_change_in_Branch151()
		{
			///sdfkljadf
		}

		public void Bla()
		{
			string jaja = "dit zou automagisch gemerged moeten worden toch?";
			jaja += "Build this!";
		}

		public void ChangesMadeFor1_7()
		{
			int mIndex = 0;

			for (int i = 0; i < 100; i++)
			{
				mIndex++;
			}
		
			string test ="changes made in 1.7 feature branch!";
			// Nothing to do here.
		}

		private World mWorld;


		public World World { get { return mWorld; } }
	}
}
