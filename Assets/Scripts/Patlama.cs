using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patlama : MonoBehaviour
{
    [SerializeField]GameObject patlamaPrefab;

    CountdownTimer yokediciGeriSayim;
    // Start is called before the first frame update
    void Start()
    {
        yokediciGeriSayim = gameObject.AddComponent<CountdownTimer>();
        yokediciGeriSayim.ToplamSure = Random.Range(1,20);
        yokediciGeriSayim.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (yokediciGeriSayim.Bitti)
        {
            Instantiate(patlamaPrefab,gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
