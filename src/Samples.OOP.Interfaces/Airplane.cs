using System;

namespace Samples.OOP.Interfaces 
{
	public class Airplane : Vehicle, Flyer {

		public Airplane(){

		}

		~Airplane(){

		}

		public override void Dispose(){

		}

		public override double CalcFuelEfficiency(){

			return 0;
		}

		public virtual void TakeOff(){

		}

		public override double CalcTripDistance(){

			return 0;
		}

		public virtual void Land(){
			Console.WriteLine("Airplane landing...");
		}

		public virtual void Fly(){

		}

	}//end Airplane

}