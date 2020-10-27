using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ondeVai : MonoBehaviour {
    public float tempoDaMensagem = 60;
    public Text texto;
    private Collider[] Colisores;
    private Collider[] Colisorer;
    public GameObject rocket;
    public GameObject GameOver;
    public GameObject Inicio;
    bool pousei;

   void Start(){
      Colisores = transform.GetComponentsInChildren<Collider> ();
      texto.enabled = false;
      pousei = GetComponent<BoxCollider2D>();
   }

   void OnTriggerEnter2D (Collider2D col){
      if (col.gameObject.CompareTag ("Player")) {
         foreach (Collider coll in Colisores) {
            coll.enabled = false;
            
         }
         StartCoroutine ("MostrarMensagem");
      }


   }

   IEnumerator MostrarMensagem(){
    texto.enabled = true;
    
        Destroy(rocket);
    
    GameOver.SetActive(true);
    Inicio.SetActive(true);
    Time.timeScale = 0;
    yield return new WaitForSeconds (tempoDaMensagem);
    }

void OnCollisionEnter2D(Collision2D coliser){ //POUSO DO FOGUETE
      if (coliser.gameObject.CompareTag ("Player")) {
         GameOver.SetActive(true);
         Inicio.SetActive(true);
            Time.timeScale = 0;
         }
         StartCoroutine ("MostrarMensagem");
      }
   


    public void Menu(){
    SceneManager.LoadScene("Menu");
    }
}