using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Items;

namespace Chances
{
    class ChanceMoreMoney : ChanceBehavior
    {
        public ChanceMoreMoney()
        {
            ChanceID = 0;
            Caption = "Bạn được thêm một lượt đi";
        }

        public override void Use(PlayerBehavior player)
        {
            ItemMoreDice moreDice = new ItemMoreDice();
            moreDice.Use(player);
        }
    }
}
