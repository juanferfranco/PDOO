using System;

namespace Polimorfismo
{
	public class BingSearch: SearchEngine
	{
		public BingSearch ()
		{
		}

		public override string[] Search(string findThis)
		{
			return new string[] {
				"I found something.", // Thanks EDI
				"I found this for you." // Thanks SIRI
			};
		} 
	}
}

