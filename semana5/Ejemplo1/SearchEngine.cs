using System;

namespace Polimorfismo
{
	public class SearchEngine
	{
		public SearchEngine ()
		{
		}

		public virtual string[] Search(string findThis)
		{
			return new string[]{"I give up"};
		}
	}
}

