using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject CreditsMenu;
    public GameObject LevelMenu;
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Options(){
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Jogar(){
        SceneManager.LoadScene("Balao");
    }
    public void SelecaoFases(){
        MainMenu.SetActive(false);
        LevelMenu.SetActive(true);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void Voltar(){
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
        LevelMenu.SetActive(false);
    }

    public void Credits(){
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    public void leve1(){
        SceneManager.LoadScene("Pangeia");
    }
    public void leve2(){
        SceneManager.LoadScene("Balao");
    }
    public void leve3(){
        SceneManager.LoadScene("DescarteResiduos");
    }
        public void leve4(){
        SceneManager.LoadScene("PousoNaLua");
    }
        public void leve5(){
        SceneManager.LoadScene("Menu");
    }
}
