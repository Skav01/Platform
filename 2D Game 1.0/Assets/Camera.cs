using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    public float x_offset;
    
    public float y_offset;
    
    public float z_offset;

    public float smooth;

    Transform player;
    Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            Vector3 targetPosition = new Vector3(player.position.x* x_offset, player.position.y* y_offset, player.position.z * z_offset);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smooth);
        }
    }
}
