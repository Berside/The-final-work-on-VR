using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCart : MonoBehaviour
{
    private float currentSpeed = 0;    // 0-1 from no speed to full speed
    private float accel = 0.5f;        // accelerate to full speed in 2 seconds (1 / accel)
    private float speed = 1;        // accelerate to full speed in 2 seconds (1 / accel)
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            rb.AddForce(new Vector3(-50, 0, 200));
            //if (transform.position != new Vector3(0, 0, -12))
            //{
            //    currentSpeed += Mathf.Min(accel * Time.deltaTime, 1);    // limit to 1 for "full speed"
            //    Vector3 pos = Vector3.MoveTowards(transform.position, new Vector3(0, 0, -12), speed * currentSpeed * Time.deltaTime);
            //    GetComponent<Rigidbody>().MovePosition(pos);
            //}
        }

        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    Debug.Log(gameObject);
        //    gameObject.GetComponent<Rigidbody>().MovePosition(new Vector3(0, 0, -12));
        //}
    }
}
