using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetConfig : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 3f;
    public KeyCode up;
    public KeyCode down;
    private bool upPressed;
    private bool downPressed;
    private float verticalInput;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyUp(up))
        {
            upPressed = true;
        }
        if (Input.GetKeyDown(down))
        {
            downPressed = true;
        }

        verticalInput = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity=new Vector2(0,verticalInput*10);
        float power = 60;
        if (upPressed)
        {
            rb.AddForce(Vector2.up * power, ForceMode2D.Force);
            upPressed= false;
        }
        if (downPressed)
        {
            rb.AddForce(Vector2.down * power, ForceMode2D.Force);
            downPressed = false;
        }

    }
}
