using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public int health;
    public float speed;
    public GameObject bloodEffect;
    private float dazedTime;
    public float startDazedTime;
    public Animator anim;
    // private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
    }

    void Update()
    {
        if(dazedTime<=0)
        {
            speed = 5;
        }
        else
        {
            speed = 0;
            dazedTime = Time.deltaTime;
        }

        if (health<=0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);    
    }
    // Update is called once per frame
    public void TakeDamage (int damage)
    {
        dazedTime = startDazedTime;
        health -= damage;
        Debug.Log("damage Taken");

        
    }

 
}
