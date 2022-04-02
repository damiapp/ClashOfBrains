using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject karta;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<5;i++)
            Instantiate(karta,new Vector3(-4+i,-5,0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
