using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class ChanceBehavior : IItemAction
{
    private int chanceID;
    private string caption;
    public ChanceBehavior()
    {
        ChanceID = 0;
        Caption = "";
    }

    protected ChanceBehavior(int chanceID, string caption)
    {
        this.chanceID = chanceID;
        this.caption = caption;
    }

    public int ChanceID
    {
        get
        {
            return chanceID;
        }

        set
        {
            chanceID = value;
        }
    }

    public string Caption
    {
        get
        {
            return caption;
        }

        set
        {
            caption = value;
        }
    }

    public void applyFor(PlayerBehavior player)
    {
        Use(player);
    }

    public abstract void Use(PlayerBehavior player);

}