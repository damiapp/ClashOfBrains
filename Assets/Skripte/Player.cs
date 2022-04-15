using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string PlayerName { get; }
    public int Lifepoints { get; set; } = 0;
    private List<AbstractCard> cards = new List<AbstractCard>();

    public Player (string name) {
        PlayerName = name;
    }
}
