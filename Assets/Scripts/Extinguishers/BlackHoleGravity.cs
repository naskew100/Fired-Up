using UnityEngine;
using System.Collections;

public class BlackHoleGravity : MonoBehaviour {

	private float holeRadius;
	private float pullForce;
	private LayerMask layersToPull;
	private bool singularizing;
	private float timeToSingularize;

	// Use this for initialization
	void Awake () {
		holeRadius = 5f;
		pullForce = 20f;
		timeToSingularize = 5f;
		layersToPull = LayerMask.GetMask (FU.Layers.Objects.furnitureString, 
		                                  FU.Layers.People.youString, 
		                                  FU.Layers.People.NPCString);
		LayerMask.
		singularizing = true;
		StartCoroutine (Timer());
		StartCoroutine (PullInObjects());
	}

	IEnumerator Timer(){
		yield return WaitForSeconds (5f);
		singularizing = false;
	}

	IEnumerator PullInObjects(){
		while (singularizing){
			foreach (Collider col in Physics.OverlapSphere(transform.position,holeRadius,layersToPull)){
				Vector3 pullDir = (transform.position - col.transform.position).normalized;
				float angle = Vector3.Angle(pullDir,transform.up);
				if (angle>90f){
					angle -= 90f;
				}
				float pullFactor = angle/90f;
				col.attachedRigidbody.AddForce(pullDir * pullForce * pullFactor);
			}
			yield return null;
		}
		yield return null;
	}

	void OnTriggerEnter(Collider col){
		if (layersToPull & 1<<col.gameObject.layer){
			Destroy(col.gameObject);
		}
	}

}
