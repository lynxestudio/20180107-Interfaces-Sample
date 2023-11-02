using System;

namespace Samples.OOP.Interfaces {
	public class Helicopter : Airplane {

		public Helicopter(){
		}

		~Helicopter(){
		}

		public override void Dispose(){
		}

		public override double CalcFuelEfficiency(){
			return 0;
		}

		public override void TakeOff(){
		}

		public override double CalcTripDistance(){
			return 0;
		}

		public override void Land(){
			Console.WriteLine("Helicopter landing...");
		}

		public override void Fly(){
		}

	}
}