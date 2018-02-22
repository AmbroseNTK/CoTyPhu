using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class PlayerManager : MonoBehaviour {

    private List<GameObject> listPlayer;
    private List<PlayerBehavior> listPlayerBehavior;
    public int currentPlayer;
    public Image panelTurn;
    public Text textPlayerName;

    public Dice dice1;
    public Dice dice2;

    private bool isGoing;
    private int diceValue;
    private int previousPos;
    private Vector3 target;
    public float epsilon;
    public float moveSpeed;
    private bool moveEnding;

    public Camera mainCamera;
    public List<Camera> listPlayerCamera;

	// Use this for initialization
	void Start () {
        foreach(Camera camera in listPlayerCamera)
        {
            camera.enabled = false;
        }
        currentPlayer = 0;
        isGoing = false;
        diceValue = 0;
        listPlayer = new List<GameObject>();
        listPlayer.Add(GameObject.Find("Player1"));
        listPlayer.Add(GameObject.Find("Player2"));
        listPlayer.Add(GameObject.Find("Player3"));
        listPlayer.Add(GameObject.Find("Player4"));

        listPlayerBehavior = new List<PlayerBehavior>();
        listPlayerBehavior.Add(listPlayer[0].GetComponent<PlayerBehavior>());
        listPlayerBehavior.Add(listPlayer[1].GetComponent<PlayerBehavior>());
        listPlayerBehavior.Add(listPlayer[2].GetComponent<PlayerBehavior>());
        listPlayerBehavior.Add(listPlayer[3].GetComponent<PlayerBehavior>());
        StartCoroutine(PlayTurn());
	}

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 deltaPos = listPlayer[currentPlayer].transform.position - target;
            Debug.Log(deltaPos);
            if (Mathf.Abs(deltaPos.x) > epsilon || Mathf.Abs(deltaPos.z) > epsilon)
            {
                listPlayer[currentPlayer].transform.position = Vector3.MoveTowards(listPlayer[currentPlayer].transform.position, target, moveSpeed * Time.deltaTime);
            }
            else if (Mathf.Abs(deltaPos.x) < epsilon && Mathf.Abs(deltaPos.z) < epsilon)
            {
                listPlayer[currentPlayer].transform.position = target;
                moveEnding = true;
                if (diceValue > 0)
                {
                    diceValue--;
                    listPlayerBehavior[currentPlayer].pos++;
                    if (listPlayerBehavior[currentPlayer].pos > 40)
                        listPlayerBehavior[currentPlayer].pos = 0;
                    if (listPlayerBehavior[currentPlayer].pos == 10 || listPlayerBehavior[currentPlayer].pos == 20 || listPlayerBehavior[currentPlayer].pos == 31 || listPlayerBehavior[currentPlayer].pos == 0)
                    {
                        listPlayer[currentPlayer].transform.Rotate(new Vector3(0, 1, 0), 90);
                    }
                    target = GameObject.Find("p" + listPlayerBehavior[currentPlayer].pos.ToString()).transform.position;

                }
                else
                {
                    listPlayerCamera[currentPlayer].enabled = false;
                    mainCamera.enabled = true;
                    mainCamera.transform.position = listPlayerCamera[currentPlayer].transform.position;
                    mainCamera.transform.rotation = listPlayerCamera[currentPlayer].transform.rotation;
                    

                }

            }
        }
        if (dice1.finish && dice2.finish)
        {
            Go();
            dice1.finish = dice2.finish = false;
            
        }
    }

    public void ChangeTurn()
    {
        if (currentPlayer == 3)
        {
            currentPlayer = 0;
            return;
        }
        currentPlayer++;
    }
    IEnumerator PlayTurn()
    {
        yield return new WaitForSeconds(1.5f);
        bool played = false;
        while (!played)
        {
            if (listPlayerBehavior[currentPlayer].playable)
            {
                panelTurn.GetComponent<Animator>().SetBool("isShow", true);
                textPlayerName.text = "Người chơi " + (listPlayerBehavior[currentPlayer].playerID + 1).ToString();
                played = true;
                yield return new WaitForSeconds(1);
            }
            else
            {
                ChangeTurn();
            }
        }
        yield break;
    }
    public void Go()
    {
        mainCamera.enabled = false;
        
        listPlayerCamera[currentPlayer].enabled = true;
        diceValue = dice1.randValue + dice2.randValue;
        target = listPlayer[currentPlayer].transform.position;
    }
}
