using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Playgame() {
        SceneManager.LoadSceneAsync(9);
    }
    public void Controls() {
        SceneManager.LoadSceneAsync(5);
    }

    public void Quitgame() {
        Application.Quit();
    }

    public void Back() {
        SceneManager.LoadSceneAsync(0);
    }

    public void Home(){
        SceneManager.LoadSceneAsync(0);
    }
}
