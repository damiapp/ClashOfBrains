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

            GameObject playerCardObject = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 286, 0), Quaternion.identity);
            playerCardObject.transform.SetParent(PlayerArea.transform, false);

            var playerAdditionCard = playerCardObject.AddComponent<AdditionCard>();
            playerAdditionCard.SetValue(broj1);

            GameObject textObject=playerCardObject.transform.GetChild(0).gameObject;
            textObject.GetComponent<TextMeshProUGUI>().text = broj1.ToString();

            GameObject enemyCardObject = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 286, 0), Quaternion.identity);
            enemyCardObject.transform.SetParent(EnemyArea.transform, false);

            var enemyAdditionCard = enemyCardObject.AddComponent<AdditionCard>();
            enemyAdditionCard.SetValue(broj2);

            GameObject textObject1=enemyCardObject.transform.GetChild(0).gameObject;
            textObject1.GetComponent<TextMeshProUGUI>().text = broj2.ToString();
        }
    }
  
}
