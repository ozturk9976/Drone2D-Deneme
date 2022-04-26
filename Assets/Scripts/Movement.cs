using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerSpeed;                        //oyuncu hızını ayarlamak i�in
    private Rigidbody2D rb; 
    private Vector2 playerDirection;                    //inputları işlemek için kullanılacak

     
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");   //
        playerDirection = new Vector2(0, directionY).normalized;

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (0,playerDirection.y * playerSpeed);
    }
}
