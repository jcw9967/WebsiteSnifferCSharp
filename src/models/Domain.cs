﻿namespace WebsiteSnifferCSharp.src.models
{
	internal class Domain
	{
		public Domain( int id, string url )
		{
			Id = id;
			Url = url;
		}

		public int Id { get; }
		public string Url { get; }
	}
}