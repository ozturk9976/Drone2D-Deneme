using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Rocket;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }
    void update()
    {
        if (Input.GetKeyDown(KeyCode.AltGr))
        {
            ates();
            
        }
    }

    // Update is called once per frame
    void ates()
    {
        GameObject Rocket11 = Instantiate(Rocket,transform.position,transform.rotation);

        
    }
}
