using UnityEngine;
using System.Collections;

public class  Score : MonoBehaviour
{
    static public int Score=0;
    public Texture2D Score0= new Texture2D (100,100);
    public Texture2D Score1= new Texture2D (100,100);


void update (){
switch (score)
{
    case 1:
    guiTexture.texture = score1;
    break;

    case 0;
    guiTexture.texture = score0;
    break;    


  }
 }    
}