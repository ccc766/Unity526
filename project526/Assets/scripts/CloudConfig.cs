using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudConfig : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb)
        {
            rb.velocity = Vector2.left*5;
        }
    }

}
