using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string PlayerName { get; }
    public float Lifepoints { get; set; } = 0;
    private List<AbstractCard> cards = new List<AbstractCard>();

    private GameObject PlayerZone;

    public Player (string name, GameObject playerZone) {
        PlayerName = name;
        PlayerZone = playerZone;
    }

    public void AddCard(AbstractCard card, GameObject cardPrefab) {
        cards.Add(card);

        GameObject cardObject = GameObject.Instantiate(cardPrefab, new Vector3(0, 286, 0), Quaternion.identity);
        cardObject.transform.SetParent(PlayerZone.transform, false);

        var playerCardView = cardObject.GetComponent<CardView>();
        playerCardView.SetCard(card);
    }
}
