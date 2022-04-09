using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Karta> deck = new List<Karta>();
    public Transform[] cardSlots;
    public bool[] avaibleCardSlots;
    public Text deckSizeText;


    public void DrawCard()
    {

        if (deck.Count >= 1)
        {
            Karta randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < avaibleCardSlots.Length; i++)
            {
                if (avaibleCardSlots[i] == true)
                {
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




// public GameObject karta;
//public int brojTrenutni1;
//public int brojTrenutni2;
// Start is called before the first frame update




//brojTrenutni1=20;
//brojTrenutni1=20;
// for(int i=0;i<5;i++)
//Instantiate(karta,new Vector3(-4+i,-5,0),Quaternion.identity);