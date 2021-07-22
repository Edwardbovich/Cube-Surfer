using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator anim;
   

    private void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    public void Jumpup()
    {
        anim.SetTrigger("Jumpup");
        
    }
    public void JumpDown()
    {
        anim.SetTrigger("Jump");
    }

    public void Stop()
    {
        anim.SetBool("Idle", true);
        
    }
    public void Stap()
    {
        anim.SetBool("Idle", true);
    }
}
