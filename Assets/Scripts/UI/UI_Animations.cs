using UnityEngine;
using System.Collections;

public class UI_Animations : MonoBehaviour {

	private bool scaling;
	private float growToSize;
	private Vector3 startScale;
	private float lerpFraction;

	[SerializeField]
	private TextMesh inventoryQuantity;
	[SerializeField]
	private Animator UIAnimator;
	
	
	public virtual void ActivateUI(){
		UIAnimator.SetInteger("AnimState",1);
	}

	public virtual void DeActivateUI(){
		UIAnimator.SetInteger("AnimState",0);
	}

	public void UpdateInventory(int quantity){
		inventoryQuantity.text = quantity.ToString();
	}
}
