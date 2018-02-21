using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Chances;
using Items;

public class ChanceCard : MonoBehaviour {

    private List<ChanceBehavior> chanceList;
    private Animator animator;
    public Text chanceText;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        chanceList = new List<ChanceBehavior>();
        chanceList.Add(new ChanceGetExtraIncome());
        chanceList.Add(new ChanceGoToFreeParking());
        chanceList.Add(new ChanceGoToStartPoint());
        chanceList.Add(new ChanceMoreMoney());
        animator.SetBool("isShow", false);
        ChanceBehavior chance = chanceList[Random.Range(0, chanceList.Count)];
        chanceText.text = chance.Caption;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
