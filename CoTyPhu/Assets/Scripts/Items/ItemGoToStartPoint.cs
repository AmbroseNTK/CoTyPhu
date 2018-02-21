using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Items
{
    class ItemGoToStartPoint : Item, IItemAction
    {
        public ItemGoToStartPoint()
        {
            ItemID = "goToStartPoint";
            Quantity = 1;
        }
        public void Use(PlayerBehavior player)
        {
            
        }
    }
}
