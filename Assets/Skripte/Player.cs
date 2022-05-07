using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string PlayerName { get; }
    public double Lifepoints { get; set; } = 0;

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

    public void DisableCardBoxCollider(){
        for (int i = 0; i < PlayerZone.transform.childCount; i++)
        {
            GameObject child = PlayerZone.transform.GetChild(i).gameObject;
            child.GetComponent<Collider2D>().enabled = false;
        }
    }
    public void ActiveCardBoxCollider(){
        for (int i = 0; i < PlayerZone.transform.childCount; i++)
        {
            GameObject child = PlayerZone.transform.GetChild(i).gameObject;
            child.GetComponent<Collider2D>().enabled = true;
        }
    }
}
