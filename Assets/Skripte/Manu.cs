using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("PojekatKarte closed");
    }
    public void StartPojekatKarte()
    {
        SceneManager.LoadScene("PojekatKarte");

    }

}
