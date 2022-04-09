using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Brojac : MonoBehaviour
{
    public GameObject DropZone1;
    
    public GameObject DropZone2;
    public TextMeshProUGUI Poeni1;
    
    public TextMeshProUGUI Poeni2;
    // Start is called before the first frame update
    void Start()
    {
        Poeni1.text="1: 0";
        Poeni2.text="2: 0";
    }

    // Update is called once per frame
    void Update()
    {        
        Sabiranje(DropZone1,Poeni1,1);
        Sabiranje(DropZone2,Poeni2,2);
    }

    void Sabiranje(GameObject DropZone, TextMeshProUGUI Poeni,int igrac){      
        int karte = DropZone.transform.childCount;

        int brojac=0;
        for (int i = 0; i < karte; i++){
            GameObject cardObject=DropZone.transform.GetChild(i).gameObject;
            GameObject textObject=cardObject.transform.GetChild(0).gameObject;
            brojac = brojac + int.Parse(textObject.GetComponent<TextMeshProUGUI>().text);
        }
        Poeni.text=igrac.ToString()+": "+brojac.ToString();
    }
}
