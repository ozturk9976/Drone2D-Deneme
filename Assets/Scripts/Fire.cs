using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Mermi;
    public float LaunchForce;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    void update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ates();
            
        }
    }

    // Update is called once per frame
    void ates()
    {
        GameObject Mermi1 = Instantiate(Mermi,transform.position,transform.rotation);
        Mermi1.GetComponent<Rigidbody2D>().velocity = transform.right * LaunchForce;
        
    }
}
