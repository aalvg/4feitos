using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
public int Score;
public Text scoreText;
[HideInInspector]
public string nomeDaCena;

    public void Start(){
        
            Score = 0;
            nomeDaCena = SceneManager.GetActiveScene().name;

    }
     public void OnTriggerEnter2D(Collider2D colisor){
        
            Score = Score + 10;
            scoreText.text = Score.ToString();

        
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
