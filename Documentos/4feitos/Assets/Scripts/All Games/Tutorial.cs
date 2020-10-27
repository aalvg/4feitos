using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject cena;
    public GameObject Objeto1;
    public GameObject Objeto2;
    public GameObject Objeto3;
    
    void Start(){
        
    }
        public void Jogar(){

            cena.SetActive(false);
            Objeto1.SetActive(true);
            Objeto2.SetActive(true);
            Objeto3.SetActive(true);
        
    }
}
