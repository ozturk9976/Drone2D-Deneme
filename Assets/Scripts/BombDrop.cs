using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Bomb1;

    public Transform olusumNoktasi;

    public float LaunchForce;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dropBomb();
        }
    }

    void dropBomb()
    {
        GameObject Bomb = Instantiate(Bomb1, olusumNoktasi.transform.position, transform.rotation); //(Bomb1,transform.position /(1*1/2),transform.rotation);
        Bomb.GetComponent<Rigidbody2D>()
            .AddForce(transform.right * LaunchForce, ForceMode2D.Impulse);
        // Bomb.GetComponent<Rigidbody2D>().velocity = transform.right * LaunchForce;

    }
}
