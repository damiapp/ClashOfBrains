using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class SinusCard: AbstractCard
{

    public double value = 1;

    public override void Apply(GameManager manager, Player player)
    {
        player.Lifepoints = Math.Sin(player.Lifepoints);
    }

    public void SetValue(double newValue)
    {
        value = newValue;

        Description = "Sin x";

        Operation = "f";
    }
}
