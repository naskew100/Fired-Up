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


	void OnTriggerEnter(Collider col){
		if (FU.Tools.IsInLayerMask(col.gameObject, igniterMask)){
			StartCoroutine(IgniteObject(col));
		}

	}

	void OnTriggerStay(Collider col){
		if (FU.Tools.IsInLayerMask(col.gameObject, extinguishMask)){

		}
	}

	protected abstract IEnumerator Extinguish(Collider col);
	protected abstract IEnumerator IgniteObject(Collider col);
	protected abstract IEnumerator Spread();


}
