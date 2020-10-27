using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    GameController controller;


   void Start(){
        controller = FindObjectOfType<GameController>();
        Time.timeScale = 1;
        
    }

     public void OnTriggerEnter2D(Collider2D colisor){
        
             controller.Score = controller.Score + 10;
             controller.scoreText.text = controller.Score.ToString();
             
    }
}
