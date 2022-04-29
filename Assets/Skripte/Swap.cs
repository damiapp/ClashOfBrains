using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : AbstractCard {

    public double value = 1;

    public override void Apply (GameManager manager, Player player) {
        double tmp=manager.player1.Lifepoints;
        manager.player1.Lifepoints=manager.player2.Lifepoints;
        manager.player2.Lifepoints=tmp;
    }

    public void SetValue (double newValue) {
        value = newValue;

        Description = "";

        Operation="zamena";

    }
}
