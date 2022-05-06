using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCard : AbstractCard
{

    public double value = 1;

    public override void Apply(GameManager manager, Player player)
    {
        double tmp=Math.Log(player.Lifepoints);
        if(tmp==double.NaN)
            player.Lifepoints+=1000;
        else
            player.Lifepoints = tmp;
    }

    public void SetValue(double newValue)
    {
        value = newValue;

        Description = "log(x)";

        Operation = "f";
    }
}

