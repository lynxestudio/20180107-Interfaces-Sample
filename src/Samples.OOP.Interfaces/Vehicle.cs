using System;

namespace Samples.OOP.Interfaces 
{
	public abstract class Vehicle {

		public Vehicle(){
		}

		~Vehicle(){
		}

		public virtual void Dispose(){
		}

		public abstract double CalcFuelEfficiency();

		public abstract double CalcTripDistance();

	}
}