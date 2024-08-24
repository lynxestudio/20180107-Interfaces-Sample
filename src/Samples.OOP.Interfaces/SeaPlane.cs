using System;
namespace Samples.OOP.Interfaces 
{
	public class SeaPlane : Airplane {

		public SeaPlane(){
		}

		~SeaPlane(){
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
			Console.WriteLine("SeaPlane landing...");
		}

		public override void Fly(){
		}

	}
}