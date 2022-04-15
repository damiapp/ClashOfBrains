using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class AbstractCard : MonoBehaviour, ICard {

    public string Name { get; set; }
    public string Description { get; set; }

    public abstract void Apply(GameManager manager, Player player);
}
