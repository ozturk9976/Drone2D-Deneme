using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Bomb1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bomb1,
            new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,0),
            new Quaternion(0,0,0,0));


        }
    }
    
}
