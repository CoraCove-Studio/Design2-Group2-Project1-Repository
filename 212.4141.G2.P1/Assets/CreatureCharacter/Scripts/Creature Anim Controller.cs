using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureAnimController : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)) 
        {
            anim.SetBool("Walking", true);
            anim.SetBool("idle", false);
            anim.SetBool("Run", false);
            anim.SetBool("Attack", false);
            anim.SetBool("Agony", false);
            anim.SetBool("Idle --> to walk or run", false);
            anim.SetBool("twerking", false);
        }
         
        if (Input.GetKeyDown(KeyCode.H))
        {
            anim.SetBool("Walking", false);
            anim.SetBool("idle", true);
            anim.SetBool("Run", false);
            anim.SetBool("Attack", false);
            anim.SetBool("Agony", false);
            anim.SetBool("Idle --> to walk or run", false);
            anim.SetBool("twerking", false);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            anim.SetBool("Walking", false);
            anim.SetBool("idle", false);
            anim.SetBool("Run", true);
            anim.SetBool("Attack", false);
            anim.SetBool("Agony", false);
            anim.SetBool("Idle --> to walk or run", false);
            anim.SetBool("twerking", false);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetBool("Walking", false);
            anim.SetBool("idle", false);
            anim.SetBool("Run", false);
            anim.SetBool("Attack", true);
            anim.SetBool("Agony", false);
            anim.SetBool("Idle --> to walk or run", false);
            anim.SetBool("twerking", false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetBool("Walking", false);
            anim.SetBool("idle", false);
            anim.SetBool("Run", false);
            anim.SetBool("Attack", false);
            anim.SetBool("Agony", true);
            anim.SetBool("Idle --> to walk or run", false);
            anim.SetBool("twerking", false);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            anim.SetBool("Walking", false);
            anim.SetBool("idle", false);
            anim.SetBool("Run", false);
            anim.SetBool("Attack", false);
            anim.SetBool("Agony", false);
            anim.SetBool("Idle --> to walk or run", true);
            anim.SetBool("twerking", false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("Walking", false);
            anim.SetBool("idle", false);
            anim.SetBool("Run", false);
            anim.SetBool("Attack", false);
            anim.SetBool("Agony", false);
            anim.SetBool("Idle --> to walk or run", false);
            anim.SetBool("twerking", true);
        }

       



    }
}
