using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xais = Input.GetAxisRaw("Horizontal");
        float Zaix = Input.GetAxisRaw("Vertical");

        if(Xais != 0 || Zaix != 0)
        {
            rb.velocity = new Vector3(Xais * speed,rb.velocity.y,Zaix * speed);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
    }
}
