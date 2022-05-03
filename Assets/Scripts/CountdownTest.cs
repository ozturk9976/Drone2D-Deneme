using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTest : MonoBehaviour
{
    CountdownTimer geriSayimSayaci;
    float baslangicZamani;
    // Start is called before the first frame update
    void Start()
    {
        // artık geri sayım test scriptinin bağlı olduğu oyun objesine countdown timer
        // dinamik olarak eklenecek
        geriSayimSayaci = gameObject.AddComponent<CountdownTimer>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();

        baslangicZamani = Time.time; // start metodunun çalıştığı andaki zaman istendiği için time kullanıldı
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            float gecenSure = Time.time - baslangicZamani;
            Debug.Log(gecenSure);

            baslangicZamani = Time.time;
            geriSayimSayaci.Calistir(); //sayac bittikten sonra tekrar çalışsın
        }
    }
}
