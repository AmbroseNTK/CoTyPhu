using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Item
{
    private string itemID;
    private int quantity;

    public Item()
    {
        ItemID = "";
        Quantity = 0;
    }

    public Item(string itemID, int quantity)
    {
        this.ItemID = itemID;
        this.Quantity = quantity;
    }

    public string ItemID
    {
        get
        {
            return itemID;
        }

        set
        {
            itemID = value;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }

        set
        {
            quantity = value;
        }
    }
}

