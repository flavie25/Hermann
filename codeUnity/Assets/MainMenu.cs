using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; // Required when using Event data.


public class MainMenu : MonoBehaviour
{
    public void PlayDemo()
    {
        SceneManager.LoadScene(5);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayCompteARebours()
    {
        SceneManager.LoadScene(4);
    }

    public void PlayMenuIntro()
    {
        SceneManager.LoadScene(3);
    }

    public void Continuer()
    {
        SceneManager.LoadScene(7);
    }

    public void Reecouter()
    {
        SceneManager.LoadScene(5);
    }

    public void ReecouterIntro()
    {
        SceneManager.LoadScene(8);
    }

    public void Intro()
    {
        SceneManager.LoadScene(8);
    }

    public void PlayEssai()
    {
        SceneManager.LoadScene(16);
    }

    public void PasserEssai()
    {
        SceneManager.LoadScene(12);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void FixedUpdate(){
        if (Input.GetAxis("Fire2") > 0){
          Debug.Log("QUIT!");
          SceneManager.LoadScene(0);
        }
    }

}
