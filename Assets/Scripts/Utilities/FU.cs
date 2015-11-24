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
			public static int ground = 18;

			public static string furnitureString = "Furniture";
			public static string groundString = "Ground";
		}

		public static class People{
			public static int NPC = 19;
			public static int you = 20;

			public static string NPCString = "NPC";
			public static string youString = "You";
		}
	}
	#endregion

	#region Controls
	public static class Controls{
		public static void SetControls (){
			if (Application.platform == RuntimePlatform.OSXPlayer ||
			    Application.platform == RuntimePlatform.OSXEditor ||
			    Application.platform == RuntimePlatform.OSXDashboardPlayer ||
			    Application.platform == RuntimePlatform.OSXWebPlayer){
			
				Forward = "Mac_Forward";
				Sideways = "Mac_Sideways";
				LookUp = "Mac_LookUp";
				LookSideways = "Mac_LookSideways";
				Jump = "Mac_Jump";
				FightFire = "Mac_FightFire";
				ToggleGear = "Mac_ToggleGear";
			}
			else{
				Forward = "Win_Forward";
				Sideways = "Win_Sideways";
				LookUp = "Win_LookUp";
				LookSideways = "Win_LookSideways";
				
				Jump = "Win_Jump";
				FightFire = "Win_FightFire";
				ToggleGear = "Win_ToggleGear";
			}
		}

		public static string Forward;
		public static string Sideways;
		public static string LookUp;
		public static string LookSideways;
		public static string Jump;
		public static string FightFire;
		public static string ToggleGear;
	}

	#endregion

	#region Tools (layerinMask)
	public static class Tools{

		public static bool IsInLayerMask(GameObject obj, LayerMask mask){
			return ((mask.value & (1<< obj.layer))>0);
		}
	}
	#endregion
}

#region ExtensionMethods

#endregion
