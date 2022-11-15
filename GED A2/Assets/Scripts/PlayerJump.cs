using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool canJump = false;

    public Material grounded;
    public Material areial;
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
            WinCondition.instance.UpdateScore(1);
            gameObject.GetComponent<MeshRenderer>().material = areial;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Ground")
        {
            canJump = true;
            gameObject.GetComponent<MeshRenderer>().material = grounded;
        }
    }
}
