using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerLixo : MonoBehaviour
{
    public GameObject lixos1;
    public GameObject lixos2;
    public GameObject lixos3;
    public GameObject lixos4;
    public GameObject lixos5;
    public GameObject lixos6;
    public GameObject lixos7;
    public GameObject lixos8;
    public float spawnTimer;
    float maxSpawnTimer;
    void Start()
    {
        Spawner();
        maxSpawnTimer = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <=0)
        {
            Spawner();
            spawnTimer = maxSpawnTimer;
        }
    }
    void Spawner(){
        int randomNumber = Random.Range(0,8);
        switch (randomNumber){
            case 0: 
            {
                Instantiate(lixos1,
                 new Vector3(Random.Range(-9,9),
                 Random.Range(5,5),0),lixos1.transform.rotation);
            } break;

            case 1:
            {
                Instantiate(lixos2,
                 new Vector3(Random.Range(-9,9),
                 Random.Range(5,5),0),lixos2.transform.rotation);
            } break;

             case 2: 
            {
                Instantiate(lixos3,
                  new Vector3(Random.Range(-9,9),
                 Random.Range(5,5),0),lixos3.transform.rotation);
            } break;

            case 3:
            {
                Instantiate(lixos4,
                  new Vector3(Random.Range(-9,9),
                 Random.Range(5,5),0),lixos4.transform.rotation);
            } break;

            case 4: 
            {
                Instantiate(lixos5,
                 new Vector3(Random.Range(-9,9),
                 Random.Range(5,5),0),lixos5.transform.rotation);
            } break;

            case 5:
            {
                Instantiate(lixos6,
                 new Vector3(Random.Range(-9,9),
                 Random.Range(5,5),0),lixos6.transform.rotation);
            } break;

             case 6: 
            {
                Instantiate(lixos7,
                  new Vector3(Random.Range(-9,9),
                 Random.Range(5,5),0),lixos7.transform.rotation);
            } break;

            case 7:
            {
                Instantiate(lixos8,
                  new Vector3(Random.Range(-9,9),
                 Random.Range(5,5),0),lixos4.transform.rotation);
            } break;
        }
    }
}
