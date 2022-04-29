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

    public DropZone dropZonePlayer11;

    public DropZone dropZonePlayer22;

    public GameObject player1Area;
    public GameObject player2Area;

    public GameObject cardPrefab;

    private void Start () {
        player1 = new Player("Njutn", player1Area);
        player2 = new Player("Lajbnic", player2Area);

        dropZonePlayer1.BelongingToPlayer = player1;
        dropZonePlayer2.BelongingToPlayer = player2;
        dropZonePlayer11.BelongingToPlayer = player1;    
        dropZonePlayer22.BelongingToPlayer = player2;

        for(int i=0;i<50;i++){
            AdditionCard card=new AdditionCard();
            card.SetValue(Random.Range(1, 22));
            deck.Add(card);
        }
        for(int i=0;i<50;i++){
            SubsractionCard card=new SubsractionCard();
            card.SetValue(Random.Range(1, 22));
            deck.Add(card);
        }

        for (int i = 0; i < 50; i++)
        {
            MnozenjeCard card = new MnozenjeCard();
            card.SetValue(Random.Range(1, 22));
            deck.Add(card);
        }

        for (int i = 0; i < 50; i++)
        {
            DeljenjeCrad card = new DeljenjeCrad();
            card.SetValue(Random.Range(1, 22));
            deck.Add(card);
        }

        for (int i = 0; i < 50; i++)
        {
            SquareRootCard card = new SquareRootCard();
            card.SetValue(1);
            deck.Add(card);
        }

        for (int i = 0; i < 5; i++) {
            DrawCard();
        }
    }

    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            AbstractCard randCard = deck[Random.Range(0, deck.Count)];
            player1.AddCard(randCard, cardPrefab);
            deck.Remove(randCard);

            randCard = deck[Random.Range(0, deck.Count)];
            player2.AddCard(randCard, cardPrefab);
            deck.Remove(randCard);
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