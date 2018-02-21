using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Items;

namespace Chances
{
    class ChanceGoToFreeParking : ChanceBehavior
    {
        public ChanceGoToFreeParking()
        {
            ChanceID = 2;
            Caption = "Bạn được đến bãi đỗ xe miễn phí";
        }
        public override void Use(PlayerBehavior player)
        {
            ItemGoToFreeParking freeParking = new ItemGoToFreeParking();
            freeParking.Use(player);
        }
    }
}
