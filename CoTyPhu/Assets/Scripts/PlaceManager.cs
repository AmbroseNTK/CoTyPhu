using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	

    public void Show()
    {
        animator.SetBool("isShow", true);
    
    }
    public void Hide()
    {
        animator.SetBool("isShow", false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
