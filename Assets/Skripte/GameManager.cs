using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject karta;
    //public int brojTrenutni1;
    //public int brojTrenutni2;
    // Start is called before the first frame update

    void Start()
    {
        //brojTrenutni1=20;
        //brojTrenutni1=20;
        for(int i=0;i<5;i++)
            Instantiate(karta,new Vector3(-4+i,-5,0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
