using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {

    public List<Sprite> dices;

    private Animator animator;

    Image imgDice;

    public Image panelDice;

    public int randValue;

	// Use this for initialization
	void Start () {
        randValue = 1;
        imgDice = GetComponent<Image>();
        animator = panelDice.GetComponent<Animator>();
        imgDice.sprite = dices[Random.Range(0, dices.Count - 1)];
	}
	
    public void Show()
    {
        animator.SetBool("isShow", true);
        StartCoroutine(DoGetDice());
    }

    public void Hide()
    {
        animator.SetBool("isShow", false);
        GameObject.Find("PanelPlace").GetComponent<PlaceManager>().Show();
    }

    

    private IEnumerator DoGetDice()
    {
        yield return new WaitForSeconds(2);
        int randSeed = Random.Range(10, 20);
        int value = 0;
        float diceSpeed = 0.1f;
        for(int i = 0; i < randSeed; i++)
        {
            value = Random.Range(0, dices.Count - 1);
            imgDice.sprite = dices[value];
            yield return new WaitForSeconds(diceSpeed);
            diceSpeed += 0.01f;
        }
        randValue = value + 1;
        yield return new WaitForSeconds(4);
        Hide();
        yield break;
    }

	// Update is called once per frame
	void Update () {
		
	}
    
}
