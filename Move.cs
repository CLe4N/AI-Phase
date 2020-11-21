using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // access Rigidbody component
    }

    void Update()
    {
        float Xais = Input.GetAxisRaw("Horizontal"); // get axis input "Horizontal"
        float Zaix = Input.GetAxisRaw("Vertical"); // get axis input "Vertical"

        if(Xais != 0 || Zaix != 0) // if Xais is not 0 or Zaix is not 0
        {
            rb.velocity = new Vector3(Xais * speed,rb.velocity.y,Zaix * speed); // this gameobject velocity = axis input
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0); = velocity = 0
        }
    }
}
