using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class PoljeKarte : MonoBehaviour
{
    public List<Karta> deck = new List<Karta>();
    public Transform[] cardSlots;
    public bool[] avaibleCardSlots;

    public Text deckSizeText;


    public void DrawCard(){

        if(deck.Count >=1){
            Karta randCard = deck[Random.Range(0, deck.Count)];

            for(int i =0; i < avaibleCardSlots.Length; i++)
           {
                if(avaibleCardSlots[i] == true){
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    avaibleCardSlots[i] = false;
                    deck.Remove(randCard);
                return;
                }
            } 
        }
    }

    private void Update()
    {
        deckSizeText.text = deck.Count.ToString();
    }

}