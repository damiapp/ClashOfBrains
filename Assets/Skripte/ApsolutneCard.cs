using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsolutnaCard : AbstractCard
{

    public double value = 1;

    public override void Apply(GameManager manager, Player player)
    {
        player.Lifepoints = Math.Abs(player.Lifepoints);
    }

    public void SetValue(double newValue)
    {
        value = newValue;

        Description = "|x|";

        Operation = "f";
    }
}

