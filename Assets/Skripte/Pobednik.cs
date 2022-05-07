using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pobednik : MonoBehaviour
{
    public GameObject Njutn;
    
    public GameObject Njutn1;
    
    public GameObject Lajbnic;
    
    public GameObject Lajbnic1;
    public int winner;
    
    void Start()
    {
        winner  =  PlayerPrefs.GetInt("winner");
        if(winner == 1){
            Njutn.SetActive(true);
            Njutn1.SetActive(true);
        }
        else if(winner == 2){
            Lajbnic.SetActive(true);
            Lajbnic1.SetActive(true);
        } 
        else if(winner == 0){
            Njutn.SetActive(true);
            Lajbnic.SetActive(true);
        }
    }

   
}
