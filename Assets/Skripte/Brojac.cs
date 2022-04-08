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
        int karte1 = DropZone1.transform.childCount;
        int karte2 = DropZone2.transform.childCount;
        //for (int i = 0; i < karte1; ++i){
        // pa sad funkcija za sabranje ITD...   
        //}
        Poeni1.text="1: "+karte1.ToString();
        
        Poeni2.text="2: "+karte2.ToString();
    }
}
