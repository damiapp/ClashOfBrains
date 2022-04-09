using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrawCard : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject EnemyArea;
   
    List<GameObject> cards = new List<GameObject>();
    
    void Start()
    {
        cards.Add(Card1);
        cards.Add(Card2);
    }
     
    public void OnClick()
    {
        for (var i = 0; i < 5; i++)
        {
            int broj1 = Random.Range(1, 22);
            int broj2 = Random.Range(1, 22);

            GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 286, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform, false);

            GameObject textObject=playerCard.transform.GetChild(0).gameObject;
            textObject.GetComponent<TextMeshProUGUI>().text = broj1.ToString();

            GameObject enemyCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 286, 0), Quaternion.identity);
            enemyCard.transform.SetParent(EnemyArea.transform, false);
            
            GameObject textObject1=enemyCard.transform.GetChild(0).gameObject;
            textObject1.GetComponent<TextMeshProUGUI>().text = broj2.ToString();
        }
    }
  
}
