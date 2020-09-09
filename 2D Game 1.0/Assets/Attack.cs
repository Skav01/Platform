using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X));
        {
            Attacco();
        }
        
    }

    void Attacco()
    {
        anim.SetTrigger("Attack");
    }
}
