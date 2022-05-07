using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UvelicajKartu : MonoBehaviour
{
    public GameObject card;
    private float x,y;
    private int d;
    public void UvelicajMe(){
        d=card.transform.GetSiblingIndex();
        Vector3 objectScale = card.transform.localScale;
        x=objectScale.x;
        y=objectScale.y;
        transform.localScale = new Vector3(objectScale.x*1.5F,  objectScale.y*1.5F, objectScale.z);
        card.transform.SetAsLastSibling();
    }
    public void SmanjiMe(){
        Vector3 objectScale = card.transform.localScale;
        transform.localScale = new Vector3(x,  y, objectScale.z);
        card.transform.SetSiblingIndex(d);
    }
}
