﻿using System;

namespace Facebook.PlacesKit
{
	public class Loader
	{
		static Loader ()
		{
			Facebook.CoreKit.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class Messaging
	{
		static Messaging ()
		{
			Facebook.PlacesKit.Loader.ForceLoad ();
		}
	}
}
