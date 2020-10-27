using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Balao : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;
    public GameObject GameOver;
    public GameObject Inicio;
    public GameObject balao;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rig.velocity = Vector2.up * speed;
        }
    }
    void OnCollisionEnter2D(Collision2D colisor){

        GameOver.SetActive(true);
        Time.timeScale = 0;
        if(GameOver){
            GameOver.SetActive(true);
            balao.SetActive(false);
            balao.GetComponent<Animator>().enabled = false;
        }

        Inicio.SetActive(true);
        Time.timeScale = 0;
        if(Inicio){
            Inicio.SetActive(true);
            balao.SetActive(false);
            balao.GetComponent<Animator>().enabled = false;
        }


    }
    public void RestartBalao(){
        SceneManager.LoadScene("Balao");
    }

    public void RestartPangeia(){
        SceneManager.LoadScene("Pangeia");
    }

    public void RestartLixo(){
        SceneManager.LoadScene("DescarteResiduos");
    }

    public void RestartLua(){
        SceneManager.LoadScene("PousoNaLua");
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
    }
}

