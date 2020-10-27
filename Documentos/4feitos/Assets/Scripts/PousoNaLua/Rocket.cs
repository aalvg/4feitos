using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
Rigidbody2D rocket;
public float speed;
public Animator rocketMove;
float horizontal;
bool isGrounded; //collide de dano
Transform position;
public int vida = 5;
float suavidade = 9.0f; //inclinacao
float angulo = 80.0f; //angulo em que inclina
bool imortal;
public float tempoImortal;
private Renderer mainRenderer;
public GameObject GameOver;
public GameObject Inicio;
//barra de vida
public Image barraVida;
public float vidaMaxima = 5.0f;
public float vidaAtual;



    void Start(){
        rocket = GetComponent<Rigidbody2D>();
        rocketMove = GetComponent<Animator>();
        isGrounded = GetComponent<BoxCollider2D>();
        mainRenderer = GetComponent<SpriteRenderer>();
        vidaAtual = vidaMaxima;
        Time.timeScale = 1;
       
    }    

    void Update() {
        if(vidaAtual >= vidaMaxima){
            vidaAtual = vidaMaxima;
        }
            barraVida.rectTransform.sizeDelta = new Vector2(vidaAtual / vidaMaxima * 104, 7);
    }

    void FixedUpdate(){
        horizontal = Input.GetAxisRaw("Horizontal");
        Movimentar(horizontal);
    }

    private void Movimentar(float horizontal){
        rocket.velocity = new Vector2(horizontal*speed, 0f);
        rocketMove.SetFloat("animaH", Mathf.Abs(horizontal));
        if(horizontal == speed ){
            rocket.GetComponent<Rigidbody2D>().gravityScale = 10f;
        }
        else{
            rocket.GetComponent<Rigidbody2D>().gravityScale = 2f;
        }

        float tiltAroundZ = Input.GetAxis("Horizontal") * angulo; //inclinacao
        float tiltAroundX = Input.GetAxis("Vertical") * angulo; //inclinacao

        // rotacao dos eixos
        Quaternion target = Quaternion.Euler(0, 0, -tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * suavidade);
    }

    void OnCollisionEnter2D(Collision2D colisor){
        if (!imortal){
        if(colisor.gameObject.CompareTag("isGrounded")){
            vida--;
        if(vida >= 5 && vidaAtual >= vidaMaxima){
            StartCoroutine(PiscarDano());
            imortal = true;
            Invoke("ResetImortal", tempoImortal);
            rocketMove.SetLayerWeight(1, 0);
            rocketMove.SetTrigger("Dano");
        }
        if(vida == 4){
            vidaAtual = 4;
            StartCoroutine(PiscarDano());
            imortal = true;
            Invoke("ResetImortal", tempoImortal);
            rocketMove.SetLayerWeight(1, 0);
            rocketMove.SetTrigger("Dano");
        }
        if(vida == 3){
            vidaAtual = 3;
            StartCoroutine(PiscarDano());
            imortal = true;
            Invoke("ResetImortal", tempoImortal);
            rocketMove.SetLayerWeight(1, 1);
            rocketMove.SetTrigger("Dano");
        }
        if(vida == 2){
            vidaAtual = 2;
            StartCoroutine(PiscarDano());
            imortal = true;
            Invoke("ResetImortal", tempoImortal);
            rocketMove.SetLayerWeight(1, 1);
            rocketMove.SetTrigger("Dano");
        }
        if(vida == 1){
            vidaAtual = 1;
            StartCoroutine(PiscarDano());
            imortal = true;
            Invoke("ResetImortal", tempoImortal);
            rocketMove.SetLayerWeight(1, 1);
            rocketMove.SetTrigger("Dano");
        }
        if(vida <= 0){
            vidaAtual = 0.1f;
            rocketMove.SetLayerWeight(1, 0);
            rocketMove.SetTrigger("Morrer");
            gameObject.GetComponent<Animator>().enabled = false;
            mainRenderer.enabled = false;
            GameOver.SetActive(true);
            if(GameOver){
            GameOver.SetActive(true);
            }
        }
            Inicio.SetActive(true);
            
        if(Inicio){
            Inicio.SetActive(true); 
            }
        }
    }
}
    public void SetLayerDano(){
            rocketMove.SetLayerWeight(1, 0);
    }
    IEnumerator PiscarDano(){
        for (int i = 0; i < tempoImortal; i++){
            mainRenderer.enabled = true;
        yield return new WaitForSeconds(0.1f);
            mainRenderer.enabled = false;
        yield return new WaitForSeconds(0.1f);
    }
            mainRenderer.enabled = true;
    }
    void ResetImortal(){
    imortal = false;
  }
    public void Menu(){
    SceneManager.LoadScene("Menu");
    }
}

