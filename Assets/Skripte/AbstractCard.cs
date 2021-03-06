using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class AbstractCard : ICard {

    public string Name { get; set; }
    public string Description { get; set; }
    public string Operation { get; set; }

    public abstract void Apply(GameManager manager, Player player);
}
