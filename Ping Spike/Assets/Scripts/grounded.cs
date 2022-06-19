using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{

    //FIND THE PLAYER
    GameObject player;
    public bool p1Grounded;

    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag == "grounded1"){
            p1Grounded = true;
            player = GameObject.FindWithTag("PlayerOne");
        }
        else if (this.gameObject.tag == "grounded2"){
            p1Grounded = false;
            player = GameObject.FindWithTag("PlayerTwo");
        }      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//CHECK IF THE PLAYER IS ON THE GROUND
    private void OnCollisionStay2D(Collision2D collision){
        if (collision.collider.tag == "ground"){
            player.GetComponent<playerController>().grounded = true;
            Debug.Log("ground");
        }
    }


//CHECK IF THE PLAYER LEAVES THE GROUND
    private void OnCollisionExit2D(Collision2D collision){
        if (collision.collider.tag == "ground"){
            player.GetComponent<playerController>().grounded = false;
        }
    }

}
