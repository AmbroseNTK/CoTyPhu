using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chances
{
    class ChanceGetExtraIncome : ChanceBehavior
    {
        public ChanceGetExtraIncome()
        {
            ChanceID = 1;
            Caption = "Bạn được nhận tiền lãnh lương 500 triệu VND";
        }
        public override void Use(PlayerBehavior player)
        {
            player.Budget += 0.5d;
        }
    }
}
