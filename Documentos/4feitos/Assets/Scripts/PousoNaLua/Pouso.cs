using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pouso : MonoBehaviour {
    public float tempoDaMensagem = 60;
    public Text texto;
    private Collider[] Colisorer;
    public GameObject rocket;
    public GameObject GameOver;
    public GameObject Inicio;
    private Animator pousar;
    bool pousei;

   void Start(){
      Colisorer = transform.GetComponentsInChildren<Collider> ();
      texto.enabled = false;
      pousei = GetComponent<BoxCollider2D>();
      pousar = GetComponent<Animator>();

   }

   IEnumerator MostrarMensagem(){
    texto.enabled = true;
    Time.timeScale = 0;
    yield return new WaitForSeconds (tempoDaMensagem);
    }

void OnCollisionEnter2D(Collision2D coliser){ //POUSO DO FOGUETE
      if (coliser.gameObject.CompareTag ("Player")) {
         GameOver.SetActive(true);
         Time.timeScale = 0;
         Inicio.SetActive(true);
            Time.timeScale = 0;
         }
         StartCoroutine ("MostrarMensagem");
      }
   


    public void Menu(){
    SceneManager.LoadScene("Menu");
    }
}