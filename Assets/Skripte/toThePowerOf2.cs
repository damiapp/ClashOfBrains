using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToThePowerOf2 : AbstractCard
{

    public double value = 1;

    public override void Apply(GameManager manager, Player player)
    {
        player.Lifepoints = Math.Pow(player.Lifepoints, 2);
    }

    public void SetValue(double newValue)
    {
        value = newValue;

        Description = "x^2";

        Operation = "f";
    }
}