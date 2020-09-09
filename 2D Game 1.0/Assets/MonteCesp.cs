using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonteCesp : MonoBehaviour
{
    float lastCamerax; // ultima poszione della camera
    float currentCamerax; // posizione attulae camera

    public float speed;
    Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("Main Camera").transform;
        // cam = Camera.main.transform;
        lastCamerax = cam.position.x;
        currentCamerax = lastCamerax;
    }

    // Update is called once per frame
    void Update()
    {
        currentCamerax = cam.position.x;
        float delta = currentCamerax - lastCamerax;
        if(Mathf.Abs(delta)>0)
        {
            Vector3 newPosition = new Vector3(transform.position.x - delta, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, newPosition, Time.deltaTime * speed);

            lastCamerax = currentCamerax;
        }
        
    }
}
