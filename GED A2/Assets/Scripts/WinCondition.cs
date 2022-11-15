using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public static WinCondition instance;
    private int currentScore;
    [SerializeField]
    private GameObject winScreen;
    private void Start() {
        if(instance == null)
        {
            instance = this;
        }

        currentScore = 0;
        winScreen.SetActive(false);
    }
    // Update is called once per frame
    private void Update() {
        if(currentScore >= 10)
        {
            winScreen.SetActive(true);
            
        }
    }
    
    
    public void UpdateScore(int score)
    {
        currentScore += score;
    }




}
