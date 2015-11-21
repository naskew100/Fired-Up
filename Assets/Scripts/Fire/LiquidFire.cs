using UnityEngine;
using System.Collections;

public class LiquidFire : Fire {

	// Use this for initialization
	void Awake () {
		
	}
	
	protected override IEnumerator Extinguish(Collider col){
		yield return null;
	}
	
	protected override IEnumerator IgniteObject(Collider col){
		yield return null;
	}
	
	protected override IEnumerator Spread(){
		yield return null;
	}
}
