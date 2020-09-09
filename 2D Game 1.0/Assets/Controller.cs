using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D))]
public class Controller : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    Rigidbody2D body;
    public Animator anim;
    bool isJumping = false;

    public Transform attackpoint;
    public float attackRange;
    public LayerMask enemyLayers;

    public int attackDamge;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        Movement();
       // Jumping();

        //if(Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    Attacco();
        //}

     
    }

    
    void Movement()
    {
        float h = Input.GetAxis("Horizontal"); //  (variabile movimento orizzontale)
        Vector2 velocity = new Vector2(Vector2.right.x * moveSpeed * h, body.velocity.y);

        body.velocity = velocity;

        if (h == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (h > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }


    }
    //void Jumping()
    //{
    //    if(isJumping)
    //    {
    //        if(body.velocity.y == 0)
    //        {
    //            isJumping = false;
                
    //            // anim.SetBool("isJumping", false);

    //        }
    //    }
    //    else
    //    {
    //        if(Input.GetAxis("Jump")>0)
    //        {
    //            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                
    //            // anim.SetBool("isJumping",true);
    //            isJumping = true;
    //        }
    //    }
    //}

    //void Attacco()
    //{
    //    // animazione + azione
    //    anim.SetTrigger("Attack");
        
    //    // collider 
    //    Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position, attackRange, enemyLayers);
        
    //    //danneggia newmico 
    //    foreach(Collider2D enemy in hitEnemies )
    //    {
    //        // Debug.Log("We Hit" + enemy.name);
    //        enemy.GetComponent<Enemy>().TakeDamage(attackDamge);
    //    }


    //}

    //void OnDrawGizmosSelected()
    //{
    //    if (attackpoint == null)
    //        return;

    //    Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    //}

}
