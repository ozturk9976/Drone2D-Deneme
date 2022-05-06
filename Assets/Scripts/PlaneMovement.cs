using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//vektörel harekette impulse kullanılır
public class PlaneMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float RotationControl;
    public float maxSpeed;
    public float Speed;
    public float Acceleration;

    public float hareketGucu = 100;

    float MovY,
        MovX = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovY = Input.GetAxis("Vertical");
        MovX = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // Vector2 Vel = transform.right * (MovX * Acceleration);
        // rb.AddForce(Vel);

        // float Dir = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.right));

        // if (Acceleration >0)
        // {

        //     rb.rotation -= MovY * RotationControl *(rb.velocity.magnitude / Speed);

        // }
        // else
        // {
        //     rb.rotation += MovY * RotationControl *(rb.velocity.magnitude / Speed);
        // }
        // float thrustForce = Vector2.Dot(rb.velocity,rb.GetRelativeVector(Vector2.down)* 2.0f);

        // Vector2 relForce = Vector2.up * thrustForce;
        // rb.AddForce(rb.GetRelativeVector(relForce));

        // if (rb.velocity.magnitude> Speed)
        // {
        //     rb.velocity = rb.velocity.normalized *Speed;
        // }

        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //      Vector2 position = this.transform.position;
        //      position.x++;
        //      this.transform.position = position;
        // }
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //      Vector2 position = this.transform.position;
        //     position.y++;
        //      this.transform.position = position;
        //     }
        //     if (Input.GetKey(KeyCode.DownArrow))
        //     {
        //      Vector2 position = this.transform.position;
        //      position.y--;
        //      this.transform.position = position;
        Vector3 position = transform.position; //şu anki konum

        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical");

        if (yatayInput != 0)
        {
            position.x += yatayInput * 2 * hareketGucu * Time.deltaTime;
        }
        if (dikeyInput != 0)
        {
            position.y += dikeyInput * hareketGucu * Time.deltaTime;
        }
        transform.position = position;
    }
}
