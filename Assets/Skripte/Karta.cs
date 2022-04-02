using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Karta : MonoBehaviour
{
    public string ime;
    public string deskripcija;


    public Karta()
    {

    } 
    
    public Karta(string Ime , string Deskripcija)
    {
        this.ime=Ime;
        this.deskripcija=Deskripcija;
    }


}
