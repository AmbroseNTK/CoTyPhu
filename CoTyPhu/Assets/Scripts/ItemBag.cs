using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ItemBag : List<Item>
{
    public ItemBag() : base()
    {

    }

    public void AddItem(string itemID, int addQuantity)
    {
        if (addQuantity > 0)
        {
            foreach (Item item in this)
            {
                if (item.ItemID == itemID)
                {
                    item.Quantity += addQuantity;
                }
            }
        }
    }

    public Item GetItem(string itemID)
    {
        foreach (Item item in this)
        {
            if (item.ItemID == itemID)
                return item;
        }
        return null;
    }

    public void UseItem(PlayerBehavior player, string itemID, int quantity)
    {
        foreach (Item item in this)
        {
            if (item.ItemID == itemID && item.Quantity >= quantity)
            {
                ((IItemAction)item).Use(player);
                item.Quantity -= quantity;

            }
        }
        for (int i = 0; i < Count; i++)
        {
            if (this[i].Quantity == 0)
            {
                RemoveAt(i);
            }
        }
    }
}
