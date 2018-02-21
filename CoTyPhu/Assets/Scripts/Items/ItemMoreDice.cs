using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Items
{
    class ItemMoreDice :Item, IItemAction
    {
        public ItemMoreDice()
        {
            ItemID = "moreDice";
            Quantity = 1;
        }
        public void Use(PlayerBehavior player)
        {
            
        }
    }
}
