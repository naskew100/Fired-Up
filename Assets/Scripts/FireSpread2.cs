using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FireSpread2 : MonoBehaviour {
    public bool isOnFire = false;
    List<FireSpread2> fireList = new List<FireSpread2>();
    public GameObject fire;
	// Use this for initialization
	void Start () {
        fire = (transform.GetChild(0)).gameObject;
        if (isOnFire)
            OnFire();
        else
        isOnFire = false;
    }
	
	// Update is called once per frame
	void Update () {
        
	
	}
    void printLocalFires()
    {
        if(fireList.Count > 0)
        for(int i = 0; i < fireList.Count-1; i++)   //foreach (FireSpread2 fire in fireList)
        {
            Debug.Log(fireList[i].name);
        }
        }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Fire")
        fireList.Add(collider.gameObject.GetComponent<FireSpread2>());
        
    }
    IEnumerator SetFires()
    {
        yield return new WaitForSeconds(5f);
        if (fireList.Count > 0)
        {
            for (int i = 0; i < fireList.Count - 1; i++)
            {
                if (!fireList[i].isOnFire)
                {
                    fireList[i].OnFire();
                }
            }
        }
        StartCoroutine(SetFires());
    }
    public void OnFire()
    {
        // fire.SetActive(true);
        fire.GetComponent<EffectSettings>().IsVisible = true;
        isOnFire = true;
        StartCoroutine(SetFires());
    }
    public void ExtinguishFire()
    {
        //fire.SetActive(false);
        fire.GetComponent<EffectSettings>().IsVisible = false;
        isOnFire = false;
    }
}
