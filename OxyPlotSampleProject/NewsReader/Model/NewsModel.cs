using System;


namespace NewsReader.Model
{
	public class NewsModel
	{
		public string Author { get; set; }
		public double NumberOfReads { get; set; }

		public NewsModel(string author, double numberOfReads)
		{
			this.Author = author;
			this.NumberOfReads = numberOfReads;
		}
		 
	}
}

