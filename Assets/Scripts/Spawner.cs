using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    
    CountdownTimer geriSayimSayaci;
    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<CountdownTimer>();
        geriSayimSayaci.ToplamSure = 1;
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            //Spawn game object
            SpawnEnemy();
            geriSayimSayaci.Calistir();

        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab);
    }
}
