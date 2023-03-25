using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI score;
    float time = 0;
    public GameObject gameOverScreen;

    void Start()
    {
    
    }

    [ContextMenu("Increase score")]
    void Update()
    {
        time += Time.deltaTime;
        playerScore = (int)(time * 3);
       
        score.text = playerScore.ToString() + "m";
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
