using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Playgame() {
        SceneManager.LoadSceneAsync(8);
    }
    public void Controls() {
        SceneManager.LoadSceneAsync(6);
    }

    public void Quitgame() {
        Application.Quit();
    }

    public void Back() {
        SceneManager.LoadSceneAsync(7);
    }
}
