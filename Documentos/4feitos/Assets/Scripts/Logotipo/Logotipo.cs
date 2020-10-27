using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logotipo : MonoBehaviour
{
 void Start(){
     StartCoroutine ("Countdown");
 }

    private IEnumerator Countdown()
    {
        
        yield return new WaitForSeconds (8);
        SceneManager.LoadScene("Menu");

    }
}