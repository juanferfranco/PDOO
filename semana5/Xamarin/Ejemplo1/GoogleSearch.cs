using System;

namespace Polimorfismo
{
	public class GoogleSearch: SearchEngine
	{
		public GoogleSearch ()
		{
			
		}

		public override string[] Search(string findThis)
		{
			// Google Search is, of course, way better than 3 hard-coded results like this…
			return new string[] {
				"Here are some great results.",
				"Aren't they neat?",
				"I found 1.2 billion things, but you will only look at the first 10." };
		} 
	}
}

