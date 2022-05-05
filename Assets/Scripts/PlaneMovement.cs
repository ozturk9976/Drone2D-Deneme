using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//vektörel harekette impulse kullanılır
public class PlaneMovement : MonoBehaviour
{
   
    private Rigidbody2D rb;
    const float hareketGucu = 45;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
    


    }
    void FixedUpdate()
    {
        
        
        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //         Vector2 position = this.transform.position;
        //         position.x++;
        //         this.transform.position = position;
        // }
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //         Vector2 position = this.transform.position;
        //         position.y++;
        //         this.transform.position = position;
        // }
        // if (Input.GetKey(KeyCode.DownArrow))
        // {
        //         Vector2 position = this.transform.position;
        //         position.y--;
        //         this.transform.position = position;
            Vector3 position = transform.position; //şu anki konum

            float yatayInput = Input.GetAxis("Horizontal");
            float dikeyInput = Input.GetAxis("Vertical");


            if (yatayInput !=0)
            {
                position.x += yatayInput * hareketGucu * Time.deltaTime;
            }
            if (dikeyInput !=0)
            {
                position.y += dikeyInput * hareketGucu * Time.deltaTime;
            }
            transform.position = position;
                            
                            
        }
   
   
    }



