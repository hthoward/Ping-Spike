using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDown : MonoBehaviour
{
    public float timer = 10;

    public GameObject p1;
    public playerController pc1;

    public GameObject p2;
    public playerController pc2;

    public GameObject numb1;
    public numbController nc1;

    public GameObject numb2;
    public numbController nc2;

    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.FindWithTag("PlayerOne");
        pc1 = p1.GetComponent<playerController>();

        p2 = GameObject.FindWithTag("PlayerTwo");
        pc2 = p2.GetComponent<playerController>();

        numb1 = GameObject.FindWithTag("NumberOne");
        nc1 = numb1.GetComponent<numbController>();
        nc1.num = 10;

        numb2 = GameObject.FindWithTag("NumberTwo");
        nc2 = numb2.GetComponent<numbController>(); 
        nc2.num = 10;       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0){
            timer -= Time.deltaTime;
            nc1.num -= Time.deltaTime;
            nc2.num -= Time.deltaTime;
        }
        else if (timer <= 0){
            pingSpike();
        }
    }

    public void pingSpike(){
        Debug.Log("PING SPIKE");
        timer += 10;
        nc1.num += 10;
        nc2.num += 10;
    }
}
