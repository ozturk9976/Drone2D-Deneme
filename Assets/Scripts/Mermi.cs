using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Mermi1;

    public Transform olusumNoktasi;

    public float LaunchForce = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {

        //     Instantiate(Bomb1,
        //     new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),
        //     new Quaternion(0,0,0,0));

        // }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            dropMermi();
        }
    }

    void dropMermi()
    {
        GameObject Mermi = Instantiate(
            Mermi1,
            olusumNoktasi.transform.position,
            transform.rotation
        );
        ;
        Mermi.GetComponent<Rigidbody2D>().velocity = Mermi.transform.right * LaunchForce;

        // Bomb.GetComponent<Rigidbody2D>().velocity = transform.right * LaunchForce;

    }
}
