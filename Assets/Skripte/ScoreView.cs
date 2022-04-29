using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreView : MonoBehaviour
{
    public GameObject DropZone1;
    public GameObject DropZone2;

    public TextMeshProUGUI Poeni1;
    public TextMeshProUGUI Poeni2;
    
    public TextMeshProUGUI Poeni11;
    public TextMeshProUGUI Poeni22;

    [SerializeField]
    private GameManager gameManager;

    void Update()
    {        
        ShowScore(Poeni1, gameManager.player1);
        ShowScore(Poeni2, gameManager.player2);
        ShowScore(Poeni11, gameManager.player1);
        ShowScore(Poeni22, gameManager.player2);
    }

    void ShowScore(TextMeshProUGUI Poeni, Player player) {
        Poeni.text = player.PlayerName + ":" + player.Lifepoints;
    }
}
