using UnityEngine;
using System.Collections;
using System;

public class GearSelector : MonoBehaviour {

	private GearEnum CurrentGear;
	public static int NumberIceGrenades{get; set;};
	public static int NumberBlackHoles;
	public static float CO2;

	// Update is called once per frame
	void Update () {
		ToggleGear();
	}

	void ToggleGear(){
		if (Input.GetButtonDown (FU.Controls.ToggleGear)){
			//deselect current gear

			//check if you have enough of the next gear to select it
				//if not, move on to the next
			//select next gear
			ActivateGearIcon ( CurrentGear );
		}
	}

	void ActivateGearIcon ( GearEnum NewlyActiveGear ){

	}
}
