using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

class PlayerBehavior : MonoBehaviour
{
    public int playerID;
    public double budget;
    private ItemBag bag;
    public int pos = 0;
    public bool playable;

    public void Start()
    {
        bag = new ItemBag();
       
    }



    public double Budget
    {
        get
        {
            return budget;
        }

        set
        {
            budget = value;
        }
    }

    public ItemBag Bag
    {
        get
        {
            return bag;
        }
    }
}