using UnityEngine;
using System.Collections;

public abstract class Fire : MonoBehaviour {


	[SerializeField]
	private AudioSource fireSound;

	[SerializeField]
	private LayerMask igniterMask;
	[SerializeField]
	private LayerMask extinguishMask;


	void Awake(){

	}


	void OnTriggerEnter(Collider2D col){
		if (col.gameObject.layer & extinguishMask){

		}
		else if (col.gameObject.layer & igniterMask){
			
		}
	}

	protected abstract void Extinguish(){

	}

	protected abstract void Ignite(){
		
	}


}
