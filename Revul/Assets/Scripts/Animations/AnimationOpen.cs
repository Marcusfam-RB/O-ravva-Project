using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOpen : MonoBehaviour
{
    public Animator anim;

    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    public void OnTriggerStay(Collider other)
    {        
        if(Input.GetKeyDown(KeyCode.F))
            anim.SetBool("IsOpen", true);
        
    }
    
}
