using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Items;

namespace Chances
{
    class ChanceGoToStartPoint:ChanceBehavior
    {
        public ChanceGoToStartPoint()
        {
            ChanceID = 3;
            Caption = "Bạn được quay về điểm xuất phát và nhận tiền trợ cấp";
        }

        public override void Use(PlayerBehavior player)
        {
            ItemGoToStartPoint goToStartPoint = new ItemGoToStartPoint();
            goToStartPoint.Use(player);
        }
    }
}
