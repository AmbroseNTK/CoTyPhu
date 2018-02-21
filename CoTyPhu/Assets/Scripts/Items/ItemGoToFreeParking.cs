using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Items
{
    class ItemGoToFreeParking : Item, IItemAction
    {
        public ItemGoToFreeParking()
        {
            ItemID = "goToFreeParking";
            Quantity = 1;
        }
        public void Use(PlayerBehavior player)
        {
            
        }
    }
}
