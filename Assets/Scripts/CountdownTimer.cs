using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    float toplamSure = 0;
    float gecenSure = 0;

    bool calisiyor = false;
    bool basladi = false;

    /// geri sayım sayacının toplam süresini ayarlar
    public float ToplamSure
    {
        set
        {
            if (!calisiyor)
            {
                toplamSure = value;
            }
        }
    }
    // geri sayımın bitip bitmediğini söyler
    public bool Bitti
    {
        get
        {
            return basladi && !calisiyor; //değer döneceği için return kullanılır //değer ataması olmadığı içn de get kullanılır
        }
    }
    /// sayacı çalıştırır
    public void Calistir(){
        if (toplamSure > 0)
        {
            calisiyor = true;
            basladi = true;
            gecenSure = 0;
        }
    }

     
    void Update()
    {
        if(calisiyor)
        {
            gecenSure += Time.deltaTime; //deltatime çalışmadan itibaren geçen süre   
            if (gecenSure >= toplamSure)
            {
                calisiyor = false;
            } 
        }
    }
}
