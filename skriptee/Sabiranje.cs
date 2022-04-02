using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sabiranje : MonoBehaviour
{
public gameObject[] cardsInBox;
     
     float boxTotal = 0;
     for (int i = 0 ; i < cardsInBox[].Length ; i++)
     {
             boxTotal += cardsInBox[i].cardNumber about;
     }
     return boxTotal;
 }

 public int cardNumber=1;
 
 public int suitTexture=0; 

 void Randomizer()
 {
     if (Input.GetKeyDown(KeyCode.Space))
     {
     cardNumber = (int)Random.Range(1,13);
     suitNumber = (int)Random.Range(0,4);
     }
 }
