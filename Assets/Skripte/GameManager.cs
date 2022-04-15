using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<AbstractCard> deck = new List<AbstractCard>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots;
    public TMP_Text deckSizeText;

    public Player player1;
    public Player player2;

    public DropZone dropZonePlayer1;
    public DropZone dropZonePlayer2;

    private void Start () {
        player1 = new Player("Njutn");
        player2 = new Player("Lajbnic");

        dropZonePlayer1.BelongingToPlayer = player1;
        dropZonePlayer2.BelongingToPlayer = player2;
    }

    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            AbstractCard randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(randCard);
                    return;
                }
            }
        }
    }

    private void Update()
    {
        deckSizeText.text = $"Remaining cards: {deck.Count}";
    }

}




// public GameObject karta;
//public int brojTrenutni1;
//public int brojTrenutni2;
// Start is called before the first frame update




//brojTrenutni1=20;
//brojTrenutni1=20;
// for(int i=0;i<5;i++)
//Instantiate(karta,new Vector3(-4+i,-5,0),Quaternion.identity);