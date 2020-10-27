using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girarTampa : MonoBehaviour
{
    bool Girar; //collide de dano
    public Animator Tampa;
    // Start is called before the first frame update
    void Start()
    {
        Girar = GetComponent<BoxCollider2D>();
        Tampa = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       void OnTriggerEnter2D (Collider2D col){
      if (col.gameObject.CompareTag ("Player")) {
         Tampa.SetLayerWeight(1, 1);
            Tampa.SetTrigger("Giro");
            
         }
        if (col.gameObject.CompareTag ("Player2")) {
         Tampa.SetLayerWeight(1, 1);
            Tampa.SetTrigger("Giro");
            
         }
                 if (col.gameObject.CompareTag ("Player3")) {
         Tampa.SetLayerWeight(1, 1);
            Tampa.SetTrigger("Giro");
            
         }
                          if (col.gameObject.CompareTag ("Player4")) {
         Tampa.SetLayerWeight(1, 1);
            Tampa.SetTrigger("Giro");
            
         }
        
      }

        public void SetLayerGiro(){
            Tampa.SetLayerWeight(1, 0);
    }
}
