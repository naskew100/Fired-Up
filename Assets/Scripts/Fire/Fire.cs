using UnityEngine;
using System.Collections;

public abstract class Fire : MonoBehaviour {


	[SerializeField]
	private AudioSource fireSound;

	[SerializeField]
	private LayerMask igniterMask;
	[SerializeField]
	private LayerMask extinguishMask;
	private float fireHealth;

	void Awake(){

	}


	void OnTriggerEnter(Collider2D col){
		if (igniterMask & 1<<col.gameObject.layer){
			StartCoroutine(IgniteObject(col));
		}

	}

	void OnTriggerStay(Collider2D col){
		if (extinguishMask & 1<<col.gameObject.layer){

		}
	}

	protected abstract IEnumerator Extinguish(Collider col);
	protected abstract IEnumerator IgniteObject(Collider col);
	protected abstract IEnumerator Spread();


}
