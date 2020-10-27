using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraCombustivel : MonoBehaviour
{
    public Image combustivelImage;
    public float combustivelMaximo = 60.0f;
    public float combustivelAtual;
    public GameObject GameOver;
    public GameObject rocket;
    public GameObject Inicio;

    void Start(){
        combustivelAtual = combustivelMaximo;
    }
    void Update()
    {
        if(combustivelAtual >= combustivelMaximo){
            combustivelAtual = combustivelMaximo;
        }
        if(combustivelMaximo > 0.0f){
            combustivelAtual -=Time.deltaTime;
            combustivelImage.rectTransform.sizeDelta = new Vector2(combustivelAtual / combustivelMaximo * 104, 7);
        }
        if(combustivelAtual < 0.0f){
            combustivelMaximo = combustivelAtual;
            GameOver.SetActive(true);
            Time.timeScale = 0;
            Destroy(rocket);   
            }
            Inicio.SetActive(true);
        if(Inicio){
            Inicio.SetActive(true); 
        }
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
    }
    public void RestartPangeia(){
        SceneManager.LoadScene("Pangeia");
    }
    public void RestartLua(){
        SceneManager.LoadScene("PousoNaLua");
    }
}
