using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliSystem : MonoBehaviour
{
    public float engineForce = 1000;
    public float rotationForce = 50;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * engineForce * Time.deltaTime);

            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back* rotationForce* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward* rotationForce* Time.deltaTime);
        }
        
        
    }
}
