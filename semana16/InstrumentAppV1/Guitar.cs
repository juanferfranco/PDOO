﻿using System;

namespace InstrumentAppV1
{
	public class Guitar: Instrument
	{
		public Guitar(String serialNumber, double price, GuitarSpec spec): base(serialNumber,
			price,spec){
		}
	}
}
