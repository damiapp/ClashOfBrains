using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<AbstractCard> deck = new List<AbstractCard>();

    public int brojacRundi=1;
    public TMP_Text runda;
    public TMP_Text runda1;


    public Player player1;
    public Player player2;

    public DropZone dropZonePlayer1;
    public DropZone dropZonePlayer2;

    public DropZone dropZonePlayer11;

    public DropZone dropZonePlayer22;

    public GameObject player1Area;
    public GameObject player2Area;

    public GameObject cardPrefab;

    private int winner;
    private bool turnToken=true;

    private void Start () {
        
        SetRound();
        player1 = new Player("Njutn", player1Area);
        player2 = new Player("Lajbnic", player2Area);

        player1.Lifepoints=20;
        player2.Lifepoints=15;
        
        
        dropZonePlayer1.BelongingToPlayer = player1;
        dropZonePlayer2.BelongingToPlayer = player2;
        dropZonePlayer11.BelongingToPlayer = player1;    
        dropZonePlayer22.BelongingToPlayer = player2;

        
        
        //deck izgradnja -------------------------------------
         for (int i = 0; i < 5; i++)
        {
            Swap card = new Swap();
            card.SetValue(1);
            deck.Add(card);
        }
        // jedna specijalna osigurana za igraca sa 15 poena
        AbstractCard randCard = deck[Random.Range(0, deck.Count)];
        player2.AddCard(randCard, cardPrefab);
        deck.Remove(randCard);

        for(int i=0;i<25;i++){
            AdditionCard card=new AdditionCard();
            card.SetValue(Random.Range(15, 60));
            deck.Add(card);
        }
        for(int i=0;i<25;i++){
            SubsractionCard card=new SubsractionCard();
            card.SetValue(Random.Range(15, 60));
            deck.Add(card);
        }

        for (int i = 0; i < 15; i++)
        {
            MnozenjeCard card = new MnozenjeCard();
            card.SetValue(Random.Range(2, 15));
            deck.Add(card);
        }

        for (int i = 0; i < 15; i++)
        {
            DeljenjeCrad card = new DeljenjeCrad();
            card.SetValue(Random.Range(2, 15));
            deck.Add(card);
        }

        for (int i = 0; i < 5; i++)
        {
            SquareRootCard card = new SquareRootCard();
            card.SetValue(1);
            deck.Add(card);
        }

        for (int i = 0; i < 3; i++)
        {
            SinusCard card = new SinusCard ();
            card.SetValue(1);
            deck.Add(card);
        }

        for (int i = 0; i < 3; i++)
        {
            CosCard card = new CosCard();
            card.SetValue(1);
            deck.Add(card);
        }

        for (int i = 0; i < 5; i++)
        {
            AbsolutnaCard card = new AbsolutnaCard();
            card.SetValue(1);
            deck.Add(card);
        }

        for (int i = 0; i < 3; i++)
        {
            LogCard card = new LogCard();
            card.SetValue(1);
            deck.Add(card);
        }

        for (int i = 0; i < 3; i++)
        {
            ToThePowerOf2 card = new ToThePowerOf2();
            card.SetValue(1);
            deck.Add(card);
        }

        //izvalcenje karata --------------------------
        for (int i = 0; i < 4; i++) {
            DrawCard();
        }
        randCard = deck[Random.Range(0, deck.Count)];
        player1.AddCard(randCard, cardPrefab);
        deck.Remove(randCard);
        
        player2.DisableCardBoxCollider();               
        //---------------------------------------------
    
    }

    public void SetRound(){
        runda.text=$"Runda #{brojacRundi}";
        runda1.text=$"Runda #{brojacRundi}";
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

    public void RoundManager(){
        if(turnToken){
           player1.DisableCardBoxCollider();
           player2.ActiveCardBoxCollider();
           turnToken=false;
        }
        else{
            player1.ActiveCardBoxCollider();
            player2.DisableCardBoxCollider();
            brojacRundi+=1;
            DrawCard();
            turnToken=true;
        }
        SetRound();
    }

    private void Update()
    {
        if(brojacRundi==20){
            if(player1.Lifepoints>player2.Lifepoints){
                winner=1;
            }
            else if(player1.Lifepoints<player2.Lifepoints){
                winner=2;
            }
            else{
                winner=0;
            }
            PlayerPrefs.SetInt("winner", winner);
            SceneManager.LoadScene("PlayAgain");
        }
    }

}

