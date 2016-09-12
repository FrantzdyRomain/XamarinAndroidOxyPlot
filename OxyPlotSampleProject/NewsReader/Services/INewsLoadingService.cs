using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsReader.Services
{
	public interface INewsLoadingService
	{

		Task<List<string>> LoadNews();
	
	}
}

