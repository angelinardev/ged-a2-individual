using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayScore : MonoBehaviour
{
    public Sprite[] texs;

    public GameObject display;
    
    int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = GameObject.FindGameObjectWithTag("Block").GetComponent<HitBlock>().GetScore();

        display.GetComponent<Image>().sprite = texs[score];
    }
}
