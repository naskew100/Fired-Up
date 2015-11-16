using UnityEngine;
using System.Collections;

public abstract class Grandpa : MonoBehaviour {

	void Awake(){
		DoThing();
	}
	public abstract void DoThing();
}
