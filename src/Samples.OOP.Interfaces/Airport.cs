using System;

namespace Samples.OOP.Interfaces
{
	public class Airport
	{
		public static void Main(string[] args)
		{
		Airport metropolisAirport = new Airport();
		Helicopter copter = new Helicopter();
		SeaPlane sPlane = new SeaPlane();
		
		metropolisAirport.GivePermissionToLand(copter);
		metropolisAirport.GivePermissionToLand(sPlane);
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
		}
		
		private void GivePermissionToLand(Flyer f)
		{
			f.Land();
		}
		
	}
}