using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
   
    private Rigidbody2D rb;
    [SerializeField]private float moveSpeed = 100f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //  if (Input.GetButton("Jump"))
        //  {
        //     rb.AddForce(transform.right * moveSpeed * Time.deltaTime);
        //  }
        //  if (Input.GetButton("Fire1"))
        //  {
        //      rb.AddForce(transform.up * moveSpeed * Time.deltaTime);
        //  }
         
        

    }
    void FixedUpdate()
    {
        
        //    if (Input.GetKey(KeyCode.LeftArrow))
        //          {
        //                  Vector2 position = this.transform.position;
        //                  position.x--;
        //                  this.transform.position = position;
        //          }
        //          if (Input.GetKey(KeyCode.RightArrow))
        //          {
        //                  Vector2 position = this.transform.position;
        //                  position.x++;
        //                  this.transform.position = position;
        //          }
        //          if (Input.GetKey(KeyCode.UpArrow))
        //          {
        //                  Vector2 position = this.transform.position;
        //                  position.y++;
        //                  this.transform.position = position;
        //          }
        //          if (Input.GetKey(KeyCode.DownArrow))
        //          {
        //                  Vector2 position = this.transform.position;
        //                  position.y--;
        //                  this.transform.position = position;
        //          }
                //   if (Input.GetKey(KeyCode.LeftArrow))
                //   {
                //     Vector2 position = this.transform.position;
                //     position.x--;
                //     this.transform.position = position;
                //   }
                  if (Input.GetKey(KeyCode.RightArrow))
                  {
                         Vector2 position = this.transform.position;
                         position.x++;
                          this.transform.position = position;
                  }
                  if (Input.GetKey(KeyCode.UpArrow))
                  {
                          Vector2 position = this.transform.position;
                          position.y++;
                          this.transform.position = position;
                  }
                  if (Input.GetKey(KeyCode.DownArrow))
                  {
                          Vector2 position = this.transform.position;
                          position.y--;
                          this.transform.position = position;
        }
   
   
    }

}

