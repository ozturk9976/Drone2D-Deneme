using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]GameObject patlamaPrefab1;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject); //eğer Destroy(collision.gameObject) yazılırsa diğer obje yokedilir
            Instantiate(patlamaPrefab1,gameObject.transform.position,Quaternion.identity);
        }
    }
}
