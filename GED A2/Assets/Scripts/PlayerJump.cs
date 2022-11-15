using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool canJump = false;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }


    public void Jump()
    {
        if(canJump)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector2(0, 8);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
}
