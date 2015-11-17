using UnityEngine;
using System.Collections;

namespace FU{

	#region Layers
	public static class Layers {
		public static class Fires{
			public static int electricFire = 10;
			public static int solidFire = 11;
			public static int liquidFire = 12;

			public static string electricFireString = "ElectricFire";
			public static string solidFireString = "SolidFire";
			public static string liquidFireString = "LiquidFire";
		}

		public static class Extinguishers{
			public static int hoseWater = 13;
			public static int CO2 = 14;
			public static int iceGrenade = 15;
			public static int blackHole = 16;

			public static string hoseWaterString = "HoseWater";
			public static string CO2String = "CO2";
			public static string iceGrenadeString = "IceGrenade";
			public static string blackHoleString = "BlackHole";
		}

		public static class Objects{
			public static int furniture = 17;

			public static string furnitureString = "Furniture";
		}

		public static class People{
			public static int NPC = 18;
			public static int you = 19;

			public static int NPCString = "NPC";
			public static int youString = "You";
		}
	}
	#endregion

	#region Controls
	public static class Controls{

		public static string Forward = "Forward";
		public static string Sideways = "Sideways";
		public static string Jump = "Jump";
		public static string FightFire = "FightFire";
		public static string ToggleGear = "ToggleGear";

	}
	#endregion
}
