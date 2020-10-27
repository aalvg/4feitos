using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObst : MonoBehaviour
{
    public GameObject obst;
    public float altura;
    public float maxTime;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObst = Instantiate(obst);
        newObst.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime){
        GameObject newObst = Instantiate(obst);
        newObst.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
        Destroy(newObst, 10f);
        timer = 0;
        }
        timer += Time.deltaTime;
    }
}
