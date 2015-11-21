using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class GearSelector : MonoBehaviour {

	[SerializeField]
	private GearEnum CurrentGear;
	[SerializeField]
	private GameObject fireHose;
	[SerializeField]
	private GameObject iceGrenade;
	[SerializeField]
	private GameObject blackHole;
	[SerializeField]
	private GameObject jetpack;
	private Dictionary <GearEnum,int> gearInventory;

	private float throwForce;
	private float timeToWaitToThrow;
	private bool canThrowGrenade;

	void Awake(){
		gearInventory = new Dictionary<GearEnum, int>();
		gearInventory.Add(GearEnum.FireHose,int.MaxValue);
		gearInventory.Add(GearEnum.IceGrenade,2);
		gearInventory.Add(GearEnum.BlackHole,3);
		gearInventory.Add(GearEnum.CO2Jetpack,10);

		throwForce = 500f;
		timeToWaitToThrow = 2f;
		canThrowGrenade = true;
		CurrentGear = 0;
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (FU.Controls.ToggleGear)){
			ToggleGear();
		}
		if (Input.GetButton (FU.Controls.FightFire) && gearInventory[CurrentGear]>0){
			UseGear();
		}
	}

	void ToggleGear(){
		if (CurrentGear == GearEnum.CO2Jetpack){
			CurrentGear = GearEnum.FireHose;
		}
		else{
			CurrentGear++;
			if (gearInventory[CurrentGear]<=0){
				ToggleGear();
			}
		}

		HighlightActiveGearIcon();
	}

	void HighlightActiveGearIcon(){
		Debug.Log(CurrentGear.ToString() +"activated!");
	}

	void UseGear(){
		if (CurrentGear == GearEnum.FireHose){
			UseHose();
		}
		else if (CurrentGear == GearEnum.IceGrenade || CurrentGear == GearEnum.BlackHole){
			if (Input.GetButtonDown(FU.Controls.FightFire)){
				if (canThrowGrenade){
					StartCoroutine (ThrowThing(CurrentGear));
				}
			}
		}
		else if (CurrentGear == GearEnum.CO2Jetpack){
			TurnOnJetPack();
		}
	}

	void UseHose(){

	}

	IEnumerator ThrowThing(GearEnum thingToThrow){
		GameObject objectToSpawn;
		if (thingToThrow == GearEnum.IceGrenade){
			objectToSpawn = iceGrenade;
			gearInventory[GearEnum.IceGrenade]--;
		}
		else {
			objectToSpawn = blackHole;
			gearInventory[GearEnum.BlackHole]--;
		}

		canThrowGrenade = false;
		GameObject grenade = Instantiate(objectToSpawn, transform.position, Quaternion.identity) as GameObject;
		grenade.GetComponentInChildren<Rigidbody>().AddForce(Camera.main.transform.forward * throwForce);
		yield return new WaitForSeconds(timeToWaitToThrow);
		canThrowGrenade = true;
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		Gizmos.DrawLine (transform.position, transform.position + Camera.main.transform.forward * 3f);
	}

	void TurnOnJetPack(){
		
	}


}
