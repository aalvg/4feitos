using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{

    public Text contagem;
    public float contador = 30.0f;
    public GameObject GameOver;
    public GameObject Inicio;

    void Update()
    {
        if(contador > 0.0f){
            contador -=Time.deltaTime;
            contagem.text = contador.ToString("F1");
        }
        else{
            contagem.text = "-";
            GameOver.SetActive(true);
            Time.timeScale = 0;

            Inicio.SetActive(true);
            Time.timeScale = 0;
        if(Inicio){
            Inicio.SetActive(true); 
        }
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
