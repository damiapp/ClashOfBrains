using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MnozenjeCard : AbstractCard
{

    public double value = 1;

    public override void Apply(GameManager manager, Player player)
    {
        player.Lifepoints *= value;
    }

    public void SetValue(double newValue)
    {
        value = newValue;

        Description = $"*{value}";
    
        Operation="*";
    }
}
