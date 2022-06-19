using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;

    //controls sprite facing
    public bool lookRight;
    
    //the controller determines which player to control
    private bool player1;

    //bools to determine animations and limitations
    private bool dashing;
    public bool grounded;
    private bool spiking;
    private bool damaged;

    //math stuffs for speed
    public float connection = 3;
    public float moveSpeed;
    public float dashSpeed;
    public float jumpSpeed;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        if (this.gameObject.tag == "PlayerOne"){
            player1 = true;
        }
        else if (this.gameObject.tag == "PlayerTwo"){
            player1 = false;
            Flip();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //PLAYER ONE

        //PLAYER TWO
    }

    void FixedUpdate(){
        if (player1){

            if (Input.GetKey("d")){
                //move player left
                rb.AddForce(new Vector2(-9, 0), ForceMode2D.Force);
                animator.SetBool("Run", true);
                animator.SetBool("Idle", false);
                
                //double check if sprite is right way
                if (!lookRight){
                    Flip();
                }
            }
            else if (Input.GetKey("g")){
                //move player right
                rb.AddForce(new Vector2(9, 0), ForceMode2D.Force);
                animator.SetBool("Run", true);

                //double check if sprite is right way
                if (lookRight){
                    Flip();
                }
            }
            if (Input.GetKeyDown("r") && grounded == true){
                rb.AddForce(new Vector2(0, 11), ForceMode2D.Impulse);
                grounded = false;
                Debug.Log("jump");
            }
            if (Input.GetKey("f") && grounded == false){
                rb.AddForce(new Vector2(0, -5), ForceMode2D.Impulse);
                Debug.Log("spike");
            }
        }
        //else if (!player1){

        //}
    }

    void Flip(){
        Vector2 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        lookRight = !lookRight;
    }


    public void Hit(){
    }
}
