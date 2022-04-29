using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class AbstractCard : ICard {

    public string Name { get; set; }//ime karte
    public string Description { get; set; }//sam opis karte
    public string Operation { get; set; }//njen tip karte

    public abstract void Apply(GameManager manager, Player player);
}
