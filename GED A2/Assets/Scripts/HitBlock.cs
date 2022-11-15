using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBlock : MonoBehaviour
{
    
    int score;

    public ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        score =0;
    }
    public int GetScore()
    {
        return score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        //collides with player
        if (other.collider.tag == "Player")
        {
            score +=1;
            particles.Play();
            
        }
    }    

}
