using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PlaceUnit : MonoBehaviour {

    public string placeName;
    public bool sellable;
    public float rentPrice;
    public float sellPrice;
    public float upgradeHouse1;
    public float upgradeHouse2;
    public float upgradeHouse3;
    public float upgradeHotel;
    
    public PlayerBehavior owner;

    public GameObject flag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowOwner()
    {
        if (owner == null)
        {
            if (owner != null)
            {
                Destroy(flag);
            }
        }
        else
        {
            flag = GameObject.Instantiate(Resources.Load<GameObject>("FlagPolePlayer"+(owner.playerID+1).ToString()));
            flag.transform.position = transform.position;
        }
    }
}
