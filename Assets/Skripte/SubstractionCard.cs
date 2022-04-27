using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubsractionCard : AbstractCard {

    public float value = 1;

    public override void Apply (GameManager manager, Player player) {
        player.Lifepoints -= value;
    }

    public void SetValue (int newValue) {
        value = newValue;
        
        Description = $"-{value}";
        
        Operation="+";
    }
}
