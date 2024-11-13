using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscenessunday : MonoBehaviour
{
    void OnTriggerEnter() {
        SceneManager.LoadScene("outsidesunday1.3", LoadSceneMode.Single);
        Debug.Log ("Trigger");
    }

}
