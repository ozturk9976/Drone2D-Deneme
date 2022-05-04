using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokedici : MonoBehaviour
{
    CountdownTimer geriSayimSayaci;
    //ekli olduğu objeyi 1sn de yok edecek

    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<CountdownTimer>();
        geriSayimSayaci.ToplamSure = 1;
        geriSayimSayaci.Calistir();
    }

    
    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            Destroy(gameObject);
        }
    }
}
