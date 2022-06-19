using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numbController : MonoBehaviour
{
    private Animator animator;
    public float num;
    public bool leftNumb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (this.gameObject.tag == "NumberOne"){
            leftNumb = true;
        }
        else if (this.gameObject.tag == "NumberTwo"){
            leftNumb = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (leftNumb == true){
            if (num <= 10 && num >= 9){
                animator.SetFloat("lNumb", 1);
            }
            else if (num <= 9 && num >= 0){
                animator.SetFloat("lNumb", 0);
            }
        }
        else if (leftNumb == false){
            if (num <= 10 && num >= 9){
                animator.SetFloat("rNumb", 10);
            }
            if (num <= 1 && num >=0){
                animator.SetFloat("rNumb", 1);
            }
            if (num <= 2 && num > 1){
                animator.SetFloat("rNumb", 2);
            }
            if (num <= 3 && num >= 2){
                animator.SetFloat("rNumb", 3);
            }
            if (num <= 4 && num >= 3){
                animator.SetFloat("rNumb", 4);
            }
            if (num <= 5 && num >= 4){
                animator.SetFloat("rNumb", 5);
            }
            if (num <= 6 && num >= 5){
                animator.SetFloat("rNumb", 6);
            }
            if (num <= 7 && num >= 6){
                animator.SetFloat("rNumb", 7);
            }
            if (num <= 8 && num >= 7){
                animator.SetFloat("rNumb", 8);
            }
            else if (num <= 9 && num >= 8){
                animator.SetFloat("rNumb", 9);
            }
        }
    }
}
